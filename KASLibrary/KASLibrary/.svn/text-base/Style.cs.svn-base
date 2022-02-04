using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;     

namespace KASLibrary
{
    [Serializable] 
    public class Style
    {
        private Color formBackColor;
        private Color formForeColor;
        private Color buttonBackColor;
        private Color buttonForeColor;
        private Color disabledButtonBackColor;
        private Color disabledButtonForeColor;
        private Color focusedButtonBackColor;
        private Color focusedButtonForeColor;
        private Color gridControlExForeColor;
        private Color gridControlExBackColor;
        private Color dialogBackColor;
        private Color dialogForeColor;
        private Color container1Color;
        private Color container2Color;
        private Color container3Color;
        private Color container4Color;
        private BorderStyle textBoxBorderStyle;
        private FlatStyle checkBoxFlatStyle;
        private FlatStyle comboBoxFlatStyle;
        private FlatStyle buttonFlatStyle;
        private BorderStyle listBoxBorderStyle;

        public Style()
        {
            formBackColor = Color.AliceBlue;
            formForeColor = Color.Blue;
            buttonForeColor = Color.Brown;
            buttonBackColor = Color.SandyBrown;
            disabledButtonForeColor = Color.DarkGray;
            disabledButtonBackColor = Color.LightGray;
            focusedButtonForeColor = Color.DarkGreen;
            focusedButtonBackColor = Color.LightGreen;
            gridControlExForeColor = Color.Black;
            gridControlExBackColor = Color.White;
            dialogBackColor = Color.Yellow;
            dialogForeColor = Color.Green;
            container1Color = Color.Cornsilk;
            container2Color = Color.Crimson;
            container3Color = Color.Cyan;
            container4Color = Color.DarkGreen;
            textBoxBorderStyle = BorderStyle.FixedSingle;
            checkBoxFlatStyle = FlatStyle.Flat;
            comboBoxFlatStyle = FlatStyle.Flat;
            buttonFlatStyle = FlatStyle.Flat;
            listBoxBorderStyle = BorderStyle.FixedSingle;  
        }
        
        public Color FormBackColor
        {
            get { return formBackColor; }
            set { formBackColor = value; }
        }

        public Color FormForeColor
        {
            get { return formForeColor; }
            set { formForeColor = value; }
        }

        public Color ButtonBackColor
        {
            get { return buttonBackColor; }
            set { buttonBackColor = value; }
        }

        public Color ButtonForeColor
        {
            get { return buttonForeColor; }
            set { buttonForeColor = value; }
        }

        public Color DisabledButtonBackColor
        {
            get { return disabledButtonBackColor; }
            set { disabledButtonBackColor = value; }
        }

        public Color DisabledButtonForeColor
        {
            get { return disabledButtonForeColor; }
            set { disabledButtonForeColor = value; }
        }

        public Color FocusedButtonBackColor
        {
            get { return focusedButtonBackColor; }
            set { focusedButtonBackColor = value; }
        }

        public Color FocusedButtonForeColor
        {
            get { return focusedButtonForeColor; }
            set { focusedButtonForeColor = value; }
        }

        public Color GridControlExBackColor
        {
            get { return gridControlExBackColor; }
            set { gridControlExBackColor = value; }
        }

        public Color GridControlExForeColor
        {
            get { return gridControlExForeColor; }
            set { gridControlExForeColor = value; }
        }

        public Color DialogBackColor
        {
            get { return dialogBackColor; }
            set { dialogBackColor = value; }
        }

        public Color DialogForeColor
        {
            get { return dialogForeColor; }
            set { dialogForeColor = value; }
        }

        public Color Container1Color
        {
            get { return container1Color; }
            set { container1Color = value; }
        }

        public Color Container2Color
        {
            get { return container2Color; }
            set { container2Color = value; }
        }
        
        public Color Container3Color
        {
            get { return container3Color; }
            set { container3Color = value; }
        }
        
        public Color Container4Color
        {
            get { return container4Color; }
            set { container4Color = value; }
        }

        public BorderStyle TextBoxBorderStyle
        {
            get { return textBoxBorderStyle; }
            set { textBoxBorderStyle = value; }
        }

