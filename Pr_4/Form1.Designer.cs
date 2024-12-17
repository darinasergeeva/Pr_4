namespace Pr_4
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
            dataGridPartners = new DataGridView();
            panelControls = new Panel();
            labeltype = new Label();
            labelName = new Label();
            labeltelephone = new Label();
            labelrating = new Label();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridPartners).BeginInit();
            SuspendLayout();
            // 
            // dataGridPartners
            // 
            dataGridPartners.BackgroundColor = Color.White;
            dataGridPartners.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPartners.Dock = DockStyle.Fill;
            dataGridPartners.Location = new Point(0, 0);
            dataGridPartners.Name = "dataGridPartners";
            dataGridPartners.Size = new Size(644, 450);
            dataGridPartners.TabIndex = 0;
            // 
            // panelControls
            // 
            panelControls.BackColor = Color.White;
            panelControls.Dock = DockStyle.Top;
            panelControls.Location = new Point(0, 0);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(644, 100);
            panelControls.TabIndex = 1;
            // 
            // labeltype
            // 
            labeltype.BackColor = Color.White;
            labeltype.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labeltype.Location = new Point(12, 120);
            labeltype.Name = "labeltype";
            labeltype.Size = new Size(231, 23);
            labeltype.TabIndex = 2;
            labeltype.Text = "Тип | Наименование партнёра";
            // 
            // labelName
            // 
            labelName.BackColor = Color.Transparent;
            labelName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelName.Location = new Point(12, 157);
            labelName.Name = "labelName";
            labelName.Size = new Size(231, 23);
            labelName.TabIndex = 3;
            labelName.Click += label1_Click;
            // 
            // labeltelephone
            // 
            labeltelephone.BackColor = Color.Transparent;
            labeltelephone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labeltelephone.Location = new Point(12, 203);
            labeltelephone.Name = "labeltelephone";
            labeltelephone.Size = new Size(231, 23);
            labeltelephone.TabIndex = 4;
            // 
            // labelrating
            // 
            labelrating.BackColor = Color.Transparent;
            labelrating.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelrating.Location = new Point(12, 248);
            labelrating.Name = "labelrating";
            labelrating.Size = new Size(231, 23);
            labelrating.TabIndex = 5;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.ActiveCaption;
            buttonAdd.Location = new Point(12, 347);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = SystemColors.ActiveCaption;
            buttonEdit.Location = new Point(112, 347);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(97, 23);
            buttonEdit.TabIndex = 7;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = SystemColors.ActiveCaption;
            buttonDelete.Location = new Point(233, 347);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = SystemColors.ActiveCaption;
            buttonUpdate.Location = new Point(333, 347);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 9;
            buttonUpdate.Text = "Обновить";
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 450);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(labelrating);
            Controls.Add(labeltelephone);
            Controls.Add(labelName);
            Controls.Add(labeltype);
            Controls.Add(panelControls);
            Controls.Add(dataGridPartners);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridPartners).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridPartners;
        private Panel panelControls;
        private Label labeltype;
        private Label labelName;
        private Label labeltelephone;
        private Label labelrating;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private Button buttonUpdate;
    }
}
