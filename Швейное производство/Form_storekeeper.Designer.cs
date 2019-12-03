namespace Швейное_производство
{
    partial class Form_storekeeper
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this._Швейное_производство_v1_1DataSet = new Швейное_производство._Швейное_производство_v1_1DataSet();
            this.тканиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тканиTableAdapter = new Швейное_производство._Швейное_производство_v1_1DataSetTableAdapters.ТканиTableAdapter();
            this.фурнитураBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фурнитураTableAdapter = new Швейное_производство._Швейное_производство_v1_1DataSetTableAdapters.ФурнитураTableAdapter();
            this.iDтканиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цветDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.составDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.изображениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ширинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.длинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDфурнитурыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.изображениеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ширинаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.длиннаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.весDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Швейное_производство_v1_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тканиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фурнитураBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDтканиDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.цветDataGridViewTextBoxColumn,
            this.составDataGridViewTextBoxColumn,
            this.изображениеDataGridViewTextBoxColumn,
            this.ширинаDataGridViewTextBoxColumn,
            this.длинаDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.тканиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(767, 194);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDфурнитурыDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn1,
            this.типDataGridViewTextBoxColumn,
            this.изображениеDataGridViewTextBoxColumn1,
            this.ширинаDataGridViewTextBoxColumn1,
            this.длиннаDataGridViewTextBoxColumn,
            this.весDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.фурнитураBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(21, 212);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(767, 212);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // _Швейное_производство_v1_1DataSet
            // 
            this._Швейное_производство_v1_1DataSet.DataSetName = "_Швейное_производство_v1_1DataSet";
            this._Швейное_производство_v1_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // тканиBindingSource
            // 
            this.тканиBindingSource.DataMember = "Ткани";
            this.тканиBindingSource.DataSource = this._Швейное_производство_v1_1DataSet;
            // 
            // тканиTableAdapter
            // 
            this.тканиTableAdapter.ClearBeforeFill = true;
            // 
            // фурнитураBindingSource
            // 
            this.фурнитураBindingSource.DataMember = "Фурнитура";
            this.фурнитураBindingSource.DataSource = this._Швейное_производство_v1_1DataSet;
            // 
            // фурнитураTableAdapter
            // 
            this.фурнитураTableAdapter.ClearBeforeFill = true;
            // 
            // iDтканиDataGridViewTextBoxColumn
            // 
            this.iDтканиDataGridViewTextBoxColumn.DataPropertyName = "ID_ткани";
            this.iDтканиDataGridViewTextBoxColumn.HeaderText = "ID_ткани";
            this.iDтканиDataGridViewTextBoxColumn.Name = "iDтканиDataGridViewTextBoxColumn";
            this.iDтканиDataGridViewTextBoxColumn.Width = 70;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            // 
            // цветDataGridViewTextBoxColumn
            // 
            this.цветDataGridViewTextBoxColumn.DataPropertyName = "Цвет";
            this.цветDataGridViewTextBoxColumn.HeaderText = "Цвет";
            this.цветDataGridViewTextBoxColumn.Name = "цветDataGridViewTextBoxColumn";
            // 
            // составDataGridViewTextBoxColumn
            // 
            this.составDataGridViewTextBoxColumn.DataPropertyName = "Состав";
            this.составDataGridViewTextBoxColumn.HeaderText = "Состав";
            this.составDataGridViewTextBoxColumn.Name = "составDataGridViewTextBoxColumn";
            // 
            // изображениеDataGridViewTextBoxColumn
            // 
            this.изображениеDataGridViewTextBoxColumn.DataPropertyName = "Изображение";
            this.изображениеDataGridViewTextBoxColumn.HeaderText = "Изображение";
            this.изображениеDataGridViewTextBoxColumn.Name = "изображениеDataGridViewTextBoxColumn";
            this.изображениеDataGridViewTextBoxColumn.Width = 80;
            // 
            // ширинаDataGridViewTextBoxColumn
            // 
            this.ширинаDataGridViewTextBoxColumn.DataPropertyName = "Ширина";
            this.ширинаDataGridViewTextBoxColumn.HeaderText = "Ширина";
            this.ширинаDataGridViewTextBoxColumn.Name = "ширинаDataGridViewTextBoxColumn";
            this.ширинаDataGridViewTextBoxColumn.Width = 90;
            // 
            // длинаDataGridViewTextBoxColumn
            // 
            this.длинаDataGridViewTextBoxColumn.DataPropertyName = "Длина";
            this.длинаDataGridViewTextBoxColumn.HeaderText = "Длина";
            this.длинаDataGridViewTextBoxColumn.Name = "длинаDataGridViewTextBoxColumn";
            this.длинаDataGridViewTextBoxColumn.Width = 90;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.Width = 90;
            // 
            // iDфурнитурыDataGridViewTextBoxColumn
            // 
            this.iDфурнитурыDataGridViewTextBoxColumn.DataPropertyName = "ID_фурнитуры";
            this.iDфурнитурыDataGridViewTextBoxColumn.HeaderText = "ID_фурнитуры";
            this.iDфурнитурыDataGridViewTextBoxColumn.Name = "iDфурнитурыDataGridViewTextBoxColumn";
            // 
            // наименованиеDataGridViewTextBoxColumn1
            // 
            this.наименованиеDataGridViewTextBoxColumn1.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn1.Name = "наименованиеDataGridViewTextBoxColumn1";
            // 
            // типDataGridViewTextBoxColumn
            // 
            this.типDataGridViewTextBoxColumn.DataPropertyName = "Тип";
            this.типDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.типDataGridViewTextBoxColumn.Name = "типDataGridViewTextBoxColumn";
            // 
            // изображениеDataGridViewTextBoxColumn1
            // 
            this.изображениеDataGridViewTextBoxColumn1.DataPropertyName = "Изображение";
            this.изображениеDataGridViewTextBoxColumn1.HeaderText = "Изображение";
            this.изображениеDataGridViewTextBoxColumn1.Name = "изображениеDataGridViewTextBoxColumn1";
            this.изображениеDataGridViewTextBoxColumn1.Width = 80;
            // 
            // ширинаDataGridViewTextBoxColumn1
            // 
            this.ширинаDataGridViewTextBoxColumn1.DataPropertyName = "Ширина";
            this.ширинаDataGridViewTextBoxColumn1.HeaderText = "Ширина";
            this.ширинаDataGridViewTextBoxColumn1.Name = "ширинаDataGridViewTextBoxColumn1";
            // 
            // длиннаDataGridViewTextBoxColumn
            // 
            this.длиннаDataGridViewTextBoxColumn.DataPropertyName = "Длинна";
            this.длиннаDataGridViewTextBoxColumn.HeaderText = "Длинна";
            this.длиннаDataGridViewTextBoxColumn.Name = "длиннаDataGridViewTextBoxColumn";
            // 
            // весDataGridViewTextBoxColumn
            // 
            this.весDataGridViewTextBoxColumn.DataPropertyName = "Вес";
            this.весDataGridViewTextBoxColumn.HeaderText = "Вес";
            this.весDataGridViewTextBoxColumn.Name = "весDataGridViewTextBoxColumn";
            this.весDataGridViewTextBoxColumn.Width = 60;
            // 
            // ценаDataGridViewTextBoxColumn1
            // 
            this.ценаDataGridViewTextBoxColumn1.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn1.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn1.Name = "ценаDataGridViewTextBoxColumn1";
            this.ценаDataGridViewTextBoxColumn1.Width = 80;
            // 
            // Form_storekeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_storekeeper";
            this.Text = "Form_storekeeper";
            this.Load += new System.EventHandler(this.Form_storekeeper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Швейное_производство_v1_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тканиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фурнитураBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private _Швейное_производство_v1_1DataSet _Швейное_производство_v1_1DataSet;
        private System.Windows.Forms.BindingSource тканиBindingSource;
        private _Швейное_производство_v1_1DataSetTableAdapters.ТканиTableAdapter тканиTableAdapter;
        private System.Windows.Forms.BindingSource фурнитураBindingSource;
        private _Швейное_производство_v1_1DataSetTableAdapters.ФурнитураTableAdapter фурнитураTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDтканиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цветDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn составDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn изображениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ширинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn длинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDфурнитурыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn типDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn изображениеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ширинаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn длиннаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn весDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn1;
    }
}