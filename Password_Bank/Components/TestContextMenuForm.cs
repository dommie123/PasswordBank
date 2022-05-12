using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Bank.Components
{
    // This code example demonstrates how to handle the Opening event.
    // It also demonstrates dynamic item addition and dynamic 
    // SourceControl determination with reuse.
    partial class TestContextMenuForm : Form
    {
        // Declare the ContextMenuStrip control.
        private ContextMenuStrip fruitContextMenuStrip;

        public TestContextMenuForm()
        {
            // Create a new ContextMenuStrip control.
            fruitContextMenuStrip = new ContextMenuStrip();

            // Attach an event handler for the 
            // ContextMenuStrip control's Opening event.
            fruitContextMenuStrip.Opening += new CancelEventHandler(cms_Opening);

            // Create a new ToolStrip control.
            ToolStrip ts = new ToolStrip();

            // Create a ToolStripDropDownButton control and add it
            // to the ToolStrip control's Items collections.
            ToolStripDropDownButton fruitToolStripDropDownButton = new ToolStripDropDownButton("Fruit", null, null, "Fruit");
            ts.Items.Add(fruitToolStripDropDownButton);

            // Dock the ToolStrip control to the top of the form.
            ts.Dock = DockStyle.Top;

            // Assign the ContextMenuStrip control as the 
            // ToolStripDropDownButton control's DropDown menu.
            fruitToolStripDropDownButton.DropDown = fruitContextMenuStrip;

            // Create a new MenuStrip control and add a ToolStripMenuItem.
            MenuStrip ms = new MenuStrip();
            ToolStripMenuItem fruitToolStripMenuItem = new ToolStripMenuItem("Fruit", null, null, "Fruit");
            ms.Items.Add(fruitToolStripMenuItem);

            // Dock the MenuStrip control to the top of the form.
            ms.Dock = DockStyle.Top;

            // Assign the MenuStrip control as the 
            // ToolStripMenuItem's DropDown menu.
            fruitToolStripMenuItem.DropDown = fruitContextMenuStrip;

            // Assign the ContextMenuStrip to the form's 
            // ContextMenuStrip property.
            this.ContextMenuStrip = fruitContextMenuStrip;

            // Add the ToolStrip control to the Controls collection.
            this.Controls.Add(ts);

            //Add a button to the form and assign its ContextMenuStrip.
            Button b = new Button();
            b.Location = new Point(60, 60);
            this.Controls.Add(b);
            b.ContextMenuStrip = fruitContextMenuStrip;

            // Add the MenuStrip control last.
            // This is important for correct placement in the z-order.
            this.Controls.Add(ms);
        }

        // This event handler is invoked when the ContextMenuStrip
        // control's Opening event is raised. It demonstrates
        // dynamic item addition and dynamic SourceControl 
        // determination with reuse.
        void cms_Opening(object sender, CancelEventArgs e)
        {
            // Acquire references to the owning control and item.
            Control c = fruitContextMenuStrip.SourceControl as Control;
            ToolStripDropDownItem tsi = fruitContextMenuStrip.OwnerItem as ToolStripDropDownItem;

            // Clear the ContextMenuStrip control's Items collection.
            fruitContextMenuStrip.Items.Clear();

            // Check the source control first.
            if (c != null)
            {
                // Add custom item (Form)
                fruitContextMenuStrip.Items.Add("Source: " + c.GetType().ToString());
            }
            else if (tsi != null)
            {
                // Add custom item (ToolStripDropDownButton or ToolStripMenuItem)
                fruitContextMenuStrip.Items.Add("Source: " + tsi.GetType().ToString());
            }

            // Populate the ContextMenuStrip control with its default items.
            fruitContextMenuStrip.Items.Add("-");
            fruitContextMenuStrip.Items.Add("Apples");
            fruitContextMenuStrip.Items.Add("Oranges");
            fruitContextMenuStrip.Items.Add("Pears");

            // Set Cancel to false. 
            // It is optimized to true based on empty entry.
            e.Cancel = false;
        }
    }
}
