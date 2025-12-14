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
            this.txtNoteAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.btnDeleteExpense = new System.Windows.Forms.Button();
            this.lblAmo = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblTy = new System.Windows.Forms.Label();
            this.lblDa = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblTransId = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtNoteEdit = new System.Windows.Forms.TextBox();
            this.txtAmountEdit = new System.Windows.Forms.TextBox();
            this.txtTypeEdit = new System.Windows.Forms.TextBox();
            this.txtCategoryEdit = new System.Windows.Forms.TextBox();
            this.lblTransactionId = new System.Windows.Forms.Label();
            this.txtEditID = new System.Windows.Forms.TextBox();
            this.btnEditExpense = new System.Windows.Forms.Button();
            this.dtpDateAdd = new System.Windows.Forms.DateTimePicker();
            this.dtpDateEdit = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionsGrid
            // 
            this.transactionsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transactionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.transactionsGrid, "transactionsGrid");
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
            // lblAmo
            // 
            resources.ApplyResources(this.lblAmo, "lblAmo");
            this.lblAmo.Name = "lblAmo";
            // 
            // lblCat
            // 
            resources.ApplyResources(this.lblCat, "lblCat");
            this.lblCat.Name = "lblCat";
            // 
            // lblTy
            // 
            resources.ApplyResources(this.lblTy, "lblTy");
            this.lblTy.Name = "lblTy";
            // 
            // lblDa
            // 
            resources.ApplyResources(this.lblDa, "lblDa");
            this.lblDa.Name = "lblDa";
            // 
            // lblNo
            // 
            resources.ApplyResources(this.lblNo, "lblNo");
            this.lblNo.Name = "lblNo";
            // 
            // lblTransId
            // 
            resources.ApplyResources(this.lblTransId, "lblTransId");
            this.lblTransId.Name = "lblTransId";
            // 
            // lblNote
            // 
            resources.ApplyResources(this.lblNote, "lblNote");
            this.lblNote.Name = "lblNote";
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.Name = "lblDate";
            // 
            // lblType
            // 
            resources.ApplyResources(this.lblType, "lblType");
            this.lblType.Name = "lblType";
            // 
            // lblCategory
            // 
            resources.ApplyResources(this.lblCategory, "lblCategory");
            this.lblCategory.Name = "lblCategory";
            // 
            // lblAmount
            // 
            resources.ApplyResources(this.lblAmount, "lblAmount");
            this.lblAmount.Name = "lblAmount";
            // 
            // txtNoteEdit
            // 
            resources.ApplyResources(this.txtNoteEdit, "txtNoteEdit");
            this.txtNoteEdit.Name = "txtNoteEdit";
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
            // lblTransactionId
            // 
            resources.ApplyResources(this.lblTransactionId, "lblTransactionId");
            this.lblTransactionId.Name = "lblTransactionId";
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
            // dtpDateAdd
            // 
            resources.ApplyResources(this.dtpDateAdd, "dtpDateAdd");
            this.dtpDateAdd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateAdd.Name = "dtpDateAdd";
            this.dtpDateAdd.Value = new System.DateTime(2025, 12, 9, 0, 0, 0, 0);
            // 
            // dtpDateEdit
            // 
            this.dtpDateEdit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            resources.ApplyResources(this.dtpDateEdit, "dtpDateEdit");
            this.dtpDateEdit.Name = "dtpDateEdit";
            this.dtpDateEdit.Value = new System.DateTime(2025, 12, 9, 0, 0, 0, 0);
            // 
            // TransactionForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpDateEdit);
            this.Controls.Add(this.dtpDateAdd);
            this.Controls.Add(this.btnEditExpense);
            this.Controls.Add(this.lblTransactionId);
            this.Controls.Add(this.txtEditID);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtNoteEdit);
            this.Controls.Add(this.txtAmountEdit);
            this.Controls.Add(this.txtTypeEdit);
            this.Controls.Add(this.txtCategoryEdit);
            this.Controls.Add(this.lblTransId);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblDa);
            this.Controls.Add(this.lblTy);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.lblAmo);
            this.Controls.Add(this.btnDeleteExpense);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNoteAdd);
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
        private System.Windows.Forms.TextBox txtNoteAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Button btnDeleteExpense;
        private System.Windows.Forms.Label lblAmo;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblTy;
        private System.Windows.Forms.Label lblDa;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblTransId;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtNoteEdit;
        private System.Windows.Forms.TextBox txtAmountEdit;
        private System.Windows.Forms.TextBox txtTypeEdit;
        private System.Windows.Forms.TextBox txtCategoryEdit;
        private System.Windows.Forms.Label lblTransactionId;
        private System.Windows.Forms.TextBox txtEditID;
        private System.Windows.Forms.Button btnEditExpense;
        private System.Windows.Forms.DateTimePicker dtpDateAdd;
        private System.Windows.Forms.DateTimePicker dtpDateEdit;
    }
}