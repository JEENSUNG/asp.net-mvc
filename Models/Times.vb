Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity

Public Class Times
    <Key>
    Property Tim_Idx As Long

    <Required, MinLength(2, ErrorMessage:="최소 2자는 입력되어야 합니다."), MaxLength(20, ErrorMessage:="최대 20자 까지만 작성 가능합니다."), RegularExpression("^[a-zA-Z가-힣]*$", ErrorMessage:="영어 또는 한글만 작성할 수 있습니다.")>
    Property Tim_Day As String

    <Required, Range(1, Integer.MaxValue), RegularExpression("^[0-9]*$", ErrorMessage:="숫자로만 입력 가능합니다.")>
    Property Tim_StartTime As Integer

    <Required, Range(1, Integer.MaxValue), RegularExpression("^[0-9]*$", ErrorMessage:="숫자로만 입력 가능합니다.")>
    Property Tim_EndTime As Integer

    <DataType(DataType.Date)>
    <DisplayFormat(DataFormatString:="{0:yyyy-MM-dd}", ApplyFormatInEditMode:=True)>
    <Required>
    Property Tim_Created_Date As DateTime

    <DataType(DataType.Date)>
    <DisplayFormat(DataFormatString:="{0:yyyy-MM-dd}", ApplyFormatInEditMode:=True)>
    <Required>
    Property Tim_Modified_Date As DateTime

    <Required, DefaultSettingValue("false")>
    Property Tim_Updated As Boolean

    <Required, DefaultSettingValue("false")>
    Property Tim_IsValid As Boolean

End Class
