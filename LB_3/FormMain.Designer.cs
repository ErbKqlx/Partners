namespace LB_3
{
    partial class FormMain
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
            flowLayoutPanelPartners = new FlowLayoutPanel();
            panel = new Panel();
            TypeOfPartner = new Label();
            label1 = new Label();
            Name = new Label();
            NameOfDirector = new Label();
            Phone = new Label();
            label2 = new Label();
            Rating = new Label();
            flowLayoutPanelPartners.SuspendLayout();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelPartners
            // 
            flowLayoutPanelPartners.Controls.Add(panel);
            flowLayoutPanelPartners.Dock = DockStyle.Fill;
            flowLayoutPanelPartners.Font = new Font("Segoe UI", 14F);
            flowLayoutPanelPartners.Location = new Point(0, 0);
            flowLayoutPanelPartners.Name = "flowLayoutPanelPartners";
            flowLayoutPanelPartners.Padding = new Padding(10);
            flowLayoutPanelPartners.Size = new Size(800, 450);
            flowLayoutPanelPartners.TabIndex = 1;
            // 
            // panel
            // 
            panel.BackColor = Color.White;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(Rating);
            panel.Controls.Add(label2);
            panel.Controls.Add(Phone);
            panel.Controls.Add(NameOfDirector);
            panel.Controls.Add(Name);
            panel.Controls.Add(label1);
            panel.Controls.Add(TypeOfPartner);
            panel.Font = new Font("Segoe UI", 14F);
            panel.Location = new Point(13, 13);
            panel.Name = "panel";
            panel.Padding = new Padding(10);
            panel.Size = new Size(775, 135);
            panel.TabIndex = 2;
            // 
            // TypeOfPartner
            // 
            TypeOfPartner.Location = new Point(14, 13);
            TypeOfPartner.Name = "TypeOfPartner";
            TypeOfPartner.Size = new Size(46, 34);
            TypeOfPartner.TabIndex = 0;
            TypeOfPartner.Text = "Тип";
            // 
            // label1
            // 
            label1.Location = new Point(55, 13);
            label1.Name = "label1";
            label1.Size = new Size(21, 34);
            label1.TabIndex = 1;
            label1.Text = "|";
            // 
            // Name
            // 
            Name.Location = new Point(69, 13);
            Name.Name = "Name";
            Name.Size = new Size(233, 34);
            Name.TabIndex = 2;
            Name.Text = "Наименование партнера";
            // 
            // NameOfDirector
            // 
            NameOfDirector.Font = new Font("Segoe UI", 12F);
            NameOfDirector.Location = new Point(13, 47);
            NameOfDirector.Name = "NameOfDirector";
            NameOfDirector.Size = new Size(91, 26);
            NameOfDirector.TabIndex = 3;
            NameOfDirector.Text = "Директор";
            // 
            // Phone
            // 
            Phone.Font = new Font("Segoe UI", 12F);
            Phone.Location = new Point(13, 72);
            Phone.Name = "Phone";
            Phone.Size = new Size(138, 26);
            Phone.TabIndex = 4;
            Phone.Text = "Номер телефона";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(13, 97);
            label2.Name = "label2";
            label2.Size = new Size(74, 26);
            label2.TabIndex = 5;
            label2.Text = "Рейтинг:";
            // 
            // Rating
            // 
            Rating.Font = new Font("Segoe UI", 12F);
            Rating.Location = new Point(81, 97);
            Rating.Name = "Rating";
            Rating.Size = new Size(52, 26);
            Rating.TabIndex = 6;
            Rating.Text = "0";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanelPartners);
            Name = "FormMain";
            Text = "Партнеры";
            flowLayoutPanelPartners.ResumeLayout(false);
            panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanelPartners;
        private Panel panel;
        private Label TypeOfPartner;
        private Label Name;
        private Label label1;
        private Label NameOfDirector;
        private Label Phone;
        private Label label2;
        private Label Rating;
    }
}
