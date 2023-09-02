```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2134/22H2/2022Update/SunValley2)
AMD Ryzen 7 5700U with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 7.0.202
  [Host]   : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2
  .NET 7.0 : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2

Job=.NET 7.0  Runtime=.NET 7.0  

```
|                   Method | Records |              Mean |           Error |          StdDev |       Gen0 |  Allocated |
|------------------------- |-------- |------------------:|----------------:|----------------:|-----------:|-----------:|
|                  **ListFor** |       **5** |         **0.9875 ns** |       **0.0411 ns** |       **0.0384 ns** |          **-** |          **-** |
|              ListForeach |       5 |         2.7701 ns |       0.0158 ns |       0.0148 ns |          - |          - |
|  ListAsGenericEnumerable |       5 |        45.2056 ns |       0.1784 ns |       0.1669 ns |     0.0191 |       40 B |
|    ListAsPlainEnumerable |       5 |        60.4338 ns |       1.2417 ns |       1.4300 ns |     0.0764 |      160 B |
|                 ArrayFor |       5 |         1.0322 ns |       0.0479 ns |       0.0492 ns |          - |          - |
|             ArrayForeach |       5 |         0.9427 ns |       0.0203 ns |       0.0170 ns |          - |          - |
|        DictionaryForeach |       5 |        19.2364 ns |       0.2173 ns |       0.2032 ns |          - |          - |
|           HashSetForeach |       5 |        14.0138 ns |       0.1463 ns |       0.1297 ns |          - |          - |
| GenericEnumerableForeach |       5 |        29.1025 ns |       0.2364 ns |       0.2212 ns |     0.0191 |       40 B |
|   PlainEnumerableForeach |       5 |        42.6809 ns |       0.8615 ns |       0.8846 ns |     0.0765 |      160 B |
|                  **ListFor** |     **100** |        **29.7365 ns** |       **0.1359 ns** |       **0.1135 ns** |          **-** |          **-** |
|              ListForeach |     100 |        43.0324 ns |       0.2257 ns |       0.1884 ns |          - |          - |
|  ListAsGenericEnumerable |     100 |       651.0318 ns |       2.7561 ns |       2.5781 ns |     0.0191 |       40 B |
|    ListAsPlainEnumerable |     100 |       905.5293 ns |      17.1402 ns |      23.4617 ns |     1.1663 |     2440 B |
|                 ArrayFor |     100 |        29.5245 ns |       0.0330 ns |       0.0293 ns |          - |          - |
|             ArrayForeach |     100 |        29.6491 ns |       0.0265 ns |       0.0235 ns |          - |          - |
|        DictionaryForeach |     100 |       293.5200 ns |       3.1482 ns |       2.9448 ns |          - |          - |
|           HashSetForeach |     100 |       247.6698 ns |       3.9599 ns |       3.7041 ns |          - |          - |
| GenericEnumerableForeach |     100 |       371.7560 ns |       0.4780 ns |       0.4472 ns |     0.0191 |       40 B |
|   PlainEnumerableForeach |     100 |       633.3775 ns |       2.3230 ns |       1.9398 ns |     1.1663 |     2440 B |
|                  **ListFor** |     **500** |       **121.3294 ns** |       **0.1781 ns** |       **0.1487 ns** |          **-** |          **-** |
|              ListForeach |     500 |       188.2064 ns |       0.8668 ns |       0.7684 ns |          - |          - |
|  ListAsGenericEnumerable |     500 |     3,164.6643 ns |       2.7722 ns |       2.3149 ns |     0.0191 |       40 B |
|    ListAsPlainEnumerable |     500 |     4,317.0388 ns |      21.7741 ns |      16.9998 ns |     5.7526 |    12040 B |
|                 ArrayFor |     500 |       122.3381 ns |       1.3803 ns |       1.2912 ns |          - |          - |
|             ArrayForeach |     500 |       121.1332 ns |       0.0954 ns |       0.0796 ns |          - |          - |
|        DictionaryForeach |     500 |     1,251.2905 ns |       5.2859 ns |       4.6858 ns |          - |          - |
|           HashSetForeach |     500 |     1,180.3528 ns |       1.7615 ns |       1.5615 ns |          - |          - |
| GenericEnumerableForeach |     500 |     1,788.3952 ns |      14.4872 ns |      13.5514 ns |     0.0191 |       40 B |
|   PlainEnumerableForeach |     500 |     2,982.2553 ns |       9.5279 ns |       7.9562 ns |     5.7564 |    12040 B |
|                  **ListFor** |    **1000** |       **236.7877 ns** |       **0.0449 ns** |       **0.0350 ns** |          **-** |          **-** |
|              ListForeach |    1000 |       476.4301 ns |       6.5970 ns |       6.1709 ns |          - |          - |
|  ListAsGenericEnumerable |    1000 |     6,325.7206 ns |      12.4536 ns |      10.3993 ns |     0.0153 |       40 B |
|    ListAsPlainEnumerable |    1000 |     8,364.6530 ns |      30.3466 ns |      23.6927 ns |    11.4899 |    24040 B |
|                 ArrayFor |    1000 |       236.9788 ns |       0.3847 ns |       0.3004 ns |          - |          - |
|             ArrayForeach |    1000 |       236.8346 ns |       0.0716 ns |       0.0635 ns |          - |          - |
|        DictionaryForeach |    1000 |     2,813.1126 ns |       1.5346 ns |       1.4354 ns |          - |          - |
|           HashSetForeach |    1000 |     2,371.9066 ns |       3.5742 ns |       2.9846 ns |          - |          - |
| GenericEnumerableForeach |    1000 |     3,554.4851 ns |      42.2219 ns |      39.4944 ns |     0.0191 |       40 B |
|   PlainEnumerableForeach |    1000 |     5,957.9892 ns |      26.7502 ns |      22.3376 ns |    11.4899 |    24040 B |
|                  **ListFor** |   **10000** |     **2,318.1597 ns** |       **0.2457 ns** |       **0.2178 ns** |          **-** |          **-** |
|              ListForeach |   10000 |     4,656.1289 ns |       3.0105 ns |       2.3504 ns |          - |          - |
|  ListAsGenericEnumerable |   10000 |    60,785.3812 ns |     432.6277 ns |     383.5132 ns |          - |       40 B |
|    ListAsPlainEnumerable |   10000 |    80,878.9325 ns |     178.0718 ns |     148.6980 ns |   114.7461 |   240040 B |
|                 ArrayFor |   10000 |     2,318.2168 ns |       0.3325 ns |       0.2947 ns |          - |          - |
|             ArrayForeach |   10000 |     2,325.8036 ns |      13.7213 ns |      11.4579 ns |          - |          - |
|        DictionaryForeach |   10000 |    24,963.8365 ns |     248.6426 ns |     220.4152 ns |          - |          - |
|           HashSetForeach |   10000 |    23,606.3993 ns |      15.5296 ns |      14.5264 ns |          - |          - |
| GenericEnumerableForeach |   10000 |    34,721.0078 ns |       8.0145 ns |       6.6925 ns |          - |       40 B |
|   PlainEnumerableForeach |   10000 |    57,074.9468 ns |   1,023.5033 ns |     907.3090 ns |   114.7461 |   240040 B |
|                  **ListFor** |   **50000** |    **11,568.3783 ns** |      **10.3076 ns** |       **9.6418 ns** |          **-** |          **-** |
|              ListForeach |   50000 |    23,140.0350 ns |      12.8460 ns |      10.7270 ns |          - |          - |
|  ListAsGenericEnumerable |   50000 |   301,499.4210 ns |   1,517.4560 ns |   1,345.1852 ns |          - |       40 B |
|    ListAsPlainEnumerable |   50000 |   414,063.8532 ns |   5,107.6647 ns |   4,527.8117 ns |   573.7305 |  1200040 B |
|                 ArrayFor |   50000 |    11,569.2730 ns |       1.4147 ns |       1.1045 ns |          - |          - |
|             ArrayForeach |   50000 |    11,599.9198 ns |      43.7063 ns |      40.8829 ns |          - |          - |
|        DictionaryForeach |   50000 |   125,040.4834 ns |   1,901.0458 ns |   1,778.2394 ns |          - |          - |
|           HashSetForeach |   50000 |   116,394.2043 ns |     369.0860 ns |     327.1851 ns |          - |          - |
| GenericEnumerableForeach |   50000 |   174,420.6281 ns |   1,132.0933 ns |   1,003.5712 ns |          - |       40 B |
|   PlainEnumerableForeach |   50000 |   283,938.1627 ns |   3,186.8432 ns |   2,825.0535 ns |   573.7305 |  1200040 B |
|                  **ListFor** |  **500000** |   **115,662.8026 ns** |     **114.1001 ns** |     **101.1468 ns** |          **-** |          **-** |
|              ListForeach |  500000 |   234,420.9359 ns |   1,680.7054 ns |   1,572.1328 ns |          - |          - |
|  ListAsGenericEnumerable |  500000 | 3,022,308.2632 ns |  10,492.7929 ns |   8,761.9573 ns |          - |       42 B |
|    ListAsPlainEnumerable |  500000 | 4,434,421.3588 ns |  83,800.3035 ns | 180,388.9939 ns |  5734.3750 | 12000045 B |
|                 ArrayFor |  500000 |   116,606.0909 ns |   1,013.4052 ns |     947.9398 ns |          - |          - |
|             ArrayForeach |  500000 |   115,858.9059 ns |     228.7989 ns |     202.8242 ns |          - |          - |
|        DictionaryForeach |  500000 | 1,325,311.5234 ns |  10,042.4903 ns |   9,393.7517 ns |          - |        1 B |
|           HashSetForeach |  500000 | 1,186,894.8242 ns |   5,663.4456 ns |   5,020.4970 ns |          - |        1 B |
| GenericEnumerableForeach |  500000 | 1,736,346.7611 ns |   2,753.2441 ns |   2,149.5519 ns |          - |       41 B |
|   PlainEnumerableForeach |  500000 | 2,902,051.6927 ns |  27,728.8932 ns |  25,937.6239 ns |  5738.2813 | 12000042 B |
|                  **ListFor** | **1000000** |   **231,202.6768 ns** |      **31.5023 ns** |      **27.9260 ns** |          **-** |          **-** |
|              ListForeach | 1000000 |   478,192.1596 ns |   5,163.1124 ns |   4,576.9647 ns |          - |          - |
|  ListAsGenericEnumerable | 1000000 | 6,066,738.0409 ns |   3,530.0601 ns |   2,947.7601 ns |          - |       45 B |
|    ListAsPlainEnumerable | 1000000 | 8,478,880.5804 ns |  16,042.5931 ns |  14,221.3409 ns | 11468.7500 | 24000049 B |
|                 ArrayFor | 1000000 |   231,292.8298 ns |     121.2219 ns |     101.2258 ns |          - |          - |
|             ArrayForeach | 1000000 |   231,233.6461 ns |      67.5700 ns |      59.8990 ns |          - |          - |
|        DictionaryForeach | 1000000 | 2,591,190.0260 ns |   4,480.0627 ns |   4,190.6534 ns |          - |        2 B |
|           HashSetForeach | 1000000 | 2,477,234.8145 ns |  47,770.9472 ns |  46,917.4576 ns |          - |        2 B |
| GenericEnumerableForeach | 1000000 | 3,479,592.7083 ns |  21,653.4088 ns |  20,254.6120 ns |          - |       42 B |
|   PlainEnumerableForeach | 1000000 | 5,661,172.3125 ns | 105,621.1835 ns | 141,001.2462 ns | 11476.5625 | 24000045 B |