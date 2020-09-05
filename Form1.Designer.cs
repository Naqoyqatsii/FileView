namespace WindowsDZ060901
{
	partial class File_Viewer
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
			this.DirTree = new System.Windows.Forms.TreeView();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this._Root = new System.Windows.Forms.ToolStripMenuItem();
			this._Table = new System.Windows.Forms.ToolStripMenuItem();
			this._List = new System.Windows.Forms.ToolStripMenuItem();
			this._Little = new System.Windows.Forms.ToolStripMenuItem();
			this._Normal = new System.Windows.Forms.ToolStripMenuItem();
			this._Big = new System.Windows.Forms.ToolStripMenuItem();
			this.ViewFile = new System.Windows.Forms.ListView();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// DirTree
			// 
			this.DirTree.Dock = System.Windows.Forms.DockStyle.Left;
			this.DirTree.Location = new System.Drawing.Point(0, 31);
			this.DirTree.Name = "DirTree";
			this.DirTree.Size = new System.Drawing.Size(369, 683);
			this.DirTree.TabIndex = 0;
			this.DirTree.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.DirTree_BeforeExpand);
			this.DirTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DirTree_AfterSelect);
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._Root});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1244, 31);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// _Root
			// 
			this._Root.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._Table,
            this._List,
            this._Little,
            this._Normal,
            this._Big});
			this._Root.Name = "_Root";
			this._Root.Size = new System.Drawing.Size(55, 27);
			this._Root.Text = "Вид";
			// 
			// _Table
			// 
			this._Table.Name = "_Table";
			this._Table.Size = new System.Drawing.Size(266, 30);
			this._Table.Text = "Таблица";
			this._Table.Click += new System.EventHandler(this._Table_Click);
			// 
			// _List
			// 
			this._List.Name = "_List";
			this._List.Size = new System.Drawing.Size(266, 30);
			this._List.Text = "Список";
			this._List.Click += new System.EventHandler(this._List_Click);
			// 
			// _Little
			// 
			this._Little.Name = "_Little";
			this._Little.Size = new System.Drawing.Size(266, 30);
			this._Little.Text = "Мелкие значки";
			this._Little.Click += new System.EventHandler(this._Little_Click);
			// 
			// _Normal
			// 
			this._Normal.Name = "_Normal";
			this._Normal.Size = new System.Drawing.Size(266, 30);
			this._Normal.Text = "Нормальные значки";
			this._Normal.Click += new System.EventHandler(this._Normal_Click);
			// 
			// _Big
			// 
			this._Big.Name = "_Big";
			this._Big.Size = new System.Drawing.Size(266, 30);
			this._Big.Text = "Крупные значки";
			this._Big.Click += new System.EventHandler(this._Big_Click);
			// 
			// ViewFile
			// 
			this.ViewFile.Dock = System.Windows.Forms.DockStyle.Right;
			this.ViewFile.HideSelection = false;
			this.ViewFile.Location = new System.Drawing.Point(375, 31);
			this.ViewFile.Name = "ViewFile";
			this.ViewFile.Size = new System.Drawing.Size(869, 683);
			this.ViewFile.TabIndex = 3;
			this.ViewFile.UseCompatibleStateImageBehavior = false;
			this.ViewFile.View = System.Windows.Forms.View.Details;
			// 
			// File_Viewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1244, 714);
			this.Controls.Add(this.ViewFile);
			this.Controls.Add(this.DirTree);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "File_Viewer";
			this.Text = "Обзор файлов";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView DirTree;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem _Root;
		private System.Windows.Forms.ListView ViewFile;
		private System.Windows.Forms.ToolStripMenuItem _Table;
		private System.Windows.Forms.ToolStripMenuItem _List;
		private System.Windows.Forms.ToolStripMenuItem _Little;
		private System.Windows.Forms.ToolStripMenuItem _Normal;
		private System.Windows.Forms.ToolStripMenuItem _Big;
	}
}

