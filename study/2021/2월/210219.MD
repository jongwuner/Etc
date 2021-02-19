## Python Excel 자동화에 있어서 여러가지를 배웠던 날
: https://www.evernote.com/shard/s372/sh/e0d3e07f-cc0e-d481-b092-7eada8d01fae/

### 맘스보드 Python 엑셀을 하는데 조금 고충이 있었다. 
- [관련 Issue](https://github.com/22hours/momsboard_python/issues/1)

### uiautomation
- pywinauto로 실행을 성공했다. 

### spy++을 활용하여 win handle을 가져올 수 있었다. 
- VS2019에서 직접 실행시켜서 활용했는데, 동기화만 가능했다. 
? 추후에 내가 win을 분석해서 Selenium의 XPath처럼 활용할 수 있는지 궁금하다. 

### Apache POI를 Micro Excel로 바꿔야하는데 이것을 해결했다. 

```python
import win32com.client

def POItoExcel(xl):
    excel = win32com.client.Dispatch('Excel.Application')
    my_excel = excel.Workbooks.Open(f'{INPUT_DIR}\\{xl}')
    my_excel.Save()
    excel.Quit()
```

### SNS공유 기능을 활용하면 앱 내부로 바로 링크를 태울 수 있을 것 같다.
- 확실하다. 