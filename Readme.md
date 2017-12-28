# StreamPad

하나의 프로그램은 하나의 스트림이다는 개념을 사용해서 무언가 할 수 있지 않을까

코드 상에서는 LINQ 같은 형태나 스트림(통로?)로 넘길 수 있겠고 혹은 아예 폼을 만들어서 **스크래치처럼 VPL로 시각화하면** 깔끔하고 재밌을듯.

## 구상

```csharp
Main = (datas)
    => datas.Dispatch({typeof(string): s => s,
                       typeof(int):    i => "{i:000}"}
            .Select(e => e.PadLeft(3))
            .ForEach(e => Console.WriteLine(e));
```

```csharp
Main = ()
    => Enumerable.Range(1, 100)
        .Split(i => i % 2)
        .ForEach(e => Console.WriteLine($"짝수 {e}"),
                 o => Console.WriteLine($"홀수 {o}"))
```

튜플의 스트림으로 생각해도 될 거 같다.