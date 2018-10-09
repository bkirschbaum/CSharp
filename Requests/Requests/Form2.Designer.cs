namespace Requests
{
    partial class Form2
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
            this.requestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fM_OPERATIONSDataSet = new Requests.FM_OPERATIONSDataSet();
            this.Return = new System.Windows.Forms.Button();
            this.requestsTableAdapter = new Requests.FM_OPERATIONSDataSetTableAdapters.RequestsTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.items = new Requests.Items();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBRsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBRsTableAdapter = new Requests.ItemsTableAdapters.ABRsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fM_OPERATIONSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBRsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // requestsBindingSource
            // 
            this.requestsBindingSource.DataMember = "Requests";
            this.requestsBindingSource.DataSource = this.fM_OPERATIONSDataSet;
            // 
            // fM_OPERATIONSDataSet
            // 
            this.fM_OPERATIONSDataSet.DataSetName = "FM_OPERATIONSDataSet";
            this.fM_OPERATIONSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(13, 13);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(129, 61);
            this.Return.TabIndex = 1;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // requestsTableAdapter
            // 
            this.requestsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.aBRsBindingSource, "PURCHID", true));
            this.comboBox1.DataSource = this.itemsBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(346, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // items
            // 
            this.items.DataSetName = "Items";
            this.items.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataSource = this.items;
            this.itemsBindingSource.Position = 0;
            // 
            // aBRsBindingSource
            // 
            this.aBRsBindingSource.DataMember = "ABRs";
            this.aBRsBindingSource.DataSource = this.items;
            // 
            // aBRsTableAdapter
            // 
            this.aBRsTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 551);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Return);
            this.Name = "Form2";
            this.Text = "Records";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fM_OPERATIONSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBRsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FM_OPERATIONSDataSet fM_OPERATIONSDataSet;
        private System.Windows.Forms.BindingSource requestsBindingSource;
        private FM_OPERATIONSDataSetTableAdapters.RequestsTableAdapter requestsTableAdapter;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private Items items;
        private System.Windows.Forms.BindingSource aBRsBindingSource;
        private ItemsTableAdapters.ABRsTableAdapter aBRsTableAdapter;
    }
}