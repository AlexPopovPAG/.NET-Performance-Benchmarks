```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2134/22H2/2022Update/SunValley2)
AMD Ryzen 7 5700U with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 7.0.202
  [Host]   : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2
  .NET 7.0 : .NET 7.0.4 (7.0.423.11508), X64 RyuJIT AVX2

Job=.NET 7.0  Runtime=.NET 7.0  

```
|                    Method | Records |             Mean |          Error |         StdDev |           Median |
|-------------------------- |-------- |-----------------:|---------------:|---------------:|-----------------:|
|       **ListDynamicCapacity** |       **5** |         **30.96 ns** |       **0.628 ns** |       **0.838 ns** |         **31.03 ns** |
|       ListPlannedCapacity |       5 |         15.34 ns |       0.335 ns |       0.470 ns |         15.27 ns |
|    HashSetDynamicCapacity |       5 |         78.54 ns |       1.382 ns |       1.292 ns |         78.03 ns |
|    HashSetPlannedCapacity |       5 |         49.08 ns |       1.053 ns |       2.952 ns |         48.35 ns |
| DictionaryDynamicCapacity |       5 |         73.81 ns |       0.367 ns |       0.343 ns |         73.76 ns |
| DictionaryPlannedCapacity |       5 |         55.27 ns |       2.750 ns |       7.846 ns |         51.93 ns |
|       **ListDynamicCapacity** |     **100** |        **274.12 ns** |       **7.734 ns** |      **22.064 ns** |        **265.68 ns** |
|       ListPlannedCapacity |     100 |        219.62 ns |       6.149 ns |      18.131 ns |        218.75 ns |
|    HashSetDynamicCapacity |     100 |      1,192.17 ns |      35.393 ns |      99.826 ns |      1,154.01 ns |
|    HashSetPlannedCapacity |     100 |        591.83 ns |       5.918 ns |       4.621 ns |        590.06 ns |
| DictionaryDynamicCapacity |     100 |      1,259.46 ns |      31.990 ns |      89.704 ns |      1,227.68 ns |
| DictionaryPlannedCapacity |     100 |        646.60 ns |      11.645 ns |      10.893 ns |        644.57 ns |
|       **ListDynamicCapacity** |     **500** |      **1,167.00 ns** |      **22.845 ns** |      **35.567 ns** |      **1,161.52 ns** |
|       ListPlannedCapacity |     500 |        923.26 ns |      17.706 ns |      16.562 ns |        920.20 ns |
|    HashSetDynamicCapacity |     500 |      5,231.46 ns |     101.238 ns |     197.457 ns |      5,186.29 ns |
|    HashSetPlannedCapacity |     500 |      3,156.93 ns |      69.762 ns |     202.393 ns |      3,106.26 ns |
| DictionaryDynamicCapacity |     500 |      5,794.68 ns |     180.205 ns |     505.316 ns |      5,597.09 ns |
| DictionaryPlannedCapacity |     500 |      3,107.39 ns |      22.879 ns |      21.401 ns |      3,107.95 ns |
|       **ListDynamicCapacity** |    **1000** |      **2,023.57 ns** |       **7.969 ns** |       **7.064 ns** |      **2,023.73 ns** |
|       ListPlannedCapacity |    1000 |      1,879.33 ns |      37.459 ns |      73.061 ns |      1,861.80 ns |
|    HashSetDynamicCapacity |    1000 |     10,269.80 ns |      56.354 ns |      52.713 ns |     10,278.31 ns |
|    HashSetPlannedCapacity |    1000 |      5,954.15 ns |     116.847 ns |     155.987 ns |      5,900.20 ns |
| DictionaryDynamicCapacity |    1000 |     10,920.76 ns |      41.595 ns |      32.475 ns |     10,921.04 ns |
| DictionaryPlannedCapacity |    1000 |      6,431.17 ns |     125.467 ns |     317.071 ns |      6,289.15 ns |
|       **ListDynamicCapacity** |   **10000** |     **24,341.29 ns** |     **889.844 ns** |   **2,581.599 ns** |     **23,563.24 ns** |
|       ListPlannedCapacity |   10000 |     17,833.66 ns |     246.274 ns |     192.274 ns |     17,805.74 ns |
|    HashSetDynamicCapacity |   10000 |    194,971.65 ns |     453.202 ns |     378.444 ns |    195,124.29 ns |
|    HashSetPlannedCapacity |   10000 |    105,787.94 ns |   2,051.943 ns |   2,595.051 ns |    104,873.44 ns |
| DictionaryDynamicCapacity |   10000 |    251,574.14 ns |   4,717.904 ns |   8,976.302 ns |    249,212.79 ns |
| DictionaryPlannedCapacity |   10000 |    127,167.95 ns |   2,903.606 ns |   8,284.152 ns |    124,126.07 ns |
|       **ListDynamicCapacity** |   **50000** |    **245,016.99 ns** |   **4,797.808 ns** |   **4,926.995 ns** |    **244,438.84 ns** |
|       ListPlannedCapacity |   50000 |    160,207.69 ns |   4,180.208 ns |  11,721.751 ns |    155,689.55 ns |
|    HashSetDynamicCapacity |   50000 |    857,795.73 ns |  17,139.370 ns |  27,184.857 ns |    854,498.83 ns |
|    HashSetPlannedCapacity |   50000 |    593,178.32 ns |  13,497.508 ns |  38,509.150 ns |    575,435.21 ns |
| DictionaryDynamicCapacity |   50000 |    994,582.30 ns |  18,099.937 ns |  28,179.421 ns |    986,110.06 ns |
| DictionaryPlannedCapacity |   50000 |    535,771.51 ns |   5,502.792 ns |   4,878.082 ns |    535,672.66 ns |
|       **ListDynamicCapacity** |  **500000** |  **2,377,466.29 ns** |  **46,060.148 ns** |  **40,831.121 ns** |  **2,379,448.63 ns** |
|       ListPlannedCapacity |  500000 |  1,551,651.50 ns |  30,296.879 ns |  55,399.557 ns |  1,528,923.34 ns |
|    HashSetDynamicCapacity |  500000 | 10,359,871.66 ns | 205,769.946 ns | 508,612.326 ns | 10,364,231.25 ns |
|    HashSetPlannedCapacity |  500000 |  4,647,332.97 ns |  91,771.325 ns | 223,384.090 ns |  4,650,121.88 ns |
| DictionaryDynamicCapacity |  500000 | 10,682,220.49 ns | 211,737.353 ns | 226,556.596 ns | 10,744,809.38 ns |
| DictionaryPlannedCapacity |  500000 |  4,796,205.89 ns |  95,620.990 ns | 172,424.369 ns |  4,747,389.84 ns |
|       **ListDynamicCapacity** | **1000000** |  **4,943,331.80 ns** |  **96,607.778 ns** |  **99,209.075 ns** |  **4,977,842.97 ns** |
|       ListPlannedCapacity | 1000000 |  3,014,976.09 ns |  52,911.705 ns |  58,811.220 ns |  3,017,630.08 ns |
|    HashSetDynamicCapacity | 1000000 | 17,668,914.06 ns | 345,827.621 ns | 339,648.965 ns | 17,596,417.19 ns |
|    HashSetPlannedCapacity | 1000000 |  8,475,631.97 ns |  97,790.202 ns |  81,659.248 ns |  8,479,632.81 ns |
| DictionaryDynamicCapacity | 1000000 | 20,343,616.67 ns | 404,671.310 ns | 567,292.659 ns | 20,241,881.25 ns |
| DictionaryPlannedCapacity | 1000000 |  9,823,887.11 ns | 175,312.740 ns | 136,872.656 ns |  9,786,100.78 ns |