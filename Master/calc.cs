using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
/***************************************************************************************
 * Author : Eng.Ahmed Mahmoud Mousa 
 * Date    : 2/9/2002
 * Feature : Basic Calculator to show you 
 *					  1) how you can use Events, properties
 *					  2) how you can use ArrayList
 *					  3) how you can use typeCasting
 *					  4) how you can make basic function(void Function)
 *					  5) how to use for Loop
 *					  6) working with string class 
 *					  7) using Exception
 *					  8) operator overloading like *=,+=,/=,-=
 * Discreption : in Basic Calculator program we have some Declaretion
 *					  1) if Prefix of variable start with bttn this is BUTTON
 *					  2) if Prefix of variable start with lb this is	  LABEL
 *					  3) if Prefix of variable start with m_	this is member variable
 *			for Example bttnD5   -> button Digit 5
 *							  lbRes      -> label result
 *							  m_Value  -> member variable naming value
 *			We have 
 *			- 10 buttons digit (bttnD0->9)
 *			- 5 buttons operator (bttnPlus,bttnMinus,bttnMul,bttnDiv,bttnEqul)
 *			- 1 dot button bttnDot and  1 clear button bttnClr.
 *			- 1 labels for display display result (mlbRes)   
 *			- m_value this to store data on it 
 *			- m_store this arraylist to store all string in lbRes 
 *			
 *			We make 4 void function
 *			
 *			1) void AddToArray(Button bttn)					
 *			this function to display Digit on lbRes and save this digit on m_value
 *			
 *			2) void AddOperatorToArray(Button bttn)		
 *			this function to add m_value in m_Store then add operator to m_Store
 *			
 *			3) void Reset() 
 *			this is to clear lbRes,m_value and m_Store
 * 
 *			4) void SetEnableOperatorBttns(bool enable)
 *			this make all operator are enable or not  
 ******************************************************************************************/
