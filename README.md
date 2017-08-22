# Grpc vs Json Performance Test on .NET Core 2.0

Benchmarked with [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet) library.

### Versions
**GRPC library version**: 1.4.1

**ASP.NET Core version**: 2.0, **Newtonsoft.Json**: 10.0.3

### Servers

**GRPC**: Benchmarked against GRPC server.

**Json**: Benchmarked against ASP.NET Core 2.0 (Kestrel + MVC framework).

### Clients
**GRPC**: .NET Core 2.0 console app.

**Json**: .NET Core 2.0 console app.

## GRPC Result

``` ini

BenchmarkDotNet=v0.10.9, OS=Windows 10 Threshold 2 (10.0.10586)
Processor=Intel Core i7-5500U CPU 2.40GHz (Broadwell), ProcessorCount=4
Frequency=2338332 Hz, Resolution=427.6553 ns, Timer=TSC
.NET Core SDK=2.0.0
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


```
 |                   Method |     Mean |    Error |   StdDev |
 |------------------------- |---------:|---------:|---------:|
 | SendSmallRequestToServer | 138.7 us | 2.349 us | 2.082 us |
 |  SendHugeRequestToServer | 277.9 us | 5.124 us | 5.483 us |
 

## Json Result

``` ini

BenchmarkDotNet=v0.10.9, OS=Windows 10 Threshold 2 (10.0.10586)
Processor=Intel Core i7-5500U CPU 2.40GHz (Broadwell), ProcessorCount=4
Frequency=2338332 Hz, Resolution=427.6553 ns, Timer=TSC
.NET Core SDK=2.0.0
  [Host]     : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.0 (Framework 4.6.00001.0), 64bit RyuJIT


```
 |                   Method |     Mean |    Error |   StdDev |   Median |
 |------------------------- |---------:|---------:|---------:|---------:|
 | SendSmallRequestToServer | 613.5 us | 20.30 us | 56.26 us | 590.5 us |
 |  SendHugeRequestToServer | 964.1 us | 20.12 us | 39.71 us | 950.1 us |

## How to run the tests
Open 2 separate command window and run the servers.

```
cd "Grpc.Json.PerformanceTest\JsonServer"
dotnet run -c Release
```
```
cd "Grpc.Json.PerformanceTest\GrpcServer"
dotnet run -c Release
```

And then the testrunners:

```
cd "Grpc.Json.PerformanceTest\JsonClient"
dotnet run -c Release
```


```
cd "Grpc.Json.PerformanceTest\GrpcClient"
dotnet run -c Release
```
