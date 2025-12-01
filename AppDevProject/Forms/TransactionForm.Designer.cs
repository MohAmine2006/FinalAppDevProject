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
            this.transactionsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transactionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsGrid.Location = new System.Drawing.Point(12, 59);
            this.transactionsGrid.Name = "transactionsGrid";
            this.transactionsGrid.RowHeadersWidth = 51;
            this.transactionsGrid.RowTemplate.Height = 24;
            this.transactionsGrid.Size = new System.Drawing.Size(1308, 323);
            this.transactionsGrid.TabIndex = 0;
            // 
            // filterTextBox
            // 
            this.filterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterTextBox.Location = new System.Drawing.Point(105, 12);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(173, 30);
            this.filterTextBox.TabIndex = 1;
            // 
            // txtDeleteID
            // 
            this.txtDeleteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeleteID.Location = new System.Drawing.Point(539, 555);
            this.txtDeleteID.Name = "txtDeleteID";
            this.txtDeleteID.Size = new System.Drawing.Size(117, 30);
            this.txtDeleteID.TabIndex = 2;
            // 
            // txtCategoryAdd
            // 
            this.txtCategoryAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryAdd.Location = new System.Drawing.Point(172, 467);
            this.txtCategoryAdd.Name = "txtCategoryAdd";
            this.txtCategoryAdd.Size = new System.Drawing.Size(200, 30);
            this.txtCategoryAdd.TabIndex = 3;
            // 
            // txtTypeAdd
            // 
            this.txtTypeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeAdd.Location = new System.Drawing.Point(172, 509);
            this.txtTypeAdd.Name = "txtTypeAdd";
            this.txtTypeAdd.Size = new System.Drawing.Size(200, 30);
            this.txtTypeAdd.TabIndex = 6;
            // 
            // txtAmountAdd
            // 
            this.txtAmountAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountAdd.Location = new System.Drawing.Point(172, 428);
            this.txtAmountAdd.Name = "txtAmountAdd";
            this.txtAmountAdd.Size = new System.Drawing.Size(200, 30);
            this.txtAmountAdd.TabIndex = 7;
            // 
            // txtDateAdd
            // 
            this.txtDateAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateAdd.Location = new System.Drawing.Point(172, 551);
            this.txtDateAdd.Name = "txtDateAdd";
            this.txtDateAdd.Size = new System.Drawing.Size(200, 30);
            this.txtDateAdd.TabIndex = 10;
            // 
            // txtNoteAdd
            // 
            this.txtNoteAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoteAdd.Location = new System.Drawing.Point(172, 593);
            this.txtNoteAdd.Name = "txtNoteAdd";
            this.txtNoteAdd.Size = new System.Drawing.Size(200, 30);
            this.txtNoteAdd.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Filter : ";
            // 
            // btnGoBack
            // 
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.Location = new System.Drawing.Point(1106, 8);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(109, 38);
            this.btnGoBack.TabIndex = 15;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExpense.Location = new System.Drawing.Point(105, 640);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(183, 44);
            this.btnAddExpense.TabIndex = 16;
            this.btnAddExpense.Text = "Add Expense";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            // 
            // btnDeleteExpense
            // 
            this.btnDeleteExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteExpense.Location = new System.Drawing.Point(509, 643);
            this.btnDeleteExpense.Name = "btnDeleteExpense";
            this.btnDeleteExpense.Size = new System.Drawing.Size(183, 44);
            this.btnDeleteExpense.TabIndex = 18;
            this.btnDeleteExpense.Text = "Delete Expense";
            this.btnDeleteExpense.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Amount : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Category : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Type : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 555);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Date : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 596);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Note : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(520, 517);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Transaction ID : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(833, 601);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 25);
            this.label8.TabIndex = 34;
            this.label8.Text = "Note : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(833, 560);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 25);
            this.label9.TabIndex = 33;
            this.label9.Text = "Date : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(833, 514);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 25);
            this.label10.TabIndex = 32;
            this.label10.Text = "Type : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(833, 472);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 25);
            this.label11.TabIndex = 31;
            this.label11.Text = "Category : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(833, 433);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 25);
            this.label12.TabIndex = 30;
            this.label12.Text = "Amount : ";
            // 
            // txtNoteEdit
            // 
            this.txtNoteEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoteEdit.Location = new System.Drawing.Point(1015, 596);
            this.txtNoteEdit.Name = "txtNoteEdit";
            this.txtNoteEdit.Size = new System.Drawing.Size(200, 30);
            this.txtNoteEdit.TabIndex = 29;
            // 
            // txtDateEdit
            // 
            this.txtDateEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateEdit.Location = new System.Drawing.Point(1015, 555);
            this.txtDateEdit.Name = "txtDateEdit";
            this.txtDateEdit.Size = new System.Drawing.Size(200, 30);
            this.txtDateEdit.TabIndex = 28;
            // 
            // txtAmountEdit
            // 
            this.txtAmountEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountEdit.Location = new System.Drawing.Point(1015, 433);
            this.txtAmountEdit.Name = "txtAmountEdit";
            this.txtAmountEdit.Size = new System.Drawing.Size(200, 30);
            this.txtAmountEdit.TabIndex = 27;
            // 
            // txtTypeEdit
            // 
            this.txtTypeEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeEdit.Location = new System.Drawing.Point(1015, 514);
            this.txtTypeEdit.Name = "txtTypeEdit";
            this.txtTypeEdit.Size = new System.Drawing.Size(200, 30);
            this.txtTypeEdit.TabIndex = 26;
            // 
            // txtCategoryEdit
            // 
            this.txtCategoryEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryEdit.Location = new System.Drawing.Point(1015, 472);
            this.txtCategoryEdit.Name = "txtCategoryEdit";
            this.txtCategoryEdit.Size = new System.Drawing.Size(200, 30);
            this.txtCategoryEdit.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(833, 402);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(172, 25);
            this.label13.TabIndex = 36;
            this.label13.Text = "Transaction ID : ";
            // 
            // txtEditID
            // 
            this.txtEditID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditID.Location = new System.Drawing.Point(1015, 397);
            this.txtEditID.Name = "txtEditID";
            this.txtEditID.Size = new System.Drawing.Size(200, 30);
            this.txtEditID.TabIndex = 35;
            // 
            // btnEditExpense
            // 
            this.btnEditExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditExpense.Location = new System.Drawing.Point(944, 640);
            this.btnEditExpense.Name = "btnEditExpense";
            this.btnEditExpense.Size = new System.Drawing.Size(183, 44);
            this.btnEditExpense.TabIndex = 37;
            this.btnEditExpense.Text = "Edit Expense";
            this.btnEditExpense.UseVisualStyleBackColor = true;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 803);
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
            this.Text = "TransactionForm";
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