using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDZ060901
{
	public partial class File_Viewer : Form
	{
		DirectoryInfo dirinfo;
		public File_Viewer()
		{
			InitializeComponent();

			var drive = DriveInfo.GetDrives();

			DirTree.Nodes.Clear();

			foreach (var el in drive)
			{
				DirTree.Nodes.Add(el.Name).Tag = el.RootDirectory;
			}

			Fill_nodes(DirTree.Nodes);

			ViewFile.View = View.Details;
		}

		private void Fill_nodes(TreeNodeCollection nodes)
		{
			foreach (TreeNode el in nodes)
			{
				try
				{
					var dirs = ((DirectoryInfo)el.Tag).GetDirectories();

					foreach (var dir in dirs)
					{
						el.Nodes.Add(dir.Name).Tag = dir;
					}
				}
				catch { }
			}
		}

		private void DirTree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{
			Fill_nodes(e.Node.Nodes);
		}

		private void DirTree_AfterSelect(object sender, TreeViewEventArgs e)
		{
			dirinfo = (DirectoryInfo)e.Node.Tag;
			var files = dirinfo.GetFiles();
			ViewFile.View = View.Details;

			ViewFile.Items.Clear();
			ViewFile.Columns.Clear();
			ViewFile.Columns.Add("Имя файла").Width = 200;
			ViewFile.Columns.Add("Размер").Width = 200;
			ViewFile.Columns.Add("Дата создания").Width = 200;
			
			foreach (FileInfo file in files)
			{
				var i = ViewFile.Items.Add(file.Name);
				i.SubItems.Add(file.Length.ToString());
				i.SubItems.Add(file.CreationTime.ToString());
			}
		}

		private void _Table_Click(object sender, EventArgs e)
		{
			ViewFile.View = View.Details;
			var files = dirinfo.GetFiles();
			ViewFile.View = View.Details;

			ViewFile.Items.Clear();
			ViewFile.Columns.Clear();
			ViewFile.Columns.Add("Имя файла").Width = 200;
			ViewFile.Columns.Add("Размер").Width = 200;
			ViewFile.Columns.Add("Дата создания").Width = 200;

			foreach (FileInfo file in files)
			{
				var i = ViewFile.Items.Add(file.Name);
				i.SubItems.Add(file.Length.ToString());
				i.SubItems.Add(file.CreationTime.ToString());
			}
		}

		private void _List_Click(object sender, EventArgs e)
		{
			var files = dirinfo.GetFiles();
			ViewFile.Items.Clear();
			ViewFile.Columns.Clear();
			ViewFile.View = View.List;

			foreach (FileInfo file in files)
			{
				ViewFile.Items.Add(file.Name);
			}
		}

		private void _Little_Click(object sender, EventArgs e)
		{
			var files = dirinfo.GetFiles();

			ViewFile.Items.Clear();
			ViewFile.Columns.Clear();

			ViewFile.View = View.SmallIcon;
			ImageList imageList = new ImageList();
			imageList.ImageSize = new Size(16, 16);
			
			foreach (var file in files)
			{
				if (file.Extension == ".jpg" || file.Extension == ".bmp" || file.Extension == ".jpeg")
					imageList.Images.Add(file.FullName, Image.FromFile(file.FullName));
				else
					imageList.Images.Add(file.FullName, Icon.ExtractAssociatedIcon(file.FullName));
			}

			ViewFile.SmallImageList = imageList;

			foreach (FileInfo file in files)
			{
				ViewFile.Items.Add(file.Name, imageList.Images.IndexOfKey(file.FullName));
			}
		}

		private void _Big_Click(object sender, EventArgs e)
		{
			var files = dirinfo.GetFiles();

			ViewFile.Items.Clear();
			ViewFile.Columns.Clear();

			ViewFile.View = View.LargeIcon;
			ImageList imageList = new ImageList();
			imageList.ImageSize = new Size(60, 60);

			foreach (var file in files)
			{
				if (file.Extension == ".jpg" || file.Extension == ".bmp" || file.Extension == ".jpeg")
					imageList.Images.Add(file.FullName, Image.FromFile(file.FullName));
				else
					imageList.Images.Add(file.FullName, Icon.ExtractAssociatedIcon(file.FullName));
			}

			ViewFile.LargeImageList = imageList;

			foreach (FileInfo file in files)
			{
					ViewFile.Items.Add(file.Name, imageList.Images.IndexOfKey(file.FullName));
			}
		}

		private void _Normal_Click(object sender, EventArgs e)
		{
			var files = dirinfo.GetFiles();

			ViewFile.Items.Clear();
			ViewFile.Columns.Clear();

			ViewFile.View = View.SmallIcon;
			ImageList imageList = new ImageList();
			imageList.ImageSize = new Size(30, 30);
			
			foreach (var file in files)
			{
				if (file.Extension == ".jpg" || file.Extension == ".bmp" || file.Extension == ".jpeg")
					imageList.Images.Add(file.FullName, Image.FromFile(file.FullName));
				else
					imageList.Images.Add(file.FullName, Icon.ExtractAssociatedIcon(file.FullName));
			}

			ViewFile.SmallImageList = imageList;

			foreach (FileInfo file in files)
			{
				ViewFile.Items.Add(file.Name, imageList.Images.IndexOfKey(file.FullName));
			}
		}
	}
}
