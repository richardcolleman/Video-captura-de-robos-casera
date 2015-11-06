<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.combo_dispositivos = New System.Windows.Forms.ComboBox
        Me.Button_iniciar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button_detener = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.webcam = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button_indica_mov = New System.Windows.Forms.Button
        Me.Timer_alarma = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.webcam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'combo_dispositivos
        '
        Me.combo_dispositivos.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_dispositivos.FormattingEnabled = True
        Me.combo_dispositivos.Location = New System.Drawing.Point(24, 555)
        Me.combo_dispositivos.Name = "combo_dispositivos"
        Me.combo_dispositivos.Size = New System.Drawing.Size(151, 26)
        Me.combo_dispositivos.TabIndex = 19
        '
        'Button_iniciar
        '
        Me.Button_iniciar.Enabled = False
        Me.Button_iniciar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_iniciar.Location = New System.Drawing.Point(196, 553)
        Me.Button_iniciar.Name = "Button_iniciar"
        Me.Button_iniciar.Size = New System.Drawing.Size(81, 28)
        Me.Button_iniciar.TabIndex = 20
        Me.Button_iniciar.Text = "Iniciar"
        Me.Button_iniciar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 531)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 18)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Dispositivos de Video"
        '
        'Button_detener
        '
        Me.Button_detener.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_detener.Location = New System.Drawing.Point(292, 553)
        Me.Button_detener.Name = "Button_detener"
        Me.Button_detener.Size = New System.Drawing.Size(81, 28)
        Me.Button_detener.TabIndex = 23
        Me.Button_detener.Text = "Detener"
        Me.Button_detener.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.webcam)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(562, 445)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'webcam
        '
        Me.webcam.BackColor = System.Drawing.Color.LightGray
        Me.webcam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.webcam.Location = New System.Drawing.Point(9, 15)
        Me.webcam.Name = "webcam"
        Me.webcam.Size = New System.Drawing.Size(542, 416)
        Me.webcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.webcam.TabIndex = 19
        Me.webcam.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(527, 30)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Sistema de Deteccion de Movimiento con WebCam"
        '
        'Button_indica_mov
        '
        Me.Button_indica_mov.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_indica_mov.ForeColor = System.Drawing.Color.Black
        Me.Button_indica_mov.Location = New System.Drawing.Point(450, 546)
        Me.Button_indica_mov.Name = "Button_indica_mov"
        Me.Button_indica_mov.Size = New System.Drawing.Size(142, 42)
        Me.Button_indica_mov.TabIndex = 28
        Me.Button_indica_mov.Text = "Movimiento"
        Me.Button_indica_mov.UseVisualStyleBackColor = True
        '
        'Timer_alarma
        '
        Me.Timer_alarma.Interval = 1000
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(645, 617)
        Me.Controls.Add(Me.Button_indica_mov)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_detener)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_iniciar)
        Me.Controls.Add(Me.combo_dispositivos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sensor de Movimiento"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.webcam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents combo_dispositivos As System.Windows.Forms.ComboBox
    Private WithEvents Button_iniciar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Button_detener As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button_indica_mov As System.Windows.Forms.Button
    Private WithEvents webcam As System.Windows.Forms.PictureBox
    Friend WithEvents Timer_alarma As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