        public FlatStyle CheckBoxFlatStyle
        {
            get { return checkBoxFlatStyle; }
            set { checkBoxFlatStyle = value; }
        }

        public FlatStyle ComboBoxFlatStyle
        {
            get { return comboBoxFlatStyle; }
            set { comboBoxFlatStyle = value; }
        }

        public FlatStyle ButtonFlatStyle
        {
            get { return buttonFlatStyle; }
            set { buttonFlatStyle = value; }
        }

        public BorderStyle ListBoxBorderStyle
        {
            get { return listBoxBorderStyle; }
            set { listBoxBorderStyle = value; }
        }

        public void Apply(Form form)
        {
            form.Paint -= new PaintEventHandler(form_Paint);
            form.Paint += new PaintEventHandler(form_Paint);
            if (form is FrmDialog)
                form.BackColor = dialogBackColor;
            else
                form.BackColor = formBackColor;
            ApplyControls(form,form.Controls);
        }

        private void ApplyControls(Form form,Control.ControlCollection collection)
        {
            foreach (Control control in collection)
            {
                if (control is Panel)
                {
                    ApplyControls(form,control.Controls);  
                }
                if (control is Label)
                {
                    Label label = (Label)control;
                    if (label.AutoSize)
                    {
                        if (form is FrmDialog)
                            label.ForeColor = dialogForeColor;
                        else
                            label.ForeColor = formForeColor;
                    }
                    else
                    {       
                        //Special Label -- No Style Applied
                        //AutoSize = false && Text != ""
                    }
                }
                if (control is Panel)
                {
                    //Apply Based on name ended with number 1-3
                    if (control.Name.EndsWith("1")) control.BackColor = container1Color;
                    if (control.Name.EndsWith("2")) control.BackColor = container2Color;
                    if (control.Name.EndsWith("3")) control.BackColor = container3Color;
                    if (control.Name.EndsWith("4")) control.BackColor = container4Color;
                }
                if (control is Button)
                {
                    Button button = (Button)control; 
                    if (button.Enabled)
                    {
                        button.BackColor = buttonBackColor;
                        button.ForeColor = buttonForeColor;
                    }
                    else
                    {
                        button.BackColor = disabledButtonBackColor;
                        button.ForeColor = disabledButtonForeColor;
                    }
                    button.FlatStyle = buttonFlatStyle;
                    button.MouseEnter -= new EventHandler(button_MouseEnter);
                    button.MouseLeave -= new EventHandler(button_MouseLeave);
                    button.MouseEnter += new EventHandler(button_MouseEnter);
                    button.MouseLeave += new EventHandler(button_MouseLeave);
                }
                if (control is GridControlEx)
                {
                    control.BackColor = gridControlExBackColor;
                    foreach (Control ctrl in control.Controls)
                    {
                        if (ctrl is Label) ctrl.ForeColor = gridControlExForeColor;
                    }
                }
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.BorderStyle = textBoxBorderStyle; 
                }
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.FlatStyle = checkBoxFlatStyle;  
                }
                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.FlatStyle = comboBoxFlatStyle;
                    if (comboBoxFlatStyle == FlatStyle.Flat)
                    {
                         //Add border  
                    }
                }
                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.BorderStyle = listBoxBorderStyle;  
                }
            }
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled)
            {
                button.BackColor = focusedButtonBackColor;
                button.ForeColor = focusedButtonForeColor;
            }
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled)
            {
                button.BackColor = buttonBackColor;
                button.ForeColor = buttonForeColor;
            }
            else
            {
                button.BackColor = disabledButtonBackColor;
                button.ForeColor = disabledButtonForeColor;
            }
        }

        private void form_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Form form = (Form)sender;
            foreach (Control control in form.Controls)
            {
                if (control is ComboBox && comboBoxFlatStyle == FlatStyle.Flat)
                {
                    g.DrawRectangle(Pens.Black, control.Bounds.Left-1,control.Bounds.Top-1,
                        control.Bounds.Width+1,control.Bounds.Height+1);   
                }
            }
        }

        public static void Save(Style style,string filename)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, style);
            stream.Close();
        }

        public static Style Load(string filename)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None);
            Style style = (Style)formatter.Deserialize(stream);
            stream.Close();
            return style; 
        }
    }
}
