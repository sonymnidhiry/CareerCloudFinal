// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/SecurityLoginsRole.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace CareerCloud.gRPC.Protos {
  public static partial class SecurityLoginsRole
  {
    static readonly string __ServiceName = "CareerCloud.gRPC.SecurityLoginsRole";

    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.SecurityLoginsRoleIdRequest> __Marshaller_CareerCloud_gRPC_SecurityLoginsRoleIdRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CareerCloud.gRPC.Protos.SecurityLoginsRoleIdRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.SecurityLoginsRolePayload> __Marshaller_CareerCloud_gRPC_SecurityLoginsRolePayload = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CareerCloud.gRPC.Protos.SecurityLoginsRolePayload.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.SecurityLoginsRoleIdRequest, global::CareerCloud.gRPC.Protos.SecurityLoginsRolePayload> __Method_ReadSecurityLoginsRole = new grpc::Method<global::CareerCloud.gRPC.Protos.SecurityLoginsRoleIdRequest, global::CareerCloud.gRPC.Protos.SecurityLoginsRolePayload>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReadSecurityLoginsRole",
        __Marshaller_CareerCloud_gRPC_SecurityLoginsRoleIdRequest,
        __Marshaller_CareerCloud_gRPC_SecurityLoginsRolePayload);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.SecurityLoginsRolePayload, global::Google.Protobuf.WellKnownTypes.Empty> __Method_CreateSecurityLoginsRole = new grpc::Method<global::CareerCloud.gRPC.Protos.SecurityLoginsRolePayload, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateSecurityLoginsRole",
        __Marshaller_CareerCloud_gRPC_SecurityLoginsRolePayload,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.SecurityLoginsRolePayload, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateSecurityLoginsRole = new grpc::Method<global::CareerCloud.gRPC.Protos.SecurityLoginsRolePayload, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateSecurityLoginsRole",
        __Marshaller_CareerCloud_gRPC_SecurityLoginsRolePayload,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.SecurityLoginsRolePayload, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteSecurityLoginsRole = new grpc::Method<global::CareerCloud.gRPC.Protos.SecurityLoginsRolePayload, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteSecurityLoginsRole",
        __Marshaller_CareerCloud_gRPC_SecurityLoginsRolePayload,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CareerCloud.gRPC.Protos.SecurityLoginsRoleReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SecurityLoginsRole</summary>
    [grpc::BindServiceMethod(typeof(SecurityLoginsRole), "BindService")]
    public abstract partial class SecurityLoginsRoleBase
    {
      public virtual global::System.Threading.Tasks.Task<global::CareerCloud.gRPC.Protos.SecurityLoginsRolePayload> ReadSecurityLoginsRole(global::CareerCloud.gRPC.Protos.SecurityLoginsRoleIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> CreateSecurityLoginsRole(global::CareerCloud.gRPC.Protos.SecurityLoginsRolePayload request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UpdateSecurityLoginsRole(global::CareerCloud.gRPC.Protos.SecurityLoginsRolePayload request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteSecurityLoginsRole(global::CareerCloud.gRPC.Protos.SecurityLoginsRolePayload request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(SecurityLoginsRoleBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ReadSecurityLoginsRole, serviceImpl.ReadSecurityLoginsRole)
          .AddMethod(__Method_CreateSecurityLoginsRole, serviceImpl.CreateSecurityLoginsRole)
          .AddMethod(__Method_UpdateSecurityLoginsRole, serviceImpl.UpdateSecurityLoginsRole)
          .AddMethod(__Method_DeleteSecurityLoginsRole, serviceImpl.DeleteSecurityLoginsRole).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SecurityLoginsRoleBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ReadSecurityLoginsRole, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.SecurityLoginsRoleIdRequest, global::CareerCloud.gRPC.Protos.SecurityLoginsRolePayload>(serviceImpl.ReadSecurityLoginsRole));
      serviceBinder.AddMethod(__Method_CreateSecurityLoginsRole, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.SecurityLoginsRolePayload, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.CreateSecurityLoginsRole));
      serviceBinder.AddMethod(__Method_UpdateSecurityLoginsRole, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.SecurityLoginsRolePayload, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.UpdateSecurityLoginsRole));
      serviceBinder.AddMethod(__Method_DeleteSecurityLoginsRole, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.SecurityLoginsRolePayload, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteSecurityLoginsRole));
    }

  }
}
#endregion
