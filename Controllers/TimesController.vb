Imports System.Data.Entity
Imports System.Net
Imports Enrollment.Data

Namespace Controllers
    Public Class TimesController
        Inherits Controller

        Private db As New TimesContext

        ' GET: Times
        Function Index() As ActionResult
            Return View(db.Times.ToList())
        End Function

        ' GET: Times/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim times As Times = db.Times.Find(id)
            If IsNothing(times) Then
                Return HttpNotFound()
            End If
            Return View(times)
        End Function

        ' GET: Times/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Times/Create
        '초과 게시 공격으로부터 보호하려면 바인딩하려는 특정 속성을 사용하도록 설정하세요. 
        '자세한 내용은 https://go.microsoft.com/fwlink/?LinkId=317598을(를) 참조하세요.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Tim_Idx,Tim_Day,Tim_StartTime,Tim_EndTime,Tim_Date,Tim_Updated,Tim_IsValid")> ByVal times As Times) As ActionResult
            If ModelState.IsValid Then
                db.Times.Add(times)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(times)
        End Function

        ' GET: Times/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim times As Times = db.Times.Find(id)
            If IsNothing(times) Then
                Return HttpNotFound()
            End If
            Return View(times)
        End Function

        ' POST: Times/Edit/5
        '초과 게시 공격으로부터 보호하려면 바인딩하려는 특정 속성을 사용하도록 설정하세요. 
        '자세한 내용은 https://go.microsoft.com/fwlink/?LinkId=317598을(를) 참조하세요.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Tim_Idx,Tim_Day,Tim_StartTime,Tim_EndTime,Tim_Date,Tim_Updated,Tim_IsValid")> ByVal times As Times) As ActionResult
            If ModelState.IsValid Then
                db.Entry(times).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(times)
        End Function

        ' GET: Times/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim times As Times = db.Times.Find(id)
            If IsNothing(times) Then
                Return HttpNotFound()
            End If
            Return View(times)
        End Function

        ' POST: Times/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim times As Times = db.Times.Find(id)
            db.Times.Remove(times)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
