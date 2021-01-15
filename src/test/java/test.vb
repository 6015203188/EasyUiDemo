  Sub mian()

      Dim bsf As Integer
      Dim zwmc As Long
      Dim zdm As Long
      Dim sm As Long
      Dim sjlxjgs As Long
      Dim zy As Long
      Dim jldw As Long
      Dim yj As Long
      Dim tjjg As Long
      Dim pzrq As Long
      Dim bb As Long
      Dim bz As Long

      Dim i As Long
      Dim count As Long
      Dim pos As Long


      count = 2

      ' 标识符

      For i = 2 To 6000

          pos = InStr(Cells(count, 1), "标识符")

          If pos > 0 Then
              Cells(i, 7) = Cells(count, 2) '& "   " & count
              count = count + 13
          Else
               count = count - 3
               Cells(i, 7) = Cells(count, 2) '& "   " & count
               count = count + 13
          End If
            '   Debug.Print count & "  " & i
          Next
      count = 3



      ' 中文名称

      For zwmc = 2 To 6000

          pos = InStr(Cells(count, 1), "中文名称")

          If pos > 0 Then
              Cells(zwmc, 8) = Cells(count, 2) ' & "   " & count
              count = count + 13
          Else
               count = count - 3
               Cells(zwmc, 8) = Cells(count, 2) '& "   " & count
               count = count + 13
          End If
               'Debug.Print count & "  " & zwmc
          Next

      count = 4


      ' 字段名

      For zdm = 2 To 6000

          pos = InStr(Cells(count, 1), "字段名")

          If pos > 0 Then
              Cells(zdm, 9) = Cells(count, 2) '& "   " & count
              count = count + 13
          Else
               count = count - 3
               Cells(zdm, 9) = Cells(count, 2) ' & "   " & count
               count = count + 13
          End If
              ' Debug.Print count & "  " & zdm
          Next
      count = 5

  ' 说明


      For i = 2 To 6000

          pos = InStr(Cells(count, 1), "说明")

          If pos > 0 Then
              Cells(i, 10) = Cells(count, 2) '& "   " & count
              count = count + 13
          Else
               count = count - 3
               Cells(i, 10) = Cells(count, 2) '& "   " & count
               count = count + 13
          End If
               'Debug.Print count & "  " & i
          Next
      count = 6


      ' 数据类型及格式

      For i = 2 To 6000

          pos = InStr(Cells(count, 1), "数据类型及格式")

          If pos > 0 Then
              Cells(i, 11) = Cells(count, 2) '& "   " & count
              count = count + 13
          Else
               count = count - 3
               Cells(i, 11) = ""
               count = count + 13
          End If
               'Debug.Print count & "  " & i
          Next
      count = 7


      ' 值域

      For i = 2 To 6000

          pos = InStr(Cells(count, 1), "值域")

          If pos > 0 Then
              Cells(i, 12) = Cells(count, 2) & "   " & count
              count = count + 13
          ElseIf InStr(Cells(count - 3, 1), "值域") > 0 Then
                    count = count - 3
                    Cells(i, 12) = Cells(count, 2) & "   " & count
                    count = count + 13

          ElseIf InStr(Cells(count - 2, 1), "值域") > 0 Then
                     count = count - 2
                     Cells(i, 12) = Cells(count, 2) & "   " & count
                     count = count + 13
           Else
                    count = count - 1
                    Cells(i, 12) = Cells(count, 2) & "   " & count
                    count = count + 13
          End If

               'Debug.Print count & "  " & i
          Next
      count = 8


      ' 计量单位

      For i = 2 To 6000

          pos = InStr(Cells(count, 1), "计量单位")

          If pos > 0 Then
              Cells(i, 13) = Cells(count, 2) '& "   " & count
              count = count + 13
          Else
               count = count - 3
               Cells(i, 13) = ""
               count = count + 13
          End If
              ' Debug.Print count & "  " & i
          Next
      count = 9


      ' 语境

      For i = 2 To 6000

          pos = InStr(Cells(count, 1), "语境")

          If pos > 0 Then
              Cells(i, 14) = Cells(count, 2) '& "   " & count
              count = count + 13
          Else
               count = count - 3
               Cells(i, 14) = ""
               count = count + 13
          End If
               'Debug.Print count & "  " & i
          Next
      count = 10


      ' 提交机构

      For i = 2 To 6000

          pos = InStr(Cells(count, 1), "提交机构")

          If pos > 0 Then
              Cells(i, 15) = Cells(count, 2) '& "   " & count
              count = count + 13
          Else
               count = count - 3
               Cells(i, 15) = Cells(count, 2) '& "   " & count
               count = count + 13
          End If
               'Debug.Print count & "  " & i
          Next
      count = 11


      ' 批准日期

      For i = 2 To 6000

          pos = InStr(Cells(count, 1), "批准日期")

          If pos > 0 Then
              Cells(i, 16) = Cells(count, 2) '& "   " & count
              count = count + 13
          Else
               count = count - 3
               Cells(i, 16) = Cells(count, 2) '& "   " & count
               count = count + 13
          End If
              ' Debug.Print count & "  " & i
          Next
      count = 12


      ' 版本

      For i = 2 To 6000

          pos = InStr(Cells(count, 1), "版本")

          If pos > 0 Then
              Cells(i, 17) = Cells(count, 2) '& "   " & count
              count = count + 13
          Else
               count = count - 3
               Cells(i, 17) = Cells(count, 2) '& "   " & count
               count = count + 13
          End If
               'Debug.Print count & "  " & i
          Next
      count = 13


      ' 备注

      For i = 2 To 6000

          pos = InStr(Cells(count, 1), "备注")

          If pos > 0 Then
              Cells(i, 18) = Cells(count, 2) '& "   " & count
              count = count + 13
          Else
               count = count - 3
               Cells(i, 18) = Cells(count, 2) '& "   " & count
               count = count + 13
          End If
               'Debug.Print count & "  " & i
          Next
      count = 14




  End Sub




