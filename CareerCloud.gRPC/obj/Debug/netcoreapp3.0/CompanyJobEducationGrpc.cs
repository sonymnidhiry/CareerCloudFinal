// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/CompanyJobEducation.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace CareerCloud.gRPC.Protos {
  public static partial class CompanyJobEducation
  {
    static readonly string __ServiceName = "CareerCloud.gRPC.CompanyJobEducation";

    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.CompanyJobEducationIdRequest> __Marshaller_CareerCloud_gRPC_CompanyJobEducationIdRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CareerCloud.gRPC.Protos.CompanyJobEducationIdRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.CompanyJobEducationPayload> __Marshaller_CareerCloud_gRPC_CompanyJobEducationPayload = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CareerCloud.gRPC.Protos.CompanyJobEducationPayload.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.CompanyJobEducationIdRequest, global::CareerCloud.gRPC.Protos.CompanyJobEducationPayload> __Method_ReadCompanyJobEducation = new grpc::Method<global::CareerCloud.gRPC.Protos.CompanyJobEducationIdRequest, global::CareerCloud.gRPC.Protos.CompanyJobEducationPayload>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReadCompanyJobEducation",
        __Marshaller_CareerCloud_gRPC_CompanyJobEducationIdRequest,
        __Marshaller_CareerCloud_gRPC_CompanyJobEducationPayload);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.CompanyJobEducationPayload, global::Google.Protobuf.WellKnownTypes.Empty> __Method_CreateCompanyJobEducation = new grpc::Method<global::CareerCloud.gRPC.Protos.CompanyJobEducationPayload, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateCompanyJobEducation",
        __Marshaller_CareerCloud_gRPC_CompanyJobEducationPayload,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.CompanyJobEducationPayload, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateCompanyJobEducation = new grpc::Method<global::CareerCloud.gRPC.Protos.CompanyJobEducationPayload, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateCompanyJobEducation",
        __Marshaller_CareerCloud_gRPC_CompanyJobEducationPayload,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.CompanyJobEducationPayload, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteCompanyJobEducation = new grpc::Method<global::CareerCloud.gRPC.Protos.CompanyJobEducationPayload, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteCompanyJobEducation",
        __Marshaller_CareerCloud_gRPC_CompanyJobEducationPayload,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CareerCloud.gRPC.Protos.CompanyJobEducationReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CompanyJobEducation</summary>
    [grpc::BindServiceMethod(typeof(CompanyJobEducation), "BindService")]
    public abstract partial class CompanyJobEducationBase
    {
      public virtual global::System.Threading.Tasks.Task<global::CareerCloud.gRPC.Protos.CompanyJobEducationPayload> ReadCompanyJobEducation(global::CareerCloud.gRPC.Protos.CompanyJobEducationIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> CreateCompanyJobEducation(global::CareerCloud.gRPC.Protos.CompanyJobEducationPayload request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UpdateCompanyJobEducation(global::CareerCloud.gRPC.Protos.CompanyJobEducationPayload request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteCompanyJobEducation(global::CareerCloud.gRPC.Protos.CompanyJobEducationPayload request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CompanyJobEducationBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ReadCompanyJobEducation, serviceImpl.ReadCompanyJobEducation)
          .AddMethod(__Method_CreateCompanyJobEducation, serviceImpl.CreateCompanyJobEducation)
          .AddMethod(__Method_UpdateCompanyJobEducation, serviceImpl.UpdateCompanyJobEducation)
          .AddMethod(__Method_DeleteCompanyJobEducation, serviceImpl.DeleteCompanyJobEducation).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CompanyJobEducationBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ReadCompanyJobEducation, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.CompanyJobEducationIdRequest, global::CareerCloud.gRPC.Protos.CompanyJobEducationPayload>(serviceImpl.ReadCompanyJobEducation));
      serviceBinder.AddMethod(__Method_CreateCompanyJobEducation, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.CompanyJobEducationPayload, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.CreateCompanyJobEducation));
      serviceBinder.AddMethod(__Method_UpdateCompanyJobEducation, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.CompanyJobEducationPayload, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.UpdateCompanyJobEducation));
      serviceBinder.AddMethod(__Method_DeleteCompanyJobEducation, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.CompanyJobEducationPayload, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteCompanyJobEducation));
    }

  }
}
#endregion
