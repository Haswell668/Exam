namespace Traffic_Violations_Var_21
{
    partial class FormTrafficViolations
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataVievMain = new System.Windows.Forms.DataGridView();
            this.btAddFine = new System.Windows.Forms.Button();
            this.btFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataVievMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dataVievMain
            // 
            this.dataVievMain.AllowUserToAddRows = false;
            this.dataVievMain.AllowUserToDeleteRows = false;
            this.dataVievMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVievMain.Location = new System.Drawing.Point(12, 12);
            this.dataVievMain.Name = "dataVievMain";
            this.dataVievMain.ReadOnly = true;
            this.dataVievMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataVievMain.Size = new System.Drawing.Size(843, 194);
            this.dataVievMain.TabIndex = 0;
            // 
            // btAddFine
            // 
            this.btAddFine.Location = new System.Drawing.Point(12, 240);
            this.btAddFine.Name = "btAddFine";
            this.btAddFine.Size = new System.Drawing.Size(158, 23);
            this.btAddFine.TabIndex = 1;
            this.btAddFine.Text = "Оформить новый штраф";
            this.btAddFine.UseVisualStyleBackColor = true;
            this.btAddFine.Click += new System.EventHandler(this.btAddFine_Click);
            // 
            // btFilter
            // 
            this.btFilter.Location = new System.Drawing.Point(225, 240);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(162, 23);
            this.btFilter.TabIndex = 2;
            this.btFilter.Text = "Наибольшая задолжность";
            this.btFilter.UseVisualStyleBackColor = true;
            // 
            // FormTrafficViolations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 284);
            this.Controls.Add(this.btFilter);
            this.Controls.Add(this.btAddFine);
            this.Controls.Add(this.dataVievMain);
            this.MaximizeBox = false;
            this.Name = "FormTrafficViolations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет нарушений правил дорожного движения";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataVievMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataVievMain;
        private System.Windows.Forms.Button btAddFine;
        private System.Windows.Forms.Button btFilter;
    }
}

