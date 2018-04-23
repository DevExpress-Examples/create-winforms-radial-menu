using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;

namespace CreateRadialMenu {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            // Create and display Radial Menu
            barManager1.ItemClick += new ItemClickEventHandler(barManager1_ItemClick);
            RadialMenu menu = new RadialMenu();
            menu.Manager = barManager1;
            menu.AddItems(CreateBarItems());

            Point pt = this.Location;
            pt.Offset(this.Width / 2, this.Height / 2);
            menu.ShowPopup(pt);
        }

        BarItem[] CreateBarItems() {
            // Create bar items to display in Radial Menu
            barManager1.Images = imageCollection1;

            BarItem barButtonItem0 = new BarButtonItem(barManager1, "Copy", 0);
            BarItem barButtonItem1 = new BarButtonItem(barManager1, "Cut", 1);
            BarItem barButtonItem2 = new BarButtonItem(barManager1, "Delete", 2);
            BarItem barButtonItem3 = new BarButtonItem(barManager1, "Paste", 3);

            // Sub-menu with 3 check buttons
            BarSubItem subMenu = new BarSubItem(barManager1, "Format");
            BarCheckItem barCheckItem4 = new BarCheckItem(barManager1, false) {
                ImageIndex = 4,
                Caption = "Bold"
            };
            BarCheckItem barCheckItem5 = new BarCheckItem(barManager1, true) {
                ImageIndex = 5,
                Caption = "Italic"
            };
            BarCheckItem barCheckItem6 = new BarCheckItem(barManager1, false) {
                ImageIndex = 6,
                Caption = "Underline"
            };
            BarItem[] subMenuItems = new BarItem[] { barCheckItem4, barCheckItem5, barCheckItem6 };
            subMenu.AddItems(subMenuItems);

            BarItem barButtonItem7 = new BarButtonItem(barManager1, "Find", 7);
            BarItem barButtonItem8 = new BarButtonItem(barManager1, "Undo", 8);
            BarItem barButtonItem9 = new BarButtonItem(barManager1, "Redo", 9);

            return new BarItem[] {barButtonItem0, barButtonItem1, barButtonItem2, barButtonItem3, 
                subMenu, barButtonItem7, barButtonItem8, barButtonItem9};
        }

        

        void barManager1_ItemClick(object sender, ItemClickEventArgs e) {
            //...
        }
    }
}
