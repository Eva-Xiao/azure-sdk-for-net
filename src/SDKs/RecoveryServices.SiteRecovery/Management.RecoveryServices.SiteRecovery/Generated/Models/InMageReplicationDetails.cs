// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// InMage provider specific settings
    /// </summary>
    [Newtonsoft.Json.JsonObject("InMage")]
    public partial class InMageReplicationDetails : ReplicationProviderSpecificSettings
    {
        /// <summary>
        /// Initializes a new instance of the InMageReplicationDetails class.
        /// </summary>
        public InMageReplicationDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InMageReplicationDetails class.
        /// </summary>
        /// <param name="activeSiteType">The active location of the VM. If the
        /// VM is being protected from Azure, this field will take values from
        /// { Azure, OnPrem }. If the VM is being protected between two
        /// data-centers, this field will be OnPrem always.</param>
        /// <param name="sourceVmCPUCount">The CPU count of the VM on the
        /// primary side.</param>
        /// <param name="sourceVmRAMSizeInMB">The RAM size of the VM on the
        /// primary side.</param>
        /// <param name="osDetails">The OS details.</param>
        /// <param name="protectionStage">The protection stage.</param>
        /// <param name="vmId">The virtual machine Id.</param>
        /// <param name="vmProtectionState">The protection state for the
        /// vm.</param>
        /// <param name="vmProtectionStateDescription">The protection state
        /// description for the vm.</param>
        /// <param name="resyncDetails">The resync details of the
        /// machine</param>
        /// <param name="retentionWindowStart">The retention window start
        /// time.</param>
        /// <param name="retentionWindowEnd">The retention window end
        /// time.</param>
        /// <param name="compressedDataRateInMB">The compressed data change
        /// rate in MB.</param>
        /// <param name="uncompressedDataRateInMB">The uncompressed data change
        /// rate in MB.</param>
        /// <param name="rpoInSeconds">The RPO in seconds.</param>
        /// <param name="protectedDisks">The list of protected disks.</param>
        /// <param name="ipAddress">The source IP address.</param>
        /// <param name="lastHeartbeat">The last heartbeat received from the
        /// source server.</param>
        /// <param name="processServerId">The process server Id.</param>
        /// <param name="masterTargetId">The master target Id.</param>
        /// <param name="consistencyPoints">The collection of Consistency
        /// points.</param>
        /// <param name="diskResized">A value indicating whether any disk is
        /// resized for this VM.</param>
        /// <param name="rebootAfterUpdateStatus">A value indicating whether
        /// the source server requires a restart after update.</param>
        /// <param name="multiVmGroupId">The multi vm group Id, if any.</param>
        /// <param name="multiVmGroupName">The multi vm group name, if
        /// any.</param>
        /// <param name="multiVmSyncStatus">A value indicating whether the
        /// multi vm sync is enabled or disabled.</param>
        /// <param name="agentDetails">The agent details.</param>
        /// <param name="vCenterInfrastructureId">The vCenter infrastructure
        /// Id.</param>
        /// <param name="infrastructureVmId">The infrastructure VM Id.</param>
        /// <param name="vmNics">The PE Network details.</param>
        /// <param name="discoveryType">A value indicating the discovery type
        /// of the machine.</param>
        /// <param name="azureStorageAccountId">A value indicating the
        /// underlying Azure storage account. If the VM is not running in
        /// Azure, this value shall be set to null.</param>
        /// <param name="datastores">The datastores of the on-premise machine
        /// Value can be list of strings that contain datastore names</param>
        /// <param name="validationErrors">The validation errors of the
        /// on-premise machine Value can be list of validation errors</param>
        /// <param name="lastRpoCalculatedTime">The last RPO calculated
        /// time.</param>
        /// <param name="lastUpdateReceivedTime">The last update time received
        /// from on-prem components.</param>
        /// <param name="replicaId">The replica id of the protected
        /// item.</param>
        /// <param name="osVersion">The OS Version of the protected
        /// item.</param>
        public InMageReplicationDetails(string activeSiteType = default(string), int? sourceVmCPUCount = default(int?), int? sourceVmRAMSizeInMB = default(int?), OSDiskDetails osDetails = default(OSDiskDetails), string protectionStage = default(string), string vmId = default(string), string vmProtectionState = default(string), string vmProtectionStateDescription = default(string), InitialReplicationDetails resyncDetails = default(InitialReplicationDetails), System.DateTime? retentionWindowStart = default(System.DateTime?), System.DateTime? retentionWindowEnd = default(System.DateTime?), double? compressedDataRateInMB = default(double?), double? uncompressedDataRateInMB = default(double?), long? rpoInSeconds = default(long?), IList<InMageProtectedDiskDetails> protectedDisks = default(IList<InMageProtectedDiskDetails>), string ipAddress = default(string), System.DateTime? lastHeartbeat = default(System.DateTime?), string processServerId = default(string), string masterTargetId = default(string), IDictionary<string, System.DateTime?> consistencyPoints = default(IDictionary<string, System.DateTime?>), string diskResized = default(string), string rebootAfterUpdateStatus = default(string), string multiVmGroupId = default(string), string multiVmGroupName = default(string), string multiVmSyncStatus = default(string), InMageAgentDetails agentDetails = default(InMageAgentDetails), string vCenterInfrastructureId = default(string), string infrastructureVmId = default(string), IList<VMNicDetails> vmNics = default(IList<VMNicDetails>), string discoveryType = default(string), string azureStorageAccountId = default(string), IList<string> datastores = default(IList<string>), IList<HealthError> validationErrors = default(IList<HealthError>), System.DateTime? lastRpoCalculatedTime = default(System.DateTime?), System.DateTime? lastUpdateReceivedTime = default(System.DateTime?), string replicaId = default(string), string osVersion = default(string))
        {
            ActiveSiteType = activeSiteType;
            SourceVmCPUCount = sourceVmCPUCount;
            SourceVmRAMSizeInMB = sourceVmRAMSizeInMB;
            OsDetails = osDetails;
            ProtectionStage = protectionStage;
            VmId = vmId;
            VmProtectionState = vmProtectionState;
            VmProtectionStateDescription = vmProtectionStateDescription;
            ResyncDetails = resyncDetails;
            RetentionWindowStart = retentionWindowStart;
            RetentionWindowEnd = retentionWindowEnd;
            CompressedDataRateInMB = compressedDataRateInMB;
            UncompressedDataRateInMB = uncompressedDataRateInMB;
            RpoInSeconds = rpoInSeconds;
            ProtectedDisks = protectedDisks;
            IpAddress = ipAddress;
            LastHeartbeat = lastHeartbeat;
            ProcessServerId = processServerId;
            MasterTargetId = masterTargetId;
            ConsistencyPoints = consistencyPoints;
            DiskResized = diskResized;
            RebootAfterUpdateStatus = rebootAfterUpdateStatus;
            MultiVmGroupId = multiVmGroupId;
            MultiVmGroupName = multiVmGroupName;
            MultiVmSyncStatus = multiVmSyncStatus;
            AgentDetails = agentDetails;
            VCenterInfrastructureId = vCenterInfrastructureId;
            InfrastructureVmId = infrastructureVmId;
            VmNics = vmNics;
            DiscoveryType = discoveryType;
            AzureStorageAccountId = azureStorageAccountId;
            Datastores = datastores;
            ValidationErrors = validationErrors;
            LastRpoCalculatedTime = lastRpoCalculatedTime;
            LastUpdateReceivedTime = lastUpdateReceivedTime;
            ReplicaId = replicaId;
            OsVersion = osVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the active location of the VM. If the VM is being
        /// protected from Azure, this field will take values from { Azure,
        /// OnPrem }. If the VM is being protected between two data-centers,
        /// this field will be OnPrem always.
        /// </summary>
        [JsonProperty(PropertyName = "activeSiteType")]
        public string ActiveSiteType { get; set; }

        /// <summary>
        /// Gets or sets the CPU count of the VM on the primary side.
        /// </summary>
        [JsonProperty(PropertyName = "sourceVmCPUCount")]
        public int? SourceVmCPUCount { get; set; }

        /// <summary>
        /// Gets or sets the RAM size of the VM on the primary side.
        /// </summary>
        [JsonProperty(PropertyName = "sourceVmRAMSizeInMB")]
        public int? SourceVmRAMSizeInMB { get; set; }

        /// <summary>
        /// Gets or sets the OS details.
        /// </summary>
        [JsonProperty(PropertyName = "osDetails")]
        public OSDiskDetails OsDetails { get; set; }

        /// <summary>
        /// Gets or sets the protection stage.
        /// </summary>
        [JsonProperty(PropertyName = "protectionStage")]
        public string ProtectionStage { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine Id.
        /// </summary>
        [JsonProperty(PropertyName = "vmId")]
        public string VmId { get; set; }

        /// <summary>
        /// Gets or sets the protection state for the vm.
        /// </summary>
        [JsonProperty(PropertyName = "vmProtectionState")]
        public string VmProtectionState { get; set; }

        /// <summary>
        /// Gets or sets the protection state description for the vm.
        /// </summary>
        [JsonProperty(PropertyName = "vmProtectionStateDescription")]
        public string VmProtectionStateDescription { get; set; }

        /// <summary>
        /// Gets or sets the resync details of the machine
        /// </summary>
        [JsonProperty(PropertyName = "resyncDetails")]
        public InitialReplicationDetails ResyncDetails { get; set; }

        /// <summary>
        /// Gets or sets the retention window start time.
        /// </summary>
        [JsonProperty(PropertyName = "retentionWindowStart")]
        public System.DateTime? RetentionWindowStart { get; set; }

        /// <summary>
        /// Gets or sets the retention window end time.
        /// </summary>
        [JsonProperty(PropertyName = "retentionWindowEnd")]
        public System.DateTime? RetentionWindowEnd { get; set; }

        /// <summary>
        /// Gets or sets the compressed data change rate in MB.
        /// </summary>
        [JsonProperty(PropertyName = "compressedDataRateInMB")]
        public double? CompressedDataRateInMB { get; set; }

        /// <summary>
        /// Gets or sets the uncompressed data change rate in MB.
        /// </summary>
        [JsonProperty(PropertyName = "uncompressedDataRateInMB")]
        public double? UncompressedDataRateInMB { get; set; }

        /// <summary>
        /// Gets or sets the RPO in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "rpoInSeconds")]
        public long? RpoInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the list of protected disks.
        /// </summary>
        [JsonProperty(PropertyName = "protectedDisks")]
        public IList<InMageProtectedDiskDetails> ProtectedDisks { get; set; }

        /// <summary>
        /// Gets or sets the source IP address.
        /// </summary>
        [JsonProperty(PropertyName = "ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the last heartbeat received from the source server.
        /// </summary>
        [JsonProperty(PropertyName = "lastHeartbeat")]
        public System.DateTime? LastHeartbeat { get; set; }

        /// <summary>
        /// Gets or sets the process server Id.
        /// </summary>
        [JsonProperty(PropertyName = "processServerId")]
        public string ProcessServerId { get; set; }

        /// <summary>
        /// Gets or sets the master target Id.
        /// </summary>
        [JsonProperty(PropertyName = "masterTargetId")]
        public string MasterTargetId { get; set; }

        /// <summary>
        /// Gets or sets the collection of Consistency points.
        /// </summary>
        [JsonProperty(PropertyName = "consistencyPoints")]
        public IDictionary<string, System.DateTime?> ConsistencyPoints { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether any disk is resized for
        /// this VM.
        /// </summary>
        [JsonProperty(PropertyName = "diskResized")]
        public string DiskResized { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the source server requires
        /// a restart after update.
        /// </summary>
        [JsonProperty(PropertyName = "rebootAfterUpdateStatus")]
        public string RebootAfterUpdateStatus { get; set; }

        /// <summary>
        /// Gets or sets the multi vm group Id, if any.
        /// </summary>
        [JsonProperty(PropertyName = "multiVmGroupId")]
        public string MultiVmGroupId { get; set; }

        /// <summary>
        /// Gets or sets the multi vm group name, if any.
        /// </summary>
        [JsonProperty(PropertyName = "multiVmGroupName")]
        public string MultiVmGroupName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the multi vm sync is
        /// enabled or disabled.
        /// </summary>
        [JsonProperty(PropertyName = "multiVmSyncStatus")]
        public string MultiVmSyncStatus { get; set; }

        /// <summary>
        /// Gets or sets the agent details.
        /// </summary>
        [JsonProperty(PropertyName = "agentDetails")]
        public InMageAgentDetails AgentDetails { get; set; }

        /// <summary>
        /// Gets or sets the vCenter infrastructure Id.
        /// </summary>
        [JsonProperty(PropertyName = "vCenterInfrastructureId")]
        public string VCenterInfrastructureId { get; set; }

        /// <summary>
        /// Gets or sets the infrastructure VM Id.
        /// </summary>
        [JsonProperty(PropertyName = "infrastructureVmId")]
        public string InfrastructureVmId { get; set; }

        /// <summary>
        /// Gets or sets the PE Network details.
        /// </summary>
        [JsonProperty(PropertyName = "vmNics")]
        public IList<VMNicDetails> VmNics { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the discovery type of the machine.
        /// </summary>
        [JsonProperty(PropertyName = "discoveryType")]
        public string DiscoveryType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the underlying Azure storage
        /// account. If the VM is not running in Azure, this value shall be set
        /// to null.
        /// </summary>
        [JsonProperty(PropertyName = "azureStorageAccountId")]
        public string AzureStorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the datastores of the on-premise machine Value can be
        /// list of strings that contain datastore names
        /// </summary>
        [JsonProperty(PropertyName = "datastores")]
        public IList<string> Datastores { get; set; }

        /// <summary>
        /// Gets or sets the validation errors of the on-premise machine Value
        /// can be list of validation errors
        /// </summary>
        [JsonProperty(PropertyName = "validationErrors")]
        public IList<HealthError> ValidationErrors { get; set; }

        /// <summary>
        /// Gets or sets the last RPO calculated time.
        /// </summary>
        [JsonProperty(PropertyName = "lastRpoCalculatedTime")]
        public System.DateTime? LastRpoCalculatedTime { get; set; }

        /// <summary>
        /// Gets or sets the last update time received from on-prem components.
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdateReceivedTime")]
        public System.DateTime? LastUpdateReceivedTime { get; set; }

        /// <summary>
        /// Gets or sets the replica id of the protected item.
        /// </summary>
        [JsonProperty(PropertyName = "replicaId")]
        public string ReplicaId { get; set; }

        /// <summary>
        /// Gets or sets the OS Version of the protected item.
        /// </summary>
        [JsonProperty(PropertyName = "osVersion")]
        public string OsVersion { get; set; }

    }
}
