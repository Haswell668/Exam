namespace Traffic_Violations_Var_21
{
    partial class FormAddFine
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
            this.components = new System.ComponentModel.Container();
            this.labelRegNumb = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelTypeViolation = new System.Windows.Forms.Label();
            this.labelFineSize = new System.Windows.Forms.Label();
            this.cbRegNumb = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.cbTypeViolation = new System.Windows.Forms.ComboBox();
            this.nudFineSize = new System.Windows.Forms.NumericUpDown();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.bD_TrafficViolationsDataSet = new Traffic_Violations_Var_21.BD_TrafficViolationsDataSet();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new Traffic_Violations_Var_21.BD_TrafficViolationsDataSetTableAdapters.CarsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nudFineSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_TrafficViolationsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRegNumb
            // 
            this.labelRegNumb.AutoSize = true;
            this.labelRegNumb.Location = new System.Drawing.Point(30, 34);
            this.labelRegNumb.Name = "labelRegNumb";
            this.labelRegNumb.Size = new System.Drawing.Size(159, 13);
            this.labelRegNumb.TabIndex = 0;
            this.labelRegNumb.Text = "Регистрационный номер авто";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(30, 79);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(33, 13);
            this.labelData.TabIndex = 1;
            this.labelData.Text = "Дата";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(30, 124);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(40, 13);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Время";
            // 
            // labelTypeViolation
            // 
            this.labelTypeViolation.AutoSize = true;
            this.labelTypeViolation.Location = new System.Drawing.Point(30, 177);
            this.labelTypeViolation.Name = "labelTypeViolation";
            this.labelTypeViolation.Size = new System.Drawing.Size(84, 13);
            this.labelTypeViolation.TabIndex = 3;
            this.labelTypeViolation.Text = "Вид нарушения";
            // 
            // labelFineSize
            // 
            this.labelFineSize.AutoSize = true;
            this.labelFineSize.Location = new System.Drawing.Point(30, 227);
            this.labelFineSize.Name = "labelFineSize";
            this.labelFineSize.Size = new System.Drawing.Size(88, 13);
            this.labelFineSize.TabIndex = 4;
            this.labelFineSize.Text = "Размер штрафа";
            // 
            // cbRegNumb
            // 
            this.cbRegNumb.DataSource = this.carsBindingSource;
            this.cbRegNumb.DisplayMember = "RegistNumber";
            this.cbRegNumb.FormattingEnabled = true;
            this.cbRegNumb.Location = new System.Drawing.Point(241, 34);
            this.cbRegNumb.Name = "cbRegNumb";
            this.cbRegNumb.Size = new System.Drawing.Size(121, 21);
            this.cbRegNumb.TabIndex = 5;
            this.cbRegNumb.ValueMember = "Id_Car";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(241, 73);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(121, 20);
            this.dtpData.TabIndex = 7;
            // 
            // cbTypeViolation
            // 
            this.cbTypeViolation.FormattingEnabled = true;
            this.cbTypeViolation.Items.AddRange(new object[] {
            "Превышение скорости",
            "Несоблюдение требований",
            "Проезд на запрещающий сигнал светофора"});
            this.cbTypeViolation.Location = new System.Drawing.Point(241, 174);
            this.cbTypeViolation.Name = "cbTypeViolation";
            this.cbTypeViolation.Size = new System.Drawing.Size(176, 21);
            this.cbTypeViolation.TabIndex = 8;
            // 
            // nudFineSize
            // 
            this.nudFineSize.Location = new System.Drawing.Point(242, 225);
            this.nudFineSize.Name = "nudFineSize";
            this.nudFineSize.Size = new System.Drawing.Size(120, 20);
            this.nudFineSize.TabIndex = 9;
            // 
            // btOK
            // 
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.Location = new System.Drawing.Point(33, 273);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(136, 23);
            this.btOK.TabIndex = 10;
            this.btOK.Text = "Сохранить штраф";
            this.btOK.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(258, 273);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 11;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(241, 117);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(121, 20);
            this.dtpTime.TabIndex = 12;
            // 
            // bD_TrafficViolationsDataSet
            // 
            this.bD_TrafficViolationsDataSet.DataSetName = "BD_TrafficViolationsDataSet";
            this.bD_TrafficViolationsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "Cars";
            this.carsBindingSource.DataSource = this.bD_TrafficViolationsDataSet;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 318);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.nudFineSize);
            this.Controls.Add(this.cbTypeViolation);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.cbRegNumb);
            this.Controls.Add(this.labelFineSize);
            this.Controls.Add(this.labelTypeViolation);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelRegNumb);
            this.MaximizeBox = false;
            this.Name = "FormAddFine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление нового штрафа";
            this.Load += new System.EventHandler(this.FormAddFine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFineSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_TrafficViolationsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRegNumb;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelTypeViolation;
        private System.Windows.Forms.Label labelFineSize;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        public System.Windows.Forms.ComboBox cbRegNumb;
        private BD_TrafficViolationsDataSet bD_TrafficViolationsDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private BD_TrafficViolationsDataSetTableAdapters.CarsTableAdapter carsTableAdapter;
        public System.Windows.Forms.DateTimePicker dtpData;
        public System.Windows.Forms.ComboBox cbTypeViolation;
        public System.Windows.Forms.NumericUpDown nudFineSize;
        public System.Windows.Forms.DateTimePicker dtpTime;
    }
}