Imports System.Data.Entity

Namespace Models.EFDbContext
    Public Class EFDbContext
        Public Class EFDbContext
            Inherits DbContext

            Public Courses As DbSet(Of Courses)
            Public Members As DbSet(Of Members)
            Public Times As DbSet(Of Times)
            Public Schedules As DbSet(Of Schedules)
            Public Basckets As DbSet(Of Basckets)
        End Class
    End Class
End Namespace
