using System.Drawing;
namespace Requests
{
    partial class Form1
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
            this.TestConnection = new System.Windows.Forms.Button();
            this.ValidConnection = new System.Windows.Forms.Label();
            this.FNameBox = new System.Windows.Forms.TextBox();
            this.LNameBox = new System.Windows.Forms.TextBox();
            this.RequestBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UploadButton = new System.Windows.Forms.Button();
            this.Hide = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.fM_OPERATIONSDataSet = new Requests.FM_OPERATIONSDataSet();
            this.fMOPERATIONSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.requestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestsTableAdapter = new Requests.FM_OPERATIONSDataSetTableAdapters.RequestsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fM_OPERATIONSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fMOPERATIONSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TestConnection
            // 
            
            this.TestConnection.Location = new System.Drawing.Point(12, 58);
            this.TestConnection.Name = "TestConnection";
            this.TestConnection.Size = new System.Drawing.Size(128, 43);
            this.TestConnection.TabIndex = 0;
            this.TestConnection.Text = "Test Connection";
            this.TestConnection.UseVisualStyleBackColor = true;
            this.TestConnection.Click += new System.EventHandler(this.TestConnection_Click);
            // 
            // ValidConnection
            // 
            this.ValidConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidConnection.Location = new System.Drawing.Point(12, 114);
            this.ValidConnection.Name = "ValidConnection";
            this.ValidConnection.Size = new System.Drawing.Size(128, 23);
            this.ValidConnection.TabIndex = 1;
            // 
            // FNameBox
            // 
            this.FNameBox.Location = new System.Drawing.Point(146, 157);
            this.FNameBox.Multiline = true;
            this.FNameBox.Name = "FNameBox";
            this.FNameBox.Size = new System.Drawing.Size(168, 41);
            this.FNameBox.TabIndex = 2;
            this.FNameBox.ForeColor = Color.Red;

            // 
            // LNameBox
            // 
            this.LNameBox.Location = new System.Drawing.Point(146, 235);
            this.LNameBox.Multiline = true;
            this.LNameBox.Name = "LNameBox";
            this.LNameBox.Size = new System.Drawing.Size(168, 41);
            this.LNameBox.TabIndex = 3;
            // 
            // RequestBox
            // 
            this.RequestBox.Location = new System.Drawing.Point(146, 308);
            this.RequestBox.Multiline = true;
            this.RequestBox.Name = "RequestBox";
            this.RequestBox.Size = new System.Drawing.Size(356, 108);
            this.RequestBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Request:";
            // 
            // UploadButton
            // 
            this.UploadButton.Location = new System.Drawing.Point(12, 449);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(128, 43);
            this.UploadButton.TabIndex = 9;
            this.UploadButton.Text = "Upload";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // Hide
            // 
            this.Hide.Location = new System.Drawing.Point(223, 58);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(139, 43);
            this.Hide.TabIndex = 10;
            this.Hide.Text = "Show Records";
            this.Hide.UseVisualStyleBackColor = true;
            this.Hide.Click += new System.EventHandler(this.Hide_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(416, 58);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(139, 43);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // fM_OPERATIONSDataSet
            // 
            this.fM_OPERATIONSDataSet.DataSetName = "FM_OPERATIONSDataSet";
            this.fM_OPERATIONSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fMOPERATIONSDataSetBindingSource
            // 
            this.fMOPERATIONSDataSetBindingSource.DataSource = this.fM_OPERATIONSDataSet;
            this.fMOPERATIONSDataSetBindingSource.Position = 0;
            // 
            // ListBox1
            // 
            this.ListBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.requestsBindingSource, "RECID", true));
            this.ListBox1.DataSource = this.requestsBindingSource;
            this.ListBox1.DisplayMember = "RECID";
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.Location = new System.Drawing.Point(386, 157);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(120, 95);
            this.ListBox1.TabIndex = 12;
            this.ListBox1.ValueMember = "RECID";
            this.ListBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // requestsBindingSource
            // 
            this.requestsBindingSource.DataMember = "Requests";
            this.requestsBindingSource.DataSource = this.fMOPERATIONSDataSetBindingSource;
            // 
            // requestsTableAdapter
            // 
            this.requestsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 519);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Hide);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RequestBox);
            this.Controls.Add(this.LNameBox);
            this.Controls.Add(this.FNameBox);
            this.Controls.Add(this.ValidConnection);
            this.Controls.Add(this.TestConnection);
            this.Name = "Form1";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fM_OPERATIONSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fMOPERATIONSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TestConnection;
        private System.Windows.Forms.Label ValidConnection;
        private System.Windows.Forms.TextBox FNameBox;
        private System.Windows.Forms.TextBox LNameBox;
        private System.Windows.Forms.TextBox RequestBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Button Hide;
        private System.Windows.Forms.Button ExitButton;
        private FM_OPERATIONSDataSet fM_OPERATIONSDataSet;
        private System.Windows.Forms.BindingSource fMOPERATIONSDataSetBindingSource;
        private System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.BindingSource requestsBindingSource;
        private FM_OPERATIONSDataSetTableAdapters.RequestsTableAdapter requestsTableAdapter;
    }
}

