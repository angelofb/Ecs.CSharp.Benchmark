```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.26100.3194)
Intel Core i5-10505 CPU 3.20GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  Job-EBYXND : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2

InvocationCount=1  UnrollFactor=1  

```
| Method           | EntityCount | Mean       | Error     | StdDev     | Median     | Gen0       | Gen1      | Gen2      | Allocated    |
|----------------- |------------ |-----------:|----------:|-----------:|-----------:|-----------:|----------:|----------:|-------------:|
| Frent            | 100000      |   1.188 ms | 0.0065 ms |  0.0050 ms |   1.186 ms |          - |         - |         - |   3713.63 KB |
| Frent_Bulk       | 100000      |   1.263 ms | 0.0241 ms |  0.0214 ms |   1.263 ms |          - |         - |         - |   3713.63 KB |
| FrifloEngineEcs  | 100000      |   2.933 ms | 0.0584 ms |  0.1588 ms |   2.952 ms |  1000.0000 | 1000.0000 | 1000.0000 |   3898.13 KB |
| Arch             | 100000      |   3.864 ms | 0.0731 ms |  0.1820 ms |   3.807 ms |          - |         - |         - |   3558.44 KB |
| LeopotamEcsLite  | 100000      |   4.599 ms | 0.2821 ms |  0.8319 ms |   4.426 ms |          - |         - |         - |   9199.61 KB |
| DefaultEcs       | 100000      |  10.217 ms | 0.2039 ms |  0.4302 ms |  10.202 ms |          - |         - |         - |   15418.9 KB |
| LeopotamEcs      | 100000      |  10.451 ms | 0.3019 ms |  0.8563 ms |  10.393 ms |  1000.0000 | 1000.0000 |         - |  14711.02 KB |
| FlecsNet         | 100000      |  14.295 ms | 0.2811 ms |  0.2492 ms |  14.221 ms |          - |         - |         - |      3.11 KB |
| MonoGameExtended | 100000      |  17.426 ms | 0.4421 ms |  1.1724 ms |  17.811 ms |  1000.0000 | 1000.0000 |         - |  23373.84 KB |
| TinyEcs          | 100000      |  19.518 ms | 0.4951 ms |  1.4443 ms |  18.828 ms |  2000.0000 | 1000.0000 |         - |  13785.08 KB |
| Fennecs          | 100000      |  19.817 ms | 0.3851 ms |  0.4584 ms |  19.786 ms |          - |         - |         - |  15174.45 KB |
| HypEcs           | 100000      |  21.669 ms | 0.3387 ms |  0.3002 ms |  21.641 ms |  5000.0000 | 3000.0000 | 1000.0000 |  45336.69 KB |
| Myriad           | 100000      |  23.799 ms | 0.4706 ms |  0.4402 ms |  23.629 ms |          - |         - |         - |   8028.55 KB |
| SveltoECS        | 100000      |  39.648 ms | 0.7873 ms |  1.8089 ms |  39.372 ms |          - |         - |         - |      4.14 KB |
| RelEcs           | 100000      |  60.414 ms | 1.2081 ms |  2.5217 ms |  60.124 ms |  5000.0000 | 2000.0000 |         - |  50749.86 KB |
| Morpeh_Stash     | 100000      |  75.880 ms | 1.3733 ms |  2.4763 ms |  75.308 ms |  6000.0000 | 3000.0000 | 1000.0000 |   48133.7 KB |
| Morpeh_Direct    | 100000      | 271.755 ms | 5.6171 ms | 16.5622 ms | 277.597 ms | 18000.0000 | 9000.0000 | 1000.0000 | 128861.64 KB |
