namespace PictureFrame
{
    partial class frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            tsmi_File = new ToolStripMenuItem();
            tsmi_OpenPicture = new ToolStripMenuItem();
            tsmi_SavePicture = new ToolStripMenuItem();
            tsmi_BatchApply = new ToolStripMenuItem();
            tsmi_BatchApply_Just_Margin = new ToolStripMenuItem();
            tsmi_BatchApply_Just_Compress = new ToolStripMenuItem();
            tsmi_Preset = new ToolStripMenuItem();
            tsmi_SavePreset = new ToolStripMenuItem();
            tsmi_OpenPreset = new ToolStripMenuItem();
            useToolStripMenuItem = new ToolStripMenuItem();
            preset_Hori_Mid = new ToolStripMenuItem();
            preset_Hori_Flex = new ToolStripMenuItem();
            preset_Square_Flex = new ToolStripMenuItem();
            preset_Vert_Flex = new ToolStripMenuItem();
            preset_Vert_Flex_Right = new ToolStripMenuItem();
            preset_Just_Margin = new ToolStripMenuItem();
            preset_Nothing = new ToolStripMenuItem();
            pb_Preview = new PictureBox();
            lbl_Preview = new Label();
            lbl_InfoStrip = new Label();
            lbl_info_location = new Label();
            lbl_info_Size = new Label();
            lbl_logoAdding = new Label();
            cbox_LogoList = new ComboBox();
            lbl_logo_Size = new Label();
            lbl_logo_X = new Label();
            btn_logo_midAlignX = new Button();
            lbl_logo_Y = new Label();
            btn_logo_midAlignY = new Button();
            tbox_date = new TextBox();
            lbl_date_text = new Label();
            lbl_date_Font = new Label();
            cbox_date_Style = new ComboBox();
            lbl_date_Style = new Label();
            lbl_date_X = new Label();
            lbl_date_Y = new Label();
            btn_date_midAlign = new Button();
            btn_date_midAlign2 = new Button();
            lbl_dateInformation = new Label();
            lbl_picInfo = new Label();
            lbl_picInfo_Font = new Label();
            lbl_picInfo_Style = new Label();
            cbox_picInfo_Font = new ComboBox();
            cbox_picInfo_Style = new ComboBox();
            tbox_picInfo_Camera = new TextBox();
            lbl_picInfo_Camera = new Label();
            lbl_picInfo_F = new Label();
            tbox_picInfo_F = new TextBox();
            lbl_picInfo_Expo = new Label();
            tbox_picInfo_Expo = new TextBox();
            lbl_picInfo_ISO = new Label();
            tbox_picInfo_ISO = new TextBox();
            lbl_picInfo_Focal = new Label();
            tbox_picInfo_Focal = new TextBox();
            lbl_picInfo_Bias = new Label();
            tbox_picInfo_Bias = new TextBox();
            lbl_date_FontSize = new Label();
            lbl_picInfo_X = new Label();
            lbl_picInfo_Y = new Label();
            lbl_picInfo_FontSize = new Label();
            btn_picInfo_midAlign = new Button();
            btn_picInfo_midAlign2 = new Button();
            lbl_logo_Brand = new Label();
            rbtn_InfoStrip_Right = new RadioButton();
            rbtn_InfoStrip_Beneath = new RadioButton();
            bar_StripSize = new ControlBar();
            bar_logoSize = new ControlBar();
            bar_logoX = new ControlBar();
            bar_logoY = new ControlBar();
            lbl_date_FontTrans = new Label();
            cbox_date_Font = new ComboBox();
            bar_timeX = new ControlBar();
            bar_timeY = new ControlBar();
            bar_timeSize = new ControlBar();
            bar_timeTrans = new ControlBar();
            bar_infoX = new ControlBar();
            bar_infoY = new ControlBar();
            bar_infoSize = new ControlBar();
            bar_infoTrans = new ControlBar();
            lbl_info_FontTrans = new Label();
            lbl_Margin = new Label();
            lbl_margin_size = new Label();
            bar_marginSize = new ControlBar();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Preview).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(28, 28);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmi_File, tsmi_Preset });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 4, 0, 4);
            menuStrip1.Size = new Size(2376, 42);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmi_File
            // 
            tsmi_File.DropDownItems.AddRange(new ToolStripItem[] { tsmi_OpenPicture, tsmi_SavePicture, tsmi_BatchApply, tsmi_BatchApply_Just_Margin, tsmi_BatchApply_Just_Compress });
            tsmi_File.Name = "tsmi_File";
            tsmi_File.Size = new Size(95, 34);
            tsmi_File.Text = "Picture";
            // 
            // tsmi_OpenPicture
            // 
            tsmi_OpenPicture.Name = "tsmi_OpenPicture";
            tsmi_OpenPicture.Size = new Size(429, 40);
            tsmi_OpenPicture.Text = "Open Picture";
            tsmi_OpenPicture.Click += tsmi_OpenPicture_Click;
            // 
            // tsmi_SavePicture
            // 
            tsmi_SavePicture.Name = "tsmi_SavePicture";
            tsmi_SavePicture.Size = new Size(429, 40);
            tsmi_SavePicture.Text = "Save Picture";
            tsmi_SavePicture.Click += tsmi_SavePicture_Click;
            // 
            // tsmi_BatchApply
            // 
            tsmi_BatchApply.Name = "tsmi_BatchApply";
            tsmi_BatchApply.Size = new Size(429, 40);
            tsmi_BatchApply.Text = "Batch Apply (Automative)";
            tsmi_BatchApply.Click += tsmi_BatchApply_Click;
            // 
            // tsmi_BatchApply_Just_Margin
            // 
            tsmi_BatchApply_Just_Margin.Name = "tsmi_BatchApply_Just_Margin";
            tsmi_BatchApply_Just_Margin.Size = new Size(429, 40);
            tsmi_BatchApply_Just_Margin.Text = "Batch Apply (Only Margin)";
            tsmi_BatchApply_Just_Margin.Click += tsmi_BatchApply_Just_Margin_Click;
            // 
            // tsmi_BatchApply_Just_Compress
            // 
            tsmi_BatchApply_Just_Compress.Name = "tsmi_BatchApply_Just_Compress";
            tsmi_BatchApply_Just_Compress.Size = new Size(429, 40);
            tsmi_BatchApply_Just_Compress.Text = "Batch Apply (Only Compression)";
            tsmi_BatchApply_Just_Compress.Click += tsmi_BatchApply_Just_Compress_Click;
            // 
            // tsmi_Preset
            // 
            tsmi_Preset.DropDownItems.AddRange(new ToolStripItem[] { tsmi_SavePreset, tsmi_OpenPreset, useToolStripMenuItem });
            tsmi_Preset.Name = "tsmi_Preset";
            tsmi_Preset.Size = new Size(88, 34);
            tsmi_Preset.Text = "Preset";
            // 
            // tsmi_SavePreset
            // 
            tsmi_SavePreset.Name = "tsmi_SavePreset";
            tsmi_SavePreset.Size = new Size(304, 40);
            tsmi_SavePreset.Text = "Save Preset";
            tsmi_SavePreset.Click += tsmi_SavePreset_Click;
            // 
            // tsmi_OpenPreset
            // 
            tsmi_OpenPreset.Name = "tsmi_OpenPreset";
            tsmi_OpenPreset.Size = new Size(304, 40);
            tsmi_OpenPreset.Text = "Open Preset";
            tsmi_OpenPreset.Click += tsmi_OpenPreset_Click;
            // 
            // useToolStripMenuItem
            // 
            useToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { preset_Hori_Mid, preset_Hori_Flex, preset_Square_Flex, preset_Vert_Flex, preset_Vert_Flex_Right, preset_Just_Margin, preset_Nothing });
            useToolStripMenuItem.Name = "useToolStripMenuItem";
            useToolStripMenuItem.Size = new Size(304, 40);
            useToolStripMenuItem.Text = "Use Primary Preset";
            // 
            // preset_Hori_Mid
            // 
            preset_Hori_Mid.Name = "preset_Hori_Mid";
            preset_Hori_Mid.Size = new Size(328, 40);
            preset_Hori_Mid.Text = "Horizontal | MidAlign";
            preset_Hori_Mid.Click += beneathMidlignToolStripMenuItem1_Click;
            // 
            // preset_Hori_Flex
            // 
            preset_Hori_Flex.Name = "preset_Hori_Flex";
            preset_Hori_Flex.Size = new Size(328, 40);
            preset_Hori_Flex.Text = "Horizontal | Flex";
            preset_Hori_Flex.Click += beneathMidlignToolStripMenuItem2_Click;
            // 
            // preset_Square_Flex
            // 
            preset_Square_Flex.Name = "preset_Square_Flex";
            preset_Square_Flex.Size = new Size(328, 40);
            preset_Square_Flex.Text = "Square | Flex";
            preset_Square_Flex.Click += beneathMidlignToolStripMenuItem3_Click;
            // 
            // preset_Vert_Flex
            // 
            preset_Vert_Flex.Name = "preset_Vert_Flex";
            preset_Vert_Flex.Size = new Size(328, 40);
            preset_Vert_Flex.Text = "Vertical | Flex";
            preset_Vert_Flex.Click += beneathCorner横向构图ToolStripMenuItem_Click;
            // 
            // preset_Vert_Flex_Right
            // 
            preset_Vert_Flex_Right.Name = "preset_Vert_Flex_Right";
            preset_Vert_Flex_Right.Size = new Size(328, 40);
            preset_Vert_Flex_Right.Text = "Vertical | Flex (Right)";
            preset_Vert_Flex_Right.Click += rightCorner方形构图ToolStripMenuItem_Click;
            // 
            // preset_Just_Margin
            // 
            preset_Just_Margin.Name = "preset_Just_Margin";
            preset_Just_Margin.Size = new Size(328, 40);
            preset_Just_Margin.Text = "Just Margin";
            preset_Just_Margin.Click += preset_Just_Margin_Click;
            // 
            // preset_Nothing
            // 
            preset_Nothing.Name = "preset_Nothing";
            preset_Nothing.Size = new Size(328, 40);
            preset_Nothing.Text = "Nothing";
            preset_Nothing.Click += preset_Nothing_Click;
            // 
            // pb_Preview
            // 
            pb_Preview.BackgroundImageLayout = ImageLayout.None;
            pb_Preview.Location = new Point(21, 102);
            pb_Preview.Margin = new Padding(0);
            pb_Preview.Name = "pb_Preview";
            pb_Preview.Size = new Size(1200, 1200);
            pb_Preview.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Preview.TabIndex = 1;
            pb_Preview.TabStop = false;
            // 
            // lbl_Preview
            // 
            lbl_Preview.AutoSize = true;
            lbl_Preview.Location = new Point(21, 58);
            lbl_Preview.Margin = new Padding(5, 0, 5, 0);
            lbl_Preview.Name = "lbl_Preview";
            lbl_Preview.Size = new Size(95, 30);
            lbl_Preview.TabIndex = 2;
            lbl_Preview.Text = "Preview :";
            // 
            // lbl_InfoStrip
            // 
            lbl_InfoStrip.AutoSize = true;
            lbl_InfoStrip.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_InfoStrip.Location = new Point(1239, 92);
            lbl_InfoStrip.Margin = new Padding(5, 0, 5, 0);
            lbl_InfoStrip.Name = "lbl_InfoStrip";
            lbl_InfoStrip.Size = new Size(338, 31);
            lbl_InfoStrip.TabIndex = 4;
            lbl_InfoStrip.Text = "Information Strip Parameters :";
            // 
            // lbl_info_location
            // 
            lbl_info_location.AutoSize = true;
            lbl_info_location.Location = new Point(1239, 150);
            lbl_info_location.Margin = new Padding(5, 0, 5, 0);
            lbl_info_location.Name = "lbl_info_location";
            lbl_info_location.Size = new Size(103, 30);
            lbl_info_location.TabIndex = 7;
            lbl_info_location.Text = "Location :";
            // 
            // lbl_info_Size
            // 
            lbl_info_Size.AutoSize = true;
            lbl_info_Size.Location = new Point(1239, 202);
            lbl_info_Size.Margin = new Padding(5, 0, 5, 0);
            lbl_info_Size.Name = "lbl_info_Size";
            lbl_info_Size.Size = new Size(61, 30);
            lbl_info_Size.TabIndex = 7;
            lbl_info_Size.Text = "Size :";
            // 
            // lbl_logoAdding
            // 
            lbl_logoAdding.AutoSize = true;
            lbl_logoAdding.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_logoAdding.Location = new Point(1238, 293);
            lbl_logoAdding.Margin = new Padding(5, 0, 5, 0);
            lbl_logoAdding.Name = "lbl_logoAdding";
            lbl_logoAdding.Size = new Size(165, 31);
            lbl_logoAdding.TabIndex = 4;
            lbl_logoAdding.Text = "Logo Adding :";
            // 
            // cbox_LogoList
            // 
            cbox_LogoList.FormattingEnabled = true;
            cbox_LogoList.Location = new Point(1329, 335);
            cbox_LogoList.Margin = new Padding(5, 6, 5, 6);
            cbox_LogoList.Name = "cbox_LogoList";
            cbox_LogoList.Size = new Size(468, 38);
            cbox_LogoList.TabIndex = 9;
            cbox_LogoList.SelectedIndexChanged += cbox_LogoList_SelectedIndexChanged;
            // 
            // lbl_logo_Size
            // 
            lbl_logo_Size.AutoSize = true;
            lbl_logo_Size.Location = new Point(1241, 388);
            lbl_logo_Size.Margin = new Padding(5, 0, 5, 0);
            lbl_logo_Size.Name = "lbl_logo_Size";
            lbl_logo_Size.Size = new Size(61, 30);
            lbl_logo_Size.TabIndex = 7;
            lbl_logo_Size.Text = "Size :";
            // 
            // lbl_logo_X
            // 
            lbl_logo_X.AutoSize = true;
            lbl_logo_X.Location = new Point(1243, 455);
            lbl_logo_X.Margin = new Padding(5, 0, 5, 0);
            lbl_logo_X.Name = "lbl_logo_X";
            lbl_logo_X.Size = new Size(36, 30);
            lbl_logo_X.TabIndex = 7;
            lbl_logo_X.Text = "X :";
            // 
            // btn_logo_midAlignX
            // 
            btn_logo_midAlignX.Location = new Point(1668, 456);
            btn_logo_midAlignX.Margin = new Padding(5, 6, 5, 6);
            btn_logo_midAlignX.Name = "btn_logo_midAlignX";
            btn_logo_midAlignX.Size = new Size(129, 30);
            btn_logo_midAlignX.TabIndex = 11;
            btn_logo_midAlignX.Text = "Mid";
            btn_logo_midAlignX.UseVisualStyleBackColor = true;
            btn_logo_midAlignX.Click += btn_logo_midAlignX_Click;
            // 
            // lbl_logo_Y
            // 
            lbl_logo_Y.AutoSize = true;
            lbl_logo_Y.Location = new Point(1245, 534);
            lbl_logo_Y.Margin = new Padding(5, 0, 5, 0);
            lbl_logo_Y.Name = "lbl_logo_Y";
            lbl_logo_Y.Size = new Size(36, 30);
            lbl_logo_Y.TabIndex = 7;
            lbl_logo_Y.Text = "Y :";
            // 
            // btn_logo_midAlignY
            // 
            btn_logo_midAlignY.Location = new Point(1668, 534);
            btn_logo_midAlignY.Margin = new Padding(5, 6, 5, 6);
            btn_logo_midAlignY.Name = "btn_logo_midAlignY";
            btn_logo_midAlignY.Size = new Size(129, 30);
            btn_logo_midAlignY.TabIndex = 11;
            btn_logo_midAlignY.Text = "Mid";
            btn_logo_midAlignY.UseVisualStyleBackColor = true;
            btn_logo_midAlignY.Click += btn_logo_midAlignY_Click;
            // 
            // tbox_date
            // 
            tbox_date.Location = new Point(1310, 697);
            tbox_date.Margin = new Padding(5, 6, 5, 6);
            tbox_date.Name = "tbox_date";
            tbox_date.Size = new Size(484, 35);
            tbox_date.TabIndex = 12;
            tbox_date.TextChanged += tbox_date_TextChanged;
            // 
            // lbl_date_text
            // 
            lbl_date_text.AutoSize = true;
            lbl_date_text.Location = new Point(1242, 700);
            lbl_date_text.Margin = new Padding(5, 0, 5, 0);
            lbl_date_text.Name = "lbl_date_text";
            lbl_date_text.Size = new Size(61, 30);
            lbl_date_text.TabIndex = 7;
            lbl_date_text.Text = "Text :";
            // 
            // lbl_date_Font
            // 
            lbl_date_Font.AutoSize = true;
            lbl_date_Font.Location = new Point(1242, 756);
            lbl_date_Font.Margin = new Padding(5, 0, 5, 0);
            lbl_date_Font.Name = "lbl_date_Font";
            lbl_date_Font.Size = new Size(129, 30);
            lbl_date_Font.TabIndex = 7;
            lbl_date_Font.Text = "Font Family :";
            // 
            // cbox_date_Style
            // 
            cbox_date_Style.FormattingEnabled = true;
            cbox_date_Style.Location = new Point(1381, 811);
            cbox_date_Style.Margin = new Padding(5, 6, 5, 6);
            cbox_date_Style.Name = "cbox_date_Style";
            cbox_date_Style.Size = new Size(413, 38);
            cbox_date_Style.TabIndex = 13;
            cbox_date_Style.SelectedIndexChanged += cbox_date_Style_SelectedIndexChanged;
            // 
            // lbl_date_Style
            // 
            lbl_date_Style.AutoSize = true;
            lbl_date_Style.Location = new Point(1242, 814);
            lbl_date_Style.Margin = new Padding(5, 0, 5, 0);
            lbl_date_Style.Name = "lbl_date_Style";
            lbl_date_Style.Size = new Size(114, 30);
            lbl_date_Style.TabIndex = 7;
            lbl_date_Style.Text = "Font Style :";
            // 
            // lbl_date_X
            // 
            lbl_date_X.AutoSize = true;
            lbl_date_X.Location = new Point(1242, 870);
            lbl_date_X.Margin = new Padding(5, 0, 5, 0);
            lbl_date_X.Name = "lbl_date_X";
            lbl_date_X.Size = new Size(36, 30);
            lbl_date_X.TabIndex = 7;
            lbl_date_X.Text = "X :";
            // 
            // lbl_date_Y
            // 
            lbl_date_Y.AutoSize = true;
            lbl_date_Y.Location = new Point(1244, 940);
            lbl_date_Y.Margin = new Padding(5, 0, 5, 0);
            lbl_date_Y.Name = "lbl_date_Y";
            lbl_date_Y.Size = new Size(36, 30);
            lbl_date_Y.TabIndex = 7;
            lbl_date_Y.Text = "Y :";
            // 
            // btn_date_midAlign
            // 
            btn_date_midAlign.Location = new Point(1665, 869);
            btn_date_midAlign.Margin = new Padding(5, 6, 5, 6);
            btn_date_midAlign.Name = "btn_date_midAlign";
            btn_date_midAlign.Size = new Size(129, 30);
            btn_date_midAlign.TabIndex = 11;
            btn_date_midAlign.Text = "Mid";
            btn_date_midAlign.UseVisualStyleBackColor = true;
            btn_date_midAlign.Click += btn_date_midAlign_Click;
            // 
            // btn_date_midAlign2
            // 
            btn_date_midAlign2.Location = new Point(1665, 933);
            btn_date_midAlign2.Margin = new Padding(5, 6, 5, 6);
            btn_date_midAlign2.Name = "btn_date_midAlign2";
            btn_date_midAlign2.Size = new Size(129, 30);
            btn_date_midAlign2.TabIndex = 11;
            btn_date_midAlign2.Text = "Mid";
            btn_date_midAlign2.UseVisualStyleBackColor = true;
            btn_date_midAlign2.Click += btn_date_midAlign2_Click;
            // 
            // lbl_dateInformation
            // 
            lbl_dateInformation.AutoSize = true;
            lbl_dateInformation.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_dateInformation.Location = new Point(1240, 637);
            lbl_dateInformation.Margin = new Padding(5, 0, 5, 0);
            lbl_dateInformation.Name = "lbl_dateInformation";
            lbl_dateInformation.Size = new Size(212, 31);
            lbl_dateInformation.TabIndex = 4;
            lbl_dateInformation.Text = "Date Information :";
            // 
            // lbl_picInfo
            // 
            lbl_picInfo.AutoSize = true;
            lbl_picInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_picInfo.Location = new Point(1807, 88);
            lbl_picInfo.Margin = new Padding(5, 0, 5, 0);
            lbl_picInfo.Name = "lbl_picInfo";
            lbl_picInfo.Size = new Size(238, 31);
            lbl_picInfo.TabIndex = 4;
            lbl_picInfo.Text = "Picture Information :";
            lbl_picInfo.TextAlign = ContentAlignment.BottomRight;
            // 
            // lbl_picInfo_Font
            // 
            lbl_picInfo_Font.AutoSize = true;
            lbl_picInfo_Font.Location = new Point(1807, 150);
            lbl_picInfo_Font.Margin = new Padding(5, 0, 5, 0);
            lbl_picInfo_Font.Name = "lbl_picInfo_Font";
            lbl_picInfo_Font.Size = new Size(123, 30);
            lbl_picInfo_Font.TabIndex = 7;
            lbl_picInfo_Font.Text = "Font Family:";
            // 
            // lbl_picInfo_Style
            // 
            lbl_picInfo_Style.AutoSize = true;
            lbl_picInfo_Style.Location = new Point(1807, 208);
            lbl_picInfo_Style.Margin = new Padding(5, 0, 5, 0);
            lbl_picInfo_Style.Name = "lbl_picInfo_Style";
            lbl_picInfo_Style.Size = new Size(114, 30);
            lbl_picInfo_Style.TabIndex = 7;
            lbl_picInfo_Style.Text = "Font Style :";
            // 
            // cbox_picInfo_Font
            // 
            cbox_picInfo_Font.FormattingEnabled = true;
            cbox_picInfo_Font.Location = new Point(1952, 144);
            cbox_picInfo_Font.Margin = new Padding(5, 6, 5, 6);
            cbox_picInfo_Font.Name = "cbox_picInfo_Font";
            cbox_picInfo_Font.Size = new Size(400, 38);
            cbox_picInfo_Font.TabIndex = 13;
            cbox_picInfo_Font.SelectedIndexChanged += cbox_picInfo_Font_SelectedIndexChanged;
            // 
            // cbox_picInfo_Style
            // 
            cbox_picInfo_Style.FormattingEnabled = true;
            cbox_picInfo_Style.Location = new Point(1952, 202);
            cbox_picInfo_Style.Margin = new Padding(5, 6, 5, 6);
            cbox_picInfo_Style.Name = "cbox_picInfo_Style";
            cbox_picInfo_Style.Size = new Size(400, 38);
            cbox_picInfo_Style.TabIndex = 13;
            cbox_picInfo_Style.SelectedIndexChanged += cbox_picInfo_Style_SelectedIndexChanged;
            // 
            // tbox_picInfo_Camera
            // 
            tbox_picInfo_Camera.Location = new Point(1952, 262);
            tbox_picInfo_Camera.Margin = new Padding(5, 6, 5, 6);
            tbox_picInfo_Camera.Name = "tbox_picInfo_Camera";
            tbox_picInfo_Camera.Size = new Size(400, 35);
            tbox_picInfo_Camera.TabIndex = 12;
            tbox_picInfo_Camera.TextChanged += tbox_picInfo_Camera_TextChanged;
            // 
            // lbl_picInfo_Camera
            // 
            lbl_picInfo_Camera.AutoSize = true;
            lbl_picInfo_Camera.Location = new Point(1807, 268);
            lbl_picInfo_Camera.Margin = new Padding(5, 0, 5, 0);
            lbl_picInfo_Camera.Name = "lbl_picInfo_Camera";
            lbl_picInfo_Camera.Size = new Size(95, 30);
            lbl_picInfo_Camera.TabIndex = 7;
            lbl_picInfo_Camera.Text = "Camera :";
            // 
            // lbl_picInfo_F
            // 
            lbl_picInfo_F.AutoSize = true;
            lbl_picInfo_F.Location = new Point(1807, 326);
            lbl_picInfo_F.Margin = new Padding(5, 0, 5, 0);
            lbl_picInfo_F.Name = "lbl_picInfo_F";
            lbl_picInfo_F.Size = new Size(82, 30);
            lbl_picInfo_F.TabIndex = 7;
            lbl_picInfo_F.Text = "F-stop :";
            // 
            // tbox_picInfo_F
            // 
            tbox_picInfo_F.Location = new Point(1952, 320);
            tbox_picInfo_F.Margin = new Padding(5, 6, 5, 6);
            tbox_picInfo_F.Name = "tbox_picInfo_F";
            tbox_picInfo_F.Size = new Size(400, 35);
            tbox_picInfo_F.TabIndex = 12;
            tbox_picInfo_F.TextChanged += tbox_picInfo_F_TextChanged;
            // 
            // lbl_picInfo_Expo
            // 
            lbl_picInfo_Expo.AutoSize = true;
            lbl_picInfo_Expo.Location = new Point(1807, 386);
            lbl_picInfo_Expo.Margin = new Padding(5, 0, 5, 0);
            lbl_picInfo_Expo.Name = "lbl_picInfo_Expo";
            lbl_picInfo_Expo.Size = new Size(122, 30);
            lbl_picInfo_Expo.TabIndex = 7;
            lbl_picInfo_Expo.Text = "Expo-Time :";
            // 
            // tbox_picInfo_Expo
            // 
            tbox_picInfo_Expo.Location = new Point(1951, 378);
            tbox_picInfo_Expo.Margin = new Padding(5, 6, 5, 6);
            tbox_picInfo_Expo.Name = "tbox_picInfo_Expo";
            tbox_picInfo_Expo.Size = new Size(400, 35);
            tbox_picInfo_Expo.TabIndex = 12;
            tbox_picInfo_Expo.TextChanged += tbox_picInfo_Expo_TextChanged;
            // 
            // lbl_picInfo_ISO
            // 
            lbl_picInfo_ISO.AutoSize = true;
            lbl_picInfo_ISO.Location = new Point(1807, 444);
            lbl_picInfo_ISO.Margin = new Padding(5, 0, 5, 0);
            lbl_picInfo_ISO.Name = "lbl_picInfo_ISO";
            lbl_picInfo_ISO.Size = new Size(57, 30);
            lbl_picInfo_ISO.TabIndex = 7;
            lbl_picInfo_ISO.Text = "ISO :";
            // 
            // tbox_picInfo_ISO
            // 
            tbox_picInfo_ISO.Location = new Point(1951, 436);
            tbox_picInfo_ISO.Margin = new Padding(5, 6, 5, 6);
            tbox_picInfo_ISO.Name = "tbox_picInfo_ISO";
            tbox_picInfo_ISO.Size = new Size(400, 35);
            tbox_picInfo_ISO.TabIndex = 12;
            tbox_picInfo_ISO.TextChanged += tbox_picInfo_ISO_TextChanged;
            // 
            // lbl_picInfo_Focal
            // 
            lbl_picInfo_Focal.AutoSize = true;
            lbl_picInfo_Focal.Location = new Point(1807, 502);
            lbl_picInfo_Focal.Margin = new Padding(5, 0, 5, 0);
            lbl_picInfo_Focal.Name = "lbl_picInfo_Focal";
            lbl_picInfo_Focal.Size = new Size(142, 30);
            lbl_picInfo_Focal.TabIndex = 7;
            lbl_picInfo_Focal.Text = "Focal Length :";
            // 
            // tbox_picInfo_Focal
            // 
            tbox_picInfo_Focal.Location = new Point(1951, 494);
            tbox_picInfo_Focal.Margin = new Padding(5, 6, 5, 6);
            tbox_picInfo_Focal.Name = "tbox_picInfo_Focal";
            tbox_picInfo_Focal.Size = new Size(400, 35);
            tbox_picInfo_Focal.TabIndex = 12;
            tbox_picInfo_Focal.TextChanged += tbox_picInfo_Focal_TextChanged;
            // 
            // lbl_picInfo_Bias
            // 
            lbl_picInfo_Bias.AutoSize = true;
            lbl_picInfo_Bias.Location = new Point(1807, 556);
            lbl_picInfo_Bias.Margin = new Padding(5, 0, 5, 0);
            lbl_picInfo_Bias.Name = "lbl_picInfo_Bias";
            lbl_picInfo_Bias.Size = new Size(114, 30);
            lbl_picInfo_Bias.TabIndex = 7;
            lbl_picInfo_Bias.Text = "Expo-Bias :";
            // 
            // tbox_picInfo_Bias
            // 
            tbox_picInfo_Bias.Location = new Point(1951, 552);
            tbox_picInfo_Bias.Margin = new Padding(5, 6, 5, 6);
            tbox_picInfo_Bias.Name = "tbox_picInfo_Bias";
            tbox_picInfo_Bias.Size = new Size(400, 35);
            tbox_picInfo_Bias.TabIndex = 12;
            tbox_picInfo_Bias.TextChanged += tbox_picInfo_Bias_TextChanged;
            // 
            // lbl_date_FontSize
            // 
            lbl_date_FontSize.AutoSize = true;
            lbl_date_FontSize.Location = new Point(1242, 1004);
            lbl_date_FontSize.Margin = new Padding(5, 0, 5, 0);
            lbl_date_FontSize.Name = "lbl_date_FontSize";
            lbl_date_FontSize.Size = new Size(108, 30);
            lbl_date_FontSize.TabIndex = 7;
            lbl_date_FontSize.Text = "Font Size :";
            // 
            // lbl_picInfo_X
            // 
            lbl_picInfo_X.AutoSize = true;
            lbl_picInfo_X.Location = new Point(1807, 608);
            lbl_picInfo_X.Margin = new Padding(5, 0, 5, 0);
            lbl_picInfo_X.Name = "lbl_picInfo_X";
            lbl_picInfo_X.Size = new Size(36, 30);
            lbl_picInfo_X.TabIndex = 7;
            lbl_picInfo_X.Text = "X :";
            // 
            // lbl_picInfo_Y
            // 
            lbl_picInfo_Y.AutoSize = true;
            lbl_picInfo_Y.Location = new Point(1809, 680);
            lbl_picInfo_Y.Margin = new Padding(5, 0, 5, 0);
            lbl_picInfo_Y.Name = "lbl_picInfo_Y";
            lbl_picInfo_Y.Size = new Size(36, 30);
            lbl_picInfo_Y.TabIndex = 7;
            lbl_picInfo_Y.Text = "Y :";
            // 
            // lbl_picInfo_FontSize
            // 
            lbl_picInfo_FontSize.AutoSize = true;
            lbl_picInfo_FontSize.Location = new Point(1807, 747);
            lbl_picInfo_FontSize.Margin = new Padding(5, 0, 5, 0);
            lbl_picInfo_FontSize.Name = "lbl_picInfo_FontSize";
            lbl_picInfo_FontSize.Size = new Size(108, 30);
            lbl_picInfo_FontSize.TabIndex = 7;
            lbl_picInfo_FontSize.Text = "Font Size :";
            // 
            // btn_picInfo_midAlign
            // 
            btn_picInfo_midAlign.Location = new Point(2222, 608);
            btn_picInfo_midAlign.Margin = new Padding(5, 6, 5, 6);
            btn_picInfo_midAlign.Name = "btn_picInfo_midAlign";
            btn_picInfo_midAlign.Size = new Size(129, 30);
            btn_picInfo_midAlign.TabIndex = 11;
            btn_picInfo_midAlign.Text = "Mid";
            btn_picInfo_midAlign.UseVisualStyleBackColor = true;
            btn_picInfo_midAlign.Click += btn_picInfo_midAlign_Click;
            // 
            // btn_picInfo_midAlign2
            // 
            btn_picInfo_midAlign2.Location = new Point(2223, 680);
            btn_picInfo_midAlign2.Margin = new Padding(5, 6, 5, 6);
            btn_picInfo_midAlign2.Name = "btn_picInfo_midAlign2";
            btn_picInfo_midAlign2.Size = new Size(129, 30);
            btn_picInfo_midAlign2.TabIndex = 11;
            btn_picInfo_midAlign2.Text = "Mid";
            btn_picInfo_midAlign2.UseVisualStyleBackColor = true;
            btn_picInfo_midAlign2.Click += btn_picInfo_midAlign2_Click;
            // 
            // lbl_logo_Brand
            // 
            lbl_logo_Brand.AutoSize = true;
            lbl_logo_Brand.Location = new Point(1241, 338);
            lbl_logo_Brand.Margin = new Padding(5, 0, 5, 0);
            lbl_logo_Brand.Name = "lbl_logo_Brand";
            lbl_logo_Brand.Size = new Size(78, 30);
            lbl_logo_Brand.TabIndex = 7;
            lbl_logo_Brand.Text = "Brand :";
            // 
            // rbtn_InfoStrip_Right
            // 
            rbtn_InfoStrip_Right.AutoSize = true;
            rbtn_InfoStrip_Right.Location = new Point(1582, 150);
            rbtn_InfoStrip_Right.Margin = new Padding(5, 6, 5, 6);
            rbtn_InfoStrip_Right.Name = "rbtn_InfoStrip_Right";
            rbtn_InfoStrip_Right.Size = new Size(87, 34);
            rbtn_InfoStrip_Right.TabIndex = 15;
            rbtn_InfoStrip_Right.TabStop = true;
            rbtn_InfoStrip_Right.Text = "Right";
            rbtn_InfoStrip_Right.UseVisualStyleBackColor = true;
            rbtn_InfoStrip_Right.CheckedChanged += rbtn_InfoStrip_Right_CheckedChanged;
            // 
            // rbtn_InfoStrip_Beneath
            // 
            rbtn_InfoStrip_Beneath.AutoSize = true;
            rbtn_InfoStrip_Beneath.Checked = true;
            rbtn_InfoStrip_Beneath.Location = new Point(1446, 150);
            rbtn_InfoStrip_Beneath.Margin = new Padding(5, 6, 5, 6);
            rbtn_InfoStrip_Beneath.Name = "rbtn_InfoStrip_Beneath";
            rbtn_InfoStrip_Beneath.Size = new Size(114, 34);
            rbtn_InfoStrip_Beneath.TabIndex = 15;
            rbtn_InfoStrip_Beneath.TabStop = true;
            rbtn_InfoStrip_Beneath.Text = "Beneath";
            rbtn_InfoStrip_Beneath.UseVisualStyleBackColor = true;
            rbtn_InfoStrip_Beneath.CheckedChanged += rbtn_InfoStrip_Beneath_CheckedChanged;
            // 
            // bar_StripSize
            // 
            bar_StripSize._BarColor = Color.FromArgb(200, 200, 200);
            bar_StripSize._Max = 200;
            bar_StripSize._Min = 0;
            bar_StripSize._Radius = 2;
            bar_StripSize._Size = 7;
            bar_StripSize._SliderColor = Color.FromArgb(0, 0, 0);
            bar_StripSize._Value = 0;
            bar_StripSize.IsRound = true;
            bar_StripSize.Location = new Point(1245, 238);
            bar_StripSize.Margin = new Padding(5, 6, 5, 6);
            bar_StripSize.Name = "bar_StripSize";
            bar_StripSize.Size = new Size(552, 10);
            bar_StripSize.TabIndex = 16;
            bar_StripSize.Text = "controlBar1";
            bar_StripSize.ValueChanged += bar_StripSize_ValueChanged;
            // 
            // bar_logoSize
            // 
            bar_logoSize._BarColor = Color.FromArgb(200, 200, 200);
            bar_logoSize._Max = 200;
            bar_logoSize._Min = 0;
            bar_logoSize._Radius = 2;
            bar_logoSize._Size = 7;
            bar_logoSize._SliderColor = Color.FromArgb(0, 0, 0);
            bar_logoSize._Value = 0;
            bar_logoSize.IsRound = true;
            bar_logoSize.Location = new Point(1243, 426);
            bar_logoSize.Margin = new Padding(5, 6, 5, 6);
            bar_logoSize.Name = "bar_logoSize";
            bar_logoSize.Size = new Size(554, 10);
            bar_logoSize.TabIndex = 17;
            bar_logoSize.Text = "controlBar1";
            bar_logoSize.ValueChanged += bar_logoSize_ValueChanged;
            // 
            // bar_logoX
            // 
            bar_logoX._BarColor = Color.FromArgb(200, 200, 200);
            bar_logoX._Max = 200;
            bar_logoX._Min = 0;
            bar_logoX._Radius = 2;
            bar_logoX._Size = 7;
            bar_logoX._SliderColor = Color.FromArgb(0, 0, 0);
            bar_logoX._Value = 0;
            bar_logoX.IsRound = true;
            bar_logoX.Location = new Point(1244, 504);
            bar_logoX.Margin = new Padding(5, 6, 5, 6);
            bar_logoX.Name = "bar_logoX";
            bar_logoX.Size = new Size(553, 10);
            bar_logoX.TabIndex = 18;
            bar_logoX.Text = "controlBar1";
            bar_logoX.ValueChanged += bar_logoX_ValueChanged;
            // 
            // bar_logoY
            // 
            bar_logoY._BarColor = Color.FromArgb(200, 200, 200);
            bar_logoY._Max = 200;
            bar_logoY._Min = 0;
            bar_logoY._Radius = 2;
            bar_logoY._Size = 7;
            bar_logoY._SliderColor = Color.FromArgb(0, 0, 0);
            bar_logoY._Value = 0;
            bar_logoY.IsRound = true;
            bar_logoY.Location = new Point(1244, 576);
            bar_logoY.Margin = new Padding(5, 6, 5, 6);
            bar_logoY.Name = "bar_logoY";
            bar_logoY.Size = new Size(553, 10);
            bar_logoY.TabIndex = 19;
            bar_logoY.Text = "controlBar2";
            bar_logoY.ValueChanged += bar_logoY_ValueChanged;
            // 
            // lbl_date_FontTrans
            // 
            lbl_date_FontTrans.AutoSize = true;
            lbl_date_FontTrans.Location = new Point(1244, 1065);
            lbl_date_FontTrans.Margin = new Padding(5, 0, 5, 0);
            lbl_date_FontTrans.Name = "lbl_date_FontTrans";
            lbl_date_FontTrans.Size = new Size(139, 30);
            lbl_date_FontTrans.TabIndex = 7;
            lbl_date_FontTrans.Text = "Transparency:";
            // 
            // cbox_date_Font
            // 
            cbox_date_Font.FormattingEnabled = true;
            cbox_date_Font.Location = new Point(1381, 752);
            cbox_date_Font.Margin = new Padding(5, 6, 5, 6);
            cbox_date_Font.Name = "cbox_date_Font";
            cbox_date_Font.Size = new Size(413, 38);
            cbox_date_Font.TabIndex = 20;
            cbox_date_Font.SelectedIndexChanged += cbox_date_Font_SelectedIndexChanged;
            // 
            // bar_timeX
            // 
            bar_timeX._BarColor = Color.FromArgb(200, 200, 200);
            bar_timeX._Max = 200;
            bar_timeX._Min = 0;
            bar_timeX._Radius = 2;
            bar_timeX._Size = 7;
            bar_timeX._SliderColor = Color.FromArgb(0, 0, 0);
            bar_timeX._Value = 0;
            bar_timeX.IsRound = true;
            bar_timeX.Location = new Point(1244, 911);
            bar_timeX.Margin = new Padding(5, 6, 5, 6);
            bar_timeX.Name = "bar_timeX";
            bar_timeX.Size = new Size(550, 10);
            bar_timeX.TabIndex = 21;
            bar_timeX.Text = "controlBar1";
            bar_timeX.ValueChanged += bar_timeX_ValueChanged;
            // 
            // bar_timeY
            // 
            bar_timeY._BarColor = Color.FromArgb(200, 200, 200);
            bar_timeY._Max = 200;
            bar_timeY._Min = 0;
            bar_timeY._Radius = 2;
            bar_timeY._Size = 7;
            bar_timeY._SliderColor = Color.FromArgb(0, 0, 0);
            bar_timeY._Value = 0;
            bar_timeY.IsRound = true;
            bar_timeY.Location = new Point(1244, 976);
            bar_timeY.Margin = new Padding(5, 6, 5, 6);
            bar_timeY.Name = "bar_timeY";
            bar_timeY.Size = new Size(550, 10);
            bar_timeY.TabIndex = 22;
            bar_timeY.Text = "controlBar1";
            bar_timeY.ValueChanged += bar_timeY_ValueChanged;
            // 
            // bar_timeSize
            // 
            bar_timeSize._BarColor = Color.FromArgb(200, 200, 200);
            bar_timeSize._Max = 200;
            bar_timeSize._Min = 0;
            bar_timeSize._Radius = 2;
            bar_timeSize._Size = 7;
            bar_timeSize._SliderColor = Color.FromArgb(0, 0, 0);
            bar_timeSize._Value = 0;
            bar_timeSize.IsRound = true;
            bar_timeSize.Location = new Point(1244, 1040);
            bar_timeSize.Margin = new Padding(5, 6, 5, 6);
            bar_timeSize.Name = "bar_timeSize";
            bar_timeSize.Size = new Size(550, 10);
            bar_timeSize.TabIndex = 23;
            bar_timeSize.Text = "controlBar1";
            bar_timeSize.ValueChanged += bar_timeSize_ValueChanged;
            // 
            // bar_timeTrans
            // 
            bar_timeTrans._BarColor = Color.FromArgb(200, 200, 200);
            bar_timeTrans._Max = 255;
            bar_timeTrans._Min = 0;
            bar_timeTrans._Radius = 2;
            bar_timeTrans._Size = 7;
            bar_timeTrans._SliderColor = Color.FromArgb(0, 0, 0);
            bar_timeTrans._Value = 0;
            bar_timeTrans.IsRound = true;
            bar_timeTrans.Location = new Point(1244, 1101);
            bar_timeTrans.Margin = new Padding(5, 6, 5, 6);
            bar_timeTrans.Name = "bar_timeTrans";
            bar_timeTrans.Size = new Size(550, 10);
            bar_timeTrans.TabIndex = 24;
            bar_timeTrans.Text = "controlBar1";
            bar_timeTrans.ValueChanged += bar_timeTrans_ValueChanged;
            // 
            // bar_infoX
            // 
            bar_infoX._BarColor = Color.FromArgb(200, 200, 200);
            bar_infoX._Max = 200;
            bar_infoX._Min = 0;
            bar_infoX._Radius = 2;
            bar_infoX._Size = 7;
            bar_infoX._SliderColor = Color.FromArgb(0, 0, 0);
            bar_infoX._Value = 0;
            bar_infoX.IsRound = true;
            bar_infoX.Location = new Point(1807, 650);
            bar_infoX.Margin = new Padding(5, 6, 5, 6);
            bar_infoX.Name = "bar_infoX";
            bar_infoX.Size = new Size(544, 10);
            bar_infoX.TabIndex = 25;
            bar_infoX.Text = "controlBar1";
            bar_infoX.ValueChanged += bar_infoX_ValueChanged;
            // 
            // bar_infoY
            // 
            bar_infoY._BarColor = Color.FromArgb(200, 200, 200);
            bar_infoY._Max = 200;
            bar_infoY._Min = 0;
            bar_infoY._Radius = 2;
            bar_infoY._Size = 7;
            bar_infoY._SliderColor = Color.FromArgb(0, 0, 0);
            bar_infoY._Value = 0;
            bar_infoY.IsRound = true;
            bar_infoY.Location = new Point(1809, 716);
            bar_infoY.Margin = new Padding(5, 6, 5, 6);
            bar_infoY.Name = "bar_infoY";
            bar_infoY.Size = new Size(545, 10);
            bar_infoY.TabIndex = 26;
            bar_infoY.Text = "controlBar1";
            bar_infoY.ValueChanged += bar_infoY_ValueChanged;
            // 
            // bar_infoSize
            // 
            bar_infoSize._BarColor = Color.FromArgb(200, 200, 200);
            bar_infoSize._Max = 200;
            bar_infoSize._Min = 0;
            bar_infoSize._Radius = 2;
            bar_infoSize._Size = 7;
            bar_infoSize._SliderColor = Color.FromArgb(0, 0, 0);
            bar_infoSize._Value = 0;
            bar_infoSize.IsRound = true;
            bar_infoSize.Location = new Point(1810, 783);
            bar_infoSize.Margin = new Padding(5, 6, 5, 6);
            bar_infoSize.Name = "bar_infoSize";
            bar_infoSize.Size = new Size(544, 10);
            bar_infoSize.TabIndex = 27;
            bar_infoSize.Text = "controlBar1";
            bar_infoSize.ValueChanged += bar_infoSize_ValueChanged;
            // 
            // bar_infoTrans
            // 
            bar_infoTrans._BarColor = Color.FromArgb(200, 200, 200);
            bar_infoTrans._Max = 255;
            bar_infoTrans._Min = 0;
            bar_infoTrans._Radius = 2;
            bar_infoTrans._Size = 7;
            bar_infoTrans._SliderColor = Color.FromArgb(0, 0, 0);
            bar_infoTrans._Value = 0;
            bar_infoTrans.IsRound = true;
            bar_infoTrans.Location = new Point(1810, 839);
            bar_infoTrans.Margin = new Padding(5, 6, 5, 6);
            bar_infoTrans.Name = "bar_infoTrans";
            bar_infoTrans.Size = new Size(544, 10);
            bar_infoTrans.TabIndex = 28;
            bar_infoTrans.Text = "controlBar1";
            bar_infoTrans.ValueChanged += bar_infoTrans_ValueChanged;
            bar_infoTrans.Click += bar_infoTrans_Click;
            // 
            // lbl_info_FontTrans
            // 
            lbl_info_FontTrans.AutoSize = true;
            lbl_info_FontTrans.Location = new Point(1809, 803);
            lbl_info_FontTrans.Margin = new Padding(5, 0, 5, 0);
            lbl_info_FontTrans.Name = "lbl_info_FontTrans";
            lbl_info_FontTrans.Size = new Size(139, 30);
            lbl_info_FontTrans.TabIndex = 7;
            lbl_info_FontTrans.Text = "Transparency:";
            // 
            // lbl_Margin
            // 
            lbl_Margin.AutoSize = true;
            lbl_Margin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Margin.Location = new Point(1807, 883);
            lbl_Margin.Margin = new Padding(5, 0, 5, 0);
            lbl_Margin.Name = "lbl_Margin";
            lbl_Margin.Size = new Size(240, 31);
            lbl_Margin.TabIndex = 4;
            lbl_Margin.Text = "Margin Information :";
            lbl_Margin.TextAlign = ContentAlignment.BottomRight;
            // 
            // lbl_margin_size
            // 
            lbl_margin_size.AutoSize = true;
            lbl_margin_size.Location = new Point(1810, 932);
            lbl_margin_size.Margin = new Padding(5, 0, 5, 0);
            lbl_margin_size.Name = "lbl_margin_size";
            lbl_margin_size.Size = new Size(61, 30);
            lbl_margin_size.TabIndex = 7;
            lbl_margin_size.Text = "Size :";
            // 
            // bar_marginSize
            // 
            bar_marginSize._BarColor = Color.FromArgb(200, 200, 200);
            bar_marginSize._Max = 200;
            bar_marginSize._Min = 0;
            bar_marginSize._Radius = 2;
            bar_marginSize._Size = 7;
            bar_marginSize._SliderColor = Color.FromArgb(0, 0, 0);
            bar_marginSize._Value = 0;
            bar_marginSize.IsRound = true;
            bar_marginSize.Location = new Point(1810, 968);
            bar_marginSize.Margin = new Padding(5, 6, 5, 6);
            bar_marginSize.Name = "bar_marginSize";
            bar_marginSize.Size = new Size(541, 10);
            bar_marginSize.TabIndex = 29;
            bar_marginSize.Text = "controlBar1";
            bar_marginSize.ValueChanged += bar_marginSize_ValueChanged;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // frm_Main
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(2376, 1336);
            Controls.Add(bar_marginSize);
            Controls.Add(bar_infoTrans);
            Controls.Add(bar_infoSize);
            Controls.Add(bar_infoY);
            Controls.Add(bar_infoX);
            Controls.Add(bar_timeTrans);
            Controls.Add(bar_timeSize);
            Controls.Add(bar_timeY);
            Controls.Add(bar_timeX);
            Controls.Add(cbox_date_Font);
            Controls.Add(bar_logoY);
            Controls.Add(bar_logoX);
            Controls.Add(bar_logoSize);
            Controls.Add(bar_StripSize);
            Controls.Add(rbtn_InfoStrip_Beneath);
            Controls.Add(rbtn_InfoStrip_Right);
            Controls.Add(cbox_picInfo_Style);
            Controls.Add(cbox_date_Style);
            Controls.Add(cbox_picInfo_Font);
            Controls.Add(tbox_picInfo_Bias);
            Controls.Add(tbox_picInfo_Focal);
            Controls.Add(tbox_picInfo_ISO);
            Controls.Add(tbox_picInfo_Expo);
            Controls.Add(tbox_picInfo_F);
            Controls.Add(tbox_picInfo_Camera);
            Controls.Add(tbox_date);
            Controls.Add(btn_picInfo_midAlign2);
            Controls.Add(btn_date_midAlign2);
            Controls.Add(btn_logo_midAlignY);
            Controls.Add(btn_picInfo_midAlign);
            Controls.Add(btn_date_midAlign);
            Controls.Add(btn_logo_midAlignX);
            Controls.Add(cbox_LogoList);
            Controls.Add(lbl_picInfo_Bias);
            Controls.Add(lbl_picInfo_Focal);
            Controls.Add(lbl_picInfo_FontSize);
            Controls.Add(lbl_margin_size);
            Controls.Add(lbl_info_FontTrans);
            Controls.Add(lbl_date_FontTrans);
            Controls.Add(lbl_date_FontSize);
            Controls.Add(lbl_picInfo_Y);
            Controls.Add(lbl_date_Y);
            Controls.Add(lbl_picInfo_ISO);
            Controls.Add(lbl_logo_Y);
            Controls.Add(lbl_picInfo_Expo);
            Controls.Add(lbl_picInfo_F);
            Controls.Add(lbl_picInfo_X);
            Controls.Add(lbl_date_X);
            Controls.Add(lbl_picInfo_Camera);
            Controls.Add(lbl_picInfo_Style);
            Controls.Add(lbl_logo_X);
            Controls.Add(lbl_picInfo_Font);
            Controls.Add(lbl_date_Style);
            Controls.Add(lbl_date_Font);
            Controls.Add(lbl_date_text);
            Controls.Add(lbl_logo_Brand);
            Controls.Add(lbl_logo_Size);
            Controls.Add(lbl_info_Size);
            Controls.Add(lbl_info_location);
            Controls.Add(lbl_dateInformation);
            Controls.Add(lbl_logoAdding);
            Controls.Add(lbl_Margin);
            Controls.Add(lbl_picInfo);
            Controls.Add(lbl_InfoStrip);
            Controls.Add(lbl_Preview);
            Controls.Add(pb_Preview);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "frm_Main";
            Text = "  Picture Frame";
            FormClosing += frm_Main_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_Preview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmi_File;
        private ToolStripMenuItem tsmi_OpenPicture;
        private ToolStripMenuItem tsmi_SavePicture;
        private ToolStripMenuItem tsmi_BatchApply;
        private ToolStripMenuItem tsmi_Preset;
        private ToolStripMenuItem tsmi_SavePreset;
        private ToolStripMenuItem tsmi_OpenPreset;
        private PictureBox pb_Preview;
        private Label lbl_Preview;
        private Label lbl_InfoStrip;
        private Label lbl_info_location;
        private Label lbl_info_Size;
        private Label lbl_logoAdding;
        private ComboBox cbox_LogoList;
        private Label lbl_logo_Size;
        private Label lbl_logo_X;
        private Button btn_logo_midAlignX;
        private Label lbl_logo_Y;
        private Button btn_logo_midAlignY;
        private TextBox tbox_date;
        private Label lbl_date_text;
        private Label lbl_date_Font;
        private ComboBox cbox_date_Style;
        private Label lbl_date_Style;
        private Label lbl_date_X;
        private Label lbl_date_Y;
        private Button btn_date_midAlign;
        private Button btn_date_midAlign2;
        private Label lbl_dateInformation;
        private Label lbl_picInfo;
        private Label lbl_picInfo_Font;
        private Label lbl_picInfo_Style;
        private ComboBox cbox_picInfo_Font;
        private ComboBox cbox_picInfo_Style;
        private TextBox tbox_picInfo_Camera;
        private Label lbl_picInfo_Camera;
        private Label lbl_picInfo_F;
        private TextBox tbox_picInfo_F;
        private Label lbl_picInfo_Expo;
        private TextBox tbox_picInfo_Expo;
        private Label lbl_picInfo_ISO;
        private TextBox tbox_picInfo_ISO;
        private Label lbl_picInfo_Focal;
        private TextBox tbox_picInfo_Focal;
        private Label lbl_picInfo_Bias;
        private TextBox tbox_picInfo_Bias;
        private Label lbl_date_FontSize;
        private Label lbl_picInfo_X;
        private Label lbl_picInfo_Y;
        private Label lbl_picInfo_FontSize;
        private Button btn_picInfo_midAlign;
        private Button btn_picInfo_midAlign2;
        private Label lbl_logo_Brand;
        private RadioButton rbtn_InfoStrip_Right;
        private RadioButton rbtn_InfoStrip_Beneath;
        private ControlBar bar_StripSize;
        private ControlBar bar_logoSize;
        private ControlBar bar_logoX;
        private ControlBar bar_logoY;
        private Label lbl_date_FontTrans;
        private ComboBox cbox_date_Font;
        private ControlBar bar_timeX;
        private ControlBar bar_timeY;
        private ControlBar bar_timeSize;
        private ControlBar bar_timeTrans;
        private ControlBar bar_infoX;
        private ControlBar bar_infoY;
        private ControlBar bar_infoSize;
        private ControlBar bar_infoTrans;
        private Label lbl_info_FontTrans;
        private Label lbl_Margin;
        private Label lbl_margin_size;
        private ControlBar bar_marginSize;
        private ToolStripMenuItem useToolStripMenuItem;
        private ToolStripMenuItem preset_Hori_Mid;
        private ToolStripMenuItem preset_Hori_Flex;
        private ToolStripMenuItem preset_Square_Flex;
        private ToolStripMenuItem preset_Vert_Flex;
        private ToolStripMenuItem preset_Vert_Flex_Right;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem tsmi_BatchApply_Just_Margin;
        private ToolStripMenuItem preset_Just_Margin;
        private ToolStripMenuItem preset_Nothing;
        private ToolStripMenuItem tsmi_BatchApply_Just_Compress;
    }
}