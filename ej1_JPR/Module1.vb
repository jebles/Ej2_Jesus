Module Module1
    Friend Structure alumno
        Public codAlum As Integer
        Public nomAlum As String
        Public apellAlum As String
        Public telfAlum As String
        Public emailAlum As String
        Public cursoAlum As String

    End Structure

End Module
Module Module2
    Public numUsuarios As Integer = 4
    Public datos_login(3, 1) As String
    Public usuario_activo As String
    Public varAlumno() As alumno
End Module