namespace Calculator
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class calc : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button bttnD4;
		private System.Windows.Forms.Button bttnD7;
		private System.Windows.Forms.Button bttnD8;
		private System.Windows.Forms.Button bttnD9;
		private System.Windows.Forms.Button bttnD1;
		private System.Windows.Forms.Button bttnD2;
		private System.Windows.Forms.Button bttnD3;
		private System.Windows.Forms.Button bttnD5;
		private System.Windows.Forms.Button bttnD6;
		private System.Windows.Forms.Button bttnD0;
		private System.Windows.Forms.Button bttnDiv;
		private System.Windows.Forms.Button bttnMul;
		private System.Windows.Forms.Button bttnMinus;
		private System.Windows.Forms.Button bttnPlus;
		private System.Windows.Forms.Button bttnClr;
		private System.Windows.Forms.Button bttnDot;
		private System.Windows.Forms.Button bttnEqual;
		private string		m_value;
		private ArrayList m_store;
		private System.Windows.Forms.Label lbRes;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public calc()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			m_value		=		""								;
			m_store		=		new ArrayList()			;
		}
		private void AddOperatorToArray(Button bttn)
		{
			m_store.Add( m_value )				;
			lbRes.Text				+= bttn.Text	;
			m_value					= ""				;
			m_store.Add( bttn.Text )			;
			bttnDot.Enabled		= true			;
			SetEnableOperatorBttns(false)		;
		}
		private void AddToArray(Button bttn)
		{
			m_value		 += bttn.Text			;
			lbRes.Text  += bttn.Text			;
			SetEnableOperatorBttns(true)	;
		}

		private void Reset()
		{
			m_value			 =	""				;
			lbRes.Text		 = ""				;
			m_store.Clear()					;
			bttnDot.Enabled = true		;
		}
		
		private void SetEnableOperatorBttns(bool enable)
		{
			bttnPlus.Enabled	= enable	;
			bttnMinus.Enabled	= enable	;
			bttnMul.Enabled		= enable	;
			bttnDiv.Enabled		= enable	;
			bttnEqual.Enabled	= enable	;
		}
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.bttnD1 = new System.Windows.Forms.Button();
			this.bttnD2 = new System.Windows.Forms.Button();
			this.bttnD3 = new System.Windows.Forms.Button();
			this.bttnD4 = new System.Windows.Forms.Button();
			this.bttnD5 = new System.Windows.Forms.Button();
			this.bttnD6 = new System.Windows.Forms.Button();
			this.bttnD7 = new System.Windows.Forms.Button();
			this.bttnD8 = new System.Windows.Forms.Button();
			this.bttnD9 = new System.Windows.Forms.Button();
			this.bttnD0 = new System.Windows.Forms.Button();
			this.bttnDiv = new System.Windows.Forms.Button();
			this.bttnMul = new System.Windows.Forms.Button();
			this.bttnMinus = new System.Windows.Forms.Button();
			this.bttnPlus = new System.Windows.Forms.Button();
			this.bttnClr = new System.Windows.Forms.Button();
			this.bttnDot = new System.Windows.Forms.Button();
			this.bttnEqual = new System.Windows.Forms.Button();
			this.lbRes = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// bttnD1
			// 
			this.bttnD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnD1.Location = new System.Drawing.Point(32, 184);
			this.bttnD1.Name = "bttnD1";
			this.bttnD1.Size = new System.Drawing.Size(48, 32);
			this.bttnD1.TabIndex = 1;
			this.bttnD1.Text = "1";
			this.bttnD1.Click += new System.EventHandler(this.bttnD1_Click);
			// 
			// bttnD2
			// 
			this.bttnD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnD2.Location = new System.Drawing.Point(88, 184);
			this.bttnD2.Name = "bttnD2";
			this.bttnD2.Size = new System.Drawing.Size(48, 32);
			this.bttnD2.TabIndex = 2;
			this.bttnD2.Text = "2";
			this.bttnD2.Click += new System.EventHandler(this.bttnD2_Click);
			// 
			// bttnD3
			// 
			this.bttnD3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnD3.Location = new System.Drawing.Point(144, 184);
			this.bttnD3.Name = "bttnD3";
			this.bttnD3.Size = new System.Drawing.Size(48, 32);
			this.bttnD3.TabIndex = 3;
			this.bttnD3.Text = "3";
			this.bttnD3.Click += new System.EventHandler(this.bttnD3_Click);
			// 
			// bttnD4
			// 
			this.bttnD4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnD4.Location = new System.Drawing.Point(32, 144);
			this.bttnD4.Name = "bttnD4";
			this.bttnD4.Size = new System.Drawing.Size(48, 32);
			this.bttnD4.TabIndex = 4;
			this.bttnD4.Text = "4";
			this.bttnD4.Click += new System.EventHandler(this.bttnD4_Click);
			// 
			// bttnD5
			// 
			this.bttnD5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnD5.Location = new System.Drawing.Point(88, 144);
			this.bttnD5.Name = "bttnD5";
			this.bttnD5.Size = new System.Drawing.Size(48, 32);
			this.bttnD5.TabIndex = 5;
			this.bttnD5.Text = "5";
			this.bttnD5.Click += new System.EventHandler(this.bttnD5_Click);
			// 
			// bttnD6
			// 
			this.bttnD6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnD6.Location = new System.Drawing.Point(144, 144);
			this.bttnD6.Name = "bttnD6";
			this.bttnD6.Size = new System.Drawing.Size(48, 32);
			this.bttnD6.TabIndex = 6;
			this.bttnD6.Text = "6";
			this.bttnD6.Click += new System.EventHandler(this.bttnD6_Click);
			// 
			// bttnD7
			// 
			this.bttnD7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnD7.Location = new System.Drawing.Point(32, 104);
			this.bttnD7.Name = "bttnD7";
			this.bttnD7.Size = new System.Drawing.Size(48, 32);
			this.bttnD7.TabIndex = 7;
			this.bttnD7.Text = "7";
			this.bttnD7.Click += new System.EventHandler(this.bttnD7_Click);
			// 
			// bttnD8
			// 
			this.bttnD8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnD8.Location = new System.Drawing.Point(88, 104);
			this.bttnD8.Name = "bttnD8";
			this.bttnD8.Size = new System.Drawing.Size(48, 32);
			this.bttnD8.TabIndex = 8;
			this.bttnD8.Text = "8";
			this.bttnD8.Click += new System.EventHandler(this.bttnD8_Click);
			// 
			// bttnD9
			// 
			this.bttnD9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnD9.Location = new System.Drawing.Point(144, 104);
			this.bttnD9.Name = "bttnD9";
			this.bttnD9.Size = new System.Drawing.Size(48, 32);
			this.bttnD9.TabIndex = 9;
			this.bttnD9.Text = "9";
			this.bttnD9.Click += new System.EventHandler(this.bttnD9_Click);
			// 
			// bttnD0
			// 
			this.bttnD0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnD0.Location = new System.Drawing.Point(32, 224);
			this.bttnD0.Name = "bttnD0";
			this.bttnD0.Size = new System.Drawing.Size(48, 32);
			this.bttnD0.TabIndex = 10;
			this.bttnD0.Text = "0";
			this.bttnD0.Click += new System.EventHandler(this.bttnD0_Click);
			// 
			// bttnDiv
			// 
			this.bttnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnDiv.Location = new System.Drawing.Point(216, 176);
			this.bttnDiv.Name = "bttnDiv";
			this.bttnDiv.Size = new System.Drawing.Size(48, 24);
			this.bttnDiv.TabIndex = 11;
			this.bttnDiv.Text = "/";
			this.bttnDiv.Click += new System.EventHandler(this.bttnDiv_Click);
			// 
			// bttnMul
			// 
			this.bttnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnMul.Location = new System.Drawing.Point(216, 152);
			this.bttnMul.Name = "bttnMul";
			this.bttnMul.Size = new System.Drawing.Size(48, 24);
			this.bttnMul.TabIndex = 12;
			this.bttnMul.Text = "*";
			this.bttnMul.Click += new System.EventHandler(this.bttnMul_Click);
			// 
			// bttnMinus
			// 
			this.bttnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnMinus.Location = new System.Drawing.Point(216, 128);
			this.bttnMinus.Name = "bttnMinus";
			this.bttnMinus.Size = new System.Drawing.Size(48, 24);
			this.bttnMinus.TabIndex = 13;
			this.bttnMinus.Text = "-";
			this.bttnMinus.Click += new System.EventHandler(this.bttnMinus_Click);
			// 
			// bttnPlus
			// 
			this.bttnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnPlus.Location = new System.Drawing.Point(216, 104);
			this.bttnPlus.Name = "bttnPlus";
			this.bttnPlus.Size = new System.Drawing.Size(48, 24);
			this.bttnPlus.TabIndex = 14;
			this.bttnPlus.Text = "+";
			this.bttnPlus.Click += new System.EventHandler(this.bttnPlus_Click);
			// 
			// bttnClr
			// 
			this.bttnClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnClr.Location = new System.Drawing.Point(144, 224);
			this.bttnClr.Name = "bttnClr";
			this.bttnClr.Size = new System.Drawing.Size(48, 32);
			this.bttnClr.TabIndex = 15;
			this.bttnClr.Text = "clr";
			this.bttnClr.Click += new System.EventHandler(this.bttnClr_Click);
			// 
			// bttnDot
			// 
			this.bttnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnDot.Location = new System.Drawing.Point(88, 224);
			this.bttnDot.Name = "bttnDot";
			this.bttnDot.Size = new System.Drawing.Size(48, 32);
			this.bttnDot.TabIndex = 16;
			this.bttnDot.Text = ".";
			this.bttnDot.Click += new System.EventHandler(this.bttnDot_Click);
			// 
			// bttnEqual
			// 
			this.bttnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.bttnEqual.Location = new System.Drawing.Point(216, 200);
			this.bttnEqual.Name = "bttnEqual";
			this.bttnEqual.Size = new System.Drawing.Size(48, 24);
			this.bttnEqual.TabIndex = 17;
			this.bttnEqual.Text = "=";
			this.bttnEqual.Click += new System.EventHandler(this.bttnEqual_Click);
			// 
			// lbRes
			// 
			this.lbRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbRes.Location = new System.Drawing.Point(32, 40);
			this.lbRes.Name = "lbRes";
			this.lbRes.Size = new System.Drawing.Size(232, 32);
			this.lbRes.TabIndex = 18;
			this.lbRes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 294);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.lbRes,
																		  this.bttnEqual,
																		  this.bttnDot,
																		  this.bttnClr,
																		  this.bttnPlus,
																		  this.bttnMinus,
																		  this.bttnMul,
																		  this.bttnDiv,
																		  this.bttnD0,
																		  this.bttnD9,
																		  this.bttnD8,
																		  this.bttnD7,
																		  this.bttnD6,
																		  this.bttnD5,
																		  this.bttnD4,
																		  this.bttnD3,
																		  this.bttnD2,
																		  this.bttnD1});
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Basic Calculator";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new calc());
		}

		private void bttnD0_Click(object sender, System.EventArgs e)
		{
			AddToArray(bttnD0);	
		}

		private void bttnD1_Click(object sender, System.EventArgs e)
		{
            AddToArray(bttnD1);	
		}

		private void bttnD2_Click(object sender, System.EventArgs e)
		{
			AddToArray(bttnD2);	
		}

		private void bttnD3_Click(object sender, System.EventArgs e)
		{
			AddToArray(bttnD3);	
		}

		private void bttnD4_Click(object sender, System.EventArgs e)
		{
			AddToArray(bttnD4);	
		}

		private void bttnD5_Click(object sender, System.EventArgs e)
		{
			AddToArray(bttnD5);	
		}

		private void bttnD6_Click(object sender, System.EventArgs e)
		{
			AddToArray(bttnD6);	
		}

		private void bttnD7_Click(object sender, System.EventArgs e)
		{
			AddToArray(bttnD7);	
		}

		private void bttnD8_Click(object sender, System.EventArgs e)
		{
			AddToArray(bttnD8);	
		}

		private void bttnD9_Click(object sender, System.EventArgs e)
		{
			AddToArray(bttnD9);	
		}

		private void bttnDiv_Click(object sender, System.EventArgs e)
		{
			AddOperatorToArray(bttnDiv);
		}

		private void bttnMul_Click(object sender, System.EventArgs e)
		{
			AddOperatorToArray(bttnMul);
		}

		private void bttnMinus_Click(object sender, System.EventArgs e)
		{
			AddOperatorToArray(bttnMinus);
		}

		private void bttnPlus_Click(object sender, System.EventArgs e)
		{
			AddOperatorToArray(bttnPlus);
		}

		private void bttnDot_Click(object sender, System.EventArgs e)
		{
			AddToArray(bttnDot)			;
			bttnDot.Enabled = false		;
		}

		private void bttnClr_Click(object sender, System.EventArgs e)
		{
			Reset();
		}

		private void bttnEqual_Click(object sender, System.EventArgs e)
		{
			try
			{
				m_store.Add(m_value)					;
				m_store.Add( bttnEqual.Text )		;
	
				/* m_res here take the first element in m_store if this element is 
				 * operator like +*-/ Exception give us Error else it will take the
				 *  Digits or dot point 
				 */
				float m_res = float.Parse ( m_store[0].ToString() ) ;
				
				/* this loop extract all element in Array then check it 
				 * if the element is operator it will calculate the prefix 
				 * and postfix and give us the result 
				 * Example 1+2/3*5 
				 * 1) 1+2 = 3
				 * 2) 3/3 = 1
				 * 3) 1*5  = 5
				 * note:- no periority operator and no brakets so it's basic calculator:)
				 */
				for( int i = 0 ;  i<m_store.Count ; i++ )
				{
				
					if( m_store[i].ToString() == "+" )
					{
						lbRes.Text						=				""				;
						m_res += float.Parse (m_store[i+1].ToString())	;
						lbRes.Text = m_res.ToString()							;		
					}
					else if( m_store[i].ToString() == "-" )
					{
						lbRes.Text						=				""				;
						m_res -= float.Parse (m_store[i+1].ToString())	;
						lbRes.Text						= m_res.ToString()		;		
					}
					else if( m_store[i].ToString() == "*" )
					{
						lbRes.Text						=				""				;
						m_res *= float.Parse ( m_store[i+1].ToString() )	;
						lbRes.Text						= m_res.ToString()		;		
					}
					else if( m_store[i].ToString() == "/" )
					{
						lbRes.Text						=				""				;
						m_res /= float.Parse ( m_store[i+1].ToString() );
						lbRes.Text						= m_res.ToString()		;		
					}
				
					
				}
				m_store.Clear()														;
				m_value = lbRes.Text												;

				for( int i = 0 ; i < m_value.Length ; i++ )
				{
					if( m_value[i].ToString() == "." )
					{
						bttnDot.Enabled = false									;
						break															;
					}
					else
					{
						bttnDot.Enabled = true									;
					}
				}
				
				bttnEqual.Enabled = false										;
			}
			catch(Exception exception)
			{
				MessageBox.Show(exception.Message,"Error")			;
			}
		}

		

		
	}
}
