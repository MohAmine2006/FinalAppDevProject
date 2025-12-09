namespace AppDevProject.Forms
{
    partial class TransactionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionForm));
            this.transactionsGrid = new System.Windows.Forms.DataGridView();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.txtDeleteID = new System.Windows.Forms.TextBox();
            this.txtCategoryAdd = new System.Windows.Forms.TextBox();
            this.txtTypeAdd = new System.Windows.Forms.TextBox();
            this.txtAmountAdd = new System.Windows.Forms.TextBox();
            this.txtDateAdd = new System.Windows.Forms.TextBox();
            this.txtNoteAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.btnDeleteExpense = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNoteEdit = new System.Windows.Forms.TextBox();
            this.txtDateEdit = new System.Windows.Forms.TextBox();
            this.txtAmountEdit = new System.Windows.Forms.TextBox();
            this.txtTypeEdit = new System.Windows.Forms.TextBox();
            this.txtCategoryEdit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEditID = new System.Windows.Forms.TextBox();
            this.btnEditExpense = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionsGrid
            // 
            resources.ApplyResources(this.transactionsGrid, "transactionsGrid");
            this.transactionsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transactionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsGrid.Name = "transactionsGrid";
            this.transactionsGrid.RowTemplate.Height = 24;
            // 
            // filterTextBox
            // 
            resources.ApplyResources(this.filterTextBox, "filterTextBox");
            this.filterTextBox.Name = "filterTextBox";
            // 
            // txtDeleteID
            // 
            resources.ApplyResources(this.txtDeleteID, "txtDeleteID");
            this.txtDeleteID.Name = "txtDeleteID";
            // 
            // txtCategoryAdd
            // 
            resources.ApplyResources(this.txtCategoryAdd, "txtCategoryAdd");
            this.txtCategoryAdd.Name = "txtCategoryAdd";
            // 
            // txtTypeAdd
            // 
            resources.ApplyResources(this.txtTypeAdd, "txtTypeAdd");
            this.txtTypeAdd.Name = "txtTypeAdd";
            // 
            // txtAmountAdd
            // 
            resources.ApplyResources(this.txtAmountAdd, "txtAmountAdd");
            this.txtAmountAdd.Name = "txtAmountAdd";
            // 
            // txtDateAdd
            // 
            resources.ApplyResources(this.txtDateAdd, "txtDateAdd");
            this.txtDateAdd.Name = "txtDateAdd";
            // 
            // txtNoteAdd
            // 
            resources.ApplyResources(this.txtNoteAdd, "txtNoteAdd");
            this.txtNoteAdd.Name = "txtNoteAdd";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnGoBack
            // 
            resources.ApplyResources(this.btnGoBack, "btnGoBack");
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnAddExpense
            // 
            resources.ApplyResources(this.btnAddExpense, "btnAddExpense");
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // btnDeleteExpense
            // 
            resources.ApplyResources(this.btnDeleteExpense, "btnDeleteExpense");
            this.btnDeleteExpense.Name = "btnDeleteExpense";
            this.btnDeleteExpense.UseVisualStyleBackColor = true;
            this.btnDeleteExpense.Click += new System.EventHandler(this.btnDeleteExpense_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // txtNoteEdit
            // 
            resources.ApplyResources(this.txtNoteEdit, "txtNoteEdit");
            this.txtNoteEdit.Name = "txtNoteEdit";
            // 
            // txtDateEdit
            // 
            resources.ApplyResources(this.txtDateEdit, "txtDateEdit");
            this.txtDateEdit.Name = "txtDateEdit";
            // 
            // txtAmountEdit
            // 
            resources.ApplyResources(this.txtAmountEdit, "txtAmountEdit");
            this.txtAmountEdit.Name = "txtAmountEdit";
            // 
            // txtTypeEdit
            // 
            resources.ApplyResources(this.txtTypeEdit, "txtTypeEdit");
            this.txtTypeEdit.Name = "txtTypeEdit";
            // 
            // txtCategoryEdit
            // 
            resources.ApplyResources(this.txtCategoryEdit, "txtCategoryEdit");
            this.txtCategoryEdit.Name = "txtCategoryEdit";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // txtEditID
            // 
            resources.ApplyResources(this.txtEditID, "txtEditID");
            this.txtEditID.Name = "txtEditID";
            // 
            // btnEditExpense
            // 
            resources.ApplyResources(this.btnEditExpense, "btnEditExpense");
            this.btnEditExpense.Name = "btnEditExpense";
            this.btnEditExpense.UseVisualStyleBackColor = true;
            this.btnEditExpense.Click += new System.EventHandler(this.btnEditExpense_Click);
            // 
            // TransactionForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEditExpense);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtEditID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNoteEdit);
            this.Controls.Add(this.txtDateEdit);
            this.Controls.Add(this.txtAmountEdit);
            this.Controls.Add(this.txtTypeEdit);
            this.Controls.Add(this.txtCategoryEdit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteExpense);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNoteAdd);
            this.Controls.Add(this.txtDateAdd);
            this.Controls.Add(this.txtAmountAdd);
            this.Controls.Add(this.txtTypeAdd);
            this.Controls.Add(this.txtCategoryAdd);
            this.Controls.Add(this.txtDeleteID);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.transactionsGrid);
            this.Name = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView transactionsGrid;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.TextBox txtDeleteID;
        private System.Windows.Forms.TextBox txtCategoryAdd;
        private System.Windows.Forms.TextBox txtTypeAdd;
        private System.Windows.Forms.TextBox txtAmountAdd;
        private System.Windows.Forms.TextBox txtDateAdd;
        private System.Windows.Forms.TextBox txtNoteAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Button btnDeleteExpense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNoteEdit;
        private System.Windows.Forms.TextBox txtDateEdit;
        private System.Windows.Forms.TextBox txtAmountEdit;
        private System.Windows.Forms.TextBox txtTypeEdit;
        private System.Windows.Forms.TextBox txtCategoryEdit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEditID;
        private System.Windows.Forms.Button btnEditExpense;
    }
}