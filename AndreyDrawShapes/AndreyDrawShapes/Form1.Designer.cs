namespace AndreyDrawShapes
{
    partial class Form1
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
            panel1 = new Panel();
            panel2 = new Panel();
            btn_clear = new Button();
            btn_save = new Button();
            color_picker = new PictureBox();
            btn_line = new Button();
            btn_rectangle = new Button();
            btn_ellipse = new Button();
            btn_eraser = new Button();
            btn_pencil = new Button();
            btn_fill = new Button();
            btn_color = new Button();
            pic_color = new Button();
            panel3 = new Panel();
            pic = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)color_picker).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1521, 150);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(btn_clear);
            panel2.Controls.Add(btn_save);
            panel2.Controls.Add(color_picker);
            panel2.Controls.Add(btn_line);
            panel2.Controls.Add(btn_rectangle);
            panel2.Controls.Add(btn_ellipse);
            panel2.Controls.Add(btn_eraser);
            panel2.Controls.Add(btn_pencil);
            panel2.Controls.Add(btn_fill);
            panel2.Controls.Add(btn_color);
            panel2.Controls.Add(pic_color);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1521, 150);
            panel2.TabIndex = 1;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.White;
            btn_clear.Cursor = Cursors.Hand;
            btn_clear.Location = new Point(1407, 67);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(103, 45);
            btn_clear.TabIndex = 10;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.White;
            btn_save.Cursor = Cursors.Hand;
            btn_save.Location = new Point(1407, 16);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(103, 45);
            btn_save.TabIndex = 9;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // color_picker
            // 
            color_picker.Cursor = Cursors.Hand;
            color_picker.Image = Properties.Resources.color_palette;
            color_picker.Location = new Point(100, 0);
            color_picker.Name = "color_picker";
            color_picker.Size = new Size(384, 150);
            color_picker.SizeMode = PictureBoxSizeMode.StretchImage;
            color_picker.TabIndex = 8;
            color_picker.TabStop = false;
            color_picker.Click += color_picker_Click;
            color_picker.Paint += color_picker_Paint;
            color_picker.MouseClick += color_picker_MouseClick;
            // 
            // btn_line
            // 
            btn_line.Cursor = Cursors.Hand;
            btn_line.Image = Properties.Resources._1181533_200_photo_resizer_ru;
            btn_line.ImageAlign = ContentAlignment.TopCenter;
            btn_line.Location = new Point(1289, 16);
            btn_line.Name = "btn_line";
            btn_line.Size = new Size(112, 95);
            btn_line.TabIndex = 7;
            btn_line.Text = "Line";
            btn_line.TextAlign = ContentAlignment.BottomCenter;
            btn_line.UseVisualStyleBackColor = true;
            btn_line.Click += btn_line_Click;
            // 
            // btn_rectangle
            // 
            btn_rectangle.Cursor = Cursors.Hand;
            btn_rectangle.Image = Properties.Resources._932217_200_photo_resizer_ru;
            btn_rectangle.ImageAlign = ContentAlignment.TopCenter;
            btn_rectangle.Location = new Point(1159, 16);
            btn_rectangle.Name = "btn_rectangle";
            btn_rectangle.Size = new Size(112, 95);
            btn_rectangle.TabIndex = 6;
            btn_rectangle.Text = "Rectangle";
            btn_rectangle.TextAlign = ContentAlignment.BottomCenter;
            btn_rectangle.UseVisualStyleBackColor = true;
            btn_rectangle.Click += btn_rectangle_Click;
            // 
            // btn_ellipse
            // 
            btn_ellipse.Cursor = Cursors.Hand;
            btn_ellipse.Image = Properties.Resources._33822_photo_resizer_ru;
            btn_ellipse.ImageAlign = ContentAlignment.TopCenter;
            btn_ellipse.Location = new Point(1027, 16);
            btn_ellipse.Name = "btn_ellipse";
            btn_ellipse.Size = new Size(112, 95);
            btn_ellipse.TabIndex = 5;
            btn_ellipse.Text = "Ellipse";
            btn_ellipse.TextAlign = ContentAlignment.BottomCenter;
            btn_ellipse.UseVisualStyleBackColor = true;
            btn_ellipse.Click += btn_ellipse_Click;
            // 
            // btn_eraser
            // 
            btn_eraser.Cursor = Cursors.Hand;
            btn_eraser.Image = Properties.Resources._254686_photo_resizer_ru;
            btn_eraser.ImageAlign = ContentAlignment.TopCenter;
            btn_eraser.Location = new Point(893, 16);
            btn_eraser.Name = "btn_eraser";
            btn_eraser.Size = new Size(112, 95);
            btn_eraser.TabIndex = 4;
            btn_eraser.Text = "Eraser";
            btn_eraser.TextAlign = ContentAlignment.BottomCenter;
            btn_eraser.UseVisualStyleBackColor = true;
            btn_eraser.Click += btn_eraser_Click;
            // 
            // btn_pencil
            // 
            btn_pencil.Cursor = Cursors.Hand;
            btn_pencil.Image = Properties.Resources._4277132_photo_resizer_ru;
            btn_pencil.ImageAlign = ContentAlignment.TopCenter;
            btn_pencil.Location = new Point(760, 16);
            btn_pencil.Name = "btn_pencil";
            btn_pencil.Size = new Size(112, 95);
            btn_pencil.TabIndex = 3;
            btn_pencil.Text = "Pencil";
            btn_pencil.TextAlign = ContentAlignment.BottomCenter;
            btn_pencil.UseVisualStyleBackColor = true;
            btn_pencil.Click += btn_pencil_Click;
            // 
            // btn_fill
            // 
            btn_fill.Cursor = Cursors.Hand;
            btn_fill.Image = Properties.Resources.fill_icon_27_photo_resizer_ru;
            btn_fill.ImageAlign = ContentAlignment.TopCenter;
            btn_fill.Location = new Point(631, 16);
            btn_fill.Name = "btn_fill";
            btn_fill.Size = new Size(112, 95);
            btn_fill.TabIndex = 2;
            btn_fill.Text = "Fill";
            btn_fill.TextAlign = ContentAlignment.BottomCenter;
            btn_fill.UseVisualStyleBackColor = true;
            btn_fill.Click += btn_fill_Click;
            // 
            // btn_color
            // 
            btn_color.Cursor = Cursors.Hand;
            btn_color.Image = Properties.Resources.paint_photo_resizer_ru__1_;
            btn_color.ImageAlign = ContentAlignment.TopCenter;
            btn_color.Location = new Point(501, 16);
            btn_color.Name = "btn_color";
            btn_color.Size = new Size(112, 95);
            btn_color.TabIndex = 1;
            btn_color.Text = "Color";
            btn_color.TextAlign = ContentAlignment.BottomCenter;
            btn_color.UseVisualStyleBackColor = true;
            btn_color.Click += btn_color_Click;
            // 
            // pic_color
            // 
            pic_color.BackColor = Color.White;
            pic_color.Location = new Point(18, 38);
            pic_color.Name = "pic_color";
            pic_color.Size = new Size(76, 73);
            pic_color.TabIndex = 0;
            pic_color.UseVisualStyleBackColor = false;
            pic_color.Click += pic_color_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 1093);
            panel3.Name = "panel3";
            panel3.Size = new Size(1521, 60);
            panel3.TabIndex = 1;
            // 
            // pic
            // 
            pic.BackColor = Color.White;
            pic.Dock = DockStyle.Fill;
            pic.Location = new Point(0, 150);
            pic.Name = "pic";
            pic.Size = new Size(1521, 943);
            pic.TabIndex = 2;
            pic.TabStop = false;
            pic.MouseClick += pic_MouseClick;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1521, 1153);
            Controls.Add(pic);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)color_picker).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pic;
        private Button btn_color;
        private Button pic_color;
        private Button btn_eraser;
        private Button btn_pencil;
        private Button btn_fill;
        private PictureBox color_picker;
        private Button btn_line;
        private Button btn_rectangle;
        private Button btn_ellipse;
        private Button btn_clear;
        private Button btn_save;
    }
}