Imports System.Data.Entity

Namespace Data
    
    Public Class EFDbContext
        Inherits DbContext
    
        ' You can add custom code to this file. Changes will not be overwritten.
        ' 
        ' If you want Entity Framework to drop and regenerate your database
        ' automatically whenever you change your model schema, please use data migrations.
        ' For more information refer to the documentation:
        ' http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        Public Sub New()
            MyBase.New("name=EFDbContext")
        End Sub

        Public Property Courses As System.Data.Entity.DbSet(Of Courses)
        Public Property Members As System.Data.Entity.DbSet(Of Members)
        Public Property Basckets As System.Data.Entity.DbSet(Of Basckets)
        Public Property Schedules As System.Data.Entity.DbSet(Of Schedules)
    End Class

End Namespace
