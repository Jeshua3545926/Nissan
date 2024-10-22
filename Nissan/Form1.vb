Public Class Form1

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
	ComboBox1.Items.Clear()  
		ComboBox1.Items.AddRange(New String() {
									"nissan Skyline GTR4 $4000",
									"nissan Shyline GTR5 $5000",
									"nissan Corolla 2005 $7340",
									"nissan March 2010 $10256"
									})
	'Panel1.BackColor = Color.FromArgb(100,0,0,0)'

	End Sub
Public sub Conditon()

Dim billete As Integer   = TextBox3.Text 
If  billete <= 4000 Then 
	Dim BilleteMenor As String = MessageBox.Show("Su billete es menor del total Desea volver a ingresar su billete", "advertencia",	MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
		If BilleteMenor = DialogResult.Yes Then
			MsgBox(Funcion())
		Else
			MsgBox("Operacion /404 cancelada")

		End If
	Else	
		MsgBox(F())
	End If
End sub
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim Result As String = MessageBox.Show("Desea salir del Programa?", "advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
		If Result = DialogResult.Yes Then
			Application.Exit()
		Else
			MsgBox("Operacion /404 cancelada")
		End If
	End Sub
	Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
		Dim g As Graphics = e.Graphics
		Dim pen As New Pen(Color.Black, 2)
		g.DrawLine(pen, TextBox1.Left, TextBox1.Bottom, TextBox1.Right, TextBox1.Bottom)
		g.DrawLine(pen, TextBox2.Left, TextBox2.Bottom, TextBox2.Right, TextBox2.Bottom)
		g.DrawLine(pen, TextBox3.Left, TextBox3.Bottom, TextBox3.Right, TextBox3.Bottom)
	End Sub
	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

		If ComboBox1.SelectedItem Is Nothing Then
			MsgBox("Por favor seleccione un producto.")
			Return
		End If
		Dim Product As String = ComboBox1.SelectedItem.ToString
		Dim Nombre As String = TextBox1.Text
		Dim cantidad As Integer = TextBox2.Text
		Dim array() As String = {"Su cantidad es"}
		    MsgBox(array(0) &cantidad)
If ComboBox1.SelectedItem = "nissan Shyline GTR5 $5000" then
			Dim operacion As Integer = cantidad * 2321 
			Dim Arrays() As String = {"su total es de"}
			Dim billete As Integer = TextBox3.Text 
			MsgBox(Arrays(0) & operacion)
			If  billete <= 4000 Then 
				Dim BilleteMenor As String = MessageBox.Show("Su billete es menor del total Desea volver a ingresar su billete", "advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
					If BilleteMenor = DialogResult.Yes Then
						MsgBox(Funcion())
					Else
						MsgBox("Operacion /404 cancelada")
				End If
			Else	
				MsgBox("pago existoso")
		End If
	End If 
If ComboBox1.SelectedItem = "nissan Shyline GTR4 $4000" then
			Dim operacion As Integer = cantidad * 2002
			Dim Arrays() As String = {"su total es de"}
			Dim billete As Integer = TextBox3.Text 
			MsgBox(Arrays(0) & operacion)
			If  billete <= 4000 Then 
				Dim BilleteMenor As String = MessageBox.Show("Su billete es menor del total Desea volver a ingresar su billete", "advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
					If BilleteMenor = DialogResult.Yes Then
						MsgBox(Funcion())
					Else
						MsgBox("Operacion /404 cancelada")
				End If
			Else	
				MsgBox("pago existoso")
		End If
	End If 
If ComboBox1.SelectedItem = "nissan Corolla 2005 $7340" Then 
			Dim  operacion As integer = cantidad * 256721 
			Dim Arrays() as String  = {"su total es de"}
			MsgBox(Arrays(0) & operacion)
			Conditon()
	End If
If ComboBox1.SelectedItem = "nnissan March 2010 $10256" Then 
			Dim  operacion As integer = cantidad * 256721 
			Dim Arrays() as String  = {"su total es de"}
			MsgBox(Arrays(0) & operacion)
			Conditon()
		End If
	End Sub
Function Funcion() As String
		Return "vuelva  a ingresae su billete"
End Function
	Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
		If Me.Button2.FlatAppearance.MouseOverBackColor = Color.Gold Then 
			 Me.Button2.ForeColor = color.White 			
		End If
	End Sub
		Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
			Me.Button2.ForeColor =  Color.Black 
		End Sub
Function F() As String
		Return "Pago existoso"
	End Function
End Class
