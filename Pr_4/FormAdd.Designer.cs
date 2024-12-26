namespace Pr_4
{
    partial class FormAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanelFill = new FlowLayoutPanel();
            labelName = new Label();
            textBoxName = new TextBox();
            textBoxLegalAddress = new TextBox();
            textBoxTin = new TextBox();
            textBoxNameOfDirector = new TextBox();
            textBoxTelephone = new TextBox();
            textBoxEmail = new TextBox();
            textBoxRating = new TextBox();
            flowLayoutPanelBotton = new FlowLayoutPanel();
            buttonSave = new Button();
            buttonCancel = new Button();
            flowLayoutPanelFill.SuspendLayout();
            flowLayoutPanelBotton.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelFill
            // 
            flowLayoutPanelFill.Controls.Add(labelName);
            flowLayoutPanelFill.Controls.Add(textBoxName);
            flowLayoutPanelFill.Controls.Add(textBoxLegalAddress);
            flowLayoutPanelFill.Controls.Add(textBoxTin);
            flowLayoutPanelFill.Controls.Add(textBoxNameOfDirector);
            flowLayoutPanelFill.Controls.Add(textBoxTelephone);
            flowLayoutPanelFill.Controls.Add(textBoxEmail);
            flowLayoutPanelFill.Controls.Add(textBoxRating);
            flowLayoutPanelFill.Dock = DockStyle.Fill;
            flowLayoutPanelFill.Location = new Point(10, 10);
            flowLayoutPanelFill.Name = "flowLayoutPanelFill";
            flowLayoutPanelFill.Padding = new Padding(10);
            flowLayoutPanelFill.Size = new Size(364, 376);
            flowLayoutPanelFill.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.Dock = DockStyle.Top;
            labelName.Location = new Point(13, 13);
            labelName.Margin = new Padding(3);
            labelName.Name = "labelName";
            labelName.Size = new Size(338, 29);
            labelName.TabIndex = 0;
            labelName.Text = "Партнёры";
            // 
            // textBoxName
            // 
            textBoxName.Dock = DockStyle.Top;
            textBoxName.Location = new Point(13, 48);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(338, 33);
            textBoxName.TabIndex = 1;
            // 
            // textBoxLegalAddress
            // 
            textBoxLegalAddress.Dock = DockStyle.Top;
            textBoxLegalAddress.Location = new Point(13, 87);
            textBoxLegalAddress.Name = "textBoxLegalAddress";
            textBoxLegalAddress.Size = new Size(338, 33);
            textBoxLegalAddress.TabIndex = 2;
            // 
            // textBoxTin
            // 
            textBoxTin.Dock = DockStyle.Top;
            textBoxTin.Location = new Point(13, 126);
            textBoxTin.Name = "textBoxTin";
            textBoxTin.Size = new Size(338, 33);
            textBoxTin.TabIndex = 3;
            // 
            // textBoxNameOfDirector
            // 
            textBoxNameOfDirector.Dock = DockStyle.Top;
            textBoxNameOfDirector.Location = new Point(13, 165);
            textBoxNameOfDirector.Name = "textBoxNameOfDirector";
            textBoxNameOfDirector.Size = new Size(338, 33);
            textBoxNameOfDirector.TabIndex = 4;
            // 
            // textBoxTelephone
            // 
            textBoxTelephone.Dock = DockStyle.Top;
            textBoxTelephone.Location = new Point(13, 204);
            textBoxTelephone.Name = "textBoxTelephone";
            textBoxTelephone.Size = new Size(338, 33);
            textBoxTelephone.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Dock = DockStyle.Top;
            textBoxEmail.Location = new Point(13, 243);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(338, 33);
            textBoxEmail.TabIndex = 6;
            // 
            // textBoxRating
            // 
            textBoxRating.Dock = DockStyle.Top;
            textBoxRating.Location = new Point(13, 282);
            textBoxRating.Name = "textBoxRating";
            textBoxRating.Size = new Size(338, 33);
            textBoxRating.TabIndex = 7;
            // 
            // flowLayoutPanelBotton
            // 
            flowLayoutPanelBotton.AutoSize = true;
            flowLayoutPanelBotton.Controls.Add(buttonSave);
            flowLayoutPanelBotton.Controls.Add(buttonCancel);
            flowLayoutPanelBotton.Dock = DockStyle.Bottom;
            flowLayoutPanelBotton.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelBotton.Location = new Point(10, 345);
            flowLayoutPanelBotton.Name = "flowLayoutPanelBotton";
            flowLayoutPanelBotton.Size = new Size(364, 41);
            flowLayoutPanelBotton.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Location = new Point(211, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(150, 35);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += button1_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(55, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(150, 35);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 396);
            Controls.Add(flowLayoutPanelBotton);
            Controls.Add(flowLayoutPanelFill);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormAdd";
            Padding = new Padding(10);
            Load += FormAdd_Load;
            flowLayoutPanelFill.ResumeLayout(false);
            flowLayoutPanelFill.PerformLayout();
            flowLayoutPanelBotton.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelFill;
        private FlowLayoutPanel flowLayoutPanelBotton;
        private Button buttonSave;
        private Button buttonCancel;
        private Label labelName;
        protected internal TextBox textBoxName;
        protected internal TextBox textBoxLegalAddress;
        protected internal TextBox textBoxTin;
        protected internal TextBox textBoxNameOfDirector;
        protected internal TextBox textBoxTelephone;
        protected internal TextBox textBoxEmail;
        protected internal TextBox textBoxRating;
    }
}