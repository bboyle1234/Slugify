``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.1.300
  [Host]   : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT
  ShortRun : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT

Job=ShortRun  LaunchCount=1  TargetCount=3  
WarmupCount=3  

```
| Method |                   TestData |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
|------- |--------------------------- |---------:|----------:|----------:|-------:|----------:|
|  **Test2** |               **Short String** | **2.180 us** | **0.2969 us** | **0.0168 us** | **0.4005** |     **841 B** |
|  **Test2** | **Super @#$ Sdf fd#$3 String** | **5.592 us** | **0.5679 us** | **0.0321 us** | **1.4038** |    **2952 B** |
