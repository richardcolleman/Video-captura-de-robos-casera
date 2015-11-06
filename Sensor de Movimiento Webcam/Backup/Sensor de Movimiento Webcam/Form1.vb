Imports AForge.Video.DirectShow
Imports AForge.Video
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Text
Imports System.Windows.Forms
Imports System.Threading

Imports AForge
Imports AForge.Imaging
Imports AForge.Video.VFW
Imports AForge.Vision.Motion


Public Class Form1


    ' Creamos una variable del tipo Thread
    Private sonido As Thread

    ' creamos un contador
    Dim i As Integer

    Private motionAlarmLevel As Single = 0.015F

    ' motion detector
    Private detector As New MotionDetector(New TwoFramesDifferenceDetector(), New MotionAreaHighlighting())

    Private Dispositivos_Disponibles As Boolean = False
    Private Disp_Video As FilterInfoCollection
    Private WithEvents FuenteDeVideo As VideoCaptureDevice = Nothing


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        i = 0
        Me.Timer_alarma.Enabled = False
        Me.Timer1.Enabled = True
        Busca_Dispositivos()
    End Sub


#Region "Parametros de configuracion"

    Sub Carga_Dispositivos()
        For i As Integer = 0 To Disp_Video.Count - 1
            combo_dispositivos.Items.Add(Disp_Video(i).Name.ToString())
        Next
        combo_dispositivos.Text = combo_dispositivos.Items(0).ToString()
    End Sub


    Sub Busca_Dispositivos()
        Disp_Video = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If Disp_Video.Count = 0 Then
            Dispositivos_Disponibles = False
        Else
            Dispositivos_Disponibles = True
            Carga_Dispositivos()
            Button_iniciar.Enabled = True
        End If
    End Sub

    Sub Termina_FuenteDeVideo()
        If Not (FuenteDeVideo Is Nothing) Then
            If FuenteDeVideo.IsRunning Then
                FuenteDeVideo.SignalToStop()
                FuenteDeVideo = Nothing
            End If
        End If
    End Sub

#End Region

    Private Sub iniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_iniciar.Click
        Try

            If Dispositivos_Disponibles Then
                FuenteDeVideo = New VideoCaptureDevice(Disp_Video(combo_dispositivos.SelectedIndex).MonikerString)
                AddHandler FuenteDeVideo.NewFrame, New NewFrameEventHandler(AddressOf video_NuevoFrame)
                FuenteDeVideo.Start()
                combo_dispositivos.Enabled = False
            End If

        Catch ex As Exception

        End Try

    End Sub


    Private Sub video_NuevoFrame(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)

        'entra aqui mientras no se haya detectado movimiento

        Dim Imagen As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)

        If detector IsNot Nothing Then
            Dim motionLevel As Single = detector.ProcessFrame(Imagen)

            If motionLevel > motionAlarmLevel Then

                Me.Button_indica_mov.ForeColor = Color.White
                Me.Button_indica_mov.Text = "Si hay Movimiento"
                Me.Button_indica_mov.BackColor = Color.Red
                'MessageBox.Show("objeto detectado", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                Me.Button_indica_mov.ForeColor = Color.Black
                Me.Button_indica_mov.Text = "No hay Movimiento"
                Me.Button_indica_mov.BackColor = Color.Yellow
            End If

            webcam.Image = Imagen
        End If

    End Sub


    Private Sub Button_detener_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_detener.Click
        Try

            If FuenteDeVideo.IsRunning Then
                Termina_FuenteDeVideo()
                combo_dispositivos.Enabled = True
            End If

        Catch ex As Exception

        End Try

    End Sub

   
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If (Me.Button_indica_mov.BackColor = Color.Red) Then
            i = 1
            Me.Timer_alarma.Enabled = True
            Me.Timer1.Enabled = False
        End If

    End Sub


    Private Sub Timer_alarma_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_alarma.Tick
        If (i = 1) Then

            'crear objeto y asignarlo al sub que queremos ejecutar
            sonido = New Thread(AddressOf reproducir_sonido)
            'ponemos al hilo en marcha
            sonido.Start()

        End If

        If (i = 6) Then
            Me.Timer_alarma.Enabled = False
            Me.Timer1.Enabled = True

            'detenemos el hilo
            sonido.Abort()
        End If
        i += 1
    End Sub

    Sub reproducir_sonido()
        My.Computer.Audio.Play("Alerta.wav", AudioPlayMode.WaitToComplete)
    End Sub

End Class
