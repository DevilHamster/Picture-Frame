using Force.DeepCloner;
using System.CodeDom;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace PictureFrame
{
    public partial class frm_Main : Form
    {
        #region Information
        string? filePath;                                                                   // µ±Ç°´ò¿ªµÄÍ¼ÏñµÄÎÄ¼þÂ·¾¶
        Bitmap rawImage;                                                                    // Ô­Ê¼Í¼Ïñ
        #endregion

        string[] brandList = new string[]
        {
            "SONY", //0
            "Nikon", //1
            "Canon", //2
            //"FUJIFILM  ¸»Ê¿", //3
            //"PENTAX  ±öµÃ", //4
            //"Ricoh  Àí¹â", //5
            //"Leica  áâ¿¨", //6
            //"Lumix  ËÉÏÂ", //7
            //"Hasselblad  ¹þËÕ", //8
            //"Kodak  ¿Â´ï", //9
            //"Olympus  °ÂÁÖ°ÍË¹","Insta360  Ó°Ê¯","SIGMA  ÊÊÂí",

            //ÊÖ»ú
            //"Apple  Æ»¹û","HUAWEI  »ªÎª","VIVO","SUMSUNG  ÈýÐÇ",
            //"OPPO","HONOR  ÈÙÒ«","ONEPLUS  Ò»¼Ó","MEIZU  ÷È×å","XiaoMi  Ð¡Ã×",
            //"LG","realme  ÕæÎÒ",

            //ÎÞÈË»ú
            //"DJI  ´ó½®",

            //ÔË¶¯Ïà»ú
            //"GoPro","SJCAM  ËÙÓ°","AKASO"
        };

        #region flags
        bool isEditing = false;                                                             // µ±Ç°ÊÇ·ñÕýÔÚ´¦ÀíÍ¼Ïñ
        bool isSaving = false;                                                              // µ±Ç°ÊÇ·ñÕýÔÚ±£´æÍ¼Ïñ»òÔ¤Éè
        #endregion

        #region classes
        PreviewGeneClass previewGenePack;                                                   // Éú³ÉÔ¤ÀÀÍ¼ÏñµÄÊý¾Ý°ü£¬´ýÔØÈëÍ¼ÏñºóÊµÀý»¯
        BarStruct barStruct;                                                                // ¿ØÖÆÌõÉÏÏÂÏÞÉè¶¨
        #endregion

        #region ´°ÌåµÄ¼ÓÔØ¡¢ÍË³ö

        // ´°Ìå¹¹Ôìº¯Êý
        public frm_Main()
        {
            InitializeComponent();
            //this.DoubleBuffered = true;                                                   // ¿ªÆôË«»º´æ

            #region ²ÎÊý³õÊ¼»¯
            timer1.Enabled = true;
            timer1.Interval = 1000;                                                         // ÄÚ´æ»ØÊÕÊ±¼ä¼ä¸ô

            // ÐÅÏ¢À¸³ß´ç¿ØÖÆ
            barStruct.strip_Size_Min = 0.00f; barStruct.strip_Size_Max = 0.40f;             // ÐÅÏ¢Õ¹Ê¾Ìõ³ß´ç¼«ÏÞÉèÖÃ
            barStruct.logo_Size_Min = 0.00f; barStruct.logo_Size_Max = 1.00f;               // logo³ß´ç¼«ÏÞÉèÖÃ
            barStruct.logo_X_Min = 0.00f; barStruct.logo_X_Max = 1.00f;                     // logoÎ»ÖÃ¼«ÏÞÉèÖÃ
            barStruct.logo_Y_Min = 0.00f; barStruct.logo_Y_Max = 1.00f;
            barStruct.time_X_Min = 0.00f; barStruct.time_X_Max = 1.00f;                     // Ê±¼äÐÅÏ¢Î»ÖÃ¼°³ß´ç¼«ÏÞÉèÖÃ
            barStruct.time_Y_Min = 0.00f; barStruct.time_Y_Max = 1.00f;
            barStruct.time_Size_Min = 0.00f; barStruct.time_Size_Max = 1.00f;
            barStruct.info_X_Min = 0.00f; barStruct.info_X_Max = 1.00f;                     // ÅÄÉãÐÅÏ¢Î»ÖÃ¼°³ß´ç¼«ÏÞÉèÖÃ
            barStruct.info_Y_Min = 0.00f; barStruct.info_Y_Max = 1.00f;
            barStruct.info_Size_Min = 0.00f; barStruct.info_Size_Max = 1.00f;
            barStruct.margin_Size_Min = 0.00f; barStruct.margin_Size_Max = 0.20f;           // ±ß¿ò³ß´ç¼«ÏÞÉèÖÃ

            // logoÀ¸ÔØÈëÏà»úÆ·ÅÆÃû³Æ¡£tips: Èç¹ûÓÃcbox_LogoList.DataSource = brandList°ó¶¨»á±¨´í
            foreach (string brand in brandList)
            {
                cbox_LogoList.Items.Add(brand);
            }

            // »ñÈ¡ÏµÍ³×Ô´øµÄÓ¢ÎÄ×ÖÌå£¬ÔÚcbox_date_Font°Ú³ö¿ÉÓÃ×ÖÌåÒÔ¼°ÑùÊ½(±íÂß¼­)
            // ×ÖÌåºÍ×ÖÌåÑùÊ½£¬·ÖÎª±íºÍÀïÁ½¸ö²ã´Î
            // ÔÚ³ÌÐòÃ»¼ÓÔØÈëÍ¼ÏñÊ±£¬½ö×ö±íÂß¼­£¬¼´³õÊ¼»¯Ò»¸öÏÔÊ¾
            // ÔÚ³ÌÐòÔØÈëÍ¼ÏñÊ±£¬×ÖÌåÖ»ÓÐÀïÂß¼­£¬¼´¸ù¾ÝÓÃ»§Éè¶¨£¬¸üÐÂpreviewGenePack£¬×ÖÌåÑùÊ½ÓÐ±íÂß¼­Ò²ÓÐÀïÂß¼­£¬±íÂß¼­Îª¸ù¾Ý×ÖÌå¸Ä±äÑ¡Ïî£¬ÀïÂß¼­Îª¸üÐÂpreviewGenePack
            InstalledFontCollection MyFont = new InstalledFontCollection();
            foreach (FontFamily family in MyFont.Families)
            {
                cbox_date_Font.Items.Add(family.Name);
                cbox_picInfo_Font.Items.Add(family.Name);
            }
            // Èç¹ûÓÐArial£¬Ê¹ÓÃArial£¬·ñÔòÑ¡ÔñÁÐ±íµÚÒ»¸ö
            if (cbox_date_Font.Items.Contains("Arial"))
            {
                cbox_date_Font.SelectedItem = "Arial";
                cbox_picInfo_Font.SelectedItem = "Arial";
            }
            else
            {
                cbox_date_Font.SelectedIndex = 0;
                cbox_picInfo_Font.SelectedIndex = 0;
            }
            // °Ú³ö¿ÉÓÃFontStyle
            FontStyleUpdate(new FontFamily(cbox_date_Font.SelectedItem.ToString()), cbox_date_Style);
            FontStyleUpdate(new FontFamily(cbox_picInfo_Font.SelectedItem.ToString()), cbox_picInfo_Style);

            // ËøËÀÈ«¾Ö
            ConditionCheck(isEditing);
            #endregion
        }

        /// <summary>
        /// ´°Ìå¹Ø±ÕÊÂ¼þn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSaving)
            {
                MessageBox.Show("Save operation is in progress, please do not close the window.");
            }
            else
            {
                System.Environment.Exit(0);                             // ³¹µ×¹Ø±Õ³ÌÐò
            }
        }

        # endregion





        #region ´ò¿ªÍ¼Ïñ¡¢±£´æÍ¼Ïñ

        private void Open_Picture(string pic_path)
        {
            #region ¸ù¾ÝÎÄ¼þÂ·¾¶£¬¼ÓÔØÍ¼Ïñ²¢ÍêÉÆÒ»¸öpreviewGenePack³öÀ´£¬±£Ö¤ÄÜÈ«²¿ÒÀÀµpreviewGenePackµÄÊý¾Ý»æÖÆÒ»ÕÅÔ¤ÀÀÍ¼³öÀ´

            rawImage = PictureFunctions.ReadFromStream(pic_path);
            Bitmap img = PictureFunctions.ResizeToStandard(rawImage, 900);                  // ÕâÀïÊ¹ÓÃÒ»´ÎResizeToStandard£¬´ò¿ªÎÄ¼þÊ±»áÏûºÄ¼¸Ê®ºÁÃë£¬µ«Ê¹½çÃæÉÏµÄ²ÎÊýµ÷Õû¸üÎª¿ìËÙ; pictureBox¿Ø¼þ¿í¸ß¾ùÎª900

            previewGenePack = new PreviewGeneClass(img);


            // ²¿·ÖpreviewGenePack²ÎÊýÒÀÀµ¿Ø¼þÊý¾Ý(Èç¹û¿Ø¼þÓÐÊý¾Ý)
            // previewGenePack×ÖÌå×ÖÑù²¿·Ö²ÎÊýÍ¨¹ý¿Ø¼þ¶ÁÈ¡
            // cbox_date_FontÒ»¶¨ÓÐÑ¡ÖÐÄÚÈÝ£¬²»×öÌõ¼þÅÐ¶Ï
            previewGenePack.timeFont = new FontFamily(cbox_date_Font.SelectedItem.ToString()); //´ò¿ªÍ¼Æ¬Ê±¶ÁÈ¡µ±Ç°Ñ¡ÖÐ×ÖÌå
            previewGenePack.infoFontFamily = new FontFamily(cbox_picInfo_Font.SelectedItem.ToString());
            // Èç¹ûÓÐÑ¡ÖÐ×ÖÌåÑùÊ½£¬previewGenePack¶ÔÓ¦²ÎÊý¸üÐÂ
            if (cbox_date_Style.SelectedIndex != -1)
            {
                switch (cbox_date_Style.SelectedItem)
                {
                    case "Bold":
                        previewGenePack.timeFontStyle = FontStyle.Bold; break;
                    case "Italic":
                        previewGenePack.timeFontStyle = FontStyle.Italic; break;
                    case "Regular":
                        previewGenePack.timeFontStyle = FontStyle.Regular; break;
                    case "Strikeout":
                        previewGenePack.timeFontStyle = FontStyle.Strikeout; break;
                    case "Underline":
                        previewGenePack.timeFontStyle = FontStyle.Underline; break;
                }
            }
            if (cbox_picInfo_Style.SelectedIndex != -1)
            {
                switch (cbox_date_Style.SelectedItem)
                {
                    case "Bold":
                        previewGenePack.infoFontStyle = FontStyle.Bold; break;
                    case "Italic":
                        previewGenePack.infoFontStyle = FontStyle.Italic; break;
                    case "Regular":
                        previewGenePack.infoFontStyle = FontStyle.Regular; break;
                    case "Strikeout":
                        previewGenePack.infoFontStyle = FontStyle.Strikeout; break;
                    case "Underline":
                        previewGenePack.infoFontStyle = FontStyle.Underline; break;
                }
            }
            #endregion

            #region ÉèÖÃ¿ª¹Ø
            // ËùÓÐ¿Ø¼þ(³ýOpen PictureÍâ)ÔÚÎ´´ò¿ªÍ¼ÏñµÄÇé¿öÏÂ±£³ÖËø¶¨
            // Ò»µ©Èí¼þ´ò¿ªÒ»´ÎÍ¼Ïñ£¬´ËºóisEditingÎªtrue
            isEditing = true; ConditionCheck(isEditing);
            #endregion

            #region »ñÈ¡Í¼ÏñÐÅÏ¢£¬ÍêÉÆÒ»¸öJPGInfo³öÀ´£¬¸üÐÂ²ÎÊý½çÃæ£¬ÒÔ¼°previewGenePack²¿·Ö²ÎÊý

            try
            {
                JPGInfo jpgInfo = PictureFunctions.GetInfo(pic_path);
                if (jpgInfo.date != null)
                {
                    String[] slices = jpgInfo.date.Split(" ");
                    jpgInfo.date = slices[0].Replace(":", "-") + " " + slices[1];
                    tbox_date.Text = jpgInfo.date;
                    //tbox_date.ReadOnly = true;
                    previewGenePack.time = jpgInfo.date;
                }
                if (jpgInfo.camera != "")
                {
                    tbox_picInfo_Camera.Text = jpgInfo.camera;
                    //tbox_picInfo_Camera.ReadOnly = true;
                }
                if (jpgInfo.f_stop != "")
                {
                    tbox_picInfo_F.Text = jpgInfo.f_stop;
                    //tbox_picInfo_F.ReadOnly = true;
                }
                if (jpgInfo.expoTime != "")
                {
                    tbox_picInfo_Expo.Text = jpgInfo.expoTime;
                    //tbox_picInfo_Expo.ReadOnly = true;
                }
                if (jpgInfo.iso != "" && jpgInfo.iso != null)
                {
                    tbox_picInfo_ISO.Text = "ISO" + jpgInfo.iso;
                    //tbox_picInfo_ISO.ReadOnly = true;
                }
                if (jpgInfo.focalLength != "")
                {
                    tbox_picInfo_Focal.Text = jpgInfo.focalLength;
                    //tbox_picInfo_Focal.ReadOnly = true;
                }
                if (jpgInfo.evBias != "")
                {
                    tbox_picInfo_Bias.Text = jpgInfo.evBias;
                    //tbox_picInfo_Bias.ReadOnly = true;
                }
                if (PictureFunctions.GetBrandIndex(jpgInfo.maker) != -1)
                {
                    cbox_LogoList.SelectedIndex = PictureFunctions.GetBrandIndex(jpgInfo.maker);
                    previewGenePack.brandIndex = PictureFunctions.GetBrandIndex(jpgInfo.maker);
                }
                InfoUpdate(previewGenePack); //¸üÐÂInfoÐÅÏ¢ 
            }
            finally
            {
                //MessageBox.Show("Í¼ÏñÐÅÏ¢»ñÈ¡Ê§°Ü£¬Çë×ÔÐÐÌí¼ÓÍ¼¿òÔªËØ");
            }
            #endregion

            PreviewUpdate();                                                                // »æÖÆÔ¤ÀÀÍ¼Ïñ
            ControlsUpdate();
        }

        private void Save_Picture(string pic_path)
        {
            isSaving = true;
            Bitmap temp = previewGenePack.bitmap;                                           // ÔÝ´æÔ¤ÀÀÍ¼

            previewGenePack.bitmap = rawImage;                                              // Ì«×Ó»»ÀêÃ¨
            Bitmap final = PictureFunctions.DrawPreview(previewGenePack);                   // »æÖÆ×îÖÕÍ¼Ïñ
            PictureFunctions.Save2Path(final, pic_path);                                    // ±£´æÍ¼Ïñ

            previewGenePack.bitmap = temp;                                                  // ÀêÃ¨»»Ì«×Ó
            isSaving = false;
        }

        /// <summary>
        /// µã»÷Open Picture£¬´ò¿ª±¾µØÍ¼Ïñ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_OpenPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();                                       // ÊµÀý»¯Ò»¸ö´ò¿ªÎÄ¼þµÄ¶Ô»°¿ò
            of.Multiselect = false;                                                         // ²»ÔÊÐí¶àÑ¡
            of.Title = "Please choose the image to edit";                                   // ÉèÖÃ¶Ô»°¿ò±êÌâ
            of.Filter = "Image Files|*.jpg";                                                // ÉèÖÃÖ¸¶¨Í¼ÏñÀàÐÍ
            if (of.ShowDialog() == DialogResult.OK)                                         // ÏÔÊ¾¶Ô»°¿ò£¬Èç¹ûÑ¡ÔñÈ·¶¨
            {
                GC.Collect();                                                               // ÄÚ´æ±£ÏÕ
                rawImage = null;
                filePath = of.FileName;                                                     // »ñÈ¡ÎÄ¼þÂ·¾¶
                Open_Picture(filePath);
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// ´ò¿ªÎÄ¼þÂ·¾¶£¬±£´æÍ¼Æ¬
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_SavePicture_Click(object sender, EventArgs e)
        {
            //±£´æÎÄ¼þ´°¿Ú
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Title = "Save Picture as:",
                RestoreDirectory = true,
                Filter = "Image Files|*.jpg",
                FileName = Path.GetFileNameWithoutExtension(filePath) + "(framed)" + ".jpg"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Save_Picture(pic_path: saveFileDialog.FileName);                                // ±£´æ³ÉÍ¼
                MessageBox.Show("Saved Successfully.");
            }
            else
            {
                return;
            }
        }

        #endregion





        #region ÑùÊ½±à¼­¿Ø¼þËùÓÐ½»»¥Âß¼­

        /// <summary>
        /// Ñ¡ÔñBeneath£¬µ÷ÕûpreviewGenePack£¬ÖØÐÂ»æÍ¼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtn_InfoStrip_Beneath_CheckedChanged(object sender, EventArgs e)
        {
            previewGenePack.stripLocation = InfoStripLocations.Beneath;
            //»æÖÆÍ¼Ïñ
            PreviewUpdate();

            //¿Ø¼þ±ä¶¯
            Update_Label_Data_Display();
        }

        /// <summary>
        /// Ñ¡ÔñRight£¬µ÷ÕûpreviewGenePack£¬ÖØÐÂ»æÍ¼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtn_InfoStrip_Right_CheckedChanged(object sender, EventArgs e)
        {
            previewGenePack.stripLocation = InfoStripLocations.Right;
            //»æÖÆÍ¼Ïñ
            PreviewUpdate();

            //¿Ø¼þ±ä¶¯
            Update_Label_Data_Display();
        }

        /// <summary>
        /// ÐÅÏ¢À¸³ß´ç¿ØÖÆÌõ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bar_StripSize_ValueChanged(object sender, ControlBarEventArgs e)
        {
            //ÏÈ¸üÐÂpreviewgenePack£¬¿ØÖÆpreviewGenePack.stripSize×î¸ßÎªbarStruct.strip_Size_Max£¬×îµÍÎªbarStruct.strip_Size_Min
            previewGenePack.stripSize = barStruct.strip_Size_Min +
                (barStruct.strip_Size_Max - barStruct.strip_Size_Min) * ((float)bar_StripSize._Value / (float)bar_StripSize._Max);

            //¸üÐÂÏà¹Ø¿Ø¼þ
            if (previewGenePack.stripLocation == InfoStripLocations.Beneath)
            {
                lbl_info_Size.Text = "Size :" + string.Format("{0:F2}", previewGenePack.stripSize * 100) + "% of the width of the image";
            }
            else
            {
                lbl_info_Size.Text = "Size :" + string.Format("{0:F2}", previewGenePack.stripSize * 100) + "% of the height of the image";
            }

            //ºó¸ù¾ÝpreviewgenePackÖØ»æÍ¼ÏñÔ¤ÀÀ
            PreviewUpdate();
        }

        /// <summary>
        /// Logo³ß´ç¿ØÖÆÌõ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bar_logoSize_ValueChanged(object sender, ControlBarEventArgs e)
        {
            //ÏÈ¸üÐÂpreviewgenePack
            previewGenePack.logoSize = barStruct.logo_Size_Min +
                (barStruct.logo_Size_Max - barStruct.logo_Size_Min) * ((float)bar_logoSize._Value / (float)bar_logoSize._Max);
            //¸üÐÂÏà¹Ø¿Ø¼þ
            if (previewGenePack.stripLocation == InfoStripLocations.Beneath)
            {
                lbl_logo_Size.Text = "Size :" + string.Format("{0:F2}", previewGenePack.logoSize * 100) + "% of the height of the Info Strip";
            }
            else
            {
                lbl_logo_Size.Text = "Size :" + string.Format("{0:F2}", previewGenePack.logoSize * 100) + "% of the width of the Info Strip";
            }

            //ºó¸ù¾ÝpreviewgenePackÖØ»æÍ¼ÏñÔ¤ÀÀ
            PreviewUpdate();
        }

        /// <summary>
        /// LogoX¿ØÖÆÌõ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bar_logoX_ValueChanged(object sender, ControlBarEventArgs e)
        {
            // ÏÈ¸üÐÂpreviewgenePack
            previewGenePack.logoX = barStruct.logo_X_Min +
                (barStruct.logo_X_Max - barStruct.logo_X_Min) * ((float)bar_logoX._Value / (float)bar_logoX._Max);
            // ¸ù¾ÝpreviewgenePackÖØ»æÍ¼ÏñÔ¤ÀÀ
            PreviewUpdate();
            // ¿Ø¼þ¸üÐÂ
            lbl_logo_X.Text = "X: " + string.Format("{0:F2}", previewGenePack.logoX * 100);
        }

        /// <summary>
        /// LogoY¿ØÖÆÌõ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bar_logoY_ValueChanged(object sender, ControlBarEventArgs e)
        {
            // ÏÈ¸üÐÂpreviewgenePack
            previewGenePack.logoY = barStruct.logo_Y_Min +
                (barStruct.logo_Y_Max - barStruct.logo_Y_Min) * ((float)bar_logoY._Value / (float)bar_logoY._Max);
            // ¸ù¾ÝpreviewgenePackÖØ»æÍ¼ÏñÔ¤ÀÀ
            PreviewUpdate();
            // ¿Ø¼þ¸üÐÂ
            lbl_logo_Y.Text = "Y: " + string.Format("{0:F2}", previewGenePack.logoY * 100);
        }

        /// <summary>
        /// logoÁÐ±íÑ¡ÖÐÏî·¢Éú±ä¶¯£¬¸üÐÂpreviewgenePack£¬Èç¹ûÏÖÔÚÓÐlogoÏÔÊ¾£¬ÖØ»æ£¬Èç¹ûÃ»ÓÐlogoÏÔÊ¾£¬ÎÞ¶¯×÷
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbox_LogoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //µ±Ç°Î´Ñ¡ÖÐÖµ£¬·µ»Ø
            if (cbox_LogoList.SelectedIndex == -1) { return; }

            else
            {
                //¸üÐÂpreviewgenePack£¬¿ØÖÆpreviewGenePack.brandIndex²ÎÊý
                previewGenePack.brandIndex = cbox_LogoList.SelectedIndex;
                //ÖØ»æ
                PreviewUpdate();
            }
        }

        /// <summary>
        /// µã»÷ºólogoX»Ø¹éÖÐÖµ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_logo_midAlignX_Click(object sender, EventArgs e)
        {
            bar_logoX._Value = (bar_logoX._Max - bar_logoX._Min) / 2;
        }

        /// <summary>
        /// µã»÷ºólogoY»Ø¹éÖÐÖµ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_logo_midAlignY_Click(object sender, EventArgs e)
        {
            bar_logoY._Value = (bar_logoY._Max - bar_logoY._Min) / 2;
        }

        /// <summary>
        /// ×ÖÌåÑ¡Ôñ¸üÐÂ£¬×ö×ÖÌåµÄÀïÂß¼­£¬×ÖÌåÑùÊ½µÄ±íÂß¼­
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbox_date_Font_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (previewGenePack != null)
            {
                FontFamily temp = new FontFamily(cbox_date_Font.SelectedItem.ToString());
                //¸üÐÂpreviewGenePack²ÎÊý
                previewGenePack.timeFont = temp;
                //¸üÐÂcbox_date_StyleÏÔÊ¾
                FontStyleUpdate(temp, cbox_date_Style);
                //»æÖÆÍ¼Ïñ
                PreviewUpdate();
            }
        }

        /// <summary>
        /// ×ÖÌåÑ¡Ôñ¸üÐÂ£¬×ö×ÖÌåµÄÀïÂß¼­£¬×ÖÌåÑùÊ½µÄ±íÂß¼­
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbox_picInfo_Font_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (previewGenePack != null)
            {
                FontFamily temp = new FontFamily(cbox_picInfo_Font.SelectedItem.ToString());
                //¸üÐÂpreviewGenePack²ÎÊý
                previewGenePack.infoFontFamily = temp;
                //¸üÐÂcbox_date_StyleÏÔÊ¾
                FontStyleUpdate(temp, cbox_picInfo_Style);
                //»æÖÆÍ¼Ïñ
                PreviewUpdate();
            }
        }

        /// <summary>
        /// ×ÖÌåÑùÊ½Ñ¡Ôñ¸üÐÂ£¬¸üÐÂpreviewGenePack
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbox_date_Style_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (previewGenePack != null)
            {
                switch (cbox_date_Style.SelectedItem)
                {
                    case "Bold":
                        previewGenePack.timeFontStyle = FontStyle.Bold; break;
                    case "Italic":
                        previewGenePack.timeFontStyle = FontStyle.Italic; break;
                    case "Regular":
                        previewGenePack.timeFontStyle = FontStyle.Regular; break;
                    case "Strikeout":
                        previewGenePack.timeFontStyle = FontStyle.Strikeout; break;
                    case "Underline":
                        previewGenePack.timeFontStyle = FontStyle.Underline; break;
                }
                //»æÖÆÍ¼Ïñ
                PreviewUpdate();
            }
        }

        /// <summary>
        /// ×ÖÌåÑùÊ½Ñ¡Ôñ¸üÐÂ£¬¸üÐÂpreviewGenePack
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbox_picInfo_Style_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (previewGenePack != null)
            {
                switch (cbox_picInfo_Style.SelectedItem)
                {
                    case "Bold":
                        previewGenePack.infoFontStyle = FontStyle.Bold; break;
                    case "Italic":
                        previewGenePack.infoFontStyle = FontStyle.Italic; break;
                    case "Regular":
                        previewGenePack.infoFontStyle = FontStyle.Regular; break;
                    case "Strikeout":
                        previewGenePack.infoFontStyle = FontStyle.Strikeout; break;
                    case "Underline":
                        previewGenePack.infoFontStyle = FontStyle.Underline; break;
                }
                //»æÖÆÍ¼Ïñ
                PreviewUpdate();
            }
        }

        /// <summary>
        /// timeX¿ØÖÆÌõ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bar_timeX_ValueChanged(object sender, ControlBarEventArgs e)
        {
            // ÏÈ¸üÐÂpreviewgenePack
            previewGenePack.timeX = barStruct.time_X_Min +
                (barStruct.time_X_Max - barStruct.time_X_Min) * ((float)bar_timeX._Value / (float)bar_timeX._Max);
            //¸ù¾ÝpreviewgenePackÖØ»æÍ¼ÏñÔ¤ÀÀ
            PreviewUpdate();
            // ¿Ø¼þ¸üÐÂ
            lbl_date_X.Text = "X: " + string.Format("{0:F2}", previewGenePack.timeX * 100);
        }

        /// <summary>
        /// timeY¿ØÖÆÌõ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bar_timeY_ValueChanged(object sender, ControlBarEventArgs e)
        {
            // ÏÈ¸üÐÂpreviewgenePack
            previewGenePack.timeY = barStruct.time_Y_Min +
                (barStruct.time_Y_Max - barStruct.time_Y_Min) * ((float)bar_timeY._Value / (float)bar_timeY._Max);
            // ¸ù¾ÝpreviewgenePackÖØ»æÍ¼ÏñÔ¤ÀÀ
            PreviewUpdate();
            // ¿Ø¼þ¸üÐÂ
            lbl_date_Y.Text = "Y: " + string.Format("{0:F2}", previewGenePack.timeY * 100);
        }

        /// <summary>
        /// timeSize¿ØÖÆÌõ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bar_timeSize_ValueChanged(object sender, ControlBarEventArgs e)
        {
            //ÏÈ¸üÐÂpreviewgenePack
            previewGenePack.timeSize = barStruct.time_Size_Min +
                (barStruct.time_Size_Max - barStruct.time_Size_Min) * ((float)bar_timeSize._Value / (float)bar_timeSize._Max);
            //¸üÐÂÏà¹Ø¿Ø¼þ
            if (previewGenePack.stripLocation == InfoStripLocations.Beneath)
            {
                lbl_date_FontSize.Text = "Size :" + string.Format("{0:F2}", previewGenePack.timeSize * 100) + "% of the height of the Info Strip";
            }
            else
            {
                lbl_date_FontSize.Text = "Size :" + string.Format("{0:F2}", previewGenePack.timeSize * 100) + "% of the width of the Info Strip";
            }
            //¸ù¾ÝpreviewgenePackÖØ»æÍ¼ÏñÔ¤ÀÀ
            PreviewUpdate();
        }

        /// <summary>
        /// timeTrans¿ØÖÆÌõ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bar_timeTrans_ValueChanged(object sender, ControlBarEventArgs e)
        {
            previewGenePack.timeTranParent = bar_timeTrans._Value;
            PreviewUpdate();
            lbl_date_FontTrans.Text = "Transparency: " + previewGenePack.timeTranParent.ToString();
        }

        /// <summary>
        /// infoX¿ØÖÆÌõ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bar_infoX_ValueChanged(object sender, ControlBarEventArgs e)
        {
            previewGenePack.infoX = barStruct.info_X_Min + (barStruct.info_X_Max - barStruct.info_X_Min) * ((float)bar_infoX._Value / (float)bar_infoX._Max);
            PreviewUpdate();
            lbl_picInfo_X.Text = "X: " + string.Format("{0:F2}", previewGenePack.infoX * 100);
        }

        /// <summary>
        /// infoY¿ØÖÆÌõ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bar_infoY_ValueChanged(object sender, ControlBarEventArgs e)
        {
            previewGenePack.infoY = barStruct.info_Y_Min + (barStruct.info_Y_Max - barStruct.info_Y_Min) * ((float)bar_infoY._Value / (float)bar_infoY._Max);
            PreviewUpdate();
            lbl_picInfo_Y.Text = "Y: " + string.Format("{0:F2}", previewGenePack.infoY * 100);
        }

        /// <summary>
        /// infoSize¿ØÖÆÌõ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bar_infoSize_ValueChanged(object sender, ControlBarEventArgs e)
        {
            previewGenePack.infoSize = barStruct.info_Size_Min + (barStruct.info_Size_Max - barStruct.info_Size_Min) * ((float)bar_infoSize._Value / (float)bar_infoSize._Max);
            if (previewGenePack.stripLocation == InfoStripLocations.Beneath)
            {
                lbl_picInfo_FontSize.Text = "Size :" + string.Format("{0:F2}", previewGenePack.infoSize * 100) + "% of the height of the Info Strip";
            }
            else
            {
                lbl_picInfo_FontSize.Text = "Size :" + string.Format("{0:F2}", previewGenePack.infoSize * 100) + "% of the width of the Info Strip";
            }
            PreviewUpdate();
        }

        /// <summary>
        /// infoTrans¿ØÖÆÌõ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bar_infoTrans_ValueChanged(object sender, ControlBarEventArgs e)
        {
            previewGenePack.infoTransparent = bar_infoTrans._Value;
            PreviewUpdate();
            lbl_info_FontTrans.Text = "Transparency: " + previewGenePack.infoTransparent.ToString();
        }

        /// <summary>
        /// Ê±¼äÏÔÊ¾¾ÓÖÐ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_date_midAlign_Click(object sender, EventArgs e)
        {
            bar_timeX._Value = (bar_timeX._Max - bar_timeX._Min) / 2;
        }

        /// <summary>
        /// Ê±¼äÏÔÊ¾¾ÓÖÐ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_date_midAlign2_Click(object sender, EventArgs e)
        {
            bar_timeY._Value = (bar_timeY._Max - bar_timeY._Min) / 2;
        }

        /// <summary>
        /// infoÏÔÊ¾¾ÓÖÐ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_picInfo_midAlign_Click(object sender, EventArgs e)
        {
            bar_infoX._Value = (bar_infoX._Max - bar_infoX._Min) / 2;
        }

        /// <summary>
        /// infoÏÔÊ¾¾ÓÖÐ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_picInfo_midAlign2_Click(object sender, EventArgs e)
        {
            bar_infoY._Value = (bar_infoY._Max - bar_infoY._Min) / 2;
        }

        /// <summary>
        /// ±ß¿ò´óÐ¡¿ØÖÆÌõ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bar_marginSize_ValueChanged(object sender, ControlBarEventArgs e)
        {
            //ÏÈ¸üÐÂpreviewgenePack
            previewGenePack.marginSize = barStruct.margin_Size_Min +
                (barStruct.margin_Size_Max - barStruct.margin_Size_Min) * ((float)bar_marginSize._Value / (float)bar_marginSize._Max);

            //¸üÐÂ¿Ø¼þ
            if (previewGenePack.stripLocation == InfoStripLocations.Beneath)
            {
                lbl_margin_size.Text = "Size :" + string.Format("{0:F2}", previewGenePack.marginSize * 100) + "% of the width of raw image";
            }
            else
            {
                lbl_margin_size.Text = "Size :" + string.Format("{0:F2}", previewGenePack.marginSize * 100) + "% of the height of raw image";
            }

            PreviewUpdate();
        }

        /// <summary>
        /// ÈÕÆÚ¸ü¸ÄÊÂ¼þ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbox_date_TextChanged(object sender, EventArgs e)
        {
            previewGenePack.time = tbox_date.Text;
            //ÖØ»æÍ¼ÏñÔ¤ÀÀ
            PreviewUpdate();
        }

        /// <summary>
        /// ÅÄÉã²ÎÊý¸ü¸ÄÊÂ¼þ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbox_picInfo_Camera_TextChanged(object sender, EventArgs e)
        {
            InfoUpdate(previewGenePack);
            //ÖØ»æÍ¼ÏñÔ¤ÀÀ
            PreviewUpdate();
        }
        private void tbox_picInfo_F_TextChanged(object sender, EventArgs e)
        {
            InfoUpdate(previewGenePack);
            //ÖØ»æÍ¼ÏñÔ¤ÀÀ
            PreviewUpdate();
        }
        private void tbox_picInfo_Expo_TextChanged(object sender, EventArgs e)
        {
            InfoUpdate(previewGenePack);
            //ÖØ»æÍ¼ÏñÔ¤ÀÀ
            PreviewUpdate();
        }
        private void tbox_picInfo_ISO_TextChanged(object sender, EventArgs e)
        {
            InfoUpdate(previewGenePack);
            //ÖØ»æÍ¼ÏñÔ¤ÀÀ
            PreviewUpdate();
        }
        private void tbox_picInfo_Focal_TextChanged(object sender, EventArgs e)
        {
            InfoUpdate(previewGenePack);
            //ÖØ»æÍ¼ÏñÔ¤ÀÀ
            PreviewUpdate();
        }
        private void tbox_picInfo_Bias_TextChanged(object sender, EventArgs e)
        {
            InfoUpdate(previewGenePack);
            //ÖØ»æÍ¼ÏñÔ¤ÀÀ
            PreviewUpdate();
        }
        /// <summary>
        /// ¸üÐÂÅÄÉã²ÎÊýÐÅÏ¢
        /// </summary>
        /// <param name="previewGeneClass"></param>
        public void InfoUpdate(PreviewGeneClass previewGeneClass)
        {
            previewGeneClass.info =
                tbox_picInfo_Camera.Text + " | "
                + tbox_picInfo_F.Text + " | "
                + tbox_picInfo_Expo.Text + " | "
                + tbox_picInfo_ISO.Text + " | "
                + tbox_picInfo_Focal.Text + " | "
                + tbox_picInfo_Bias.Text;
        }



        /// <summary>
        /// ¸üÐÂ×ÖÌåÑùÊ½Ñ¡Ïî(±íÂß¼­)
        /// </summary>
        /// <param name="fontFamily"></param>
        public void FontStyleUpdate(FontFamily fontFamily, ComboBox cbox)
        {
            cbox.Items.Clear();
            if (fontFamily != null)
            {
                foreach (FontStyle fs in FontFunctions.FontStyleAvailable(fontFamily))
                {
                    cbox.Items.Add(fs.ToString());
                }
            }
        }

        #endregion





        #region ÔØÈëÔ¤Éè¡¢±£´æÔ¤Éè

        /// <summary>
        /// ¶ÁÈ¡Ô¤Éè
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_OpenPreset_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Multiselect = false;
            of.Title = "Please choose the preset to apply";
            of.Filter = "Preset Files|*.json";
            if (of.ShowDialog() == DialogResult.OK)
            {
                JSONinteractions.Json2Parameters(previewGenePack, of.FileName);             // ±ä¸üpreviewGenePack
                PreviewUpdate();
                ControlsUpdate();
            }
            else
            {
                return;
            }
        }
        /// <summary>
        /// ´ò¿ªÎÄ¼þÂ·¾¶£¬±£´æÔ¤Éè
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_SavePreset_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Title = "Save Preset as:",
                RestoreDirectory = true,
                Filter = "Preset Files|*.json"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                isSaving = true;
                JSONinteractions.Parameters2Json(previewGenePack, saveFileDialog.FileName.ToString());
                isSaving = false;
            }
            else
            {
                return;
            }
        }

        // ºáÏòÍ¼·ù -> ¾ÓÖÐÅÅÁÐ
        private void beneathMidlignToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            JSONinteractions.Json2Parameters(previewGenePack, Properties.Resources.Horizontal_MidAlign);
            PreviewUpdate();
            ControlsUpdate();
        }
        // ºáÏòÍ¼·ù -> ·ÖÉ¢ÅÅÁÐ
        private void beneathMidlignToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            JSONinteractions.Json2Parameters(previewGenePack, Properties.Resources.Horizontal_Flex);
            PreviewUpdate();
            ControlsUpdate();
        }
        // ·½ÐÎÍ¼·ù -> ·ÖÉ¢ÅÅÁÐ
        private void beneathMidlignToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            JSONinteractions.Json2Parameters(previewGenePack, Properties.Resources.Square_Flex);
            PreviewUpdate();
            ControlsUpdate();
        }
        // ÊúÏòÍ¼·ù -> µ×²¿·ÖÉ¢ÅÅÁÐ
        private void beneathCorner横向构图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JSONinteractions.Json2Parameters(previewGenePack, Properties.Resources.Vertical_Flex);
            PreviewUpdate();
            ControlsUpdate();
        }
        // ÊúÏòÍ¼·ù -> ÓÒ²à·ÖÉ¢ÅÅÁÐ
        private void rightCorner方形构图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JSONinteractions.Json2Parameters(previewGenePack, Properties.Resources.Vertical_Flex_Right);
            PreviewUpdate();
            ControlsUpdate();
        }
        // ½ö°×±ß
        private void preset_Just_Margin_Click(object sender, EventArgs e)
        {
            JSONinteractions.Json2Parameters(previewGenePack, Properties.Resources.Just_Margin);
            PreviewUpdate();
            ControlsUpdate();
        }
        // É¶Ò²Ã»ÓÐ
        private void preset_Nothing_Click(object sender, EventArgs e)
        {
            JSONinteractions.Json2Parameters(previewGenePack, Properties.Resources.Nothing);
            PreviewUpdate();
            ControlsUpdate();
        }

        #endregion





        #region ¹¤¾ßº¯Êý

        /// <summary>
        /// ¸üÐÂÔ¤ÀÀ
        /// </summary>
        public void PreviewUpdate()
        {
            if (pb_Preview.Image != null)
            { pb_Preview.Image.Dispose(); }

            pb_Preview.Image = PictureFunctions.DrawPreview(previewGenePack); // ¸üÐÂ¿Ø¼þÏÔÊ¾
        }

        /// <summary>
        /// ×´Ì¬µ±Ç°ÊÇ·ñÕýÔÚ±à¼­Í¼Ïñ£¬Èç¹û·ñÔòÈ«¾ÖËøËÀ
        /// </summary>
        public void ConditionCheck(bool isEditing)
        {
            //Èç¹ûµ±Ç°Ã»´ò¿ªÍ¼Ïñ£¬ËøËÀ
            if (!isEditing)
            {
                foreach (Control control in this.Controls)
                {
                    control.Enabled = false;
                }
                //Ö»±£Áô"Open Picture"¹¦ÄÜ
                menuStrip1.Enabled = true;
                tsmi_SavePicture.Enabled = false;
                tsmi_SavePreset.Enabled = false;
                tsmi_OpenPreset.Enabled = false;
                useToolStripMenuItem.Enabled = false;
                return;
            }
            //Èç¹ûµ±Ç°ÒÑ¾­´ò¿ªÍ¼Ïñ£¬¼ì²éµÚÒ»¸ö¿Ø¼þ£¬Èç¹ûµÚÒ»¸ö¿Ø¼þEnable==true£¬Ôò²»¼ÌÐø±éÀú£¬·´Ö®ËµÃ÷µ±Ç°ÊÇµÚÒ»´Î´ò¿ªÍ¼Ïñ£¬È«²¿½âËø
            else
            {
                if (this.Controls[0].Enabled == true)
                {
                    return;
                }
                else
                {
                    foreach (Control control in this.Controls)
                    {
                        control.Enabled = true;
                    }
                    menuStrip1.Enabled = true;
                    tsmi_SavePicture.Enabled = true;
                    tsmi_SavePreset.Enabled = true;
                    tsmi_OpenPreset.Enabled = true;
                    tsmi_BatchApply.Enabled = true;
                    useToolStripMenuItem.Enabled = true;
                }
            }
        }

        /// <summary>
        /// ¸ù¾ÝpreviewGenePack ¸üÐÂ¸÷LabelµÄÊýÖµÏÔÊ¾
        /// </summary>
        /// <param name="pgp"></param>
        private void Update_Label_Data_Display()
        {
            lbl_info_Size.Text = "Size :" + string.Format("{0:F2}", previewGenePack.stripSize * 100) + "% of the width of the image";

            lbl_logo_Size.Text = "Size :" + string.Format("{0:F2}", previewGenePack.logoSize * 100) + "% of the height of the Info Strip";
            lbl_logo_X.Text = "X: " + string.Format("{0:F2}", previewGenePack.logoX * 100);
            lbl_logo_Y.Text = "Y: " + string.Format("{0:F2}", previewGenePack.logoY * 100);

            lbl_date_X.Text = "X: " + string.Format("{0:F2}", previewGenePack.timeX * 100);
            lbl_date_Y.Text = "Y: " + string.Format("{0:F2}", previewGenePack.timeY * 100);
            lbl_date_FontSize.Text = "Font Size :" + string.Format("{0:F2}", previewGenePack.timeSize * 100) + "% of the height of the Info Strip";
            lbl_date_FontTrans.Text = "Transparency: " + previewGenePack.timeTranParent.ToString();

            lbl_picInfo_X.Text = "X: " + string.Format("{0:F2}", previewGenePack.infoX * 100);
            lbl_picInfo_Y.Text = "Y: " + string.Format("{0:F2}", previewGenePack.infoY * 100);
            lbl_picInfo_FontSize.Text = "Font Size :" + string.Format("{0:F2}", previewGenePack.infoSize * 100) + "% of the height of the Info Strip";
            lbl_info_FontTrans.Text = "Transparency: " + previewGenePack.infoTransparent.ToString();
        }

        /// <summary>
        /// ¸ù¾ÝpreviewGenePack ¸üÐÂ¸÷BarµÄÊýÖµ
        /// </summary>
        /// <param name="pgp"></param>
        private void Update_Bar_Data()
        {
            bar_StripSize._Value = bar_StripSize._Min + (int)((previewGenePack.stripSize - barStruct.strip_Size_Min) * (bar_StripSize._Max - bar_StripSize._Min) / (barStruct.strip_Size_Max - barStruct.strip_Size_Min));

            bar_logoSize._Value = bar_logoSize._Min + (int)((previewGenePack.logoSize - barStruct.logo_Size_Min) * (bar_logoSize._Max - bar_logoSize._Min) / (barStruct.logo_Size_Max - barStruct.logo_Size_Min));
            bar_logoX._Value = bar_logoX._Min + (int)((previewGenePack.logoX - barStruct.logo_X_Min) * (bar_logoX._Max - bar_logoX._Min) / (barStruct.logo_X_Max - barStruct.logo_X_Min));
            bar_logoY._Value = bar_logoY._Min + (int)((previewGenePack.logoY - barStruct.logo_Y_Min) * (bar_logoY._Max - bar_logoY._Min) / (barStruct.logo_Y_Max - barStruct.logo_Y_Min));

            bar_timeSize._Value = bar_timeSize._Min + (int)((previewGenePack.timeSize - barStruct.time_Size_Min) * (bar_timeSize._Max - bar_timeSize._Min) / (barStruct.time_Size_Max - barStruct.time_Size_Min));
            bar_timeX._Value = bar_timeX._Min + (int)((previewGenePack.timeX - barStruct.time_X_Min) * (bar_timeX._Max - bar_timeX._Min) / (barStruct.time_X_Max - barStruct.time_X_Min));
            bar_timeY._Value = bar_timeY._Min + (int)((previewGenePack.timeY - barStruct.time_Y_Min) * (bar_timeY._Max - bar_timeY._Min) / (barStruct.time_Y_Max - barStruct.time_Y_Min));

            bar_timeTrans._Value = previewGenePack.timeTranParent;
            bar_infoTrans._Value = previewGenePack.infoTransparent;

            bar_infoSize._Value = bar_infoSize._Min + (int)((previewGenePack.infoSize - barStruct.info_Size_Min) * (bar_infoSize._Max - bar_infoSize._Min) / (barStruct.info_Size_Max - barStruct.info_Size_Min));

            bar_infoX._Value = bar_infoX._Min + (int)((previewGenePack.infoX - barStruct.info_X_Min) * (bar_infoX._Max - bar_infoX._Min) / (barStruct.info_X_Max - barStruct.info_X_Min));
            bar_infoY._Value = bar_infoY._Min + (int)((previewGenePack.infoY - barStruct.info_Y_Min) * (bar_infoY._Max - bar_infoY._Min) / (barStruct.info_Y_Max - barStruct.info_Y_Min));

            bar_marginSize._Value = bar_marginSize._Min + (int)((previewGenePack.marginSize - barStruct.margin_Size_Min) * (bar_marginSize._Max - bar_marginSize._Min) / (barStruct.margin_Size_Max - barStruct.margin_Size_Min));
        }

        /// <summary>
        /// ¸ù¾Ý previewGenePack ¸üÐÂËùÓÐ¿Ø¼þ
        /// </summary>
        public void ControlsUpdate()
        {
            if (previewGenePack.stripLocation == InfoStripLocations.Beneath)
            {
                rbtn_InfoStrip_Beneath.Checked = true;
                rbtn_InfoStrip_Right.Checked = false;
            }
            else
            {
                rbtn_InfoStrip_Beneath.Checked = false;
                rbtn_InfoStrip_Right.Checked = true;
            }

            //¸üÐÂÊ±¼äÐÅÏ¢×ÖÌå
            //Èç¹û¶ÁÈ¡³öµÄ×ÖÌå²»ÔÚÏµÍ³ÖÐ£¬ÇÐ»»ÖÁArial»òµÚÒ»Î»
            if (!cbox_date_Font.Items.Contains(previewGenePack.timeFont.Name))
            {
                MessageBox.Show("Font not installed, will switch to default font.");
                if (cbox_date_Font.Items.Contains("Arial"))
                {
                    cbox_date_Font.SelectedItem = "Arial";
                    previewGenePack.timeFont = new FontFamily("Arial"); //ÐÞÕý
                }
                else
                {
                    cbox_date_Font.SelectedIndex = 0;
                    previewGenePack.timeFont = new FontFamily(cbox_date_Font.Items[0].ToString()); //ÐÞÕý
                }
            }
            else
            {
                cbox_date_Font.SelectedItem = previewGenePack.timeFont.ToString();
            }

            //¸üÐÂÅÄÉã²ÎÊýÐÅÏ¢×ÖÌå
            if (!cbox_picInfo_Font.Items.Contains(previewGenePack.infoFontFamily.Name))
            {
                MessageBox.Show("Font not installed, will switch to default font.");
                if (cbox_picInfo_Font.Items.Contains("Arial"))
                {
                    cbox_picInfo_Font.SelectedItem = "Arial";
                    previewGenePack.infoFontFamily = new FontFamily("Arial");
                }
                else
                {
                    cbox_picInfo_Font.SelectedIndex = 0;
                    previewGenePack.infoFontFamily = new FontFamily(cbox_picInfo_Font.Items[0].ToString());
                }
            }
            else
            {
                cbox_picInfo_Font.SelectedItem = previewGenePack.infoFontFamily.ToString();
            }

            cbox_date_Style.SelectedItem = previewGenePack.timeFontStyle.ToString();
            cbox_picInfo_Style.SelectedItem = previewGenePack.infoFontStyle.ToString();

            Update_Label_Data_Display();
            Update_Bar_Data();
        }

        /// <summary>
        /// Ã¿¸ô1s»ØÊÕÒ»´ÎÄÚ´æ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // timer1.Enabled = false;
            System.GC.Collect();
            // timer1.Enabled = true;
        }
        #endregion


        /// <summary>
        /// Åú´¦Àí²Ù×÷
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_BatchApply_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();                   // ÊµÀý»¯Ò»¸ö´ò¿ªÎÄ¼þµÄ¶Ô»°¿ò
            of.Multiselect = true;                                      // ÔÊÐí¶àÑ¡
            of.Title = "Please choose the images to edit";              // ÉèÖÃ¶Ô»°¿ò±êÌâ
            of.Filter = "Image Files|*.jpg";                            // ÉèÖÃÖ¸¶¨Í¼ÏñÀàÐÍ
            if (of.ShowDialog() == DialogResult.OK)                     // ÏÔÊ¾¶Ô»°¿ò£¬Èç¹ûÑ¡ÔñÈ·¶¨
            {
                //»ñÈ¡ÎÄ¼þÂ·¾¶
                string[] nameList = of.FileNames;

                //ÏÔÊ¾½ø¶ÈÌõ´°¿Ú
                ProgressShower progress = new ProgressShower();
                progress.Location = this.Location;
                progress.progressBar1.Maximum = nameList.Count();
                progress.Show();

                foreach (string path in nameList)
                {
                    // Éú³ÉÍêÕû±£´æÂ·¾¶
                    string fullpath = Path.GetDirectoryName(path) + "\\" + Path.GetFileNameWithoutExtension(path) + "(framed)" + ".jpg";

                    Open_Picture(pic_path: path);                                                       // ´ò¿ªÍ¼Ïñ
                    Save_Picture(pic_path: fullpath);                                                   // ±£´æÍ¼Ïñ
                    progress.progressBar1.Value += 1;
                }
                progress.Close(); //¹Ø±Õ½ø¶ÈÌõÏÔÊ¾
                MessageBox.Show("Process done.");

                PreviewUpdate();
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// ÅúÁ¿Ìí¼Ó°×±ß
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmi_BatchApply_Just_Margin_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();                   // ÊµÀý»¯Ò»¸ö´ò¿ªÎÄ¼þµÄ¶Ô»°¿ò
            of.Multiselect = true;                                      // ÔÊÐí¶àÑ¡
            of.Title = "Please choose the images to edit";              // ÉèÖÃ¶Ô»°¿ò±êÌâ
            of.Filter = "Image Files|*.jpg";                            // ÉèÖÃÖ¸¶¨Í¼ÏñÀàÐÍ
            if (of.ShowDialog() == DialogResult.OK)                     // ÏÔÊ¾¶Ô»°¿ò£¬Èç¹ûÑ¡ÔñÈ·¶¨
            {
                //»ñÈ¡ÎÄ¼þÂ·¾¶
                string[] nameList = of.FileNames;

                //ÏÔÊ¾½ø¶ÈÌõ´°¿Ú
                ProgressShower progress = new ProgressShower();
                progress.Location = this.Location;
                progress.progressBar1.Maximum = nameList.Count();
                progress.Show();

                foreach (string path in nameList)
                {
                    // Éú³ÉÍêÕû±£´æÂ·¾¶
                    string fullpath = Path.GetDirectoryName(path) + "\\" + Path.GetFileNameWithoutExtension(path) + "(framed)" + ".jpg";

                    Open_Picture(pic_path: path);                                                       // ´ò¿ªÍ¼Ïñ

                    JSONinteractions.Json2Parameters(previewGenePack, Properties.Resources.Just_Margin);
                    PreviewUpdate();
                    ControlsUpdate();

                    Save_Picture(pic_path: fullpath);                                                   // ±£´æÍ¼Ïñ
                    progress.progressBar1.Value += 1;
                }
                progress.Close(); //¹Ø±Õ½ø¶ÈÌõÏÔÊ¾
                MessageBox.Show("Process done.");

                PreviewUpdate();
            }
            else
            {
                return;
            }
        }

        private void tsmi_BatchApply_Just_Compress_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();                   // ÊµÀý»¯Ò»¸ö´ò¿ªÎÄ¼þµÄ¶Ô»°¿ò
            of.Multiselect = true;                                      // ÔÊÐí¶àÑ¡
            of.Title = "Please choose the images to edit";              // ÉèÖÃ¶Ô»°¿ò±êÌâ
            of.Filter = "Image Files|*.jpg";                            // ÉèÖÃÖ¸¶¨Í¼ÏñÀàÐÍ
            if (of.ShowDialog() == DialogResult.OK)                     // ÏÔÊ¾¶Ô»°¿ò£¬Èç¹ûÑ¡ÔñÈ·¶¨
            {
                //»ñÈ¡ÎÄ¼þÂ·¾¶
                string[] nameList = of.FileNames;

                //ÏÔÊ¾½ø¶ÈÌõ´°¿Ú
                ProgressShower progress = new ProgressShower();
                progress.Location = this.Location;
                progress.progressBar1.Maximum = nameList.Count();
                progress.Show();

                foreach (string path in nameList)
                {
                    // Éú³ÉÍêÕû±£´æÂ·¾¶
                    string fullpath = Path.GetDirectoryName(path) + "\\" + Path.GetFileNameWithoutExtension(path) + "(framed)" + ".jpg";

                    Open_Picture(pic_path: path);                                                       // ´ò¿ªÍ¼Ïñ

                    JSONinteractions.Json2Parameters(previewGenePack, Properties.Resources.Nothing);
                    PreviewUpdate();
                    ControlsUpdate();

                    Save_Picture(pic_path: fullpath);                                                   // ±£´æÍ¼Ïñ
                    progress.progressBar1.Value += 1;
                }
                progress.Close(); //¹Ø±Õ½ø¶ÈÌõÏÔÊ¾
                MessageBox.Show("Process done.");

                PreviewUpdate();
            }
            else
            {
                return;
            }
        }

        private void bar_infoTrans_Click(object sender, EventArgs e)
        {

        }
    }
}