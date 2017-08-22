// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: HugePayload.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace  Shared.GeneratedCode{
  public static partial class HugePayloadService
  {
    static readonly string __ServiceName = "HugePayloadService";

    static readonly grpc::Marshaller<global::HugeRequest> __Marshaller_HugeRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HugeRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::HugeResponse> __Marshaller_HugeResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::HugeResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::HugeRequest, global::HugeResponse> __Method_SendHugePayload = new grpc::Method<global::HugeRequest, global::HugeResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SendHugePayload",
        __Marshaller_HugeRequest,
        __Marshaller_HugeResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::HugePayloadReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of HugePayloadService</summary>
    public abstract partial class HugePayloadServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::HugeResponse> SendHugePayload(global::HugeRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for HugePayloadService</summary>
    public partial class HugePayloadServiceClient : grpc::ClientBase<HugePayloadServiceClient>
    {
      /// <summary>Creates a new client for HugePayloadService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public HugePayloadServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for HugePayloadService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public HugePayloadServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected HugePayloadServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected HugePayloadServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::HugeResponse SendHugePayload(global::HugeRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SendHugePayload(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::HugeResponse SendHugePayload(global::HugeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SendHugePayload, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::HugeResponse> SendHugePayloadAsync(global::HugeRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SendHugePayloadAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::HugeResponse> SendHugePayloadAsync(global::HugeRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SendHugePayload, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override HugePayloadServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new HugePayloadServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(HugePayloadServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SendHugePayload, serviceImpl.SendHugePayload).Build();
    }

  }
}
#endregion