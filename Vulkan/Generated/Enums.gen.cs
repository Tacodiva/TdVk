// This file is generated.

using System;

namespace Vulkan
{
    public enum VkImageLayout : int
    {
        ///<summary>Implicit layout an image is when its contents are undefined due to various reasons (e.g. right after creation)</summary>
        Undefined = 0,
        ///<summary>General layout when image can be used for any kind of access</summary>
        General = 1,
        ///<summary>Optimal layout when image is only used for color attachment read/write</summary>
        ColorAttachmentOptimal = 2,
        ///<summary>Optimal layout when image is only used for depth/stencil attachment read/write</summary>
        DepthStencilAttachmentOptimal = 3,
        ///<summary>Optimal layout when image is used for read only depth/stencil attachment and shader access</summary>
        DepthStencilReadOnlyOptimal = 4,
        ///<summary>Optimal layout when image is used for read only shader access</summary>
        ShaderReadOnlyOptimal = 5,
        ///<summary>Optimal layout when image is used only as source of transfer operations</summary>
        TransferSrcOptimal = 6,
        ///<summary>Optimal layout when image is used only as destination of transfer operations</summary>
        TransferDstOptimal = 7,
        ///<summary>Initial layout used when the data is populated by the CPU</summary>
        Preinitialized = 8,
        DepthReadOnlyStencilAttachmentOptimal = 1000117000,
        DepthAttachmentStencilReadOnlyOptimal = 1000117001,
        DepthAttachmentOptimal = 1000241000,
        DepthReadOnlyOptimal = 1000241001,
        StencilAttachmentOptimal = 1000241002,
        StencilReadOnlyOptimal = 1000241003,
        ReadOnlyOptimal = 1000314000,
        AttachmentOptimal = 1000314001,
        PresentSrcKHR = 1000001002,
        VideoDecodeDstKHR = 1000024000,
        VideoDecodeSrcKHR = 1000024001,
        VideoDecodeDpbKHR = 1000024002,
        SharedPresentKHR = 1000111000,
        FragmentDensityMapOptimalEXT = 1000218000,
        FragmentShadingRateAttachmentOptimalKHR = 1000164003,
        VideoEncodeDstKHR = 1000299000,
        VideoEncodeSrcKHR = 1000299001,
        VideoEncodeDpbKHR = 1000299002,
        AttachmentFeedbackLoopOptimalEXT = 1000339000,
    }
    public static partial class RawConstants
    {
        ///<summary>Implicit layout an image is when its contents are undefined due to various reasons (e.g. right after creation)</summary>
        public const VkImageLayout VK_IMAGE_LAYOUT_UNDEFINED = VkImageLayout.Undefined;
        ///<summary>General layout when image can be used for any kind of access</summary>
        public const VkImageLayout VK_IMAGE_LAYOUT_GENERAL = VkImageLayout.General;
        ///<summary>Optimal layout when image is only used for color attachment read/write</summary>
        public const VkImageLayout VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL = VkImageLayout.ColorAttachmentOptimal;
        ///<summary>Optimal layout when image is only used for depth/stencil attachment read/write</summary>
        public const VkImageLayout VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL = VkImageLayout.DepthStencilAttachmentOptimal;
        ///<summary>Optimal layout when image is used for read only depth/stencil attachment and shader access</summary>
        public const VkImageLayout VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL = VkImageLayout.DepthStencilReadOnlyOptimal;
        ///<summary>Optimal layout when image is used for read only shader access</summary>
        public const VkImageLayout VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL = VkImageLayout.ShaderReadOnlyOptimal;
        ///<summary>Optimal layout when image is used only as source of transfer operations</summary>
        public const VkImageLayout VK_IMAGE_LAYOUT_TRANSFER_SRC_OPTIMAL = VkImageLayout.TransferSrcOptimal;
        ///<summary>Optimal layout when image is used only as destination of transfer operations</summary>
        public const VkImageLayout VK_IMAGE_LAYOUT_TRANSFER_DST_OPTIMAL = VkImageLayout.TransferDstOptimal;
        ///<summary>Initial layout used when the data is populated by the CPU</summary>
        public const VkImageLayout VK_IMAGE_LAYOUT_PREINITIALIZED = VkImageLayout.Preinitialized;
        public const VkImageLayout VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_OPTIMAL = VkImageLayout.DepthReadOnlyStencilAttachmentOptimal;
        public const VkImageLayout VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_OPTIMAL = VkImageLayout.DepthAttachmentStencilReadOnlyOptimal;
        public const VkImageLayout VK_IMAGE_LAYOUT_DEPTH_ATTACHMENT_OPTIMAL = VkImageLayout.DepthAttachmentOptimal;
        public const VkImageLayout VK_IMAGE_LAYOUT_DEPTH_READ_ONLY_OPTIMAL = VkImageLayout.DepthReadOnlyOptimal;
        public const VkImageLayout VK_IMAGE_LAYOUT_STENCIL_ATTACHMENT_OPTIMAL = VkImageLayout.StencilAttachmentOptimal;
        public const VkImageLayout VK_IMAGE_LAYOUT_STENCIL_READ_ONLY_OPTIMAL = VkImageLayout.StencilReadOnlyOptimal;
        public const VkImageLayout VK_IMAGE_LAYOUT_READ_ONLY_OPTIMAL = VkImageLayout.ReadOnlyOptimal;
        public const VkImageLayout VK_IMAGE_LAYOUT_ATTACHMENT_OPTIMAL = VkImageLayout.AttachmentOptimal;
        public const VkImageLayout VK_IMAGE_LAYOUT_PRESENT_SRC_KHR = VkImageLayout.PresentSrcKHR;
        public const VkImageLayout VK_IMAGE_LAYOUT_VIDEO_DECODE_DST_KHR = VkImageLayout.VideoDecodeDstKHR;
        public const VkImageLayout VK_IMAGE_LAYOUT_VIDEO_DECODE_SRC_KHR = VkImageLayout.VideoDecodeSrcKHR;
        public const VkImageLayout VK_IMAGE_LAYOUT_VIDEO_DECODE_DPB_KHR = VkImageLayout.VideoDecodeDpbKHR;
        public const VkImageLayout VK_IMAGE_LAYOUT_SHARED_PRESENT_KHR = VkImageLayout.SharedPresentKHR;
        public const VkImageLayout VK_IMAGE_LAYOUT_FRAGMENT_DENSITY_MAP_OPTIMAL_EXT = VkImageLayout.FragmentDensityMapOptimalEXT;
        public const VkImageLayout VK_IMAGE_LAYOUT_FRAGMENT_SHADING_RATE_ATTACHMENT_OPTIMAL_KHR = VkImageLayout.FragmentShadingRateAttachmentOptimalKHR;
        public const VkImageLayout VK_IMAGE_LAYOUT_VIDEO_ENCODE_DST_KHR = VkImageLayout.VideoEncodeDstKHR;
        public const VkImageLayout VK_IMAGE_LAYOUT_VIDEO_ENCODE_SRC_KHR = VkImageLayout.VideoEncodeSrcKHR;
        public const VkImageLayout VK_IMAGE_LAYOUT_VIDEO_ENCODE_DPB_KHR = VkImageLayout.VideoEncodeDpbKHR;
        public const VkImageLayout VK_IMAGE_LAYOUT_ATTACHMENT_FEEDBACK_LOOP_OPTIMAL_EXT = VkImageLayout.AttachmentFeedbackLoopOptimalEXT;
    }

    public enum VkAttachmentLoadOp : int
    {
        Load = 0,
        Clear = 1,
        DontCare = 2,
        NoneEXT = 1000400000,
    }
    public static partial class RawConstants
    {
        public const VkAttachmentLoadOp VK_ATTACHMENT_LOAD_OP_LOAD = VkAttachmentLoadOp.Load;
        public const VkAttachmentLoadOp VK_ATTACHMENT_LOAD_OP_CLEAR = VkAttachmentLoadOp.Clear;
        public const VkAttachmentLoadOp VK_ATTACHMENT_LOAD_OP_DONT_CARE = VkAttachmentLoadOp.DontCare;
        public const VkAttachmentLoadOp VK_ATTACHMENT_LOAD_OP_NONE_EXT = VkAttachmentLoadOp.NoneEXT;
    }

    public enum VkAttachmentStoreOp : int
    {
        Store = 0,
        DontCare = 1,
        None = 1000301000,
    }
    public static partial class RawConstants
    {
        public const VkAttachmentStoreOp VK_ATTACHMENT_STORE_OP_STORE = VkAttachmentStoreOp.Store;
        public const VkAttachmentStoreOp VK_ATTACHMENT_STORE_OP_DONT_CARE = VkAttachmentStoreOp.DontCare;
        public const VkAttachmentStoreOp VK_ATTACHMENT_STORE_OP_NONE = VkAttachmentStoreOp.None;
    }

    public enum VkImageType : int
    {
        Image1D = 0,
        Image2D = 1,
        Image3D = 2,
    }
    public static partial class RawConstants
    {
        public const VkImageType VK_IMAGE_TYPE_1D = VkImageType.Image1D;
        public const VkImageType VK_IMAGE_TYPE_2D = VkImageType.Image2D;
        public const VkImageType VK_IMAGE_TYPE_3D = VkImageType.Image3D;
    }

    public enum VkImageTiling : int
    {
        Optimal = 0,
        Linear = 1,
        DrmFormatModifierEXT = 1000158000,
    }
    public static partial class RawConstants
    {
        public const VkImageTiling VK_IMAGE_TILING_OPTIMAL = VkImageTiling.Optimal;
        public const VkImageTiling VK_IMAGE_TILING_LINEAR = VkImageTiling.Linear;
        public const VkImageTiling VK_IMAGE_TILING_DRM_FORMAT_MODIFIER_EXT = VkImageTiling.DrmFormatModifierEXT;
    }

    public enum VkImageViewType : int
    {
        Image1D = 0,
        Image2D = 1,
        Image3D = 2,
        ImageCube = 3,
        Image1DArray = 4,
        Image2DArray = 5,
        ImageCubeArray = 6,
    }
    public static partial class RawConstants
    {
        public const VkImageViewType VK_IMAGE_VIEW_TYPE_1D = VkImageViewType.Image1D;
        public const VkImageViewType VK_IMAGE_VIEW_TYPE_2D = VkImageViewType.Image2D;
        public const VkImageViewType VK_IMAGE_VIEW_TYPE_3D = VkImageViewType.Image3D;
        public const VkImageViewType VK_IMAGE_VIEW_TYPE_CUBE = VkImageViewType.ImageCube;
        public const VkImageViewType VK_IMAGE_VIEW_TYPE_1D_ARRAY = VkImageViewType.Image1DArray;
        public const VkImageViewType VK_IMAGE_VIEW_TYPE_2D_ARRAY = VkImageViewType.Image2DArray;
        public const VkImageViewType VK_IMAGE_VIEW_TYPE_CUBE_ARRAY = VkImageViewType.ImageCubeArray;
    }

    public enum VkCommandBufferLevel : int
    {
        Primary = 0,
        Secondary = 1,
    }
    public static partial class RawConstants
    {
        public const VkCommandBufferLevel VK_COMMAND_BUFFER_LEVEL_PRIMARY = VkCommandBufferLevel.Primary;
        public const VkCommandBufferLevel VK_COMMAND_BUFFER_LEVEL_SECONDARY = VkCommandBufferLevel.Secondary;
    }

    public enum VkComponentSwizzle : int
    {
        Identity = 0,
        Zero = 1,
        One = 2,
        R = 3,
        G = 4,
        B = 5,
        A = 6,
    }
    public static partial class RawConstants
    {
        public const VkComponentSwizzle VK_COMPONENT_SWIZZLE_IDENTITY = VkComponentSwizzle.Identity;
        public const VkComponentSwizzle VK_COMPONENT_SWIZZLE_ZERO = VkComponentSwizzle.Zero;
        public const VkComponentSwizzle VK_COMPONENT_SWIZZLE_ONE = VkComponentSwizzle.One;
        public const VkComponentSwizzle VK_COMPONENT_SWIZZLE_R = VkComponentSwizzle.R;
        public const VkComponentSwizzle VK_COMPONENT_SWIZZLE_G = VkComponentSwizzle.G;
        public const VkComponentSwizzle VK_COMPONENT_SWIZZLE_B = VkComponentSwizzle.B;
        public const VkComponentSwizzle VK_COMPONENT_SWIZZLE_A = VkComponentSwizzle.A;
    }

    public enum VkDescriptorType : int
    {
        Sampler = 0,
        CombinedImageSampler = 1,
        SampledImage = 2,
        StorageImage = 3,
        UniformTexelBuffer = 4,
        StorageTexelBuffer = 5,
        UniformBuffer = 6,
        StorageBuffer = 7,
        UniformBufferDynamic = 8,
        StorageBufferDynamic = 9,
        InputAttachment = 10,
        InlineUniformBlock = 1000138000,
        AccelerationStructureKHR = 1000150000,
        AccelerationStructureNV = 1000165000,
        SampleWeightImageQcom = 1000440000,
        BlockMatchImageQcom = 1000440001,
        MutableEXT = 1000351000,
    }
    public static partial class RawConstants
    {
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_SAMPLER = VkDescriptorType.Sampler;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER = VkDescriptorType.CombinedImageSampler;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE = VkDescriptorType.SampledImage;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_STORAGE_IMAGE = VkDescriptorType.StorageImage;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER = VkDescriptorType.UniformTexelBuffer;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER = VkDescriptorType.StorageTexelBuffer;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER = VkDescriptorType.UniformBuffer;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_STORAGE_BUFFER = VkDescriptorType.StorageBuffer;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC = VkDescriptorType.UniformBufferDynamic;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC = VkDescriptorType.StorageBufferDynamic;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT = VkDescriptorType.InputAttachment;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_INLINE_UNIFORM_BLOCK = VkDescriptorType.InlineUniformBlock;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_KHR = VkDescriptorType.AccelerationStructureKHR;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_ACCELERATION_STRUCTURE_NV = VkDescriptorType.AccelerationStructureNV;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_SAMPLE_WEIGHT_IMAGE_QCOM = VkDescriptorType.SampleWeightImageQcom;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_BLOCK_MATCH_IMAGE_QCOM = VkDescriptorType.BlockMatchImageQcom;
        public const VkDescriptorType VK_DESCRIPTOR_TYPE_MUTABLE_EXT = VkDescriptorType.MutableEXT;
    }

    public enum VkQueryType : int
    {
        Occlusion = 0,
        ///<summary>Optional</summary>
        PipelineStatistics = 1,
        Timestamp = 2,
        ResultStatusOnlyKHR = 1000023000,
        TransformFeedbackStreamEXT = 1000028004,
        PerformanceQueryKHR = 1000116000,
        AccelerationStructureCompactedSizeKHR = 1000150000,
        AccelerationStructureSerializationSizeKHR = 1000150001,
        AccelerationStructureCompactedSizeNV = 1000165000,
        PerformanceQueryIntel = 1000210000,
        VideoEncodeFeedbackKHR = 1000299000,
        MeshPrimitivesGeneratedEXT = 1000328000,
        PrimitivesGeneratedEXT = 1000382000,
        AccelerationStructureSerializationBottomLevelPointersKHR = 1000386000,
        AccelerationStructureSizeKHR = 1000386001,
        MicromapSerializationSizeEXT = 1000396000,
        MicromapCompactedSizeEXT = 1000396001,
    }
    public static partial class RawConstants
    {
        public const VkQueryType VK_QUERY_TYPE_OCCLUSION = VkQueryType.Occlusion;
        ///<summary>Optional</summary>
        public const VkQueryType VK_QUERY_TYPE_PIPELINE_STATISTICS = VkQueryType.PipelineStatistics;
        public const VkQueryType VK_QUERY_TYPE_TIMESTAMP = VkQueryType.Timestamp;
        public const VkQueryType VK_QUERY_TYPE_RESULT_STATUS_ONLY_KHR = VkQueryType.ResultStatusOnlyKHR;
        public const VkQueryType VK_QUERY_TYPE_TRANSFORM_FEEDBACK_STREAM_EXT = VkQueryType.TransformFeedbackStreamEXT;
        public const VkQueryType VK_QUERY_TYPE_PERFORMANCE_QUERY_KHR = VkQueryType.PerformanceQueryKHR;
        public const VkQueryType VK_QUERY_TYPE_ACCELERATION_STRUCTURE_COMPACTED_SIZE_KHR = VkQueryType.AccelerationStructureCompactedSizeKHR;
        public const VkQueryType VK_QUERY_TYPE_ACCELERATION_STRUCTURE_SERIALIZATION_SIZE_KHR = VkQueryType.AccelerationStructureSerializationSizeKHR;
        public const VkQueryType VK_QUERY_TYPE_ACCELERATION_STRUCTURE_COMPACTED_SIZE_NV = VkQueryType.AccelerationStructureCompactedSizeNV;
        public const VkQueryType VK_QUERY_TYPE_PERFORMANCE_QUERY_INTEL = VkQueryType.PerformanceQueryIntel;
        public const VkQueryType VK_QUERY_TYPE_VIDEO_ENCODE_FEEDBACK_KHR = VkQueryType.VideoEncodeFeedbackKHR;
        public const VkQueryType VK_QUERY_TYPE_MESH_PRIMITIVES_GENERATED_EXT = VkQueryType.MeshPrimitivesGeneratedEXT;
        public const VkQueryType VK_QUERY_TYPE_PRIMITIVES_GENERATED_EXT = VkQueryType.PrimitivesGeneratedEXT;
        public const VkQueryType VK_QUERY_TYPE_ACCELERATION_STRUCTURE_SERIALIZATION_BOTTOM_LEVEL_POINTERS_KHR = VkQueryType.AccelerationStructureSerializationBottomLevelPointersKHR;
        public const VkQueryType VK_QUERY_TYPE_ACCELERATION_STRUCTURE_SIZE_KHR = VkQueryType.AccelerationStructureSizeKHR;
        public const VkQueryType VK_QUERY_TYPE_MICROMAP_SERIALIZATION_SIZE_EXT = VkQueryType.MicromapSerializationSizeEXT;
        public const VkQueryType VK_QUERY_TYPE_MICROMAP_COMPACTED_SIZE_EXT = VkQueryType.MicromapCompactedSizeEXT;
    }

    public enum VkBorderColor : int
    {
        FloatTransparentBlack = 0,
        IntTransparentBlack = 1,
        FloatOpaqueBlack = 2,
        IntOpaqueBlack = 3,
        FloatOpaqueWhite = 4,
        IntOpaqueWhite = 5,
        FloatCustomEXT = 1000287003,
        IntCustomEXT = 1000287004,
    }
    public static partial class RawConstants
    {
        public const VkBorderColor VK_BORDER_COLOR_FLOAT_TRANSPARENT_BLACK = VkBorderColor.FloatTransparentBlack;
        public const VkBorderColor VK_BORDER_COLOR_INT_TRANSPARENT_BLACK = VkBorderColor.IntTransparentBlack;
        public const VkBorderColor VK_BORDER_COLOR_FLOAT_OPAQUE_BLACK = VkBorderColor.FloatOpaqueBlack;
        public const VkBorderColor VK_BORDER_COLOR_INT_OPAQUE_BLACK = VkBorderColor.IntOpaqueBlack;
        public const VkBorderColor VK_BORDER_COLOR_FLOAT_OPAQUE_WHITE = VkBorderColor.FloatOpaqueWhite;
        public const VkBorderColor VK_BORDER_COLOR_INT_OPAQUE_WHITE = VkBorderColor.IntOpaqueWhite;
        public const VkBorderColor VK_BORDER_COLOR_FLOAT_CUSTOM_EXT = VkBorderColor.FloatCustomEXT;
        public const VkBorderColor VK_BORDER_COLOR_INT_CUSTOM_EXT = VkBorderColor.IntCustomEXT;
    }

    public enum VkPipelineBindPoint : int
    {
        Graphics = 0,
        Compute = 1,
        ExecutionGraphAmdx = 1000134000,
        RayTracingKHR = 1000165000,
        SubpassShadingHuawei = 1000369003,
    }
    public static partial class RawConstants
    {
        public const VkPipelineBindPoint VK_PIPELINE_BIND_POINT_GRAPHICS = VkPipelineBindPoint.Graphics;
        public const VkPipelineBindPoint VK_PIPELINE_BIND_POINT_COMPUTE = VkPipelineBindPoint.Compute;
        public const VkPipelineBindPoint VK_PIPELINE_BIND_POINT_EXECUTION_GRAPH_AMDX = VkPipelineBindPoint.ExecutionGraphAmdx;
        public const VkPipelineBindPoint VK_PIPELINE_BIND_POINT_RAY_TRACING_KHR = VkPipelineBindPoint.RayTracingKHR;
        public const VkPipelineBindPoint VK_PIPELINE_BIND_POINT_SUBPASS_SHADING_HUAWEI = VkPipelineBindPoint.SubpassShadingHuawei;
    }

    public enum VkPipelineCacheHeaderVersion : int
    {
        One = 1,
        SafetyCriticalOne = 1000298001,
    }
    public static partial class RawConstants
    {
        public const VkPipelineCacheHeaderVersion VK_PIPELINE_CACHE_HEADER_VERSION_ONE = VkPipelineCacheHeaderVersion.One;
        public const VkPipelineCacheHeaderVersion VK_PIPELINE_CACHE_HEADER_VERSION_SAFETY_CRITICAL_ONE = VkPipelineCacheHeaderVersion.SafetyCriticalOne;
    }

    [Flags]
    public enum VkPipelineCacheCreateFlags : int
    {
        None = 0,
        ExternallySynchronized = 1,
        ReadOnly = 2,
        UseApplicationStorage = 4,
    }
    public static partial class RawConstants
    {
        public const VkPipelineCacheCreateFlags VK_PIPELINE_CACHE_CREATE_EXTERNALLY_SYNCHRONIZED_BIT = VkPipelineCacheCreateFlags.ExternallySynchronized;
        public const VkPipelineCacheCreateFlags VK_PIPELINE_CACHE_CREATE_READ_ONLY_BIT = VkPipelineCacheCreateFlags.ReadOnly;
        public const VkPipelineCacheCreateFlags VK_PIPELINE_CACHE_CREATE_USE_APPLICATION_STORAGE_BIT = VkPipelineCacheCreateFlags.UseApplicationStorage;
    }

    public enum VkPrimitiveTopology : int
    {
        PointList = 0,
        LineList = 1,
        LineStrip = 2,
        TriangleList = 3,
        TriangleStrip = 4,
        TriangleFan = 5,
        LineListWithAdjacency = 6,
        LineStripWithAdjacency = 7,
        TriangleListWithAdjacency = 8,
        TriangleStripWithAdjacency = 9,
        PatchList = 10,
    }
    public static partial class RawConstants
    {
        public const VkPrimitiveTopology VK_PRIMITIVE_TOPOLOGY_POINT_LIST = VkPrimitiveTopology.PointList;
        public const VkPrimitiveTopology VK_PRIMITIVE_TOPOLOGY_LINE_LIST = VkPrimitiveTopology.LineList;
        public const VkPrimitiveTopology VK_PRIMITIVE_TOPOLOGY_LINE_STRIP = VkPrimitiveTopology.LineStrip;
        public const VkPrimitiveTopology VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST = VkPrimitiveTopology.TriangleList;
        public const VkPrimitiveTopology VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP = VkPrimitiveTopology.TriangleStrip;
        public const VkPrimitiveTopology VK_PRIMITIVE_TOPOLOGY_TRIANGLE_FAN = VkPrimitiveTopology.TriangleFan;
        public const VkPrimitiveTopology VK_PRIMITIVE_TOPOLOGY_LINE_LIST_WITH_ADJACENCY = VkPrimitiveTopology.LineListWithAdjacency;
        public const VkPrimitiveTopology VK_PRIMITIVE_TOPOLOGY_LINE_STRIP_WITH_ADJACENCY = VkPrimitiveTopology.LineStripWithAdjacency;
        public const VkPrimitiveTopology VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST_WITH_ADJACENCY = VkPrimitiveTopology.TriangleListWithAdjacency;
        public const VkPrimitiveTopology VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP_WITH_ADJACENCY = VkPrimitiveTopology.TriangleStripWithAdjacency;
        public const VkPrimitiveTopology VK_PRIMITIVE_TOPOLOGY_PATCH_LIST = VkPrimitiveTopology.PatchList;
    }

    public enum VkSharingMode : int
    {
        Exclusive = 0,
        Concurrent = 1,
    }
    public static partial class RawConstants
    {
        public const VkSharingMode VK_SHARING_MODE_EXCLUSIVE = VkSharingMode.Exclusive;
        public const VkSharingMode VK_SHARING_MODE_CONCURRENT = VkSharingMode.Concurrent;
    }

    public enum VkIndexType : int
    {
        Uint16 = 0,
        Uint32 = 1,
        NoneKHR = 1000165000,
        Uint8EXT = 1000265000,
    }
    public static partial class RawConstants
    {
        public const VkIndexType VK_INDEX_TYPE_UINT16 = VkIndexType.Uint16;
        public const VkIndexType VK_INDEX_TYPE_UINT32 = VkIndexType.Uint32;
        public const VkIndexType VK_INDEX_TYPE_NONE_KHR = VkIndexType.NoneKHR;
        public const VkIndexType VK_INDEX_TYPE_UINT8_EXT = VkIndexType.Uint8EXT;
    }

    public enum VkFilter : int
    {
        Nearest = 0,
        Linear = 1,
        CubicEXT = 1000015000,
    }
    public static partial class RawConstants
    {
        public const VkFilter VK_FILTER_NEAREST = VkFilter.Nearest;
        public const VkFilter VK_FILTER_LINEAR = VkFilter.Linear;
        public const VkFilter VK_FILTER_CUBIC_EXT = VkFilter.CubicEXT;
    }

    public enum VkSamplerMipmapMode : int
    {
        ///<summary>Choose nearest mip level</summary>
        Nearest = 0,
        ///<summary>Linear filter between mip levels</summary>
        Linear = 1,
    }
    public static partial class RawConstants
    {
        ///<summary>Choose nearest mip level</summary>
        public const VkSamplerMipmapMode VK_SAMPLER_MIPMAP_MODE_NEAREST = VkSamplerMipmapMode.Nearest;
        ///<summary>Linear filter between mip levels</summary>
        public const VkSamplerMipmapMode VK_SAMPLER_MIPMAP_MODE_LINEAR = VkSamplerMipmapMode.Linear;
    }

    public enum VkSamplerAddressMode : int
    {
        Repeat = 0,
        MirroredRepeat = 1,
        ClampToEdge = 2,
        ClampToBorder = 3,
        MirrorClampToEdge = 4,
    }
    public static partial class RawConstants
    {
        public const VkSamplerAddressMode VK_SAMPLER_ADDRESS_MODE_REPEAT = VkSamplerAddressMode.Repeat;
        public const VkSamplerAddressMode VK_SAMPLER_ADDRESS_MODE_MIRRORED_REPEAT = VkSamplerAddressMode.MirroredRepeat;
        public const VkSamplerAddressMode VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_EDGE = VkSamplerAddressMode.ClampToEdge;
        public const VkSamplerAddressMode VK_SAMPLER_ADDRESS_MODE_CLAMP_TO_BORDER = VkSamplerAddressMode.ClampToBorder;
        public const VkSamplerAddressMode VK_SAMPLER_ADDRESS_MODE_MIRROR_CLAMP_TO_EDGE = VkSamplerAddressMode.MirrorClampToEdge;
    }

    public enum VkCompareOp : int
    {
        Never = 0,
        Less = 1,
        Equal = 2,
        LessOrEqual = 3,
        Greater = 4,
        NotEqual = 5,
        GreaterOrEqual = 6,
        Always = 7,
    }
    public static partial class RawConstants
    {
        public const VkCompareOp VK_COMPARE_OP_NEVER = VkCompareOp.Never;
        public const VkCompareOp VK_COMPARE_OP_LESS = VkCompareOp.Less;
        public const VkCompareOp VK_COMPARE_OP_EQUAL = VkCompareOp.Equal;
        public const VkCompareOp VK_COMPARE_OP_LESS_OR_EQUAL = VkCompareOp.LessOrEqual;
        public const VkCompareOp VK_COMPARE_OP_GREATER = VkCompareOp.Greater;
        public const VkCompareOp VK_COMPARE_OP_NOT_EQUAL = VkCompareOp.NotEqual;
        public const VkCompareOp VK_COMPARE_OP_GREATER_OR_EQUAL = VkCompareOp.GreaterOrEqual;
        public const VkCompareOp VK_COMPARE_OP_ALWAYS = VkCompareOp.Always;
    }

    public enum VkPolygonMode : int
    {
        Fill = 0,
        Line = 1,
        Point = 2,
        FillRectangleNV = 1000153000,
    }
    public static partial class RawConstants
    {
        public const VkPolygonMode VK_POLYGON_MODE_FILL = VkPolygonMode.Fill;
        public const VkPolygonMode VK_POLYGON_MODE_LINE = VkPolygonMode.Line;
        public const VkPolygonMode VK_POLYGON_MODE_POINT = VkPolygonMode.Point;
        public const VkPolygonMode VK_POLYGON_MODE_FILL_RECTANGLE_NV = VkPolygonMode.FillRectangleNV;
    }

    public enum VkFrontFace : int
    {
        CounterClockwise = 0,
        Clockwise = 1,
    }
    public static partial class RawConstants
    {
        public const VkFrontFace VK_FRONT_FACE_COUNTER_CLOCKWISE = VkFrontFace.CounterClockwise;
        public const VkFrontFace VK_FRONT_FACE_CLOCKWISE = VkFrontFace.Clockwise;
    }

    public enum VkBlendFactor : int
    {
        Zero = 0,
        One = 1,
        SrcColor = 2,
        OneMinusSrcColor = 3,
        DstColor = 4,
        OneMinusDstColor = 5,
        SrcAlpha = 6,
        OneMinusSrcAlpha = 7,
        DstAlpha = 8,
        OneMinusDstAlpha = 9,
        ConstantColor = 10,
        OneMinusConstantColor = 11,
        ConstantAlpha = 12,
        OneMinusConstantAlpha = 13,
        SrcAlphaSaturate = 14,
        Src1Color = 15,
        OneMinusSrc1Color = 16,
        Src1Alpha = 17,
        OneMinusSrc1Alpha = 18,
    }
    public static partial class RawConstants
    {
        public const VkBlendFactor VK_BLEND_FACTOR_ZERO = VkBlendFactor.Zero;
        public const VkBlendFactor VK_BLEND_FACTOR_ONE = VkBlendFactor.One;
        public const VkBlendFactor VK_BLEND_FACTOR_SRC_COLOR = VkBlendFactor.SrcColor;
        public const VkBlendFactor VK_BLEND_FACTOR_ONE_MINUS_SRC_COLOR = VkBlendFactor.OneMinusSrcColor;
        public const VkBlendFactor VK_BLEND_FACTOR_DST_COLOR = VkBlendFactor.DstColor;
        public const VkBlendFactor VK_BLEND_FACTOR_ONE_MINUS_DST_COLOR = VkBlendFactor.OneMinusDstColor;
        public const VkBlendFactor VK_BLEND_FACTOR_SRC_ALPHA = VkBlendFactor.SrcAlpha;
        public const VkBlendFactor VK_BLEND_FACTOR_ONE_MINUS_SRC_ALPHA = VkBlendFactor.OneMinusSrcAlpha;
        public const VkBlendFactor VK_BLEND_FACTOR_DST_ALPHA = VkBlendFactor.DstAlpha;
        public const VkBlendFactor VK_BLEND_FACTOR_ONE_MINUS_DST_ALPHA = VkBlendFactor.OneMinusDstAlpha;
        public const VkBlendFactor VK_BLEND_FACTOR_CONSTANT_COLOR = VkBlendFactor.ConstantColor;
        public const VkBlendFactor VK_BLEND_FACTOR_ONE_MINUS_CONSTANT_COLOR = VkBlendFactor.OneMinusConstantColor;
        public const VkBlendFactor VK_BLEND_FACTOR_CONSTANT_ALPHA = VkBlendFactor.ConstantAlpha;
        public const VkBlendFactor VK_BLEND_FACTOR_ONE_MINUS_CONSTANT_ALPHA = VkBlendFactor.OneMinusConstantAlpha;
        public const VkBlendFactor VK_BLEND_FACTOR_SRC_ALPHA_SATURATE = VkBlendFactor.SrcAlphaSaturate;
        public const VkBlendFactor VK_BLEND_FACTOR_SRC1_COLOR = VkBlendFactor.Src1Color;
        public const VkBlendFactor VK_BLEND_FACTOR_ONE_MINUS_SRC1_COLOR = VkBlendFactor.OneMinusSrc1Color;
        public const VkBlendFactor VK_BLEND_FACTOR_SRC1_ALPHA = VkBlendFactor.Src1Alpha;
        public const VkBlendFactor VK_BLEND_FACTOR_ONE_MINUS_SRC1_ALPHA = VkBlendFactor.OneMinusSrc1Alpha;
    }

    public enum VkBlendOp : int
    {
        Add = 0,
        Subtract = 1,
        ReverseSubtract = 2,
        Min = 3,
        Max = 4,
        ZeroEXT = 1000148000,
        SrcEXT = 1000148001,
        DstEXT = 1000148002,
        SrcOverEXT = 1000148003,
        DstOverEXT = 1000148004,
        SrcInEXT = 1000148005,
        DstInEXT = 1000148006,
        SrcOutEXT = 1000148007,
        DstOutEXT = 1000148008,
        SrcAtopEXT = 1000148009,
        DstAtopEXT = 1000148010,
        XorEXT = 1000148011,
        MultiplyEXT = 1000148012,
        ScreenEXT = 1000148013,
        OverlayEXT = 1000148014,
        DarkenEXT = 1000148015,
        LightenEXT = 1000148016,
        ColordodgeEXT = 1000148017,
        ColorburnEXT = 1000148018,
        HardlightEXT = 1000148019,
        SoftlightEXT = 1000148020,
        DifferenceEXT = 1000148021,
        ExclusionEXT = 1000148022,
        InvertEXT = 1000148023,
        InvertRgbEXT = 1000148024,
        LineardodgeEXT = 1000148025,
        LinearburnEXT = 1000148026,
        VividlightEXT = 1000148027,
        LinearlightEXT = 1000148028,
        PinlightEXT = 1000148029,
        HardmixEXT = 1000148030,
        HslHueEXT = 1000148031,
        HslSaturationEXT = 1000148032,
        HslColorEXT = 1000148033,
        HslLuminosityEXT = 1000148034,
        PlusEXT = 1000148035,
        PlusClampedEXT = 1000148036,
        PlusClampedAlphaEXT = 1000148037,
        PlusDarkerEXT = 1000148038,
        MinusEXT = 1000148039,
        MinusClampedEXT = 1000148040,
        ContrastEXT = 1000148041,
        InvertOvgEXT = 1000148042,
        RedEXT = 1000148043,
        GreenEXT = 1000148044,
        BlueEXT = 1000148045,
    }
    public static partial class RawConstants
    {
        public const VkBlendOp VK_BLEND_OP_ADD = VkBlendOp.Add;
        public const VkBlendOp VK_BLEND_OP_SUBTRACT = VkBlendOp.Subtract;
        public const VkBlendOp VK_BLEND_OP_REVERSE_SUBTRACT = VkBlendOp.ReverseSubtract;
        public const VkBlendOp VK_BLEND_OP_MIN = VkBlendOp.Min;
        public const VkBlendOp VK_BLEND_OP_MAX = VkBlendOp.Max;
        public const VkBlendOp VK_BLEND_OP_ZERO_EXT = VkBlendOp.ZeroEXT;
        public const VkBlendOp VK_BLEND_OP_SRC_EXT = VkBlendOp.SrcEXT;
        public const VkBlendOp VK_BLEND_OP_DST_EXT = VkBlendOp.DstEXT;
        public const VkBlendOp VK_BLEND_OP_SRC_OVER_EXT = VkBlendOp.SrcOverEXT;
        public const VkBlendOp VK_BLEND_OP_DST_OVER_EXT = VkBlendOp.DstOverEXT;
        public const VkBlendOp VK_BLEND_OP_SRC_IN_EXT = VkBlendOp.SrcInEXT;
        public const VkBlendOp VK_BLEND_OP_DST_IN_EXT = VkBlendOp.DstInEXT;
        public const VkBlendOp VK_BLEND_OP_SRC_OUT_EXT = VkBlendOp.SrcOutEXT;
        public const VkBlendOp VK_BLEND_OP_DST_OUT_EXT = VkBlendOp.DstOutEXT;
        public const VkBlendOp VK_BLEND_OP_SRC_ATOP_EXT = VkBlendOp.SrcAtopEXT;
        public const VkBlendOp VK_BLEND_OP_DST_ATOP_EXT = VkBlendOp.DstAtopEXT;
        public const VkBlendOp VK_BLEND_OP_XOR_EXT = VkBlendOp.XorEXT;
        public const VkBlendOp VK_BLEND_OP_MULTIPLY_EXT = VkBlendOp.MultiplyEXT;
        public const VkBlendOp VK_BLEND_OP_SCREEN_EXT = VkBlendOp.ScreenEXT;
        public const VkBlendOp VK_BLEND_OP_OVERLAY_EXT = VkBlendOp.OverlayEXT;
        public const VkBlendOp VK_BLEND_OP_DARKEN_EXT = VkBlendOp.DarkenEXT;
        public const VkBlendOp VK_BLEND_OP_LIGHTEN_EXT = VkBlendOp.LightenEXT;
        public const VkBlendOp VK_BLEND_OP_COLORDODGE_EXT = VkBlendOp.ColordodgeEXT;
        public const VkBlendOp VK_BLEND_OP_COLORBURN_EXT = VkBlendOp.ColorburnEXT;
        public const VkBlendOp VK_BLEND_OP_HARDLIGHT_EXT = VkBlendOp.HardlightEXT;
        public const VkBlendOp VK_BLEND_OP_SOFTLIGHT_EXT = VkBlendOp.SoftlightEXT;
        public const VkBlendOp VK_BLEND_OP_DIFFERENCE_EXT = VkBlendOp.DifferenceEXT;
        public const VkBlendOp VK_BLEND_OP_EXCLUSION_EXT = VkBlendOp.ExclusionEXT;
        public const VkBlendOp VK_BLEND_OP_INVERT_EXT = VkBlendOp.InvertEXT;
        public const VkBlendOp VK_BLEND_OP_INVERT_RGB_EXT = VkBlendOp.InvertRgbEXT;
        public const VkBlendOp VK_BLEND_OP_LINEARDODGE_EXT = VkBlendOp.LineardodgeEXT;
        public const VkBlendOp VK_BLEND_OP_LINEARBURN_EXT = VkBlendOp.LinearburnEXT;
        public const VkBlendOp VK_BLEND_OP_VIVIDLIGHT_EXT = VkBlendOp.VividlightEXT;
        public const VkBlendOp VK_BLEND_OP_LINEARLIGHT_EXT = VkBlendOp.LinearlightEXT;
        public const VkBlendOp VK_BLEND_OP_PINLIGHT_EXT = VkBlendOp.PinlightEXT;
        public const VkBlendOp VK_BLEND_OP_HARDMIX_EXT = VkBlendOp.HardmixEXT;
        public const VkBlendOp VK_BLEND_OP_HSL_HUE_EXT = VkBlendOp.HslHueEXT;
        public const VkBlendOp VK_BLEND_OP_HSL_SATURATION_EXT = VkBlendOp.HslSaturationEXT;
        public const VkBlendOp VK_BLEND_OP_HSL_COLOR_EXT = VkBlendOp.HslColorEXT;
        public const VkBlendOp VK_BLEND_OP_HSL_LUMINOSITY_EXT = VkBlendOp.HslLuminosityEXT;
        public const VkBlendOp VK_BLEND_OP_PLUS_EXT = VkBlendOp.PlusEXT;
        public const VkBlendOp VK_BLEND_OP_PLUS_CLAMPED_EXT = VkBlendOp.PlusClampedEXT;
        public const VkBlendOp VK_BLEND_OP_PLUS_CLAMPED_ALPHA_EXT = VkBlendOp.PlusClampedAlphaEXT;
        public const VkBlendOp VK_BLEND_OP_PLUS_DARKER_EXT = VkBlendOp.PlusDarkerEXT;
        public const VkBlendOp VK_BLEND_OP_MINUS_EXT = VkBlendOp.MinusEXT;
        public const VkBlendOp VK_BLEND_OP_MINUS_CLAMPED_EXT = VkBlendOp.MinusClampedEXT;
        public const VkBlendOp VK_BLEND_OP_CONTRAST_EXT = VkBlendOp.ContrastEXT;
        public const VkBlendOp VK_BLEND_OP_INVERT_OVG_EXT = VkBlendOp.InvertOvgEXT;
        public const VkBlendOp VK_BLEND_OP_RED_EXT = VkBlendOp.RedEXT;
        public const VkBlendOp VK_BLEND_OP_GREEN_EXT = VkBlendOp.GreenEXT;
        public const VkBlendOp VK_BLEND_OP_BLUE_EXT = VkBlendOp.BlueEXT;
    }

    public enum VkStencilOp : int
    {
        Keep = 0,
        Zero = 1,
        Replace = 2,
        IncrementAndClamp = 3,
        DecrementAndClamp = 4,
        Invert = 5,
        IncrementAndWrap = 6,
        DecrementAndWrap = 7,
    }
    public static partial class RawConstants
    {
        public const VkStencilOp VK_STENCIL_OP_KEEP = VkStencilOp.Keep;
        public const VkStencilOp VK_STENCIL_OP_ZERO = VkStencilOp.Zero;
        public const VkStencilOp VK_STENCIL_OP_REPLACE = VkStencilOp.Replace;
        public const VkStencilOp VK_STENCIL_OP_INCREMENT_AND_CLAMP = VkStencilOp.IncrementAndClamp;
        public const VkStencilOp VK_STENCIL_OP_DECREMENT_AND_CLAMP = VkStencilOp.DecrementAndClamp;
        public const VkStencilOp VK_STENCIL_OP_INVERT = VkStencilOp.Invert;
        public const VkStencilOp VK_STENCIL_OP_INCREMENT_AND_WRAP = VkStencilOp.IncrementAndWrap;
        public const VkStencilOp VK_STENCIL_OP_DECREMENT_AND_WRAP = VkStencilOp.DecrementAndWrap;
    }

    public enum VkLogicOp : int
    {
        Clear = 0,
        And = 1,
        AndReverse = 2,
        Copy = 3,
        AndInverted = 4,
        NoOp = 5,
        Xor = 6,
        Or = 7,
        Nor = 8,
        Equivalent = 9,
        Invert = 10,
        OrReverse = 11,
        CopyInverted = 12,
        OrInverted = 13,
        Nand = 14,
        Set = 15,
    }
    public static partial class RawConstants
    {
        public const VkLogicOp VK_LOGIC_OP_CLEAR = VkLogicOp.Clear;
        public const VkLogicOp VK_LOGIC_OP_AND = VkLogicOp.And;
        public const VkLogicOp VK_LOGIC_OP_AND_REVERSE = VkLogicOp.AndReverse;
        public const VkLogicOp VK_LOGIC_OP_COPY = VkLogicOp.Copy;
        public const VkLogicOp VK_LOGIC_OP_AND_INVERTED = VkLogicOp.AndInverted;
        public const VkLogicOp VK_LOGIC_OP_NO_OP = VkLogicOp.NoOp;
        public const VkLogicOp VK_LOGIC_OP_XOR = VkLogicOp.Xor;
        public const VkLogicOp VK_LOGIC_OP_OR = VkLogicOp.Or;
        public const VkLogicOp VK_LOGIC_OP_NOR = VkLogicOp.Nor;
        public const VkLogicOp VK_LOGIC_OP_EQUIVALENT = VkLogicOp.Equivalent;
        public const VkLogicOp VK_LOGIC_OP_INVERT = VkLogicOp.Invert;
        public const VkLogicOp VK_LOGIC_OP_OR_REVERSE = VkLogicOp.OrReverse;
        public const VkLogicOp VK_LOGIC_OP_COPY_INVERTED = VkLogicOp.CopyInverted;
        public const VkLogicOp VK_LOGIC_OP_OR_INVERTED = VkLogicOp.OrInverted;
        public const VkLogicOp VK_LOGIC_OP_NAND = VkLogicOp.Nand;
        public const VkLogicOp VK_LOGIC_OP_SET = VkLogicOp.Set;
    }

    public enum VkInternalAllocationType : int
    {
        Executable = 0,
    }
    public static partial class RawConstants
    {
        public const VkInternalAllocationType VK_INTERNAL_ALLOCATION_TYPE_EXECUTABLE = VkInternalAllocationType.Executable;
    }

    public enum VkSystemAllocationScope : int
    {
        Command = 0,
        Object = 1,
        Cache = 2,
        Device = 3,
        Instance = 4,
    }
    public static partial class RawConstants
    {
        public const VkSystemAllocationScope VK_SYSTEM_ALLOCATION_SCOPE_COMMAND = VkSystemAllocationScope.Command;
        public const VkSystemAllocationScope VK_SYSTEM_ALLOCATION_SCOPE_OBJECT = VkSystemAllocationScope.Object;
        public const VkSystemAllocationScope VK_SYSTEM_ALLOCATION_SCOPE_CACHE = VkSystemAllocationScope.Cache;
        public const VkSystemAllocationScope VK_SYSTEM_ALLOCATION_SCOPE_DEVICE = VkSystemAllocationScope.Device;
        public const VkSystemAllocationScope VK_SYSTEM_ALLOCATION_SCOPE_INSTANCE = VkSystemAllocationScope.Instance;
    }

    public enum VkPhysicalDeviceType : int
    {
        Other = 0,
        IntegratedGpu = 1,
        DiscreteGpu = 2,
        VirtualGpu = 3,
        Cpu = 4,
    }
    public static partial class RawConstants
    {
        public const VkPhysicalDeviceType VK_PHYSICAL_DEVICE_TYPE_OTHER = VkPhysicalDeviceType.Other;
        public const VkPhysicalDeviceType VK_PHYSICAL_DEVICE_TYPE_INTEGRATED_GPU = VkPhysicalDeviceType.IntegratedGpu;
        public const VkPhysicalDeviceType VK_PHYSICAL_DEVICE_TYPE_DISCRETE_GPU = VkPhysicalDeviceType.DiscreteGpu;
        public const VkPhysicalDeviceType VK_PHYSICAL_DEVICE_TYPE_VIRTUAL_GPU = VkPhysicalDeviceType.VirtualGpu;
        public const VkPhysicalDeviceType VK_PHYSICAL_DEVICE_TYPE_CPU = VkPhysicalDeviceType.Cpu;
    }

    public enum VkVertexInputRate : int
    {
        Vertex = 0,
        Instance = 1,
    }
    public static partial class RawConstants
    {
        public const VkVertexInputRate VK_VERTEX_INPUT_RATE_VERTEX = VkVertexInputRate.Vertex;
        public const VkVertexInputRate VK_VERTEX_INPUT_RATE_INSTANCE = VkVertexInputRate.Instance;
    }

    public enum VkFormat : int
    {
        Undefined = 0,
        R4g4UnormPack8 = 1,
        R4g4b4a4UnormPack16 = 2,
        B4g4r4a4UnormPack16 = 3,
        R5g6b5UnormPack16 = 4,
        B5g6r5UnormPack16 = 5,
        R5g5b5a1UnormPack16 = 6,
        B5g5r5a1UnormPack16 = 7,
        A1r5g5b5UnormPack16 = 8,
        R8Unorm = 9,
        R8Snorm = 10,
        R8Uscaled = 11,
        R8Sscaled = 12,
        R8Uint = 13,
        R8Sint = 14,
        R8Srgb = 15,
        R8g8Unorm = 16,
        R8g8Snorm = 17,
        R8g8Uscaled = 18,
        R8g8Sscaled = 19,
        R8g8Uint = 20,
        R8g8Sint = 21,
        R8g8Srgb = 22,
        R8g8b8Unorm = 23,
        R8g8b8Snorm = 24,
        R8g8b8Uscaled = 25,
        R8g8b8Sscaled = 26,
        R8g8b8Uint = 27,
        R8g8b8Sint = 28,
        R8g8b8Srgb = 29,
        B8g8r8Unorm = 30,
        B8g8r8Snorm = 31,
        B8g8r8Uscaled = 32,
        B8g8r8Sscaled = 33,
        B8g8r8Uint = 34,
        B8g8r8Sint = 35,
        B8g8r8Srgb = 36,
        R8g8b8a8Unorm = 37,
        R8g8b8a8Snorm = 38,
        R8g8b8a8Uscaled = 39,
        R8g8b8a8Sscaled = 40,
        R8g8b8a8Uint = 41,
        R8g8b8a8Sint = 42,
        R8g8b8a8Srgb = 43,
        B8g8r8a8Unorm = 44,
        B8g8r8a8Snorm = 45,
        B8g8r8a8Uscaled = 46,
        B8g8r8a8Sscaled = 47,
        B8g8r8a8Uint = 48,
        B8g8r8a8Sint = 49,
        B8g8r8a8Srgb = 50,
        A8b8g8r8UnormPack32 = 51,
        A8b8g8r8SnormPack32 = 52,
        A8b8g8r8UscaledPack32 = 53,
        A8b8g8r8SscaledPack32 = 54,
        A8b8g8r8UintPack32 = 55,
        A8b8g8r8SintPack32 = 56,
        A8b8g8r8SrgbPack32 = 57,
        A2r10g10b10UnormPack32 = 58,
        A2r10g10b10SnormPack32 = 59,
        A2r10g10b10UscaledPack32 = 60,
        A2r10g10b10SscaledPack32 = 61,
        A2r10g10b10UintPack32 = 62,
        A2r10g10b10SintPack32 = 63,
        A2b10g10r10UnormPack32 = 64,
        A2b10g10r10SnormPack32 = 65,
        A2b10g10r10UscaledPack32 = 66,
        A2b10g10r10SscaledPack32 = 67,
        A2b10g10r10UintPack32 = 68,
        A2b10g10r10SintPack32 = 69,
        R16Unorm = 70,
        R16Snorm = 71,
        R16Uscaled = 72,
        R16Sscaled = 73,
        R16Uint = 74,
        R16Sint = 75,
        R16Sfloat = 76,
        R16g16Unorm = 77,
        R16g16Snorm = 78,
        R16g16Uscaled = 79,
        R16g16Sscaled = 80,
        R16g16Uint = 81,
        R16g16Sint = 82,
        R16g16Sfloat = 83,
        R16g16b16Unorm = 84,
        R16g16b16Snorm = 85,
        R16g16b16Uscaled = 86,
        R16g16b16Sscaled = 87,
        R16g16b16Uint = 88,
        R16g16b16Sint = 89,
        R16g16b16Sfloat = 90,
        R16g16b16a16Unorm = 91,
        R16g16b16a16Snorm = 92,
        R16g16b16a16Uscaled = 93,
        R16g16b16a16Sscaled = 94,
        R16g16b16a16Uint = 95,
        R16g16b16a16Sint = 96,
        R16g16b16a16Sfloat = 97,
        R32Uint = 98,
        R32Sint = 99,
        R32Sfloat = 100,
        R32g32Uint = 101,
        R32g32Sint = 102,
        R32g32Sfloat = 103,
        R32g32b32Uint = 104,
        R32g32b32Sint = 105,
        R32g32b32Sfloat = 106,
        R32g32b32a32Uint = 107,
        R32g32b32a32Sint = 108,
        R32g32b32a32Sfloat = 109,
        R64Uint = 110,
        R64Sint = 111,
        R64Sfloat = 112,
        R64g64Uint = 113,
        R64g64Sint = 114,
        R64g64Sfloat = 115,
        R64g64b64Uint = 116,
        R64g64b64Sint = 117,
        R64g64b64Sfloat = 118,
        R64g64b64a64Uint = 119,
        R64g64b64a64Sint = 120,
        R64g64b64a64Sfloat = 121,
        B10g11r11UfloatPack32 = 122,
        E5b9g9r9UfloatPack32 = 123,
        D16Unorm = 124,
        X8D24UnormPack32 = 125,
        D32Sfloat = 126,
        S8Uint = 127,
        D16UnormS8Uint = 128,
        D24UnormS8Uint = 129,
        D32SfloatS8Uint = 130,
        Bc1RgbUnormBlock = 131,
        Bc1RgbSrgbBlock = 132,
        Bc1RgbaUnormBlock = 133,
        Bc1RgbaSrgbBlock = 134,
        Bc2UnormBlock = 135,
        Bc2SrgbBlock = 136,
        Bc3UnormBlock = 137,
        Bc3SrgbBlock = 138,
        Bc4UnormBlock = 139,
        Bc4SnormBlock = 140,
        Bc5UnormBlock = 141,
        Bc5SnormBlock = 142,
        Bc6hUfloatBlock = 143,
        Bc6hSfloatBlock = 144,
        Bc7UnormBlock = 145,
        Bc7SrgbBlock = 146,
        Etc2R8g8b8UnormBlock = 147,
        Etc2R8g8b8SrgbBlock = 148,
        Etc2R8g8b8a1UnormBlock = 149,
        Etc2R8g8b8a1SrgbBlock = 150,
        Etc2R8g8b8a8UnormBlock = 151,
        Etc2R8g8b8a8SrgbBlock = 152,
        EacR11UnormBlock = 153,
        EacR11SnormBlock = 154,
        EacR11g11UnormBlock = 155,
        EacR11g11SnormBlock = 156,
        Astc4x4UnormBlock = 157,
        Astc4x4SrgbBlock = 158,
        Astc5x4UnormBlock = 159,
        Astc5x4SrgbBlock = 160,
        Astc5x5UnormBlock = 161,
        Astc5x5SrgbBlock = 162,
        Astc6x5UnormBlock = 163,
        Astc6x5SrgbBlock = 164,
        Astc6x6UnormBlock = 165,
        Astc6x6SrgbBlock = 166,
        Astc8x5UnormBlock = 167,
        Astc8x5SrgbBlock = 168,
        Astc8x6UnormBlock = 169,
        Astc8x6SrgbBlock = 170,
        Astc8x8UnormBlock = 171,
        Astc8x8SrgbBlock = 172,
        Astc10x5UnormBlock = 173,
        Astc10x5SrgbBlock = 174,
        Astc10x6UnormBlock = 175,
        Astc10x6SrgbBlock = 176,
        Astc10x8UnormBlock = 177,
        Astc10x8SrgbBlock = 178,
        Astc10x10UnormBlock = 179,
        Astc10x10SrgbBlock = 180,
        Astc12x10UnormBlock = 181,
        Astc12x10SrgbBlock = 182,
        Astc12x12UnormBlock = 183,
        Astc12x12SrgbBlock = 184,
        G8b8g8r8422Unorm = 1000156000,
        B8g8r8g8422Unorm = 1000156001,
        G8B8R83plane420Unorm = 1000156002,
        G8B8r82plane420Unorm = 1000156003,
        G8B8R83plane422Unorm = 1000156004,
        G8B8r82plane422Unorm = 1000156005,
        G8B8R83plane444Unorm = 1000156006,
        R10x6UnormPack16 = 1000156007,
        R10x6g10x6Unorm2pack16 = 1000156008,
        R10x6g10x6b10x6a10x6Unorm4pack16 = 1000156009,
        G10x6b10x6g10x6r10x6422Unorm4pack16 = 1000156010,
        B10x6g10x6r10x6g10x6422Unorm4pack16 = 1000156011,
        G10x6B10x6R10x63plane420Unorm3pack16 = 1000156012,
        G10x6B10x6r10x62plane420Unorm3pack16 = 1000156013,
        G10x6B10x6R10x63plane422Unorm3pack16 = 1000156014,
        G10x6B10x6r10x62plane422Unorm3pack16 = 1000156015,
        G10x6B10x6R10x63plane444Unorm3pack16 = 1000156016,
        R12x4UnormPack16 = 1000156017,
        R12x4g12x4Unorm2pack16 = 1000156018,
        R12x4g12x4b12x4a12x4Unorm4pack16 = 1000156019,
        G12x4b12x4g12x4r12x4422Unorm4pack16 = 1000156020,
        B12x4g12x4r12x4g12x4422Unorm4pack16 = 1000156021,
        G12x4B12x4R12x43plane420Unorm3pack16 = 1000156022,
        G12x4B12x4r12x42plane420Unorm3pack16 = 1000156023,
        G12x4B12x4R12x43plane422Unorm3pack16 = 1000156024,
        G12x4B12x4r12x42plane422Unorm3pack16 = 1000156025,
        G12x4B12x4R12x43plane444Unorm3pack16 = 1000156026,
        G16b16g16r16422Unorm = 1000156027,
        B16g16r16g16422Unorm = 1000156028,
        G16B16R163plane420Unorm = 1000156029,
        G16B16r162plane420Unorm = 1000156030,
        G16B16R163plane422Unorm = 1000156031,
        G16B16r162plane422Unorm = 1000156032,
        G16B16R163plane444Unorm = 1000156033,
        G8B8r82plane444Unorm = 1000330000,
        G10x6B10x6r10x62plane444Unorm3pack16 = 1000330001,
        G12x4B12x4r12x42plane444Unorm3pack16 = 1000330002,
        G16B16r162plane444Unorm = 1000330003,
        A4r4g4b4UnormPack16 = 1000340000,
        A4b4g4r4UnormPack16 = 1000340001,
        Astc4x4SfloatBlock = 1000066000,
        Astc5x4SfloatBlock = 1000066001,
        Astc5x5SfloatBlock = 1000066002,
        Astc6x5SfloatBlock = 1000066003,
        Astc6x6SfloatBlock = 1000066004,
        Astc8x5SfloatBlock = 1000066005,
        Astc8x6SfloatBlock = 1000066006,
        Astc8x8SfloatBlock = 1000066007,
        Astc10x5SfloatBlock = 1000066008,
        Astc10x6SfloatBlock = 1000066009,
        Astc10x8SfloatBlock = 1000066010,
        Astc10x10SfloatBlock = 1000066011,
        Astc12x10SfloatBlock = 1000066012,
        Astc12x12SfloatBlock = 1000066013,
        Pvrtc12bppUnormBlockImg = 1000054000,
        Pvrtc14bppUnormBlockImg = 1000054001,
        Pvrtc22bppUnormBlockImg = 1000054002,
        Pvrtc24bppUnormBlockImg = 1000054003,
        Pvrtc12bppSrgbBlockImg = 1000054004,
        Pvrtc14bppSrgbBlockImg = 1000054005,
        Pvrtc22bppSrgbBlockImg = 1000054006,
        Pvrtc24bppSrgbBlockImg = 1000054007,
        Astc3x3x3UnormBlockEXT = 1000288000,
        Astc3x3x3SrgbBlockEXT = 1000288001,
        Astc3x3x3SfloatBlockEXT = 1000288002,
        Astc4x3x3UnormBlockEXT = 1000288003,
        Astc4x3x3SrgbBlockEXT = 1000288004,
        Astc4x3x3SfloatBlockEXT = 1000288005,
        Astc4x4x3UnormBlockEXT = 1000288006,
        Astc4x4x3SrgbBlockEXT = 1000288007,
        Astc4x4x3SfloatBlockEXT = 1000288008,
        Astc4x4x4UnormBlockEXT = 1000288009,
        Astc4x4x4SrgbBlockEXT = 1000288010,
        Astc4x4x4SfloatBlockEXT = 1000288011,
        Astc5x4x4UnormBlockEXT = 1000288012,
        Astc5x4x4SrgbBlockEXT = 1000288013,
        Astc5x4x4SfloatBlockEXT = 1000288014,
        Astc5x5x4UnormBlockEXT = 1000288015,
        Astc5x5x4SrgbBlockEXT = 1000288016,
        Astc5x5x4SfloatBlockEXT = 1000288017,
        Astc5x5x5UnormBlockEXT = 1000288018,
        Astc5x5x5SrgbBlockEXT = 1000288019,
        Astc5x5x5SfloatBlockEXT = 1000288020,
        Astc6x5x5UnormBlockEXT = 1000288021,
        Astc6x5x5SrgbBlockEXT = 1000288022,
        Astc6x5x5SfloatBlockEXT = 1000288023,
        Astc6x6x5UnormBlockEXT = 1000288024,
        Astc6x6x5SrgbBlockEXT = 1000288025,
        Astc6x6x5SfloatBlockEXT = 1000288026,
        Astc6x6x6UnormBlockEXT = 1000288027,
        Astc6x6x6SrgbBlockEXT = 1000288028,
        Astc6x6x6SfloatBlockEXT = 1000288029,
        R16g16S105NV = 1000464000,
        A1b5g5r5UnormPack16KHR = 1000470000,
        A8UnormKHR = 1000470001,
    }
    public static partial class RawConstants
    {
        public const VkFormat VK_FORMAT_UNDEFINED = VkFormat.Undefined;
        public const VkFormat VK_FORMAT_R4G4_UNORM_PACK8 = VkFormat.R4g4UnormPack8;
        public const VkFormat VK_FORMAT_R4G4B4A4_UNORM_PACK16 = VkFormat.R4g4b4a4UnormPack16;
        public const VkFormat VK_FORMAT_B4G4R4A4_UNORM_PACK16 = VkFormat.B4g4r4a4UnormPack16;
        public const VkFormat VK_FORMAT_R5G6B5_UNORM_PACK16 = VkFormat.R5g6b5UnormPack16;
        public const VkFormat VK_FORMAT_B5G6R5_UNORM_PACK16 = VkFormat.B5g6r5UnormPack16;
        public const VkFormat VK_FORMAT_R5G5B5A1_UNORM_PACK16 = VkFormat.R5g5b5a1UnormPack16;
        public const VkFormat VK_FORMAT_B5G5R5A1_UNORM_PACK16 = VkFormat.B5g5r5a1UnormPack16;
        public const VkFormat VK_FORMAT_A1R5G5B5_UNORM_PACK16 = VkFormat.A1r5g5b5UnormPack16;
        public const VkFormat VK_FORMAT_R8_UNORM = VkFormat.R8Unorm;
        public const VkFormat VK_FORMAT_R8_SNORM = VkFormat.R8Snorm;
        public const VkFormat VK_FORMAT_R8_USCALED = VkFormat.R8Uscaled;
        public const VkFormat VK_FORMAT_R8_SSCALED = VkFormat.R8Sscaled;
        public const VkFormat VK_FORMAT_R8_UINT = VkFormat.R8Uint;
        public const VkFormat VK_FORMAT_R8_SINT = VkFormat.R8Sint;
        public const VkFormat VK_FORMAT_R8_SRGB = VkFormat.R8Srgb;
        public const VkFormat VK_FORMAT_R8G8_UNORM = VkFormat.R8g8Unorm;
        public const VkFormat VK_FORMAT_R8G8_SNORM = VkFormat.R8g8Snorm;
        public const VkFormat VK_FORMAT_R8G8_USCALED = VkFormat.R8g8Uscaled;
        public const VkFormat VK_FORMAT_R8G8_SSCALED = VkFormat.R8g8Sscaled;
        public const VkFormat VK_FORMAT_R8G8_UINT = VkFormat.R8g8Uint;
        public const VkFormat VK_FORMAT_R8G8_SINT = VkFormat.R8g8Sint;
        public const VkFormat VK_FORMAT_R8G8_SRGB = VkFormat.R8g8Srgb;
        public const VkFormat VK_FORMAT_R8G8B8_UNORM = VkFormat.R8g8b8Unorm;
        public const VkFormat VK_FORMAT_R8G8B8_SNORM = VkFormat.R8g8b8Snorm;
        public const VkFormat VK_FORMAT_R8G8B8_USCALED = VkFormat.R8g8b8Uscaled;
        public const VkFormat VK_FORMAT_R8G8B8_SSCALED = VkFormat.R8g8b8Sscaled;
        public const VkFormat VK_FORMAT_R8G8B8_UINT = VkFormat.R8g8b8Uint;
        public const VkFormat VK_FORMAT_R8G8B8_SINT = VkFormat.R8g8b8Sint;
        public const VkFormat VK_FORMAT_R8G8B8_SRGB = VkFormat.R8g8b8Srgb;
        public const VkFormat VK_FORMAT_B8G8R8_UNORM = VkFormat.B8g8r8Unorm;
        public const VkFormat VK_FORMAT_B8G8R8_SNORM = VkFormat.B8g8r8Snorm;
        public const VkFormat VK_FORMAT_B8G8R8_USCALED = VkFormat.B8g8r8Uscaled;
        public const VkFormat VK_FORMAT_B8G8R8_SSCALED = VkFormat.B8g8r8Sscaled;
        public const VkFormat VK_FORMAT_B8G8R8_UINT = VkFormat.B8g8r8Uint;
        public const VkFormat VK_FORMAT_B8G8R8_SINT = VkFormat.B8g8r8Sint;
        public const VkFormat VK_FORMAT_B8G8R8_SRGB = VkFormat.B8g8r8Srgb;
        public const VkFormat VK_FORMAT_R8G8B8A8_UNORM = VkFormat.R8g8b8a8Unorm;
        public const VkFormat VK_FORMAT_R8G8B8A8_SNORM = VkFormat.R8g8b8a8Snorm;
        public const VkFormat VK_FORMAT_R8G8B8A8_USCALED = VkFormat.R8g8b8a8Uscaled;
        public const VkFormat VK_FORMAT_R8G8B8A8_SSCALED = VkFormat.R8g8b8a8Sscaled;
        public const VkFormat VK_FORMAT_R8G8B8A8_UINT = VkFormat.R8g8b8a8Uint;
        public const VkFormat VK_FORMAT_R8G8B8A8_SINT = VkFormat.R8g8b8a8Sint;
        public const VkFormat VK_FORMAT_R8G8B8A8_SRGB = VkFormat.R8g8b8a8Srgb;
        public const VkFormat VK_FORMAT_B8G8R8A8_UNORM = VkFormat.B8g8r8a8Unorm;
        public const VkFormat VK_FORMAT_B8G8R8A8_SNORM = VkFormat.B8g8r8a8Snorm;
        public const VkFormat VK_FORMAT_B8G8R8A8_USCALED = VkFormat.B8g8r8a8Uscaled;
        public const VkFormat VK_FORMAT_B8G8R8A8_SSCALED = VkFormat.B8g8r8a8Sscaled;
        public const VkFormat VK_FORMAT_B8G8R8A8_UINT = VkFormat.B8g8r8a8Uint;
        public const VkFormat VK_FORMAT_B8G8R8A8_SINT = VkFormat.B8g8r8a8Sint;
        public const VkFormat VK_FORMAT_B8G8R8A8_SRGB = VkFormat.B8g8r8a8Srgb;
        public const VkFormat VK_FORMAT_A8B8G8R8_UNORM_PACK32 = VkFormat.A8b8g8r8UnormPack32;
        public const VkFormat VK_FORMAT_A8B8G8R8_SNORM_PACK32 = VkFormat.A8b8g8r8SnormPack32;
        public const VkFormat VK_FORMAT_A8B8G8R8_USCALED_PACK32 = VkFormat.A8b8g8r8UscaledPack32;
        public const VkFormat VK_FORMAT_A8B8G8R8_SSCALED_PACK32 = VkFormat.A8b8g8r8SscaledPack32;
        public const VkFormat VK_FORMAT_A8B8G8R8_UINT_PACK32 = VkFormat.A8b8g8r8UintPack32;
        public const VkFormat VK_FORMAT_A8B8G8R8_SINT_PACK32 = VkFormat.A8b8g8r8SintPack32;
        public const VkFormat VK_FORMAT_A8B8G8R8_SRGB_PACK32 = VkFormat.A8b8g8r8SrgbPack32;
        public const VkFormat VK_FORMAT_A2R10G10B10_UNORM_PACK32 = VkFormat.A2r10g10b10UnormPack32;
        public const VkFormat VK_FORMAT_A2R10G10B10_SNORM_PACK32 = VkFormat.A2r10g10b10SnormPack32;
        public const VkFormat VK_FORMAT_A2R10G10B10_USCALED_PACK32 = VkFormat.A2r10g10b10UscaledPack32;
        public const VkFormat VK_FORMAT_A2R10G10B10_SSCALED_PACK32 = VkFormat.A2r10g10b10SscaledPack32;
        public const VkFormat VK_FORMAT_A2R10G10B10_UINT_PACK32 = VkFormat.A2r10g10b10UintPack32;
        public const VkFormat VK_FORMAT_A2R10G10B10_SINT_PACK32 = VkFormat.A2r10g10b10SintPack32;
        public const VkFormat VK_FORMAT_A2B10G10R10_UNORM_PACK32 = VkFormat.A2b10g10r10UnormPack32;
        public const VkFormat VK_FORMAT_A2B10G10R10_SNORM_PACK32 = VkFormat.A2b10g10r10SnormPack32;
        public const VkFormat VK_FORMAT_A2B10G10R10_USCALED_PACK32 = VkFormat.A2b10g10r10UscaledPack32;
        public const VkFormat VK_FORMAT_A2B10G10R10_SSCALED_PACK32 = VkFormat.A2b10g10r10SscaledPack32;
        public const VkFormat VK_FORMAT_A2B10G10R10_UINT_PACK32 = VkFormat.A2b10g10r10UintPack32;
        public const VkFormat VK_FORMAT_A2B10G10R10_SINT_PACK32 = VkFormat.A2b10g10r10SintPack32;
        public const VkFormat VK_FORMAT_R16_UNORM = VkFormat.R16Unorm;
        public const VkFormat VK_FORMAT_R16_SNORM = VkFormat.R16Snorm;
        public const VkFormat VK_FORMAT_R16_USCALED = VkFormat.R16Uscaled;
        public const VkFormat VK_FORMAT_R16_SSCALED = VkFormat.R16Sscaled;
        public const VkFormat VK_FORMAT_R16_UINT = VkFormat.R16Uint;
        public const VkFormat VK_FORMAT_R16_SINT = VkFormat.R16Sint;
        public const VkFormat VK_FORMAT_R16_SFLOAT = VkFormat.R16Sfloat;
        public const VkFormat VK_FORMAT_R16G16_UNORM = VkFormat.R16g16Unorm;
        public const VkFormat VK_FORMAT_R16G16_SNORM = VkFormat.R16g16Snorm;
        public const VkFormat VK_FORMAT_R16G16_USCALED = VkFormat.R16g16Uscaled;
        public const VkFormat VK_FORMAT_R16G16_SSCALED = VkFormat.R16g16Sscaled;
        public const VkFormat VK_FORMAT_R16G16_UINT = VkFormat.R16g16Uint;
        public const VkFormat VK_FORMAT_R16G16_SINT = VkFormat.R16g16Sint;
        public const VkFormat VK_FORMAT_R16G16_SFLOAT = VkFormat.R16g16Sfloat;
        public const VkFormat VK_FORMAT_R16G16B16_UNORM = VkFormat.R16g16b16Unorm;
        public const VkFormat VK_FORMAT_R16G16B16_SNORM = VkFormat.R16g16b16Snorm;
        public const VkFormat VK_FORMAT_R16G16B16_USCALED = VkFormat.R16g16b16Uscaled;
        public const VkFormat VK_FORMAT_R16G16B16_SSCALED = VkFormat.R16g16b16Sscaled;
        public const VkFormat VK_FORMAT_R16G16B16_UINT = VkFormat.R16g16b16Uint;
        public const VkFormat VK_FORMAT_R16G16B16_SINT = VkFormat.R16g16b16Sint;
        public const VkFormat VK_FORMAT_R16G16B16_SFLOAT = VkFormat.R16g16b16Sfloat;
        public const VkFormat VK_FORMAT_R16G16B16A16_UNORM = VkFormat.R16g16b16a16Unorm;
        public const VkFormat VK_FORMAT_R16G16B16A16_SNORM = VkFormat.R16g16b16a16Snorm;
        public const VkFormat VK_FORMAT_R16G16B16A16_USCALED = VkFormat.R16g16b16a16Uscaled;
        public const VkFormat VK_FORMAT_R16G16B16A16_SSCALED = VkFormat.R16g16b16a16Sscaled;
        public const VkFormat VK_FORMAT_R16G16B16A16_UINT = VkFormat.R16g16b16a16Uint;
        public const VkFormat VK_FORMAT_R16G16B16A16_SINT = VkFormat.R16g16b16a16Sint;
        public const VkFormat VK_FORMAT_R16G16B16A16_SFLOAT = VkFormat.R16g16b16a16Sfloat;
        public const VkFormat VK_FORMAT_R32_UINT = VkFormat.R32Uint;
        public const VkFormat VK_FORMAT_R32_SINT = VkFormat.R32Sint;
        public const VkFormat VK_FORMAT_R32_SFLOAT = VkFormat.R32Sfloat;
        public const VkFormat VK_FORMAT_R32G32_UINT = VkFormat.R32g32Uint;
        public const VkFormat VK_FORMAT_R32G32_SINT = VkFormat.R32g32Sint;
        public const VkFormat VK_FORMAT_R32G32_SFLOAT = VkFormat.R32g32Sfloat;
        public const VkFormat VK_FORMAT_R32G32B32_UINT = VkFormat.R32g32b32Uint;
        public const VkFormat VK_FORMAT_R32G32B32_SINT = VkFormat.R32g32b32Sint;
        public const VkFormat VK_FORMAT_R32G32B32_SFLOAT = VkFormat.R32g32b32Sfloat;
        public const VkFormat VK_FORMAT_R32G32B32A32_UINT = VkFormat.R32g32b32a32Uint;
        public const VkFormat VK_FORMAT_R32G32B32A32_SINT = VkFormat.R32g32b32a32Sint;
        public const VkFormat VK_FORMAT_R32G32B32A32_SFLOAT = VkFormat.R32g32b32a32Sfloat;
        public const VkFormat VK_FORMAT_R64_UINT = VkFormat.R64Uint;
        public const VkFormat VK_FORMAT_R64_SINT = VkFormat.R64Sint;
        public const VkFormat VK_FORMAT_R64_SFLOAT = VkFormat.R64Sfloat;
        public const VkFormat VK_FORMAT_R64G64_UINT = VkFormat.R64g64Uint;
        public const VkFormat VK_FORMAT_R64G64_SINT = VkFormat.R64g64Sint;
        public const VkFormat VK_FORMAT_R64G64_SFLOAT = VkFormat.R64g64Sfloat;
        public const VkFormat VK_FORMAT_R64G64B64_UINT = VkFormat.R64g64b64Uint;
        public const VkFormat VK_FORMAT_R64G64B64_SINT = VkFormat.R64g64b64Sint;
        public const VkFormat VK_FORMAT_R64G64B64_SFLOAT = VkFormat.R64g64b64Sfloat;
        public const VkFormat VK_FORMAT_R64G64B64A64_UINT = VkFormat.R64g64b64a64Uint;
        public const VkFormat VK_FORMAT_R64G64B64A64_SINT = VkFormat.R64g64b64a64Sint;
        public const VkFormat VK_FORMAT_R64G64B64A64_SFLOAT = VkFormat.R64g64b64a64Sfloat;
        public const VkFormat VK_FORMAT_B10G11R11_UFLOAT_PACK32 = VkFormat.B10g11r11UfloatPack32;
        public const VkFormat VK_FORMAT_E5B9G9R9_UFLOAT_PACK32 = VkFormat.E5b9g9r9UfloatPack32;
        public const VkFormat VK_FORMAT_D16_UNORM = VkFormat.D16Unorm;
        public const VkFormat VK_FORMAT_X8_D24_UNORM_PACK32 = VkFormat.X8D24UnormPack32;
        public const VkFormat VK_FORMAT_D32_SFLOAT = VkFormat.D32Sfloat;
        public const VkFormat VK_FORMAT_S8_UINT = VkFormat.S8Uint;
        public const VkFormat VK_FORMAT_D16_UNORM_S8_UINT = VkFormat.D16UnormS8Uint;
        public const VkFormat VK_FORMAT_D24_UNORM_S8_UINT = VkFormat.D24UnormS8Uint;
        public const VkFormat VK_FORMAT_D32_SFLOAT_S8_UINT = VkFormat.D32SfloatS8Uint;
        public const VkFormat VK_FORMAT_BC1_RGB_UNORM_BLOCK = VkFormat.Bc1RgbUnormBlock;
        public const VkFormat VK_FORMAT_BC1_RGB_SRGB_BLOCK = VkFormat.Bc1RgbSrgbBlock;
        public const VkFormat VK_FORMAT_BC1_RGBA_UNORM_BLOCK = VkFormat.Bc1RgbaUnormBlock;
        public const VkFormat VK_FORMAT_BC1_RGBA_SRGB_BLOCK = VkFormat.Bc1RgbaSrgbBlock;
        public const VkFormat VK_FORMAT_BC2_UNORM_BLOCK = VkFormat.Bc2UnormBlock;
        public const VkFormat VK_FORMAT_BC2_SRGB_BLOCK = VkFormat.Bc2SrgbBlock;
        public const VkFormat VK_FORMAT_BC3_UNORM_BLOCK = VkFormat.Bc3UnormBlock;
        public const VkFormat VK_FORMAT_BC3_SRGB_BLOCK = VkFormat.Bc3SrgbBlock;
        public const VkFormat VK_FORMAT_BC4_UNORM_BLOCK = VkFormat.Bc4UnormBlock;
        public const VkFormat VK_FORMAT_BC4_SNORM_BLOCK = VkFormat.Bc4SnormBlock;
        public const VkFormat VK_FORMAT_BC5_UNORM_BLOCK = VkFormat.Bc5UnormBlock;
        public const VkFormat VK_FORMAT_BC5_SNORM_BLOCK = VkFormat.Bc5SnormBlock;
        public const VkFormat VK_FORMAT_BC6H_UFLOAT_BLOCK = VkFormat.Bc6hUfloatBlock;
        public const VkFormat VK_FORMAT_BC6H_SFLOAT_BLOCK = VkFormat.Bc6hSfloatBlock;
        public const VkFormat VK_FORMAT_BC7_UNORM_BLOCK = VkFormat.Bc7UnormBlock;
        public const VkFormat VK_FORMAT_BC7_SRGB_BLOCK = VkFormat.Bc7SrgbBlock;
        public const VkFormat VK_FORMAT_ETC2_R8G8B8_UNORM_BLOCK = VkFormat.Etc2R8g8b8UnormBlock;
        public const VkFormat VK_FORMAT_ETC2_R8G8B8_SRGB_BLOCK = VkFormat.Etc2R8g8b8SrgbBlock;
        public const VkFormat VK_FORMAT_ETC2_R8G8B8A1_UNORM_BLOCK = VkFormat.Etc2R8g8b8a1UnormBlock;
        public const VkFormat VK_FORMAT_ETC2_R8G8B8A1_SRGB_BLOCK = VkFormat.Etc2R8g8b8a1SrgbBlock;
        public const VkFormat VK_FORMAT_ETC2_R8G8B8A8_UNORM_BLOCK = VkFormat.Etc2R8g8b8a8UnormBlock;
        public const VkFormat VK_FORMAT_ETC2_R8G8B8A8_SRGB_BLOCK = VkFormat.Etc2R8g8b8a8SrgbBlock;
        public const VkFormat VK_FORMAT_EAC_R11_UNORM_BLOCK = VkFormat.EacR11UnormBlock;
        public const VkFormat VK_FORMAT_EAC_R11_SNORM_BLOCK = VkFormat.EacR11SnormBlock;
        public const VkFormat VK_FORMAT_EAC_R11G11_UNORM_BLOCK = VkFormat.EacR11g11UnormBlock;
        public const VkFormat VK_FORMAT_EAC_R11G11_SNORM_BLOCK = VkFormat.EacR11g11SnormBlock;
        public const VkFormat VK_FORMAT_ASTC_4x4_UNORM_BLOCK = VkFormat.Astc4x4UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_4x4_SRGB_BLOCK = VkFormat.Astc4x4SrgbBlock;
        public const VkFormat VK_FORMAT_ASTC_5x4_UNORM_BLOCK = VkFormat.Astc5x4UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_5x4_SRGB_BLOCK = VkFormat.Astc5x4SrgbBlock;
        public const VkFormat VK_FORMAT_ASTC_5x5_UNORM_BLOCK = VkFormat.Astc5x5UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_5x5_SRGB_BLOCK = VkFormat.Astc5x5SrgbBlock;
        public const VkFormat VK_FORMAT_ASTC_6x5_UNORM_BLOCK = VkFormat.Astc6x5UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_6x5_SRGB_BLOCK = VkFormat.Astc6x5SrgbBlock;
        public const VkFormat VK_FORMAT_ASTC_6x6_UNORM_BLOCK = VkFormat.Astc6x6UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_6x6_SRGB_BLOCK = VkFormat.Astc6x6SrgbBlock;
        public const VkFormat VK_FORMAT_ASTC_8x5_UNORM_BLOCK = VkFormat.Astc8x5UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_8x5_SRGB_BLOCK = VkFormat.Astc8x5SrgbBlock;
        public const VkFormat VK_FORMAT_ASTC_8x6_UNORM_BLOCK = VkFormat.Astc8x6UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_8x6_SRGB_BLOCK = VkFormat.Astc8x6SrgbBlock;
        public const VkFormat VK_FORMAT_ASTC_8x8_UNORM_BLOCK = VkFormat.Astc8x8UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_8x8_SRGB_BLOCK = VkFormat.Astc8x8SrgbBlock;
        public const VkFormat VK_FORMAT_ASTC_10x5_UNORM_BLOCK = VkFormat.Astc10x5UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_10x5_SRGB_BLOCK = VkFormat.Astc10x5SrgbBlock;
        public const VkFormat VK_FORMAT_ASTC_10x6_UNORM_BLOCK = VkFormat.Astc10x6UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_10x6_SRGB_BLOCK = VkFormat.Astc10x6SrgbBlock;
        public const VkFormat VK_FORMAT_ASTC_10x8_UNORM_BLOCK = VkFormat.Astc10x8UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_10x8_SRGB_BLOCK = VkFormat.Astc10x8SrgbBlock;
        public const VkFormat VK_FORMAT_ASTC_10x10_UNORM_BLOCK = VkFormat.Astc10x10UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_10x10_SRGB_BLOCK = VkFormat.Astc10x10SrgbBlock;
        public const VkFormat VK_FORMAT_ASTC_12x10_UNORM_BLOCK = VkFormat.Astc12x10UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_12x10_SRGB_BLOCK = VkFormat.Astc12x10SrgbBlock;
        public const VkFormat VK_FORMAT_ASTC_12x12_UNORM_BLOCK = VkFormat.Astc12x12UnormBlock;
        public const VkFormat VK_FORMAT_ASTC_12x12_SRGB_BLOCK = VkFormat.Astc12x12SrgbBlock;
        public const VkFormat VK_FORMAT_G8B8G8R8_422_UNORM = VkFormat.G8b8g8r8422Unorm;
        public const VkFormat VK_FORMAT_B8G8R8G8_422_UNORM = VkFormat.B8g8r8g8422Unorm;
        public const VkFormat VK_FORMAT_G8_B8_R8_3PLANE_420_UNORM = VkFormat.G8B8R83plane420Unorm;
        public const VkFormat VK_FORMAT_G8_B8R8_2PLANE_420_UNORM = VkFormat.G8B8r82plane420Unorm;
        public const VkFormat VK_FORMAT_G8_B8_R8_3PLANE_422_UNORM = VkFormat.G8B8R83plane422Unorm;
        public const VkFormat VK_FORMAT_G8_B8R8_2PLANE_422_UNORM = VkFormat.G8B8r82plane422Unorm;
        public const VkFormat VK_FORMAT_G8_B8_R8_3PLANE_444_UNORM = VkFormat.G8B8R83plane444Unorm;
        public const VkFormat VK_FORMAT_R10X6_UNORM_PACK16 = VkFormat.R10x6UnormPack16;
        public const VkFormat VK_FORMAT_R10X6G10X6_UNORM_2PACK16 = VkFormat.R10x6g10x6Unorm2pack16;
        public const VkFormat VK_FORMAT_R10X6G10X6B10X6A10X6_UNORM_4PACK16 = VkFormat.R10x6g10x6b10x6a10x6Unorm4pack16;
        public const VkFormat VK_FORMAT_G10X6B10X6G10X6R10X6_422_UNORM_4PACK16 = VkFormat.G10x6b10x6g10x6r10x6422Unorm4pack16;
        public const VkFormat VK_FORMAT_B10X6G10X6R10X6G10X6_422_UNORM_4PACK16 = VkFormat.B10x6g10x6r10x6g10x6422Unorm4pack16;
        public const VkFormat VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_420_UNORM_3PACK16 = VkFormat.G10x6B10x6R10x63plane420Unorm3pack16;
        public const VkFormat VK_FORMAT_G10X6_B10X6R10X6_2PLANE_420_UNORM_3PACK16 = VkFormat.G10x6B10x6r10x62plane420Unorm3pack16;
        public const VkFormat VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_422_UNORM_3PACK16 = VkFormat.G10x6B10x6R10x63plane422Unorm3pack16;
        public const VkFormat VK_FORMAT_G10X6_B10X6R10X6_2PLANE_422_UNORM_3PACK16 = VkFormat.G10x6B10x6r10x62plane422Unorm3pack16;
        public const VkFormat VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_444_UNORM_3PACK16 = VkFormat.G10x6B10x6R10x63plane444Unorm3pack16;
        public const VkFormat VK_FORMAT_R12X4_UNORM_PACK16 = VkFormat.R12x4UnormPack16;
        public const VkFormat VK_FORMAT_R12X4G12X4_UNORM_2PACK16 = VkFormat.R12x4g12x4Unorm2pack16;
        public const VkFormat VK_FORMAT_R12X4G12X4B12X4A12X4_UNORM_4PACK16 = VkFormat.R12x4g12x4b12x4a12x4Unorm4pack16;
        public const VkFormat VK_FORMAT_G12X4B12X4G12X4R12X4_422_UNORM_4PACK16 = VkFormat.G12x4b12x4g12x4r12x4422Unorm4pack16;
        public const VkFormat VK_FORMAT_B12X4G12X4R12X4G12X4_422_UNORM_4PACK16 = VkFormat.B12x4g12x4r12x4g12x4422Unorm4pack16;
        public const VkFormat VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_420_UNORM_3PACK16 = VkFormat.G12x4B12x4R12x43plane420Unorm3pack16;
        public const VkFormat VK_FORMAT_G12X4_B12X4R12X4_2PLANE_420_UNORM_3PACK16 = VkFormat.G12x4B12x4r12x42plane420Unorm3pack16;
        public const VkFormat VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_422_UNORM_3PACK16 = VkFormat.G12x4B12x4R12x43plane422Unorm3pack16;
        public const VkFormat VK_FORMAT_G12X4_B12X4R12X4_2PLANE_422_UNORM_3PACK16 = VkFormat.G12x4B12x4r12x42plane422Unorm3pack16;
        public const VkFormat VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_444_UNORM_3PACK16 = VkFormat.G12x4B12x4R12x43plane444Unorm3pack16;
        public const VkFormat VK_FORMAT_G16B16G16R16_422_UNORM = VkFormat.G16b16g16r16422Unorm;
        public const VkFormat VK_FORMAT_B16G16R16G16_422_UNORM = VkFormat.B16g16r16g16422Unorm;
        public const VkFormat VK_FORMAT_G16_B16_R16_3PLANE_420_UNORM = VkFormat.G16B16R163plane420Unorm;
        public const VkFormat VK_FORMAT_G16_B16R16_2PLANE_420_UNORM = VkFormat.G16B16r162plane420Unorm;
        public const VkFormat VK_FORMAT_G16_B16_R16_3PLANE_422_UNORM = VkFormat.G16B16R163plane422Unorm;
        public const VkFormat VK_FORMAT_G16_B16R16_2PLANE_422_UNORM = VkFormat.G16B16r162plane422Unorm;
        public const VkFormat VK_FORMAT_G16_B16_R16_3PLANE_444_UNORM = VkFormat.G16B16R163plane444Unorm;
        public const VkFormat VK_FORMAT_G8_B8R8_2PLANE_444_UNORM = VkFormat.G8B8r82plane444Unorm;
        public const VkFormat VK_FORMAT_G10X6_B10X6R10X6_2PLANE_444_UNORM_3PACK16 = VkFormat.G10x6B10x6r10x62plane444Unorm3pack16;
        public const VkFormat VK_FORMAT_G12X4_B12X4R12X4_2PLANE_444_UNORM_3PACK16 = VkFormat.G12x4B12x4r12x42plane444Unorm3pack16;
        public const VkFormat VK_FORMAT_G16_B16R16_2PLANE_444_UNORM = VkFormat.G16B16r162plane444Unorm;
        public const VkFormat VK_FORMAT_A4R4G4B4_UNORM_PACK16 = VkFormat.A4r4g4b4UnormPack16;
        public const VkFormat VK_FORMAT_A4B4G4R4_UNORM_PACK16 = VkFormat.A4b4g4r4UnormPack16;
        public const VkFormat VK_FORMAT_ASTC_4x4_SFLOAT_BLOCK = VkFormat.Astc4x4SfloatBlock;
        public const VkFormat VK_FORMAT_ASTC_5x4_SFLOAT_BLOCK = VkFormat.Astc5x4SfloatBlock;
        public const VkFormat VK_FORMAT_ASTC_5x5_SFLOAT_BLOCK = VkFormat.Astc5x5SfloatBlock;
        public const VkFormat VK_FORMAT_ASTC_6x5_SFLOAT_BLOCK = VkFormat.Astc6x5SfloatBlock;
        public const VkFormat VK_FORMAT_ASTC_6x6_SFLOAT_BLOCK = VkFormat.Astc6x6SfloatBlock;
        public const VkFormat VK_FORMAT_ASTC_8x5_SFLOAT_BLOCK = VkFormat.Astc8x5SfloatBlock;
        public const VkFormat VK_FORMAT_ASTC_8x6_SFLOAT_BLOCK = VkFormat.Astc8x6SfloatBlock;
        public const VkFormat VK_FORMAT_ASTC_8x8_SFLOAT_BLOCK = VkFormat.Astc8x8SfloatBlock;
        public const VkFormat VK_FORMAT_ASTC_10x5_SFLOAT_BLOCK = VkFormat.Astc10x5SfloatBlock;
        public const VkFormat VK_FORMAT_ASTC_10x6_SFLOAT_BLOCK = VkFormat.Astc10x6SfloatBlock;
        public const VkFormat VK_FORMAT_ASTC_10x8_SFLOAT_BLOCK = VkFormat.Astc10x8SfloatBlock;
        public const VkFormat VK_FORMAT_ASTC_10x10_SFLOAT_BLOCK = VkFormat.Astc10x10SfloatBlock;
        public const VkFormat VK_FORMAT_ASTC_12x10_SFLOAT_BLOCK = VkFormat.Astc12x10SfloatBlock;
        public const VkFormat VK_FORMAT_ASTC_12x12_SFLOAT_BLOCK = VkFormat.Astc12x12SfloatBlock;
        public const VkFormat VK_FORMAT_PVRTC1_2BPP_UNORM_BLOCK_IMG = VkFormat.Pvrtc12bppUnormBlockImg;
        public const VkFormat VK_FORMAT_PVRTC1_4BPP_UNORM_BLOCK_IMG = VkFormat.Pvrtc14bppUnormBlockImg;
        public const VkFormat VK_FORMAT_PVRTC2_2BPP_UNORM_BLOCK_IMG = VkFormat.Pvrtc22bppUnormBlockImg;
        public const VkFormat VK_FORMAT_PVRTC2_4BPP_UNORM_BLOCK_IMG = VkFormat.Pvrtc24bppUnormBlockImg;
        public const VkFormat VK_FORMAT_PVRTC1_2BPP_SRGB_BLOCK_IMG = VkFormat.Pvrtc12bppSrgbBlockImg;
        public const VkFormat VK_FORMAT_PVRTC1_4BPP_SRGB_BLOCK_IMG = VkFormat.Pvrtc14bppSrgbBlockImg;
        public const VkFormat VK_FORMAT_PVRTC2_2BPP_SRGB_BLOCK_IMG = VkFormat.Pvrtc22bppSrgbBlockImg;
        public const VkFormat VK_FORMAT_PVRTC2_4BPP_SRGB_BLOCK_IMG = VkFormat.Pvrtc24bppSrgbBlockImg;
        public const VkFormat VK_FORMAT_ASTC_3x3x3_UNORM_BLOCK_EXT = VkFormat.Astc3x3x3UnormBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_3x3x3_SRGB_BLOCK_EXT = VkFormat.Astc3x3x3SrgbBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_3x3x3_SFLOAT_BLOCK_EXT = VkFormat.Astc3x3x3SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_4x3x3_UNORM_BLOCK_EXT = VkFormat.Astc4x3x3UnormBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_4x3x3_SRGB_BLOCK_EXT = VkFormat.Astc4x3x3SrgbBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_4x3x3_SFLOAT_BLOCK_EXT = VkFormat.Astc4x3x3SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_4x4x3_UNORM_BLOCK_EXT = VkFormat.Astc4x4x3UnormBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_4x4x3_SRGB_BLOCK_EXT = VkFormat.Astc4x4x3SrgbBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_4x4x3_SFLOAT_BLOCK_EXT = VkFormat.Astc4x4x3SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_4x4x4_UNORM_BLOCK_EXT = VkFormat.Astc4x4x4UnormBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_4x4x4_SRGB_BLOCK_EXT = VkFormat.Astc4x4x4SrgbBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_4x4x4_SFLOAT_BLOCK_EXT = VkFormat.Astc4x4x4SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_5x4x4_UNORM_BLOCK_EXT = VkFormat.Astc5x4x4UnormBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_5x4x4_SRGB_BLOCK_EXT = VkFormat.Astc5x4x4SrgbBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_5x4x4_SFLOAT_BLOCK_EXT = VkFormat.Astc5x4x4SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_5x5x4_UNORM_BLOCK_EXT = VkFormat.Astc5x5x4UnormBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_5x5x4_SRGB_BLOCK_EXT = VkFormat.Astc5x5x4SrgbBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_5x5x4_SFLOAT_BLOCK_EXT = VkFormat.Astc5x5x4SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_5x5x5_UNORM_BLOCK_EXT = VkFormat.Astc5x5x5UnormBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_5x5x5_SRGB_BLOCK_EXT = VkFormat.Astc5x5x5SrgbBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_5x5x5_SFLOAT_BLOCK_EXT = VkFormat.Astc5x5x5SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_6x5x5_UNORM_BLOCK_EXT = VkFormat.Astc6x5x5UnormBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_6x5x5_SRGB_BLOCK_EXT = VkFormat.Astc6x5x5SrgbBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_6x5x5_SFLOAT_BLOCK_EXT = VkFormat.Astc6x5x5SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_6x6x5_UNORM_BLOCK_EXT = VkFormat.Astc6x6x5UnormBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_6x6x5_SRGB_BLOCK_EXT = VkFormat.Astc6x6x5SrgbBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_6x6x5_SFLOAT_BLOCK_EXT = VkFormat.Astc6x6x5SfloatBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_6x6x6_UNORM_BLOCK_EXT = VkFormat.Astc6x6x6UnormBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_6x6x6_SRGB_BLOCK_EXT = VkFormat.Astc6x6x6SrgbBlockEXT;
        public const VkFormat VK_FORMAT_ASTC_6x6x6_SFLOAT_BLOCK_EXT = VkFormat.Astc6x6x6SfloatBlockEXT;
        public const VkFormat VK_FORMAT_R16G16_S10_5_NV = VkFormat.R16g16S105NV;
        public const VkFormat VK_FORMAT_A1B5G5R5_UNORM_PACK16_KHR = VkFormat.A1b5g5r5UnormPack16KHR;
        public const VkFormat VK_FORMAT_A8_UNORM_KHR = VkFormat.A8UnormKHR;
    }

    public enum VkStructureType : int
    {
        ApplicationInfo = 0,
        InstanceCreateInfo = 1,
        DeviceQueueCreateInfo = 2,
        DeviceCreateInfo = 3,
        SubmitInfo = 4,
        MemoryAllocateInfo = 5,
        MappedMemoryRange = 6,
        BindSparseInfo = 7,
        FenceCreateInfo = 8,
        SemaphoreCreateInfo = 9,
        EventCreateInfo = 10,
        QueryPoolCreateInfo = 11,
        BufferCreateInfo = 12,
        BufferViewCreateInfo = 13,
        ImageCreateInfo = 14,
        ImageViewCreateInfo = 15,
        ShaderModuleCreateInfo = 16,
        PipelineCacheCreateInfo = 17,
        PipelineShaderStageCreateInfo = 18,
        PipelineVertexInputStateCreateInfo = 19,
        PipelineInputAssemblyStateCreateInfo = 20,
        PipelineTessellationStateCreateInfo = 21,
        PipelineViewportStateCreateInfo = 22,
        PipelineRasterizationStateCreateInfo = 23,
        PipelineMultisampleStateCreateInfo = 24,
        PipelineDepthStencilStateCreateInfo = 25,
        PipelineColorBlendStateCreateInfo = 26,
        PipelineDynamicStateCreateInfo = 27,
        GraphicsPipelineCreateInfo = 28,
        ComputePipelineCreateInfo = 29,
        PipelineLayoutCreateInfo = 30,
        SamplerCreateInfo = 31,
        DescriptorSetLayoutCreateInfo = 32,
        DescriptorPoolCreateInfo = 33,
        DescriptorSetAllocateInfo = 34,
        WriteDescriptorSet = 35,
        CopyDescriptorSet = 36,
        FramebufferCreateInfo = 37,
        RenderPassCreateInfo = 38,
        CommandPoolCreateInfo = 39,
        CommandBufferAllocateInfo = 40,
        CommandBufferInheritanceInfo = 41,
        CommandBufferBeginInfo = 42,
        RenderPassBeginInfo = 43,
        BufferMemoryBarrier = 44,
        ImageMemoryBarrier = 45,
        MemoryBarrier = 46,
        ///<summary>Reserved for internal use by the loader, layers, and ICDs</summary>
        LoaderInstanceCreateInfo = 47,
        ///<summary>Reserved for internal use by the loader, layers, and ICDs</summary>
        LoaderDeviceCreateInfo = 48,
        PhysicalDeviceSubgroupProperties = 1000094000,
        BindBufferMemoryInfo = 1000157000,
        BindImageMemoryInfo = 1000157001,
        PhysicalDevice16bitStorageFeatures = 1000083000,
        MemoryDedicatedRequirements = 1000127000,
        MemoryDedicatedAllocateInfo = 1000127001,
        MemoryAllocateFlagsInfo = 1000060000,
        DeviceGroupRenderPassBeginInfo = 1000060003,
        DeviceGroupCommandBufferBeginInfo = 1000060004,
        DeviceGroupSubmitInfo = 1000060005,
        DeviceGroupBindSparseInfo = 1000060006,
        BindBufferMemoryDeviceGroupInfo = 1000060013,
        BindImageMemoryDeviceGroupInfo = 1000060014,
        PhysicalDeviceGroupProperties = 1000070000,
        DeviceGroupDeviceCreateInfo = 1000070001,
        BufferMemoryRequirementsInfo2 = 1000146000,
        ImageMemoryRequirementsInfo2 = 1000146001,
        ImageSparseMemoryRequirementsInfo2 = 1000146002,
        MemoryRequirements2 = 1000146003,
        SparseImageMemoryRequirements2 = 1000146004,
        PhysicalDeviceFeatures2 = 1000059000,
        PhysicalDeviceProperties2 = 1000059001,
        FormatProperties2 = 1000059002,
        ImageFormatProperties2 = 1000059003,
        PhysicalDeviceImageFormatInfo2 = 1000059004,
        QueueFamilyProperties2 = 1000059005,
        PhysicalDeviceMemoryProperties2 = 1000059006,
        SparseImageFormatProperties2 = 1000059007,
        PhysicalDeviceSparseImageFormatInfo2 = 1000059008,
        PhysicalDevicePointClippingProperties = 1000117000,
        RenderPassInputAttachmentAspectCreateInfo = 1000117001,
        ImageViewUsageCreateInfo = 1000117002,
        PipelineTessellationDomainOriginStateCreateInfo = 1000117003,
        RenderPassMultiviewCreateInfo = 1000053000,
        PhysicalDeviceMultiviewFeatures = 1000053001,
        PhysicalDeviceMultiviewProperties = 1000053002,
        PhysicalDeviceVariablePointersFeatures = 1000120000,
        ProtectedSubmitInfo = 1000145000,
        PhysicalDeviceProtectedMemoryFeatures = 1000145001,
        PhysicalDeviceProtectedMemoryProperties = 1000145002,
        DeviceQueueInfo2 = 1000145003,
        SamplerYcbcrConversionCreateInfo = 1000156000,
        SamplerYcbcrConversionInfo = 1000156001,
        BindImagePlaneMemoryInfo = 1000156002,
        ImagePlaneMemoryRequirementsInfo = 1000156003,
        PhysicalDeviceSamplerYcbcrConversionFeatures = 1000156004,
        SamplerYcbcrConversionImageFormatProperties = 1000156005,
        DescriptorUpdateTemplateCreateInfo = 1000085000,
        PhysicalDeviceExternalImageFormatInfo = 1000071000,
        ExternalImageFormatProperties = 1000071001,
        PhysicalDeviceExternalBufferInfo = 1000071002,
        ExternalBufferProperties = 1000071003,
        PhysicalDeviceIdProperties = 1000071004,
        ExternalMemoryBufferCreateInfo = 1000072000,
        ExternalMemoryImageCreateInfo = 1000072001,
        ExportMemoryAllocateInfo = 1000072002,
        PhysicalDeviceExternalFenceInfo = 1000112000,
        ExternalFenceProperties = 1000112001,
        ExportFenceCreateInfo = 1000113000,
        ExportSemaphoreCreateInfo = 1000077000,
        PhysicalDeviceExternalSemaphoreInfo = 1000076000,
        ExternalSemaphoreProperties = 1000076001,
        PhysicalDeviceMaintenance3Properties = 1000168000,
        DescriptorSetLayoutSupport = 1000168001,
        PhysicalDeviceShaderDrawParametersFeatures = 1000063000,
        PhysicalDeviceVulkan11Features = 49,
        PhysicalDeviceVulkan11Properties = 50,
        PhysicalDeviceVulkan12Features = 51,
        PhysicalDeviceVulkan12Properties = 52,
        ImageFormatListCreateInfo = 1000147000,
        AttachmentDescription2 = 1000109000,
        AttachmentReference2 = 1000109001,
        SubpassDescription2 = 1000109002,
        SubpassDependency2 = 1000109003,
        RenderPassCreateInfo2 = 1000109004,
        SubpassBeginInfo = 1000109005,
        SubpassEndInfo = 1000109006,
        PhysicalDevice8bitStorageFeatures = 1000177000,
        PhysicalDeviceDriverProperties = 1000196000,
        PhysicalDeviceShaderAtomicInt64Features = 1000180000,
        PhysicalDeviceShaderFloat16Int8Features = 1000082000,
        PhysicalDeviceFloatControlsProperties = 1000197000,
        DescriptorSetLayoutBindingCreateInfo = 1000161000,
        PhysicalDeviceDescriptorIndexingFeatures = 1000161001,
        PhysicalDeviceDescriptorIndexingProperties = 1000161002,
        DescriptorSetVariableDescriptorCountAllocateInfo = 1000161003,
        DescriptorSetVariableDescriptorCountLayoutSupport = 1000161004,
        PhysicalDeviceDepthStencilResolveProperties = 1000199000,
        SubpassDescriptionDepthStencilResolve = 1000199001,
        PhysicalDeviceScalarBlockLayoutFeatures = 1000221000,
        ImageStencilUsageCreateInfo = 1000246000,
        PhysicalDeviceSamplerFilterMinmaxProperties = 1000130000,
        SamplerReductionModeCreateInfo = 1000130001,
        PhysicalDeviceVulkanMemoryModelFeatures = 1000211000,
        PhysicalDeviceImagelessFramebufferFeatures = 1000108000,
        FramebufferAttachmentsCreateInfo = 1000108001,
        FramebufferAttachmentImageInfo = 1000108002,
        RenderPassAttachmentBeginInfo = 1000108003,
        PhysicalDeviceUniformBufferStandardLayoutFeatures = 1000253000,
        PhysicalDeviceShaderSubgroupExtendedTypesFeatures = 1000175000,
        PhysicalDeviceSeparateDepthStencilLayoutsFeatures = 1000241000,
        AttachmentReferenceStencilLayout = 1000241001,
        AttachmentDescriptionStencilLayout = 1000241002,
        PhysicalDeviceHostQueryResetFeatures = 1000261000,
        PhysicalDeviceTimelineSemaphoreFeatures = 1000207000,
        PhysicalDeviceTimelineSemaphoreProperties = 1000207001,
        SemaphoreTypeCreateInfo = 1000207002,
        TimelineSemaphoreSubmitInfo = 1000207003,
        SemaphoreWaitInfo = 1000207004,
        SemaphoreSignalInfo = 1000207005,
        PhysicalDeviceBufferDeviceAddressFeatures = 1000257000,
        BufferDeviceAddressInfo = 1000244001,
        BufferOpaqueCaptureAddressCreateInfo = 1000257002,
        MemoryOpaqueCaptureAddressAllocateInfo = 1000257003,
        DeviceMemoryOpaqueCaptureAddressInfo = 1000257004,
        PhysicalDeviceVulkan13Features = 53,
        PhysicalDeviceVulkan13Properties = 54,
        PipelineCreationFeedbackCreateInfo = 1000192000,
        PhysicalDeviceShaderTerminateInvocationFeatures = 1000215000,
        PhysicalDeviceToolProperties = 1000245000,
        PhysicalDeviceShaderDemoteToHelperInvocationFeatures = 1000276000,
        PhysicalDevicePrivateDataFeatures = 1000295000,
        DevicePrivateDataCreateInfo = 1000295001,
        PrivateDataSlotCreateInfo = 1000295002,
        PhysicalDevicePipelineCreationCacheControlFeatures = 1000297000,
        MemoryBarrier2 = 1000314000,
        BufferMemoryBarrier2 = 1000314001,
        ImageMemoryBarrier2 = 1000314002,
        DependencyInfo = 1000314003,
        SubmitInfo2 = 1000314004,
        SemaphoreSubmitInfo = 1000314005,
        CommandBufferSubmitInfo = 1000314006,
        PhysicalDeviceSynchronization2Features = 1000314007,
        PhysicalDeviceZeroInitializeWorkgroupMemoryFeatures = 1000325000,
        PhysicalDeviceImageRobustnessFeatures = 1000335000,
        CopyBufferInfo2 = 1000337000,
        CopyImageInfo2 = 1000337001,
        CopyBufferToImageInfo2 = 1000337002,
        CopyImageToBufferInfo2 = 1000337003,
        BlitImageInfo2 = 1000337004,
        ResolveImageInfo2 = 1000337005,
        BufferCopy2 = 1000337006,
        ImageCopy2 = 1000337007,
        ImageBlit2 = 1000337008,
        BufferImageCopy2 = 1000337009,
        ImageResolve2 = 1000337010,
        PhysicalDeviceSubgroupSizeControlProperties = 1000225000,
        PipelineShaderStageRequiredSubgroupSizeCreateInfo = 1000225001,
        PhysicalDeviceSubgroupSizeControlFeatures = 1000225002,
        PhysicalDeviceInlineUniformBlockFeatures = 1000138000,
        PhysicalDeviceInlineUniformBlockProperties = 1000138001,
        WriteDescriptorSetInlineUniformBlock = 1000138002,
        DescriptorPoolInlineUniformBlockCreateInfo = 1000138003,
        PhysicalDeviceTextureCompressionAstcHdrFeatures = 1000066000,
        RenderingInfo = 1000044000,
        RenderingAttachmentInfo = 1000044001,
        PipelineRenderingCreateInfo = 1000044002,
        PhysicalDeviceDynamicRenderingFeatures = 1000044003,
        CommandBufferInheritanceRenderingInfo = 1000044004,
        PhysicalDeviceShaderIntegerDotProductFeatures = 1000280000,
        PhysicalDeviceShaderIntegerDotProductProperties = 1000280001,
        PhysicalDeviceTexelBufferAlignmentProperties = 1000281001,
        FormatProperties3 = 1000360000,
        PhysicalDeviceMaintenance4Features = 1000413000,
        PhysicalDeviceMaintenance4Properties = 1000413001,
        DeviceBufferMemoryRequirements = 1000413002,
        DeviceImageMemoryRequirements = 1000413003,
        PhysicalDeviceVulkanSc10Features = 1000298000,
        PhysicalDeviceVulkanSc10Properties = 1000298001,
        DeviceObjectReservationCreateInfo = 1000298002,
        CommandPoolMemoryReservationCreateInfo = 1000298003,
        CommandPoolMemoryConsumption = 1000298004,
        PipelinePoolSize = 1000298005,
        FaultData = 1000298007,
        FaultCallbackInfo = 1000298008,
        PipelineOfflineCreateInfo = 1000298010,
        SwapchainCreateInfoKHR = 1000001000,
        PresentInfoKHR = 1000001001,
        DeviceGroupPresentCapabilitiesKHR = 1000060007,
        ImageSwapchainCreateInfoKHR = 1000060008,
        BindImageMemorySwapchainInfoKHR = 1000060009,
        AcquireNextImageInfoKHR = 1000060010,
        DeviceGroupPresentInfoKHR = 1000060011,
        DeviceGroupSwapchainCreateInfoKHR = 1000060012,
        DisplayModeCreateInfoKHR = 1000002000,
        DisplaySurfaceCreateInfoKHR = 1000002001,
        DisplayPresentInfoKHR = 1000003000,
        XlibSurfaceCreateInfoKHR = 1000004000,
        XcbSurfaceCreateInfoKHR = 1000005000,
        WaylandSurfaceCreateInfoKHR = 1000006000,
        AndroidSurfaceCreateInfoKHR = 1000008000,
        Win32SurfaceCreateInfoKHR = 1000009000,
        NativeBufferAndroid = 1000010000,
        SwapchainImageCreateInfoAndroid = 1000010001,
        PhysicalDevicePresentationPropertiesAndroid = 1000010002,
        DebugReportCallbackCreateInfoEXT = 1000011000,
        PipelineRasterizationStateRasterizationOrderAMD = 1000018000,
        DebugMarkerObjectNameInfoEXT = 1000022000,
        DebugMarkerObjectTagInfoEXT = 1000022001,
        DebugMarkerMarkerInfoEXT = 1000022002,
        VideoProfileInfoKHR = 1000023000,
        VideoCapabilitiesKHR = 1000023001,
        VideoPictureResourceInfoKHR = 1000023002,
        VideoSessionMemoryRequirementsKHR = 1000023003,
        BindVideoSessionMemoryInfoKHR = 1000023004,
        VideoSessionCreateInfoKHR = 1000023005,
        VideoSessionParametersCreateInfoKHR = 1000023006,
        VideoSessionParametersUpdateInfoKHR = 1000023007,
        VideoBeginCodingInfoKHR = 1000023008,
        VideoEndCodingInfoKHR = 1000023009,
        VideoCodingControlInfoKHR = 1000023010,
        VideoReferenceSlotInfoKHR = 1000023011,
        QueueFamilyVideoPropertiesKHR = 1000023012,
        VideoProfileListInfoKHR = 1000023013,
        PhysicalDeviceVideoFormatInfoKHR = 1000023014,
        VideoFormatPropertiesKHR = 1000023015,
        QueueFamilyQueryResultStatusPropertiesKHR = 1000023016,
        VideoDecodeInfoKHR = 1000024000,
        VideoDecodeCapabilitiesKHR = 1000024001,
        VideoDecodeUsageInfoKHR = 1000024002,
        DedicatedAllocationImageCreateInfoNV = 1000026000,
        DedicatedAllocationBufferCreateInfoNV = 1000026001,
        DedicatedAllocationMemoryAllocateInfoNV = 1000026002,
        PhysicalDeviceTransformFeedbackFeaturesEXT = 1000028000,
        PhysicalDeviceTransformFeedbackPropertiesEXT = 1000028001,
        PipelineRasterizationStateStreamCreateInfoEXT = 1000028002,
        CuModuleCreateInfoNVX = 1000029000,
        CuFunctionCreateInfoNVX = 1000029001,
        CuLaunchInfoNVX = 1000029002,
        ImageViewHandleInfoNVX = 1000030000,
        ImageViewAddressPropertiesNVX = 1000030001,
        VideoEncodeH264CapabilitiesEXT = 1000038000,
        VideoEncodeH264SessionParametersCreateInfoEXT = 1000038001,
        VideoEncodeH264SessionParametersAddInfoEXT = 1000038002,
        VideoEncodeH264PictureInfoEXT = 1000038003,
        VideoEncodeH264DpbSlotInfoEXT = 1000038004,
        VideoEncodeH264NaluSliceInfoEXT = 1000038005,
        VideoEncodeH264GopRemainingFrameInfoEXT = 1000038006,
        VideoEncodeH264ProfileInfoEXT = 1000038007,
        VideoEncodeH264RateControlInfoEXT = 1000038008,
        VideoEncodeH264RateControlLayerInfoEXT = 1000038009,
        VideoEncodeH264SessionCreateInfoEXT = 1000038010,
        VideoEncodeH264QualityLevelPropertiesEXT = 1000038011,
        VideoEncodeH264SessionParametersGetInfoEXT = 1000038012,
        VideoEncodeH264SessionParametersFeedbackInfoEXT = 1000038013,
        VideoEncodeH265CapabilitiesEXT = 1000039000,
        VideoEncodeH265SessionParametersCreateInfoEXT = 1000039001,
        VideoEncodeH265SessionParametersAddInfoEXT = 1000039002,
        VideoEncodeH265PictureInfoEXT = 1000039003,
        VideoEncodeH265DpbSlotInfoEXT = 1000039004,
        VideoEncodeH265NaluSliceSegmentInfoEXT = 1000039005,
        VideoEncodeH265GopRemainingFrameInfoEXT = 1000039006,
        VideoEncodeH265ProfileInfoEXT = 1000039007,
        VideoEncodeH265RateControlInfoEXT = 1000039009,
        VideoEncodeH265RateControlLayerInfoEXT = 1000039010,
        VideoEncodeH265SessionCreateInfoEXT = 1000039011,
        VideoEncodeH265QualityLevelPropertiesEXT = 1000039012,
        VideoEncodeH265SessionParametersGetInfoEXT = 1000039013,
        VideoEncodeH265SessionParametersFeedbackInfoEXT = 1000039014,
        VideoDecodeH264CapabilitiesKHR = 1000040000,
        VideoDecodeH264PictureInfoKHR = 1000040001,
        VideoDecodeH264ProfileInfoKHR = 1000040003,
        VideoDecodeH264SessionParametersCreateInfoKHR = 1000040004,
        VideoDecodeH264SessionParametersAddInfoKHR = 1000040005,
        VideoDecodeH264DpbSlotInfoKHR = 1000040006,
        TextureLodGatherFormatPropertiesAMD = 1000041000,
        RenderingFragmentShadingRateAttachmentInfoKHR = 1000044006,
        RenderingFragmentDensityMapAttachmentInfoEXT = 1000044007,
        AttachmentSampleCountInfoAMD = 1000044008,
        MultiviewPerViewAttributesInfoNVX = 1000044009,
        StreamDescriptorSurfaceCreateInfoGgp = 1000049000,
        PhysicalDeviceCornerSampledImageFeaturesNV = 1000050000,
        PrivateVendorInfoPlaceholderOffset0NV = 1000051000,
        ExternalMemoryImageCreateInfoNV = 1000056000,
        ExportMemoryAllocateInfoNV = 1000056001,
        ImportMemoryWin32HandleInfoNV = 1000057000,
        ExportMemoryWin32HandleInfoNV = 1000057001,
        Win32KeyedMutexAcquireReleaseInfoNV = 1000058000,
        ValidationEXT = 1000061000,
        ViSurfaceCreateInfoNn = 1000062000,
        ImageViewAstcDecodeModeEXT = 1000067000,
        PhysicalDeviceAstcDecodeFeaturesEXT = 1000067001,
        PipelineRobustnessCreateInfoEXT = 1000068000,
        PhysicalDevicePipelineRobustnessFeaturesEXT = 1000068001,
        PhysicalDevicePipelineRobustnessPropertiesEXT = 1000068002,
        ImportMemoryWin32HandleInfoKHR = 1000073000,
        ExportMemoryWin32HandleInfoKHR = 1000073001,
        MemoryWin32HandlePropertiesKHR = 1000073002,
        MemoryGetWin32HandleInfoKHR = 1000073003,
        ImportMemoryFdInfoKHR = 1000074000,
        MemoryFdPropertiesKHR = 1000074001,
        MemoryGetFdInfoKHR = 1000074002,
        Win32KeyedMutexAcquireReleaseInfoKHR = 1000075000,
        ImportSemaphoreWin32HandleInfoKHR = 1000078000,
        ExportSemaphoreWin32HandleInfoKHR = 1000078001,
        D3d12FenceSubmitInfoKHR = 1000078002,
        SemaphoreGetWin32HandleInfoKHR = 1000078003,
        ImportSemaphoreFdInfoKHR = 1000079000,
        SemaphoreGetFdInfoKHR = 1000079001,
        PhysicalDevicePushDescriptorPropertiesKHR = 1000080000,
        CommandBufferInheritanceConditionalRenderingInfoEXT = 1000081000,
        PhysicalDeviceConditionalRenderingFeaturesEXT = 1000081001,
        ConditionalRenderingBeginInfoEXT = 1000081002,
        PresentRegionsKHR = 1000084000,
        PipelineViewportWScalingStateCreateInfoNV = 1000087000,
        SurfaceCapabilities2EXT = 1000090000,
        DisplayPowerInfoEXT = 1000091000,
        DeviceEventInfoEXT = 1000091001,
        DisplayEventInfoEXT = 1000091002,
        SwapchainCounterCreateInfoEXT = 1000091003,
        PresentTimesInfoGoogle = 1000092000,
        PhysicalDeviceMultiviewPerViewAttributesPropertiesNVX = 1000097000,
        PipelineViewportSwizzleStateCreateInfoNV = 1000098000,
        PhysicalDeviceDiscardRectanglePropertiesEXT = 1000099000,
        PipelineDiscardRectangleStateCreateInfoEXT = 1000099001,
        PhysicalDeviceConservativeRasterizationPropertiesEXT = 1000101000,
        PipelineRasterizationConservativeStateCreateInfoEXT = 1000101001,
        PhysicalDeviceDepthClipEnableFeaturesEXT = 1000102000,
        PipelineRasterizationDepthClipStateCreateInfoEXT = 1000102001,
        HdrMetadataEXT = 1000105000,
        SharedPresentSurfaceCapabilitiesKHR = 1000111000,
        ImportFenceWin32HandleInfoKHR = 1000114000,
        ExportFenceWin32HandleInfoKHR = 1000114001,
        FenceGetWin32HandleInfoKHR = 1000114002,
        ImportFenceFdInfoKHR = 1000115000,
        FenceGetFdInfoKHR = 1000115001,
        PhysicalDevicePerformanceQueryFeaturesKHR = 1000116000,
        PhysicalDevicePerformanceQueryPropertiesKHR = 1000116001,
        QueryPoolPerformanceCreateInfoKHR = 1000116002,
        PerformanceQuerySubmitInfoKHR = 1000116003,
        AcquireProfilingLockInfoKHR = 1000116004,
        PerformanceCounterKHR = 1000116005,
        PerformanceCounterDescriptionKHR = 1000116006,
        PerformanceQueryReservationInfoKHR = 1000116007,
        PhysicalDeviceSurfaceInfo2KHR = 1000119000,
        SurfaceCapabilities2KHR = 1000119001,
        SurfaceFormat2KHR = 1000119002,
        DisplayProperties2KHR = 1000121000,
        DisplayPlaneProperties2KHR = 1000121001,
        DisplayModeProperties2KHR = 1000121002,
        DisplayPlaneInfo2KHR = 1000121003,
        DisplayPlaneCapabilities2KHR = 1000121004,
        IosSurfaceCreateInfoMvk = 1000122000,
        MacosSurfaceCreateInfoMvk = 1000123000,
        DebugUtilsObjectNameInfoEXT = 1000128000,
        DebugUtilsObjectTagInfoEXT = 1000128001,
        DebugUtilsLabelEXT = 1000128002,
        DebugUtilsMessengerCallbackDataEXT = 1000128003,
        DebugUtilsMessengerCreateInfoEXT = 1000128004,
        AndroidHardwareBufferUsageAndroid = 1000129000,
        AndroidHardwareBufferPropertiesAndroid = 1000129001,
        AndroidHardwareBufferFormatPropertiesAndroid = 1000129002,
        ImportAndroidHardwareBufferInfoAndroid = 1000129003,
        MemoryGetAndroidHardwareBufferInfoAndroid = 1000129004,
        ExternalFormatAndroid = 1000129005,
        AndroidHardwareBufferFormatProperties2Android = 1000129006,
        PhysicalDeviceShaderEnqueueFeaturesAmdx = 1000134000,
        PhysicalDeviceShaderEnqueuePropertiesAmdx = 1000134001,
        ExecutionGraphPipelineScratchSizeAmdx = 1000134002,
        ExecutionGraphPipelineCreateInfoAmdx = 1000134003,
        PipelineShaderStageNodeCreateInfoAmdx = 1000134004,
        SampleLocationsInfoEXT = 1000143000,
        RenderPassSampleLocationsBeginInfoEXT = 1000143001,
        PipelineSampleLocationsStateCreateInfoEXT = 1000143002,
        PhysicalDeviceSampleLocationsPropertiesEXT = 1000143003,
        MultisamplePropertiesEXT = 1000143004,
        PhysicalDeviceBlendOperationAdvancedFeaturesEXT = 1000148000,
        PhysicalDeviceBlendOperationAdvancedPropertiesEXT = 1000148001,
        PipelineColorBlendAdvancedStateCreateInfoEXT = 1000148002,
        PipelineCoverageToColorStateCreateInfoNV = 1000149000,
        WriteDescriptorSetAccelerationStructureKHR = 1000150007,
        AccelerationStructureBuildGeometryInfoKHR = 1000150000,
        AccelerationStructureDeviceAddressInfoKHR = 1000150002,
        AccelerationStructureGeometryAabbsDataKHR = 1000150003,
        AccelerationStructureGeometryInstancesDataKHR = 1000150004,
        AccelerationStructureGeometryTrianglesDataKHR = 1000150005,
        AccelerationStructureGeometryKHR = 1000150006,
        AccelerationStructureVersionInfoKHR = 1000150009,
        CopyAccelerationStructureInfoKHR = 1000150010,
        CopyAccelerationStructureToMemoryInfoKHR = 1000150011,
        CopyMemoryToAccelerationStructureInfoKHR = 1000150012,
        PhysicalDeviceAccelerationStructureFeaturesKHR = 1000150013,
        PhysicalDeviceAccelerationStructurePropertiesKHR = 1000150014,
        AccelerationStructureCreateInfoKHR = 1000150017,
        AccelerationStructureBuildSizesInfoKHR = 1000150020,
        PhysicalDeviceRayTracingPipelineFeaturesKHR = 1000347000,
        PhysicalDeviceRayTracingPipelinePropertiesKHR = 1000347001,
        RayTracingPipelineCreateInfoKHR = 1000150015,
        RayTracingShaderGroupCreateInfoKHR = 1000150016,
        RayTracingPipelineInterfaceCreateInfoKHR = 1000150018,
        PhysicalDeviceRayQueryFeaturesKHR = 1000348013,
        PipelineCoverageModulationStateCreateInfoNV = 1000152000,
        PhysicalDeviceShaderSmBuiltinsFeaturesNV = 1000154000,
        PhysicalDeviceShaderSmBuiltinsPropertiesNV = 1000154001,
        DrmFormatModifierPropertiesListEXT = 1000158000,
        PhysicalDeviceImageDrmFormatModifierInfoEXT = 1000158002,
        ImageDrmFormatModifierListCreateInfoEXT = 1000158003,
        ImageDrmFormatModifierExplicitCreateInfoEXT = 1000158004,
        ImageDrmFormatModifierPropertiesEXT = 1000158005,
        DrmFormatModifierPropertiesList2EXT = 1000158006,
        ValidationCacheCreateInfoEXT = 1000160000,
        ShaderModuleValidationCacheCreateInfoEXT = 1000160001,
        PhysicalDevicePortabilitySubsetFeaturesKHR = 1000163000,
        PhysicalDevicePortabilitySubsetPropertiesKHR = 1000163001,
        PipelineViewportShadingRateImageStateCreateInfoNV = 1000164000,
        PhysicalDeviceShadingRateImageFeaturesNV = 1000164001,
        PhysicalDeviceShadingRateImagePropertiesNV = 1000164002,
        PipelineViewportCoarseSampleOrderStateCreateInfoNV = 1000164005,
        RayTracingPipelineCreateInfoNV = 1000165000,
        AccelerationStructureCreateInfoNV = 1000165001,
        GeometryNV = 1000165003,
        GeometryTrianglesNV = 1000165004,
        GeometryAabbNV = 1000165005,
        BindAccelerationStructureMemoryInfoNV = 1000165006,
        WriteDescriptorSetAccelerationStructureNV = 1000165007,
        AccelerationStructureMemoryRequirementsInfoNV = 1000165008,
        PhysicalDeviceRayTracingPropertiesNV = 1000165009,
        RayTracingShaderGroupCreateInfoNV = 1000165011,
        AccelerationStructureInfoNV = 1000165012,
        PhysicalDeviceRepresentativeFragmentTestFeaturesNV = 1000166000,
        PipelineRepresentativeFragmentTestStateCreateInfoNV = 1000166001,
        PhysicalDeviceImageViewImageFormatInfoEXT = 1000170000,
        FilterCubicImageViewImageFormatPropertiesEXT = 1000170001,
        ImportMemoryHostPointerInfoEXT = 1000178000,
        MemoryHostPointerPropertiesEXT = 1000178001,
        PhysicalDeviceExternalMemoryHostPropertiesEXT = 1000178002,
        PhysicalDeviceShaderClockFeaturesKHR = 1000181000,
        PipelineCompilerControlCreateInfoAMD = 1000183000,
        CalibratedTimestampInfoEXT = 1000184000,
        PhysicalDeviceShaderCorePropertiesAMD = 1000185000,
        VideoDecodeH265CapabilitiesKHR = 1000187000,
        VideoDecodeH265SessionParametersCreateInfoKHR = 1000187001,
        VideoDecodeH265SessionParametersAddInfoKHR = 1000187002,
        VideoDecodeH265ProfileInfoKHR = 1000187003,
        VideoDecodeH265PictureInfoKHR = 1000187004,
        VideoDecodeH265DpbSlotInfoKHR = 1000187005,
        DeviceQueueGlobalPriorityCreateInfoKHR = 1000174000,
        PhysicalDeviceGlobalPriorityQueryFeaturesKHR = 1000388000,
        QueueFamilyGlobalPriorityPropertiesKHR = 1000388001,
        DeviceMemoryOverallocationCreateInfoAMD = 1000189000,
        PhysicalDeviceVertexAttributeDivisorPropertiesEXT = 1000190000,
        PipelineVertexInputDivisorStateCreateInfoEXT = 1000190001,
        PhysicalDeviceVertexAttributeDivisorFeaturesEXT = 1000190002,
        PresentFrameTokenGgp = 1000191000,
        PhysicalDeviceComputeShaderDerivativesFeaturesNV = 1000201000,
        PhysicalDeviceMeshShaderFeaturesNV = 1000202000,
        PhysicalDeviceMeshShaderPropertiesNV = 1000202001,
        PhysicalDeviceShaderImageFootprintFeaturesNV = 1000204000,
        PipelineViewportExclusiveScissorStateCreateInfoNV = 1000205000,
        PhysicalDeviceExclusiveScissorFeaturesNV = 1000205002,
        CheckpointDataNV = 1000206000,
        QueueFamilyCheckpointPropertiesNV = 1000206001,
        PhysicalDeviceShaderIntegerFunctions2FeaturesIntel = 1000209000,
        QueryPoolPerformanceQueryCreateInfoIntel = 1000210000,
        InitializePerformanceApiInfoIntel = 1000210001,
        PerformanceMarkerInfoIntel = 1000210002,
        PerformanceStreamMarkerInfoIntel = 1000210003,
        PerformanceOverrideInfoIntel = 1000210004,
        PerformanceConfigurationAcquireInfoIntel = 1000210005,
        PhysicalDevicePciBusInfoPropertiesEXT = 1000212000,
        DisplayNativeHdrSurfaceCapabilitiesAMD = 1000213000,
        SwapchainDisplayNativeHdrCreateInfoAMD = 1000213001,
        ImagepipeSurfaceCreateInfoFuchsia = 1000214000,
        MetalSurfaceCreateInfoEXT = 1000217000,
        PhysicalDeviceFragmentDensityMapFeaturesEXT = 1000218000,
        PhysicalDeviceFragmentDensityMapPropertiesEXT = 1000218001,
        RenderPassFragmentDensityMapCreateInfoEXT = 1000218002,
        FragmentShadingRateAttachmentInfoKHR = 1000226000,
        PipelineFragmentShadingRateStateCreateInfoKHR = 1000226001,
        PhysicalDeviceFragmentShadingRatePropertiesKHR = 1000226002,
        PhysicalDeviceFragmentShadingRateFeaturesKHR = 1000226003,
        PhysicalDeviceFragmentShadingRateKHR = 1000226004,
        PhysicalDeviceShaderCoreProperties2AMD = 1000227000,
        PhysicalDeviceCoherentMemoryFeaturesAMD = 1000229000,
        PhysicalDeviceShaderImageAtomicInt64FeaturesEXT = 1000234000,
        PhysicalDeviceMemoryBudgetPropertiesEXT = 1000237000,
        PhysicalDeviceMemoryPriorityFeaturesEXT = 1000238000,
        MemoryPriorityAllocateInfoEXT = 1000238001,
        SurfaceProtectedCapabilitiesKHR = 1000239000,
        PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV = 1000240000,
        PhysicalDeviceBufferDeviceAddressFeaturesEXT = 1000244000,
        BufferDeviceAddressCreateInfoEXT = 1000244002,
        ValidationFeaturesEXT = 1000247000,
        PhysicalDevicePresentWaitFeaturesKHR = 1000248000,
        PhysicalDeviceCooperativeMatrixFeaturesNV = 1000249000,
        CooperativeMatrixPropertiesNV = 1000249001,
        PhysicalDeviceCooperativeMatrixPropertiesNV = 1000249002,
        PhysicalDeviceCoverageReductionModeFeaturesNV = 1000250000,
        PipelineCoverageReductionStateCreateInfoNV = 1000250001,
        FramebufferMixedSamplesCombinationNV = 1000250002,
        PhysicalDeviceFragmentShaderInterlockFeaturesEXT = 1000251000,
        PhysicalDeviceYcbcrImageArraysFeaturesEXT = 1000252000,
        PhysicalDeviceProvokingVertexFeaturesEXT = 1000254000,
        PipelineRasterizationProvokingVertexStateCreateInfoEXT = 1000254001,
        PhysicalDeviceProvokingVertexPropertiesEXT = 1000254002,
        SurfaceFullScreenExclusiveInfoEXT = 1000255000,
        SurfaceCapabilitiesFullScreenExclusiveEXT = 1000255002,
        SurfaceFullScreenExclusiveWin32InfoEXT = 1000255001,
        HeadlessSurfaceCreateInfoEXT = 1000256000,
        PhysicalDeviceLineRasterizationFeaturesEXT = 1000259000,
        PipelineRasterizationLineStateCreateInfoEXT = 1000259001,
        PhysicalDeviceLineRasterizationPropertiesEXT = 1000259002,
        PhysicalDeviceShaderAtomicFloatFeaturesEXT = 1000260000,
        PhysicalDeviceIndexTypeUint8FeaturesEXT = 1000265000,
        PhysicalDeviceExtendedDynamicStateFeaturesEXT = 1000267000,
        PhysicalDevicePipelineExecutablePropertiesFeaturesKHR = 1000269000,
        PipelineInfoKHR = 1000269001,
        PipelineExecutablePropertiesKHR = 1000269002,
        PipelineExecutableInfoKHR = 1000269003,
        PipelineExecutableStatisticKHR = 1000269004,
        PipelineExecutableInternalRepresentationKHR = 1000269005,
        PhysicalDeviceHostImageCopyFeaturesEXT = 1000270000,
        PhysicalDeviceHostImageCopyPropertiesEXT = 1000270001,
        MemoryToImageCopyEXT = 1000270002,
        ImageToMemoryCopyEXT = 1000270003,
        CopyImageToMemoryInfoEXT = 1000270004,
        CopyMemoryToImageInfoEXT = 1000270005,
        HostImageLayoutTransitionInfoEXT = 1000270006,
        CopyImageToImageInfoEXT = 1000270007,
        SubresourceHostMemcpySizeEXT = 1000270008,
        HostImageCopyDevicePerformanceQueryEXT = 1000270009,
        MemoryMapInfoKHR = 1000271000,
        MemoryUnmapInfoKHR = 1000271001,
        PhysicalDeviceShaderAtomicFloat2FeaturesEXT = 1000273000,
        SurfacePresentModeEXT = 1000274000,
        SurfacePresentScalingCapabilitiesEXT = 1000274001,
        SurfacePresentModeCompatibilityEXT = 1000274002,
        PhysicalDeviceSwapchainMaintenance1FeaturesEXT = 1000275000,
        SwapchainPresentFenceInfoEXT = 1000275001,
        SwapchainPresentModesCreateInfoEXT = 1000275002,
        SwapchainPresentModeInfoEXT = 1000275003,
        SwapchainPresentScalingCreateInfoEXT = 1000275004,
        ReleaseSwapchainImagesInfoEXT = 1000275005,
        PhysicalDeviceDeviceGeneratedCommandsPropertiesNV = 1000277000,
        GraphicsShaderGroupCreateInfoNV = 1000277001,
        GraphicsPipelineShaderGroupsCreateInfoNV = 1000277002,
        IndirectCommandsLayoutTokenNV = 1000277003,
        IndirectCommandsLayoutCreateInfoNV = 1000277004,
        GeneratedCommandsInfoNV = 1000277005,
        GeneratedCommandsMemoryRequirementsInfoNV = 1000277006,
        PhysicalDeviceDeviceGeneratedCommandsFeaturesNV = 1000277007,
        PhysicalDeviceInheritedViewportScissorFeaturesNV = 1000278000,
        CommandBufferInheritanceViewportScissorInfoNV = 1000278001,
        PhysicalDeviceTexelBufferAlignmentFeaturesEXT = 1000281000,
        CommandBufferInheritanceRenderPassTransformInfoQcom = 1000282000,
        RenderPassTransformBeginInfoQcom = 1000282001,
        PhysicalDeviceDepthBiasControlFeaturesEXT = 1000283000,
        DepthBiasInfoEXT = 1000283001,
        DepthBiasRepresentationInfoEXT = 1000283002,
        PhysicalDeviceDeviceMemoryReportFeaturesEXT = 1000284000,
        DeviceDeviceMemoryReportCreateInfoEXT = 1000284001,
        DeviceMemoryReportCallbackDataEXT = 1000284002,
        PhysicalDeviceRobustness2FeaturesEXT = 1000286000,
        PhysicalDeviceRobustness2PropertiesEXT = 1000286001,
        SamplerCustomBorderColorCreateInfoEXT = 1000287000,
        PhysicalDeviceCustomBorderColorPropertiesEXT = 1000287001,
        PhysicalDeviceCustomBorderColorFeaturesEXT = 1000287002,
        PipelineLibraryCreateInfoKHR = 1000290000,
        PhysicalDevicePresentBarrierFeaturesNV = 1000292000,
        SurfaceCapabilitiesPresentBarrierNV = 1000292001,
        SwapchainPresentBarrierCreateInfoNV = 1000292002,
        PresentIdKHR = 1000294000,
        PhysicalDevicePresentIdFeaturesKHR = 1000294001,
        VideoEncodeInfoKHR = 1000299000,
        VideoEncodeRateControlInfoKHR = 1000299001,
        VideoEncodeRateControlLayerInfoKHR = 1000299002,
        VideoEncodeCapabilitiesKHR = 1000299003,
        VideoEncodeUsageInfoKHR = 1000299004,
        QueryPoolVideoEncodeFeedbackCreateInfoKHR = 1000299005,
        PhysicalDeviceVideoEncodeQualityLevelInfoKHR = 1000299006,
        VideoEncodeQualityLevelPropertiesKHR = 1000299007,
        VideoEncodeQualityLevelInfoKHR = 1000299008,
        VideoEncodeSessionParametersGetInfoKHR = 1000299009,
        VideoEncodeSessionParametersFeedbackInfoKHR = 1000299010,
        PhysicalDeviceDiagnosticsConfigFeaturesNV = 1000300000,
        DeviceDiagnosticsConfigCreateInfoNV = 1000300001,
        RefreshObjectListKHR = 1000308000,
        QueryLowLatencySupportNV = 1000310000,
        ExportMetalObjectCreateInfoEXT = 1000311000,
        ExportMetalObjectsInfoEXT = 1000311001,
        ExportMetalDeviceInfoEXT = 1000311002,
        ExportMetalCommandQueueInfoEXT = 1000311003,
        ExportMetalBufferInfoEXT = 1000311004,
        ImportMetalBufferInfoEXT = 1000311005,
        ExportMetalTextureInfoEXT = 1000311006,
        ImportMetalTextureInfoEXT = 1000311007,
        ExportMetalIoSurfaceInfoEXT = 1000311008,
        ImportMetalIoSurfaceInfoEXT = 1000311009,
        ExportMetalSharedEventInfoEXT = 1000311010,
        ImportMetalSharedEventInfoEXT = 1000311011,
        QueueFamilyCheckpointProperties2NV = 1000314008,
        CheckpointData2NV = 1000314009,
        PhysicalDeviceDescriptorBufferPropertiesEXT = 1000316000,
        PhysicalDeviceDescriptorBufferDensityMapPropertiesEXT = 1000316001,
        PhysicalDeviceDescriptorBufferFeaturesEXT = 1000316002,
        DescriptorAddressInfoEXT = 1000316003,
        DescriptorGetInfoEXT = 1000316004,
        BufferCaptureDescriptorDataInfoEXT = 1000316005,
        ImageCaptureDescriptorDataInfoEXT = 1000316006,
        ImageViewCaptureDescriptorDataInfoEXT = 1000316007,
        SamplerCaptureDescriptorDataInfoEXT = 1000316008,
        OpaqueCaptureDescriptorDataCreateInfoEXT = 1000316010,
        DescriptorBufferBindingInfoEXT = 1000316011,
        DescriptorBufferBindingPushDescriptorBufferHandleEXT = 1000316012,
        AccelerationStructureCaptureDescriptorDataInfoEXT = 1000316009,
        PhysicalDeviceGraphicsPipelineLibraryFeaturesEXT = 1000320000,
        PhysicalDeviceGraphicsPipelineLibraryPropertiesEXT = 1000320001,
        GraphicsPipelineLibraryCreateInfoEXT = 1000320002,
        PhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD = 1000321000,
        PhysicalDeviceFragmentShaderBarycentricFeaturesKHR = 1000203000,
        PhysicalDeviceFragmentShaderBarycentricPropertiesKHR = 1000322000,
        PhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR = 1000323000,
        PhysicalDeviceFragmentShadingRateEnumsPropertiesNV = 1000326000,
        PhysicalDeviceFragmentShadingRateEnumsFeaturesNV = 1000326001,
        PipelineFragmentShadingRateEnumStateCreateInfoNV = 1000326002,
        AccelerationStructureGeometryMotionTrianglesDataNV = 1000327000,
        PhysicalDeviceRayTracingMotionBlurFeaturesNV = 1000327001,
        AccelerationStructureMotionInfoNV = 1000327002,
        PhysicalDeviceMeshShaderFeaturesEXT = 1000328000,
        PhysicalDeviceMeshShaderPropertiesEXT = 1000328001,
        PhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT = 1000330000,
        PhysicalDeviceFragmentDensityMap2FeaturesEXT = 1000332000,
        PhysicalDeviceFragmentDensityMap2PropertiesEXT = 1000332001,
        CopyCommandTransformInfoQcom = 1000333000,
        PhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR = 1000336000,
        PhysicalDeviceImageCompressionControlFeaturesEXT = 1000338000,
        ImageCompressionControlEXT = 1000338001,
        ImageCompressionPropertiesEXT = 1000338004,
        PhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT = 1000339000,
        PhysicalDevice4444FormatsFeaturesEXT = 1000340000,
        PhysicalDeviceFaultFeaturesEXT = 1000341000,
        DeviceFaultCountsEXT = 1000341001,
        DeviceFaultInfoEXT = 1000341002,
        PhysicalDeviceRgba10x6FormatsFeaturesEXT = 1000344000,
        DirectfbSurfaceCreateInfoEXT = 1000346000,
        PhysicalDeviceVertexInputDynamicStateFeaturesEXT = 1000352000,
        VertexInputBindingDescription2EXT = 1000352001,
        VertexInputAttributeDescription2EXT = 1000352002,
        PhysicalDeviceDrmPropertiesEXT = 1000353000,
        PhysicalDeviceAddressBindingReportFeaturesEXT = 1000354000,
        DeviceAddressBindingCallbackDataEXT = 1000354001,
        PhysicalDeviceDepthClipControlFeaturesEXT = 1000355000,
        PipelineViewportDepthClipControlCreateInfoEXT = 1000355001,
        PhysicalDevicePrimitiveTopologyListRestartFeaturesEXT = 1000356000,
        ImportMemoryZirconHandleInfoFuchsia = 1000364000,
        MemoryZirconHandlePropertiesFuchsia = 1000364001,
        MemoryGetZirconHandleInfoFuchsia = 1000364002,
        ImportSemaphoreZirconHandleInfoFuchsia = 1000365000,
        SemaphoreGetZirconHandleInfoFuchsia = 1000365001,
        BufferCollectionCreateInfoFuchsia = 1000366000,
        ImportMemoryBufferCollectionFuchsia = 1000366001,
        BufferCollectionImageCreateInfoFuchsia = 1000366002,
        BufferCollectionPropertiesFuchsia = 1000366003,
        BufferConstraintsInfoFuchsia = 1000366004,
        BufferCollectionBufferCreateInfoFuchsia = 1000366005,
        ImageConstraintsInfoFuchsia = 1000366006,
        ImageFormatConstraintsInfoFuchsia = 1000366007,
        SysmemColorSpaceFuchsia = 1000366008,
        BufferCollectionConstraintsInfoFuchsia = 1000366009,
        SubpassShadingPipelineCreateInfoHuawei = 1000369000,
        PhysicalDeviceSubpassShadingFeaturesHuawei = 1000369001,
        PhysicalDeviceSubpassShadingPropertiesHuawei = 1000369002,
        PhysicalDeviceInvocationMaskFeaturesHuawei = 1000370000,
        MemoryGetRemoteAddressInfoNV = 1000371000,
        PhysicalDeviceExternalMemoryRdmaFeaturesNV = 1000371001,
        PipelinePropertiesIdentifierEXT = 1000372000,
        PhysicalDevicePipelinePropertiesFeaturesEXT = 1000372001,
        ImportFenceSciSyncInfoNV = 1000373000,
        ExportFenceSciSyncInfoNV = 1000373001,
        FenceGetSciSyncInfoNV = 1000373002,
        SciSyncAttributesInfoNV = 1000373003,
        ImportSemaphoreSciSyncInfoNV = 1000373004,
        ExportSemaphoreSciSyncInfoNV = 1000373005,
        SemaphoreGetSciSyncInfoNV = 1000373006,
        PhysicalDeviceExternalSciSyncFeaturesNV = 1000373007,
        ImportMemorySciBufInfoNV = 1000374000,
        ExportMemorySciBufInfoNV = 1000374001,
        MemoryGetSciBufInfoNV = 1000374002,
        MemorySciBufPropertiesNV = 1000374003,
        PhysicalDeviceExternalMemorySciBufFeaturesNV = 1000374004,
        PhysicalDeviceFrameBoundaryFeaturesEXT = 1000375000,
        FrameBoundaryEXT = 1000375001,
        PhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT = 1000376000,
        SubpassResolvePerformanceQueryEXT = 1000376001,
        MultisampledRenderToSingleSampledInfoEXT = 1000376002,
        PhysicalDeviceExtendedDynamicState2FeaturesEXT = 1000377000,
        ScreenSurfaceCreateInfoQnx = 1000378000,
        PhysicalDeviceColorWriteEnableFeaturesEXT = 1000381000,
        PipelineColorWriteCreateInfoEXT = 1000381001,
        PhysicalDevicePrimitivesGeneratedQueryFeaturesEXT = 1000382000,
        PhysicalDeviceRayTracingMaintenance1FeaturesKHR = 1000386000,
        PhysicalDeviceImageViewMinLodFeaturesEXT = 1000391000,
        ImageViewMinLodCreateInfoEXT = 1000391001,
        PhysicalDeviceMultiDrawFeaturesEXT = 1000392000,
        PhysicalDeviceMultiDrawPropertiesEXT = 1000392001,
        PhysicalDeviceImage2dViewOf3dFeaturesEXT = 1000393000,
        PhysicalDeviceShaderTileImageFeaturesEXT = 1000395000,
        PhysicalDeviceShaderTileImagePropertiesEXT = 1000395001,
        MicromapBuildInfoEXT = 1000396000,
        MicromapVersionInfoEXT = 1000396001,
        CopyMicromapInfoEXT = 1000396002,
        CopyMicromapToMemoryInfoEXT = 1000396003,
        CopyMemoryToMicromapInfoEXT = 1000396004,
        PhysicalDeviceOpacityMicromapFeaturesEXT = 1000396005,
        PhysicalDeviceOpacityMicromapPropertiesEXT = 1000396006,
        MicromapCreateInfoEXT = 1000396007,
        MicromapBuildSizesInfoEXT = 1000396008,
        AccelerationStructureTrianglesOpacityMicromapEXT = 1000396009,
        PhysicalDeviceDisplacementMicromapFeaturesNV = 1000397000,
        PhysicalDeviceDisplacementMicromapPropertiesNV = 1000397001,
        AccelerationStructureTrianglesDisplacementMicromapNV = 1000397002,
        PhysicalDeviceClusterCullingShaderFeaturesHuawei = 1000404000,
        PhysicalDeviceClusterCullingShaderPropertiesHuawei = 1000404001,
        PhysicalDeviceBorderColorSwizzleFeaturesEXT = 1000411000,
        SamplerBorderColorComponentMappingCreateInfoEXT = 1000411001,
        PhysicalDevicePageableDeviceLocalMemoryFeaturesEXT = 1000412000,
        PhysicalDeviceShaderCorePropertiesArm = 1000415000,
        PhysicalDeviceImageSlicedViewOf3dFeaturesEXT = 1000418000,
        ImageViewSlicedCreateInfoEXT = 1000418001,
        PhysicalDeviceDescriptorSetHostMappingFeaturesValve = 1000420000,
        DescriptorSetBindingReferenceValve = 1000420001,
        DescriptorSetLayoutHostMappingInfoValve = 1000420002,
        PhysicalDeviceDepthClampZeroOneFeaturesEXT = 1000421000,
        PhysicalDeviceNonSeamlessCubeMapFeaturesEXT = 1000422000,
        PhysicalDeviceFragmentDensityMapOffsetFeaturesQcom = 1000425000,
        PhysicalDeviceFragmentDensityMapOffsetPropertiesQcom = 1000425001,
        SubpassFragmentDensityMapOffsetEndInfoQcom = 1000425002,
        PhysicalDeviceCopyMemoryIndirectFeaturesNV = 1000426000,
        PhysicalDeviceCopyMemoryIndirectPropertiesNV = 1000426001,
        PhysicalDeviceMemoryDecompressionFeaturesNV = 1000427000,
        PhysicalDeviceMemoryDecompressionPropertiesNV = 1000427001,
        PhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV = 1000428000,
        ComputePipelineIndirectBufferInfoNV = 1000428001,
        PipelineIndirectDeviceAddressInfoNV = 1000428002,
        PhysicalDeviceLinearColorAttachmentFeaturesNV = 1000430000,
        ApplicationParametersEXT = 1000435000,
        PhysicalDeviceImageCompressionControlSwapchainFeaturesEXT = 1000437000,
        PhysicalDeviceImageProcessingFeaturesQcom = 1000440000,
        PhysicalDeviceImageProcessingPropertiesQcom = 1000440001,
        ImageViewSampleWeightCreateInfoQcom = 1000440002,
        ExternalMemoryAcquireUnmodifiedEXT = 1000453000,
        PhysicalDeviceExtendedDynamicState3FeaturesEXT = 1000455000,
        PhysicalDeviceExtendedDynamicState3PropertiesEXT = 1000455001,
        PhysicalDeviceSubpassMergeFeedbackFeaturesEXT = 1000458000,
        RenderPassCreationControlEXT = 1000458001,
        RenderPassCreationFeedbackCreateInfoEXT = 1000458002,
        RenderPassSubpassFeedbackCreateInfoEXT = 1000458003,
        DirectDriverLoadingInfoLunarg = 1000459000,
        DirectDriverLoadingListLunarg = 1000459001,
        PhysicalDeviceShaderModuleIdentifierFeaturesEXT = 1000462000,
        PhysicalDeviceShaderModuleIdentifierPropertiesEXT = 1000462001,
        PipelineShaderStageModuleIdentifierCreateInfoEXT = 1000462002,
        ShaderModuleIdentifierEXT = 1000462003,
        PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT = 1000342000,
        PhysicalDeviceOpticalFlowFeaturesNV = 1000464000,
        PhysicalDeviceOpticalFlowPropertiesNV = 1000464001,
        OpticalFlowImageFormatInfoNV = 1000464002,
        OpticalFlowImageFormatPropertiesNV = 1000464003,
        OpticalFlowSessionCreateInfoNV = 1000464004,
        OpticalFlowExecuteInfoNV = 1000464005,
        OpticalFlowSessionCreatePrivateDataInfoNV = 1000464010,
        PhysicalDeviceLegacyDitheringFeaturesEXT = 1000465000,
        PhysicalDevicePipelineProtectedAccessFeaturesEXT = 1000466000,
        PhysicalDeviceMaintenance5FeaturesKHR = 1000470000,
        PhysicalDeviceMaintenance5PropertiesKHR = 1000470001,
        RenderingAreaInfoKHR = 1000470003,
        DeviceImageSubresourceInfoKHR = 1000470004,
        SubresourceLayout2KHR = 1000338002,
        ImageSubresource2KHR = 1000338003,
        PipelineCreate2CreateInfoKHR = 1000470005,
        BufferUsage2CreateInfoKHR = 1000470006,
        PhysicalDeviceRayTracingPositionFetchFeaturesKHR = 1000481000,
        PhysicalDeviceShaderObjectFeaturesEXT = 1000482000,
        PhysicalDeviceShaderObjectPropertiesEXT = 1000482001,
        ShaderCreateInfoEXT = 1000482002,
        PhysicalDeviceTilePropertiesFeaturesQcom = 1000484000,
        TilePropertiesQcom = 1000484001,
        PhysicalDeviceAmigoProfilingFeaturesSec = 1000485000,
        AmigoProfilingSubmitInfoSec = 1000485001,
        PhysicalDeviceMultiviewPerViewViewportsFeaturesQcom = 1000488000,
        SemaphoreSciSyncPoolCreateInfoNV = 1000489000,
        SemaphoreSciSyncCreateInfoNV = 1000489001,
        PhysicalDeviceExternalSciSync2FeaturesNV = 1000489002,
        DeviceSemaphoreSciSyncPoolReservationCreateInfoNV = 1000489003,
        PhysicalDeviceRayTracingInvocationReorderFeaturesNV = 1000490000,
        PhysicalDeviceRayTracingInvocationReorderPropertiesNV = 1000490001,
        PhysicalDeviceMutableDescriptorTypeFeaturesEXT = 1000351000,
        MutableDescriptorTypeCreateInfoEXT = 1000351002,
        PhysicalDeviceShaderCoreBuiltinsFeaturesArm = 1000497000,
        PhysicalDeviceShaderCoreBuiltinsPropertiesArm = 1000497001,
        PhysicalDevicePipelineLibraryGroupHandlesFeaturesEXT = 1000498000,
        PhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT = 1000499000,
        PhysicalDeviceCooperativeMatrixFeaturesKHR = 1000506000,
        CooperativeMatrixPropertiesKHR = 1000506001,
        PhysicalDeviceCooperativeMatrixPropertiesKHR = 1000506002,
        PhysicalDeviceMultiviewPerViewRenderAreasFeaturesQcom = 1000510000,
        MultiviewPerViewRenderAreasRenderPassBeginInfoQcom = 1000510001,
        PhysicalDeviceImageProcessing2FeaturesQcom = 1000518000,
        PhysicalDeviceImageProcessing2PropertiesQcom = 1000518001,
        SamplerBlockMatchWindowCreateInfoQcom = 1000518002,
        SamplerCubicWeightsCreateInfoQcom = 1000519000,
        PhysicalDeviceCubicWeightsFeaturesQcom = 1000519001,
        BlitImageCubicWeightsInfoQcom = 1000519002,
        PhysicalDeviceYcbcrDegammaFeaturesQcom = 1000520000,
        SamplerYcbcrConversionYcbcrDegammaCreateInfoQcom = 1000520001,
        PhysicalDeviceCubicClampFeaturesQcom = 1000521000,
        PhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesEXT = 1000524000,
        ScreenBufferPropertiesQnx = 1000529000,
        ScreenBufferFormatPropertiesQnx = 1000529001,
        ImportScreenBufferInfoQnx = 1000529002,
        ExternalFormatQnx = 1000529003,
        PhysicalDeviceExternalMemoryScreenBufferFeaturesQnx = 1000529004,
        PhysicalDeviceLayeredDriverPropertiesMsft = 1000530000,
        PhysicalDeviceDescriptorPoolOverallocationFeaturesNV = 1000546000,
    }
    public static partial class RawConstants
    {
        public const VkStructureType VK_STRUCTURE_TYPE_APPLICATION_INFO = VkStructureType.ApplicationInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_INSTANCE_CREATE_INFO = VkStructureType.InstanceCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_QUEUE_CREATE_INFO = VkStructureType.DeviceQueueCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_CREATE_INFO = VkStructureType.DeviceCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_SUBMIT_INFO = VkStructureType.SubmitInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_INFO = VkStructureType.MemoryAllocateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_MAPPED_MEMORY_RANGE = VkStructureType.MappedMemoryRange;
        public const VkStructureType VK_STRUCTURE_TYPE_BIND_SPARSE_INFO = VkStructureType.BindSparseInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_FENCE_CREATE_INFO = VkStructureType.FenceCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_SEMAPHORE_CREATE_INFO = VkStructureType.SemaphoreCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_EVENT_CREATE_INFO = VkStructureType.EventCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_QUERY_POOL_CREATE_INFO = VkStructureType.QueryPoolCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_BUFFER_CREATE_INFO = VkStructureType.BufferCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_BUFFER_VIEW_CREATE_INFO = VkStructureType.BufferViewCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_CREATE_INFO = VkStructureType.ImageCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_VIEW_CREATE_INFO = VkStructureType.ImageViewCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_SHADER_MODULE_CREATE_INFO = VkStructureType.ShaderModuleCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_CACHE_CREATE_INFO = VkStructureType.PipelineCacheCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO = VkStructureType.PipelineShaderStageCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_STATE_CREATE_INFO = VkStructureType.PipelineVertexInputStateCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_INPUT_ASSEMBLY_STATE_CREATE_INFO = VkStructureType.PipelineInputAssemblyStateCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_STATE_CREATE_INFO = VkStructureType.PipelineTessellationStateCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_STATE_CREATE_INFO = VkStructureType.PipelineViewportStateCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_CREATE_INFO = VkStructureType.PipelineRasterizationStateCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_MULTISAMPLE_STATE_CREATE_INFO = VkStructureType.PipelineMultisampleStateCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_DEPTH_STENCIL_STATE_CREATE_INFO = VkStructureType.PipelineDepthStencilStateCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_STATE_CREATE_INFO = VkStructureType.PipelineColorBlendStateCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_DYNAMIC_STATE_CREATE_INFO = VkStructureType.PipelineDynamicStateCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_CREATE_INFO = VkStructureType.GraphicsPipelineCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_COMPUTE_PIPELINE_CREATE_INFO = VkStructureType.ComputePipelineCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_LAYOUT_CREATE_INFO = VkStructureType.PipelineLayoutCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_SAMPLER_CREATE_INFO = VkStructureType.SamplerCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_CREATE_INFO = VkStructureType.DescriptorSetLayoutCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_CREATE_INFO = VkStructureType.DescriptorPoolCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_DESCRIPTOR_SET_ALLOCATE_INFO = VkStructureType.DescriptorSetAllocateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET = VkStructureType.WriteDescriptorSet;
        public const VkStructureType VK_STRUCTURE_TYPE_COPY_DESCRIPTOR_SET = VkStructureType.CopyDescriptorSet;
        public const VkStructureType VK_STRUCTURE_TYPE_FRAMEBUFFER_CREATE_INFO = VkStructureType.FramebufferCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO = VkStructureType.RenderPassCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_COMMAND_POOL_CREATE_INFO = VkStructureType.CommandPoolCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_COMMAND_BUFFER_ALLOCATE_INFO = VkStructureType.CommandBufferAllocateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_INFO = VkStructureType.CommandBufferInheritanceInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_COMMAND_BUFFER_BEGIN_INFO = VkStructureType.CommandBufferBeginInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_RENDER_PASS_BEGIN_INFO = VkStructureType.RenderPassBeginInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER = VkStructureType.BufferMemoryBarrier;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER = VkStructureType.ImageMemoryBarrier;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_BARRIER = VkStructureType.MemoryBarrier;
        ///<summary>Reserved for internal use by the loader, layers, and ICDs</summary>
        public const VkStructureType VK_STRUCTURE_TYPE_LOADER_INSTANCE_CREATE_INFO = VkStructureType.LoaderInstanceCreateInfo;
        ///<summary>Reserved for internal use by the loader, layers, and ICDs</summary>
        public const VkStructureType VK_STRUCTURE_TYPE_LOADER_DEVICE_CREATE_INFO = VkStructureType.LoaderDeviceCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_PROPERTIES = VkStructureType.PhysicalDeviceSubgroupProperties;
        public const VkStructureType VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_INFO = VkStructureType.BindBufferMemoryInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_INFO = VkStructureType.BindImageMemoryInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_16BIT_STORAGE_FEATURES = VkStructureType.PhysicalDevice16bitStorageFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS = VkStructureType.MemoryDedicatedRequirements;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_DEDICATED_ALLOCATE_INFO = VkStructureType.MemoryDedicatedAllocateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_ALLOCATE_FLAGS_INFO = VkStructureType.MemoryAllocateFlagsInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO = VkStructureType.DeviceGroupRenderPassBeginInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_GROUP_COMMAND_BUFFER_BEGIN_INFO = VkStructureType.DeviceGroupCommandBufferBeginInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_GROUP_SUBMIT_INFO = VkStructureType.DeviceGroupSubmitInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_GROUP_BIND_SPARSE_INFO = VkStructureType.DeviceGroupBindSparseInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_BIND_BUFFER_MEMORY_DEVICE_GROUP_INFO = VkStructureType.BindBufferMemoryDeviceGroupInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_DEVICE_GROUP_INFO = VkStructureType.BindImageMemoryDeviceGroupInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GROUP_PROPERTIES = VkStructureType.PhysicalDeviceGroupProperties;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_GROUP_DEVICE_CREATE_INFO = VkStructureType.DeviceGroupDeviceCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_BUFFER_MEMORY_REQUIREMENTS_INFO_2 = VkStructureType.BufferMemoryRequirementsInfo2;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_MEMORY_REQUIREMENTS_INFO_2 = VkStructureType.ImageMemoryRequirementsInfo2;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_SPARSE_MEMORY_REQUIREMENTS_INFO_2 = VkStructureType.ImageSparseMemoryRequirementsInfo2;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2 = VkStructureType.MemoryRequirements2;
        public const VkStructureType VK_STRUCTURE_TYPE_SPARSE_IMAGE_MEMORY_REQUIREMENTS_2 = VkStructureType.SparseImageMemoryRequirements2;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FEATURES_2 = VkStructureType.PhysicalDeviceFeatures2;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROPERTIES_2 = VkStructureType.PhysicalDeviceProperties2;
        public const VkStructureType VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_2 = VkStructureType.FormatProperties2;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_FORMAT_PROPERTIES_2 = VkStructureType.ImageFormatProperties2;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_FORMAT_INFO_2 = VkStructureType.PhysicalDeviceImageFormatInfo2;
        public const VkStructureType VK_STRUCTURE_TYPE_QUEUE_FAMILY_PROPERTIES_2 = VkStructureType.QueueFamilyProperties2;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PROPERTIES_2 = VkStructureType.PhysicalDeviceMemoryProperties2;
        public const VkStructureType VK_STRUCTURE_TYPE_SPARSE_IMAGE_FORMAT_PROPERTIES_2 = VkStructureType.SparseImageFormatProperties2;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SPARSE_IMAGE_FORMAT_INFO_2 = VkStructureType.PhysicalDeviceSparseImageFormatInfo2;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_POINT_CLIPPING_PROPERTIES = VkStructureType.PhysicalDevicePointClippingProperties;
        public const VkStructureType VK_STRUCTURE_TYPE_RENDER_PASS_INPUT_ATTACHMENT_ASPECT_CREATE_INFO = VkStructureType.RenderPassInputAttachmentAspectCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_CREATE_INFO = VkStructureType.ImageViewUsageCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_DOMAIN_ORIGIN_STATE_CREATE_INFO = VkStructureType.PipelineTessellationDomainOriginStateCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_RENDER_PASS_MULTIVIEW_CREATE_INFO = VkStructureType.RenderPassMultiviewCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_FEATURES = VkStructureType.PhysicalDeviceMultiviewFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PROPERTIES = VkStructureType.PhysicalDeviceMultiviewProperties;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VARIABLE_POINTERS_FEATURES = VkStructureType.PhysicalDeviceVariablePointersFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_PROTECTED_SUBMIT_INFO = VkStructureType.ProtectedSubmitInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROTECTED_MEMORY_FEATURES = VkStructureType.PhysicalDeviceProtectedMemoryFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROTECTED_MEMORY_PROPERTIES = VkStructureType.PhysicalDeviceProtectedMemoryProperties;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_QUEUE_INFO_2 = VkStructureType.DeviceQueueInfo2;
        public const VkStructureType VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_CREATE_INFO = VkStructureType.SamplerYcbcrConversionCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_INFO = VkStructureType.SamplerYcbcrConversionInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO = VkStructureType.BindImagePlaneMemoryInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO = VkStructureType.ImagePlaneMemoryRequirementsInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_YCBCR_CONVERSION_FEATURES = VkStructureType.PhysicalDeviceSamplerYcbcrConversionFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_IMAGE_FORMAT_PROPERTIES = VkStructureType.SamplerYcbcrConversionImageFormatProperties;
        public const VkStructureType VK_STRUCTURE_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_CREATE_INFO = VkStructureType.DescriptorUpdateTemplateCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_IMAGE_FORMAT_INFO = VkStructureType.PhysicalDeviceExternalImageFormatInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_EXTERNAL_IMAGE_FORMAT_PROPERTIES = VkStructureType.ExternalImageFormatProperties;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_BUFFER_INFO = VkStructureType.PhysicalDeviceExternalBufferInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_EXTERNAL_BUFFER_PROPERTIES = VkStructureType.ExternalBufferProperties;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ID_PROPERTIES = VkStructureType.PhysicalDeviceIdProperties;
        public const VkStructureType VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_BUFFER_CREATE_INFO = VkStructureType.ExternalMemoryBufferCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO = VkStructureType.ExternalMemoryImageCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO = VkStructureType.ExportMemoryAllocateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_FENCE_INFO = VkStructureType.PhysicalDeviceExternalFenceInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_EXTERNAL_FENCE_PROPERTIES = VkStructureType.ExternalFenceProperties;
        public const VkStructureType VK_STRUCTURE_TYPE_EXPORT_FENCE_CREATE_INFO = VkStructureType.ExportFenceCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_CREATE_INFO = VkStructureType.ExportSemaphoreCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SEMAPHORE_INFO = VkStructureType.PhysicalDeviceExternalSemaphoreInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_EXTERNAL_SEMAPHORE_PROPERTIES = VkStructureType.ExternalSemaphoreProperties;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_3_PROPERTIES = VkStructureType.PhysicalDeviceMaintenance3Properties;
        public const VkStructureType VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_SUPPORT = VkStructureType.DescriptorSetLayoutSupport;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DRAW_PARAMETERS_FEATURES = VkStructureType.PhysicalDeviceShaderDrawParametersFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_1_FEATURES = VkStructureType.PhysicalDeviceVulkan11Features;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_1_PROPERTIES = VkStructureType.PhysicalDeviceVulkan11Properties;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_2_FEATURES = VkStructureType.PhysicalDeviceVulkan12Features;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_2_PROPERTIES = VkStructureType.PhysicalDeviceVulkan12Properties;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_FORMAT_LIST_CREATE_INFO = VkStructureType.ImageFormatListCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_2 = VkStructureType.AttachmentDescription2;
        public const VkStructureType VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_2 = VkStructureType.AttachmentReference2;
        public const VkStructureType VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_2 = VkStructureType.SubpassDescription2;
        public const VkStructureType VK_STRUCTURE_TYPE_SUBPASS_DEPENDENCY_2 = VkStructureType.SubpassDependency2;
        public const VkStructureType VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO_2 = VkStructureType.RenderPassCreateInfo2;
        public const VkStructureType VK_STRUCTURE_TYPE_SUBPASS_BEGIN_INFO = VkStructureType.SubpassBeginInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_SUBPASS_END_INFO = VkStructureType.SubpassEndInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_8BIT_STORAGE_FEATURES = VkStructureType.PhysicalDevice8bitStorageFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRIVER_PROPERTIES = VkStructureType.PhysicalDeviceDriverProperties;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_INT64_FEATURES = VkStructureType.PhysicalDeviceShaderAtomicInt64Features;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_FLOAT16_INT8_FEATURES = VkStructureType.PhysicalDeviceShaderFloat16Int8Features;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FLOAT_CONTROLS_PROPERTIES = VkStructureType.PhysicalDeviceFloatControlsProperties;
        public const VkStructureType VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_BINDING_FLAGS_CREATE_INFO = VkStructureType.DescriptorSetLayoutBindingCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_FEATURES = VkStructureType.PhysicalDeviceDescriptorIndexingFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_INDEXING_PROPERTIES = VkStructureType.PhysicalDeviceDescriptorIndexingProperties;
        public const VkStructureType VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_ALLOCATE_INFO = VkStructureType.DescriptorSetVariableDescriptorCountAllocateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_DESCRIPTOR_SET_VARIABLE_DESCRIPTOR_COUNT_LAYOUT_SUPPORT = VkStructureType.DescriptorSetVariableDescriptorCountLayoutSupport;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_STENCIL_RESOLVE_PROPERTIES = VkStructureType.PhysicalDeviceDepthStencilResolveProperties;
        public const VkStructureType VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE = VkStructureType.SubpassDescriptionDepthStencilResolve;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCALAR_BLOCK_LAYOUT_FEATURES = VkStructureType.PhysicalDeviceScalarBlockLayoutFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_CREATE_INFO = VkStructureType.ImageStencilUsageCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLER_FILTER_MINMAX_PROPERTIES = VkStructureType.PhysicalDeviceSamplerFilterMinmaxProperties;
        public const VkStructureType VK_STRUCTURE_TYPE_SAMPLER_REDUCTION_MODE_CREATE_INFO = VkStructureType.SamplerReductionModeCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_MEMORY_MODEL_FEATURES = VkStructureType.PhysicalDeviceVulkanMemoryModelFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGELESS_FRAMEBUFFER_FEATURES = VkStructureType.PhysicalDeviceImagelessFramebufferFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENTS_CREATE_INFO = VkStructureType.FramebufferAttachmentsCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_FRAMEBUFFER_ATTACHMENT_IMAGE_INFO = VkStructureType.FramebufferAttachmentImageInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_RENDER_PASS_ATTACHMENT_BEGIN_INFO = VkStructureType.RenderPassAttachmentBeginInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFORM_BUFFER_STANDARD_LAYOUT_FEATURES = VkStructureType.PhysicalDeviceUniformBufferStandardLayoutFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_EXTENDED_TYPES_FEATURES = VkStructureType.PhysicalDeviceShaderSubgroupExtendedTypesFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SEPARATE_DEPTH_STENCIL_LAYOUTS_FEATURES = VkStructureType.PhysicalDeviceSeparateDepthStencilLayoutsFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_ATTACHMENT_REFERENCE_STENCIL_LAYOUT = VkStructureType.AttachmentReferenceStencilLayout;
        public const VkStructureType VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION_STENCIL_LAYOUT = VkStructureType.AttachmentDescriptionStencilLayout;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_QUERY_RESET_FEATURES = VkStructureType.PhysicalDeviceHostQueryResetFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_FEATURES = VkStructureType.PhysicalDeviceTimelineSemaphoreFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TIMELINE_SEMAPHORE_PROPERTIES = VkStructureType.PhysicalDeviceTimelineSemaphoreProperties;
        public const VkStructureType VK_STRUCTURE_TYPE_SEMAPHORE_TYPE_CREATE_INFO = VkStructureType.SemaphoreTypeCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_TIMELINE_SEMAPHORE_SUBMIT_INFO = VkStructureType.TimelineSemaphoreSubmitInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_SEMAPHORE_WAIT_INFO = VkStructureType.SemaphoreWaitInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_SEMAPHORE_SIGNAL_INFO = VkStructureType.SemaphoreSignalInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES = VkStructureType.PhysicalDeviceBufferDeviceAddressFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO = VkStructureType.BufferDeviceAddressInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_BUFFER_OPAQUE_CAPTURE_ADDRESS_CREATE_INFO = VkStructureType.BufferOpaqueCaptureAddressCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO = VkStructureType.MemoryOpaqueCaptureAddressAllocateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_MEMORY_OPAQUE_CAPTURE_ADDRESS_INFO = VkStructureType.DeviceMemoryOpaqueCaptureAddressInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_3_FEATURES = VkStructureType.PhysicalDeviceVulkan13Features;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_1_3_PROPERTIES = VkStructureType.PhysicalDeviceVulkan13Properties;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_CREATION_FEEDBACK_CREATE_INFO = VkStructureType.PipelineCreationFeedbackCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TERMINATE_INVOCATION_FEATURES = VkStructureType.PhysicalDeviceShaderTerminateInvocationFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TOOL_PROPERTIES = VkStructureType.PhysicalDeviceToolProperties;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_DEMOTE_TO_HELPER_INVOCATION_FEATURES = VkStructureType.PhysicalDeviceShaderDemoteToHelperInvocationFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIVATE_DATA_FEATURES = VkStructureType.PhysicalDevicePrivateDataFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_PRIVATE_DATA_CREATE_INFO = VkStructureType.DevicePrivateDataCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PRIVATE_DATA_SLOT_CREATE_INFO = VkStructureType.PrivateDataSlotCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_CREATION_CACHE_CONTROL_FEATURES = VkStructureType.PhysicalDevicePipelineCreationCacheControlFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_BARRIER_2 = VkStructureType.MemoryBarrier2;
        public const VkStructureType VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER_2 = VkStructureType.BufferMemoryBarrier2;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER_2 = VkStructureType.ImageMemoryBarrier2;
        public const VkStructureType VK_STRUCTURE_TYPE_DEPENDENCY_INFO = VkStructureType.DependencyInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_SUBMIT_INFO_2 = VkStructureType.SubmitInfo2;
        public const VkStructureType VK_STRUCTURE_TYPE_SEMAPHORE_SUBMIT_INFO = VkStructureType.SemaphoreSubmitInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_COMMAND_BUFFER_SUBMIT_INFO = VkStructureType.CommandBufferSubmitInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SYNCHRONIZATION_2_FEATURES = VkStructureType.PhysicalDeviceSynchronization2Features;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ZERO_INITIALIZE_WORKGROUP_MEMORY_FEATURES = VkStructureType.PhysicalDeviceZeroInitializeWorkgroupMemoryFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_ROBUSTNESS_FEATURES = VkStructureType.PhysicalDeviceImageRobustnessFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_COPY_BUFFER_INFO_2 = VkStructureType.CopyBufferInfo2;
        public const VkStructureType VK_STRUCTURE_TYPE_COPY_IMAGE_INFO_2 = VkStructureType.CopyImageInfo2;
        public const VkStructureType VK_STRUCTURE_TYPE_COPY_BUFFER_TO_IMAGE_INFO_2 = VkStructureType.CopyBufferToImageInfo2;
        public const VkStructureType VK_STRUCTURE_TYPE_COPY_IMAGE_TO_BUFFER_INFO_2 = VkStructureType.CopyImageToBufferInfo2;
        public const VkStructureType VK_STRUCTURE_TYPE_BLIT_IMAGE_INFO_2 = VkStructureType.BlitImageInfo2;
        public const VkStructureType VK_STRUCTURE_TYPE_RESOLVE_IMAGE_INFO_2 = VkStructureType.ResolveImageInfo2;
        public const VkStructureType VK_STRUCTURE_TYPE_BUFFER_COPY_2 = VkStructureType.BufferCopy2;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_COPY_2 = VkStructureType.ImageCopy2;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_BLIT_2 = VkStructureType.ImageBlit2;
        public const VkStructureType VK_STRUCTURE_TYPE_BUFFER_IMAGE_COPY_2 = VkStructureType.BufferImageCopy2;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_RESOLVE_2 = VkStructureType.ImageResolve2;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_PROPERTIES = VkStructureType.PhysicalDeviceSubgroupSizeControlProperties;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_REQUIRED_SUBGROUP_SIZE_CREATE_INFO = VkStructureType.PipelineShaderStageRequiredSubgroupSizeCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBGROUP_SIZE_CONTROL_FEATURES = VkStructureType.PhysicalDeviceSubgroupSizeControlFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_FEATURES = VkStructureType.PhysicalDeviceInlineUniformBlockFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_PROPERTIES = VkStructureType.PhysicalDeviceInlineUniformBlockProperties;
        public const VkStructureType VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_INLINE_UNIFORM_BLOCK = VkStructureType.WriteDescriptorSetInlineUniformBlock;
        public const VkStructureType VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_INLINE_UNIFORM_BLOCK_CREATE_INFO = VkStructureType.DescriptorPoolInlineUniformBlockCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXTURE_COMPRESSION_ASTC_HDR_FEATURES = VkStructureType.PhysicalDeviceTextureCompressionAstcHdrFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_RENDERING_INFO = VkStructureType.RenderingInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_RENDERING_ATTACHMENT_INFO = VkStructureType.RenderingAttachmentInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_RENDERING_CREATE_INFO = VkStructureType.PipelineRenderingCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_FEATURES = VkStructureType.PhysicalDeviceDynamicRenderingFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDERING_INFO = VkStructureType.CommandBufferInheritanceRenderingInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_FEATURES = VkStructureType.PhysicalDeviceShaderIntegerDotProductFeatures;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_PROPERTIES = VkStructureType.PhysicalDeviceShaderIntegerDotProductProperties;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_PROPERTIES = VkStructureType.PhysicalDeviceTexelBufferAlignmentProperties;
        public const VkStructureType VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_3 = VkStructureType.FormatProperties3;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_FEATURES = VkStructureType.PhysicalDeviceMaintenance4Features;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_4_PROPERTIES = VkStructureType.PhysicalDeviceMaintenance4Properties;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_BUFFER_MEMORY_REQUIREMENTS = VkStructureType.DeviceBufferMemoryRequirements;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_IMAGE_MEMORY_REQUIREMENTS = VkStructureType.DeviceImageMemoryRequirements;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_SC_1_0_FEATURES = VkStructureType.PhysicalDeviceVulkanSc10Features;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VULKAN_SC_1_0_PROPERTIES = VkStructureType.PhysicalDeviceVulkanSc10Properties;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_OBJECT_RESERVATION_CREATE_INFO = VkStructureType.DeviceObjectReservationCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_COMMAND_POOL_MEMORY_RESERVATION_CREATE_INFO = VkStructureType.CommandPoolMemoryReservationCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_COMMAND_POOL_MEMORY_CONSUMPTION = VkStructureType.CommandPoolMemoryConsumption;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_POOL_SIZE = VkStructureType.PipelinePoolSize;
        public const VkStructureType VK_STRUCTURE_TYPE_FAULT_DATA = VkStructureType.FaultData;
        public const VkStructureType VK_STRUCTURE_TYPE_FAULT_CALLBACK_INFO = VkStructureType.FaultCallbackInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_OFFLINE_CREATE_INFO = VkStructureType.PipelineOfflineCreateInfo;
        public const VkStructureType VK_STRUCTURE_TYPE_SWAPCHAIN_CREATE_INFO_KHR = VkStructureType.SwapchainCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PRESENT_INFO_KHR = VkStructureType.PresentInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_CAPABILITIES_KHR = VkStructureType.DeviceGroupPresentCapabilitiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_SWAPCHAIN_CREATE_INFO_KHR = VkStructureType.ImageSwapchainCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_BIND_IMAGE_MEMORY_SWAPCHAIN_INFO_KHR = VkStructureType.BindImageMemorySwapchainInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_ACQUIRE_NEXT_IMAGE_INFO_KHR = VkStructureType.AcquireNextImageInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_GROUP_PRESENT_INFO_KHR = VkStructureType.DeviceGroupPresentInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_GROUP_SWAPCHAIN_CREATE_INFO_KHR = VkStructureType.DeviceGroupSwapchainCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DISPLAY_MODE_CREATE_INFO_KHR = VkStructureType.DisplayModeCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DISPLAY_SURFACE_CREATE_INFO_KHR = VkStructureType.DisplaySurfaceCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DISPLAY_PRESENT_INFO_KHR = VkStructureType.DisplayPresentInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_XLIB_SURFACE_CREATE_INFO_KHR = VkStructureType.XlibSurfaceCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_XCB_SURFACE_CREATE_INFO_KHR = VkStructureType.XcbSurfaceCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_WAYLAND_SURFACE_CREATE_INFO_KHR = VkStructureType.WaylandSurfaceCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_ANDROID_SURFACE_CREATE_INFO_KHR = VkStructureType.AndroidSurfaceCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_WIN32_SURFACE_CREATE_INFO_KHR = VkStructureType.Win32SurfaceCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_NATIVE_BUFFER_ANDROID = VkStructureType.NativeBufferAndroid;
        public const VkStructureType VK_STRUCTURE_TYPE_SWAPCHAIN_IMAGE_CREATE_INFO_ANDROID = VkStructureType.SwapchainImageCreateInfoAndroid;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENTATION_PROPERTIES_ANDROID = VkStructureType.PhysicalDevicePresentationPropertiesAndroid;
        public const VkStructureType VK_STRUCTURE_TYPE_DEBUG_REPORT_CALLBACK_CREATE_INFO_EXT = VkStructureType.DebugReportCallbackCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_RASTERIZATION_ORDER_AMD = VkStructureType.PipelineRasterizationStateRasterizationOrderAMD;
        public const VkStructureType VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_NAME_INFO_EXT = VkStructureType.DebugMarkerObjectNameInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DEBUG_MARKER_OBJECT_TAG_INFO_EXT = VkStructureType.DebugMarkerObjectTagInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DEBUG_MARKER_MARKER_INFO_EXT = VkStructureType.DebugMarkerMarkerInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_PROFILE_INFO_KHR = VkStructureType.VideoProfileInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_CAPABILITIES_KHR = VkStructureType.VideoCapabilitiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_PICTURE_RESOURCE_INFO_KHR = VkStructureType.VideoPictureResourceInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_SESSION_MEMORY_REQUIREMENTS_KHR = VkStructureType.VideoSessionMemoryRequirementsKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_BIND_VIDEO_SESSION_MEMORY_INFO_KHR = VkStructureType.BindVideoSessionMemoryInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_SESSION_CREATE_INFO_KHR = VkStructureType.VideoSessionCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_CREATE_INFO_KHR = VkStructureType.VideoSessionParametersCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_SESSION_PARAMETERS_UPDATE_INFO_KHR = VkStructureType.VideoSessionParametersUpdateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_BEGIN_CODING_INFO_KHR = VkStructureType.VideoBeginCodingInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_END_CODING_INFO_KHR = VkStructureType.VideoEndCodingInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_CODING_CONTROL_INFO_KHR = VkStructureType.VideoCodingControlInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_REFERENCE_SLOT_INFO_KHR = VkStructureType.VideoReferenceSlotInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_QUEUE_FAMILY_VIDEO_PROPERTIES_KHR = VkStructureType.QueueFamilyVideoPropertiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_PROFILE_LIST_INFO_KHR = VkStructureType.VideoProfileListInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_FORMAT_INFO_KHR = VkStructureType.PhysicalDeviceVideoFormatInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_FORMAT_PROPERTIES_KHR = VkStructureType.VideoFormatPropertiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_QUEUE_FAMILY_QUERY_RESULT_STATUS_PROPERTIES_KHR = VkStructureType.QueueFamilyQueryResultStatusPropertiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_DECODE_INFO_KHR = VkStructureType.VideoDecodeInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_DECODE_CAPABILITIES_KHR = VkStructureType.VideoDecodeCapabilitiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_DECODE_USAGE_INFO_KHR = VkStructureType.VideoDecodeUsageInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_IMAGE_CREATE_INFO_NV = VkStructureType.DedicatedAllocationImageCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_BUFFER_CREATE_INFO_NV = VkStructureType.DedicatedAllocationBufferCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_DEDICATED_ALLOCATION_MEMORY_ALLOCATE_INFO_NV = VkStructureType.DedicatedAllocationMemoryAllocateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_FEATURES_EXT = VkStructureType.PhysicalDeviceTransformFeedbackFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_PROPERTIES_EXT = VkStructureType.PhysicalDeviceTransformFeedbackPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_STATE_STREAM_CREATE_INFO_EXT = VkStructureType.PipelineRasterizationStateStreamCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_CU_MODULE_CREATE_INFO_NVX = VkStructureType.CuModuleCreateInfoNVX;
        public const VkStructureType VK_STRUCTURE_TYPE_CU_FUNCTION_CREATE_INFO_NVX = VkStructureType.CuFunctionCreateInfoNVX;
        public const VkStructureType VK_STRUCTURE_TYPE_CU_LAUNCH_INFO_NVX = VkStructureType.CuLaunchInfoNVX;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_VIEW_HANDLE_INFO_NVX = VkStructureType.ImageViewHandleInfoNVX;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_VIEW_ADDRESS_PROPERTIES_NVX = VkStructureType.ImageViewAddressPropertiesNVX;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_CAPABILITIES_EXT = VkStructureType.VideoEncodeH264CapabilitiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_CREATE_INFO_EXT = VkStructureType.VideoEncodeH264SessionParametersCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_ADD_INFO_EXT = VkStructureType.VideoEncodeH264SessionParametersAddInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_PICTURE_INFO_EXT = VkStructureType.VideoEncodeH264PictureInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_DPB_SLOT_INFO_EXT = VkStructureType.VideoEncodeH264DpbSlotInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_NALU_SLICE_INFO_EXT = VkStructureType.VideoEncodeH264NaluSliceInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_GOP_REMAINING_FRAME_INFO_EXT = VkStructureType.VideoEncodeH264GopRemainingFrameInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_PROFILE_INFO_EXT = VkStructureType.VideoEncodeH264ProfileInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_INFO_EXT = VkStructureType.VideoEncodeH264RateControlInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_RATE_CONTROL_LAYER_INFO_EXT = VkStructureType.VideoEncodeH264RateControlLayerInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_CREATE_INFO_EXT = VkStructureType.VideoEncodeH264SessionCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_QUALITY_LEVEL_PROPERTIES_EXT = VkStructureType.VideoEncodeH264QualityLevelPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_GET_INFO_EXT = VkStructureType.VideoEncodeH264SessionParametersGetInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H264_SESSION_PARAMETERS_FEEDBACK_INFO_EXT = VkStructureType.VideoEncodeH264SessionParametersFeedbackInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_CAPABILITIES_EXT = VkStructureType.VideoEncodeH265CapabilitiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_CREATE_INFO_EXT = VkStructureType.VideoEncodeH265SessionParametersCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_ADD_INFO_EXT = VkStructureType.VideoEncodeH265SessionParametersAddInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_PICTURE_INFO_EXT = VkStructureType.VideoEncodeH265PictureInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_DPB_SLOT_INFO_EXT = VkStructureType.VideoEncodeH265DpbSlotInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_NALU_SLICE_SEGMENT_INFO_EXT = VkStructureType.VideoEncodeH265NaluSliceSegmentInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_GOP_REMAINING_FRAME_INFO_EXT = VkStructureType.VideoEncodeH265GopRemainingFrameInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_PROFILE_INFO_EXT = VkStructureType.VideoEncodeH265ProfileInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_RATE_CONTROL_INFO_EXT = VkStructureType.VideoEncodeH265RateControlInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_RATE_CONTROL_LAYER_INFO_EXT = VkStructureType.VideoEncodeH265RateControlLayerInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_CREATE_INFO_EXT = VkStructureType.VideoEncodeH265SessionCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_QUALITY_LEVEL_PROPERTIES_EXT = VkStructureType.VideoEncodeH265QualityLevelPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_GET_INFO_EXT = VkStructureType.VideoEncodeH265SessionParametersGetInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_H265_SESSION_PARAMETERS_FEEDBACK_INFO_EXT = VkStructureType.VideoEncodeH265SessionParametersFeedbackInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_CAPABILITIES_KHR = VkStructureType.VideoDecodeH264CapabilitiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PICTURE_INFO_KHR = VkStructureType.VideoDecodeH264PictureInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PROFILE_INFO_KHR = VkStructureType.VideoDecodeH264ProfileInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_PARAMETERS_CREATE_INFO_KHR = VkStructureType.VideoDecodeH264SessionParametersCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_PARAMETERS_ADD_INFO_KHR = VkStructureType.VideoDecodeH264SessionParametersAddInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_DPB_SLOT_INFO_KHR = VkStructureType.VideoDecodeH264DpbSlotInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_TEXTURE_LOD_GATHER_FORMAT_PROPERTIES_AMD = VkStructureType.TextureLodGatherFormatPropertiesAMD;
        public const VkStructureType VK_STRUCTURE_TYPE_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_INFO_KHR = VkStructureType.RenderingFragmentShadingRateAttachmentInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_INFO_EXT = VkStructureType.RenderingFragmentDensityMapAttachmentInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_ATTACHMENT_SAMPLE_COUNT_INFO_AMD = VkStructureType.AttachmentSampleCountInfoAMD;
        public const VkStructureType VK_STRUCTURE_TYPE_MULTIVIEW_PER_VIEW_ATTRIBUTES_INFO_NVX = VkStructureType.MultiviewPerViewAttributesInfoNVX;
        public const VkStructureType VK_STRUCTURE_TYPE_STREAM_DESCRIPTOR_SURFACE_CREATE_INFO_GGP = VkStructureType.StreamDescriptorSurfaceCreateInfoGgp;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CORNER_SAMPLED_IMAGE_FEATURES_NV = VkStructureType.PhysicalDeviceCornerSampledImageFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PRIVATE_VENDOR_INFO_PLACEHOLDER_OFFSET_0_NV = VkStructureType.PrivateVendorInfoPlaceholderOffset0NV;
        public const VkStructureType VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_IMAGE_CREATE_INFO_NV = VkStructureType.ExternalMemoryImageCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_EXPORT_MEMORY_ALLOCATE_INFO_NV = VkStructureType.ExportMemoryAllocateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_NV = VkStructureType.ImportMemoryWin32HandleInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_NV = VkStructureType.ExportMemoryWin32HandleInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_NV = VkStructureType.Win32KeyedMutexAcquireReleaseInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_VALIDATION_FLAGS_EXT = VkStructureType.ValidationEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VI_SURFACE_CREATE_INFO_NN = VkStructureType.ViSurfaceCreateInfoNn;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_VIEW_ASTC_DECODE_MODE_EXT = VkStructureType.ImageViewAstcDecodeModeEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ASTC_DECODE_FEATURES_EXT = VkStructureType.PhysicalDeviceAstcDecodeFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_ROBUSTNESS_CREATE_INFO_EXT = VkStructureType.PipelineRobustnessCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_FEATURES_EXT = VkStructureType.PhysicalDevicePipelineRobustnessFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_ROBUSTNESS_PROPERTIES_EXT = VkStructureType.PhysicalDevicePipelineRobustnessPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_MEMORY_WIN32_HANDLE_INFO_KHR = VkStructureType.ImportMemoryWin32HandleInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_EXPORT_MEMORY_WIN32_HANDLE_INFO_KHR = VkStructureType.ExportMemoryWin32HandleInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_WIN32_HANDLE_PROPERTIES_KHR = VkStructureType.MemoryWin32HandlePropertiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_GET_WIN32_HANDLE_INFO_KHR = VkStructureType.MemoryGetWin32HandleInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_MEMORY_FD_INFO_KHR = VkStructureType.ImportMemoryFdInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_FD_PROPERTIES_KHR = VkStructureType.MemoryFdPropertiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_GET_FD_INFO_KHR = VkStructureType.MemoryGetFdInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_WIN32_KEYED_MUTEX_ACQUIRE_RELEASE_INFO_KHR = VkStructureType.Win32KeyedMutexAcquireReleaseInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR = VkStructureType.ImportSemaphoreWin32HandleInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_WIN32_HANDLE_INFO_KHR = VkStructureType.ExportSemaphoreWin32HandleInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_D3D12_FENCE_SUBMIT_INFO_KHR = VkStructureType.D3d12FenceSubmitInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_SEMAPHORE_GET_WIN32_HANDLE_INFO_KHR = VkStructureType.SemaphoreGetWin32HandleInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_FD_INFO_KHR = VkStructureType.ImportSemaphoreFdInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_SEMAPHORE_GET_FD_INFO_KHR = VkStructureType.SemaphoreGetFdInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PUSH_DESCRIPTOR_PROPERTIES_KHR = VkStructureType.PhysicalDevicePushDescriptorPropertiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_CONDITIONAL_RENDERING_INFO_EXT = VkStructureType.CommandBufferInheritanceConditionalRenderingInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONDITIONAL_RENDERING_FEATURES_EXT = VkStructureType.PhysicalDeviceConditionalRenderingFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_CONDITIONAL_RENDERING_BEGIN_INFO_EXT = VkStructureType.ConditionalRenderingBeginInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PRESENT_REGIONS_KHR = VkStructureType.PresentRegionsKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_W_SCALING_STATE_CREATE_INFO_NV = VkStructureType.PipelineViewportWScalingStateCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_EXT = VkStructureType.SurfaceCapabilities2EXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DISPLAY_POWER_INFO_EXT = VkStructureType.DisplayPowerInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_EVENT_INFO_EXT = VkStructureType.DeviceEventInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DISPLAY_EVENT_INFO_EXT = VkStructureType.DisplayEventInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SWAPCHAIN_COUNTER_CREATE_INFO_EXT = VkStructureType.SwapchainCounterCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PRESENT_TIMES_INFO_GOOGLE = VkStructureType.PresentTimesInfoGoogle;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_ATTRIBUTES_PROPERTIES_NVX = VkStructureType.PhysicalDeviceMultiviewPerViewAttributesPropertiesNVX;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SWIZZLE_STATE_CREATE_INFO_NV = VkStructureType.PipelineViewportSwizzleStateCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DISCARD_RECTANGLE_PROPERTIES_EXT = VkStructureType.PhysicalDeviceDiscardRectanglePropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_DISCARD_RECTANGLE_STATE_CREATE_INFO_EXT = VkStructureType.PipelineDiscardRectangleStateCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CONSERVATIVE_RASTERIZATION_PROPERTIES_EXT = VkStructureType.PhysicalDeviceConservativeRasterizationPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_CONSERVATIVE_STATE_CREATE_INFO_EXT = VkStructureType.PipelineRasterizationConservativeStateCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLIP_ENABLE_FEATURES_EXT = VkStructureType.PhysicalDeviceDepthClipEnableFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_DEPTH_CLIP_STATE_CREATE_INFO_EXT = VkStructureType.PipelineRasterizationDepthClipStateCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_HDR_METADATA_EXT = VkStructureType.HdrMetadataEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SHARED_PRESENT_SURFACE_CAPABILITIES_KHR = VkStructureType.SharedPresentSurfaceCapabilitiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_FENCE_WIN32_HANDLE_INFO_KHR = VkStructureType.ImportFenceWin32HandleInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_EXPORT_FENCE_WIN32_HANDLE_INFO_KHR = VkStructureType.ExportFenceWin32HandleInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_FENCE_GET_WIN32_HANDLE_INFO_KHR = VkStructureType.FenceGetWin32HandleInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_FENCE_FD_INFO_KHR = VkStructureType.ImportFenceFdInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_FENCE_GET_FD_INFO_KHR = VkStructureType.FenceGetFdInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_QUERY_FEATURES_KHR = VkStructureType.PhysicalDevicePerformanceQueryFeaturesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PERFORMANCE_QUERY_PROPERTIES_KHR = VkStructureType.PhysicalDevicePerformanceQueryPropertiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_CREATE_INFO_KHR = VkStructureType.QueryPoolPerformanceCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PERFORMANCE_QUERY_SUBMIT_INFO_KHR = VkStructureType.PerformanceQuerySubmitInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_ACQUIRE_PROFILING_LOCK_INFO_KHR = VkStructureType.AcquireProfilingLockInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_KHR = VkStructureType.PerformanceCounterKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PERFORMANCE_COUNTER_DESCRIPTION_KHR = VkStructureType.PerformanceCounterDescriptionKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PERFORMANCE_QUERY_RESERVATION_INFO_KHR = VkStructureType.PerformanceQueryReservationInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SURFACE_INFO_2_KHR = VkStructureType.PhysicalDeviceSurfaceInfo2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_2_KHR = VkStructureType.SurfaceCapabilities2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_SURFACE_FORMAT_2_KHR = VkStructureType.SurfaceFormat2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DISPLAY_PROPERTIES_2_KHR = VkStructureType.DisplayProperties2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DISPLAY_PLANE_PROPERTIES_2_KHR = VkStructureType.DisplayPlaneProperties2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DISPLAY_MODE_PROPERTIES_2_KHR = VkStructureType.DisplayModeProperties2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DISPLAY_PLANE_INFO_2_KHR = VkStructureType.DisplayPlaneInfo2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DISPLAY_PLANE_CAPABILITIES_2_KHR = VkStructureType.DisplayPlaneCapabilities2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_IOS_SURFACE_CREATE_INFO_MVK = VkStructureType.IosSurfaceCreateInfoMvk;
        public const VkStructureType VK_STRUCTURE_TYPE_MACOS_SURFACE_CREATE_INFO_MVK = VkStructureType.MacosSurfaceCreateInfoMvk;
        public const VkStructureType VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_NAME_INFO_EXT = VkStructureType.DebugUtilsObjectNameInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DEBUG_UTILS_OBJECT_TAG_INFO_EXT = VkStructureType.DebugUtilsObjectTagInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DEBUG_UTILS_LABEL_EXT = VkStructureType.DebugUtilsLabelEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CALLBACK_DATA_EXT = VkStructureType.DebugUtilsMessengerCallbackDataEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT = VkStructureType.DebugUtilsMessengerCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_USAGE_ANDROID = VkStructureType.AndroidHardwareBufferUsageAndroid;
        public const VkStructureType VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_PROPERTIES_ANDROID = VkStructureType.AndroidHardwareBufferPropertiesAndroid;
        public const VkStructureType VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_PROPERTIES_ANDROID = VkStructureType.AndroidHardwareBufferFormatPropertiesAndroid;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_ANDROID_HARDWARE_BUFFER_INFO_ANDROID = VkStructureType.ImportAndroidHardwareBufferInfoAndroid;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_GET_ANDROID_HARDWARE_BUFFER_INFO_ANDROID = VkStructureType.MemoryGetAndroidHardwareBufferInfoAndroid;
        public const VkStructureType VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_ANDROID = VkStructureType.ExternalFormatAndroid;
        public const VkStructureType VK_STRUCTURE_TYPE_ANDROID_HARDWARE_BUFFER_FORMAT_PROPERTIES_2_ANDROID = VkStructureType.AndroidHardwareBufferFormatProperties2Android;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ENQUEUE_FEATURES_AMDX = VkStructureType.PhysicalDeviceShaderEnqueueFeaturesAmdx;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ENQUEUE_PROPERTIES_AMDX = VkStructureType.PhysicalDeviceShaderEnqueuePropertiesAmdx;
        public const VkStructureType VK_STRUCTURE_TYPE_EXECUTION_GRAPH_PIPELINE_SCRATCH_SIZE_AMDX = VkStructureType.ExecutionGraphPipelineScratchSizeAmdx;
        public const VkStructureType VK_STRUCTURE_TYPE_EXECUTION_GRAPH_PIPELINE_CREATE_INFO_AMDX = VkStructureType.ExecutionGraphPipelineCreateInfoAmdx;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_NODE_CREATE_INFO_AMDX = VkStructureType.PipelineShaderStageNodeCreateInfoAmdx;
        public const VkStructureType VK_STRUCTURE_TYPE_SAMPLE_LOCATIONS_INFO_EXT = VkStructureType.SampleLocationsInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_RENDER_PASS_SAMPLE_LOCATIONS_BEGIN_INFO_EXT = VkStructureType.RenderPassSampleLocationsBeginInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_SAMPLE_LOCATIONS_STATE_CREATE_INFO_EXT = VkStructureType.PipelineSampleLocationsStateCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SAMPLE_LOCATIONS_PROPERTIES_EXT = VkStructureType.PhysicalDeviceSampleLocationsPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_MULTISAMPLE_PROPERTIES_EXT = VkStructureType.MultisamplePropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_FEATURES_EXT = VkStructureType.PhysicalDeviceBlendOperationAdvancedFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_PROPERTIES_EXT = VkStructureType.PhysicalDeviceBlendOperationAdvancedPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_ADVANCED_STATE_CREATE_INFO_EXT = VkStructureType.PipelineColorBlendAdvancedStateCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_TO_COLOR_STATE_CREATE_INFO_NV = VkStructureType.PipelineCoverageToColorStateCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_KHR = VkStructureType.WriteDescriptorSetAccelerationStructureKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_GEOMETRY_INFO_KHR = VkStructureType.AccelerationStructureBuildGeometryInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_DEVICE_ADDRESS_INFO_KHR = VkStructureType.AccelerationStructureDeviceAddressInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_AABBS_DATA_KHR = VkStructureType.AccelerationStructureGeometryAabbsDataKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_INSTANCES_DATA_KHR = VkStructureType.AccelerationStructureGeometryInstancesDataKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_TRIANGLES_DATA_KHR = VkStructureType.AccelerationStructureGeometryTrianglesDataKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_KHR = VkStructureType.AccelerationStructureGeometryKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_VERSION_INFO_KHR = VkStructureType.AccelerationStructureVersionInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_COPY_ACCELERATION_STRUCTURE_INFO_KHR = VkStructureType.CopyAccelerationStructureInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_COPY_ACCELERATION_STRUCTURE_TO_MEMORY_INFO_KHR = VkStructureType.CopyAccelerationStructureToMemoryInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_COPY_MEMORY_TO_ACCELERATION_STRUCTURE_INFO_KHR = VkStructureType.CopyMemoryToAccelerationStructureInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_FEATURES_KHR = VkStructureType.PhysicalDeviceAccelerationStructureFeaturesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ACCELERATION_STRUCTURE_PROPERTIES_KHR = VkStructureType.PhysicalDeviceAccelerationStructurePropertiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_KHR = VkStructureType.AccelerationStructureCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_BUILD_SIZES_INFO_KHR = VkStructureType.AccelerationStructureBuildSizesInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_FEATURES_KHR = VkStructureType.PhysicalDeviceRayTracingPipelineFeaturesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PIPELINE_PROPERTIES_KHR = VkStructureType.PhysicalDeviceRayTracingPipelinePropertiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_KHR = VkStructureType.RayTracingPipelineCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_KHR = VkStructureType.RayTracingShaderGroupCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_INTERFACE_CREATE_INFO_KHR = VkStructureType.RayTracingPipelineInterfaceCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_QUERY_FEATURES_KHR = VkStructureType.PhysicalDeviceRayQueryFeaturesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_MODULATION_STATE_CREATE_INFO_NV = VkStructureType.PipelineCoverageModulationStateCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SM_BUILTINS_FEATURES_NV = VkStructureType.PhysicalDeviceShaderSmBuiltinsFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SM_BUILTINS_PROPERTIES_NV = VkStructureType.PhysicalDeviceShaderSmBuiltinsPropertiesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_DRM_FORMAT_MODIFIER_PROPERTIES_LIST_EXT = VkStructureType.DrmFormatModifierPropertiesListEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_DRM_FORMAT_MODIFIER_INFO_EXT = VkStructureType.PhysicalDeviceImageDrmFormatModifierInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_LIST_CREATE_INFO_EXT = VkStructureType.ImageDrmFormatModifierListCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_EXPLICIT_CREATE_INFO_EXT = VkStructureType.ImageDrmFormatModifierExplicitCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_PROPERTIES_EXT = VkStructureType.ImageDrmFormatModifierPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DRM_FORMAT_MODIFIER_PROPERTIES_LIST_2_EXT = VkStructureType.DrmFormatModifierPropertiesList2EXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VALIDATION_CACHE_CREATE_INFO_EXT = VkStructureType.ValidationCacheCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SHADER_MODULE_VALIDATION_CACHE_CREATE_INFO_EXT = VkStructureType.ShaderModuleValidationCacheCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PORTABILITY_SUBSET_FEATURES_KHR = VkStructureType.PhysicalDevicePortabilitySubsetFeaturesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PORTABILITY_SUBSET_PROPERTIES_KHR = VkStructureType.PhysicalDevicePortabilitySubsetPropertiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SHADING_RATE_IMAGE_STATE_CREATE_INFO_NV = VkStructureType.PipelineViewportShadingRateImageStateCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_FEATURES_NV = VkStructureType.PhysicalDeviceShadingRateImageFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADING_RATE_IMAGE_PROPERTIES_NV = VkStructureType.PhysicalDeviceShadingRateImagePropertiesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_COARSE_SAMPLE_ORDER_STATE_CREATE_INFO_NV = VkStructureType.PipelineViewportCoarseSampleOrderStateCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_RAY_TRACING_PIPELINE_CREATE_INFO_NV = VkStructureType.RayTracingPipelineCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CREATE_INFO_NV = VkStructureType.AccelerationStructureCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_GEOMETRY_NV = VkStructureType.GeometryNV;
        public const VkStructureType VK_STRUCTURE_TYPE_GEOMETRY_TRIANGLES_NV = VkStructureType.GeometryTrianglesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_GEOMETRY_AABB_NV = VkStructureType.GeometryAabbNV;
        public const VkStructureType VK_STRUCTURE_TYPE_BIND_ACCELERATION_STRUCTURE_MEMORY_INFO_NV = VkStructureType.BindAccelerationStructureMemoryInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET_ACCELERATION_STRUCTURE_NV = VkStructureType.WriteDescriptorSetAccelerationStructureNV;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_INFO_NV = VkStructureType.AccelerationStructureMemoryRequirementsInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_PROPERTIES_NV = VkStructureType.PhysicalDeviceRayTracingPropertiesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_RAY_TRACING_SHADER_GROUP_CREATE_INFO_NV = VkStructureType.RayTracingShaderGroupCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_INFO_NV = VkStructureType.AccelerationStructureInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_REPRESENTATIVE_FRAGMENT_TEST_FEATURES_NV = VkStructureType.PhysicalDeviceRepresentativeFragmentTestFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_REPRESENTATIVE_FRAGMENT_TEST_STATE_CREATE_INFO_NV = VkStructureType.PipelineRepresentativeFragmentTestStateCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_IMAGE_FORMAT_INFO_EXT = VkStructureType.PhysicalDeviceImageViewImageFormatInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_FILTER_CUBIC_IMAGE_VIEW_IMAGE_FORMAT_PROPERTIES_EXT = VkStructureType.FilterCubicImageViewImageFormatPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_MEMORY_HOST_POINTER_INFO_EXT = VkStructureType.ImportMemoryHostPointerInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_HOST_POINTER_PROPERTIES_EXT = VkStructureType.MemoryHostPointerPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_HOST_PROPERTIES_EXT = VkStructureType.PhysicalDeviceExternalMemoryHostPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CLOCK_FEATURES_KHR = VkStructureType.PhysicalDeviceShaderClockFeaturesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_COMPILER_CONTROL_CREATE_INFO_AMD = VkStructureType.PipelineCompilerControlCreateInfoAMD;
        public const VkStructureType VK_STRUCTURE_TYPE_CALIBRATED_TIMESTAMP_INFO_EXT = VkStructureType.CalibratedTimestampInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_AMD = VkStructureType.PhysicalDeviceShaderCorePropertiesAMD;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_CAPABILITIES_KHR = VkStructureType.VideoDecodeH265CapabilitiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_SESSION_PARAMETERS_CREATE_INFO_KHR = VkStructureType.VideoDecodeH265SessionParametersCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_SESSION_PARAMETERS_ADD_INFO_KHR = VkStructureType.VideoDecodeH265SessionParametersAddInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PROFILE_INFO_KHR = VkStructureType.VideoDecodeH265ProfileInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PICTURE_INFO_KHR = VkStructureType.VideoDecodeH265PictureInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_DPB_SLOT_INFO_KHR = VkStructureType.VideoDecodeH265DpbSlotInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_QUEUE_GLOBAL_PRIORITY_CREATE_INFO_KHR = VkStructureType.DeviceQueueGlobalPriorityCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GLOBAL_PRIORITY_QUERY_FEATURES_KHR = VkStructureType.PhysicalDeviceGlobalPriorityQueryFeaturesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_QUEUE_FAMILY_GLOBAL_PRIORITY_PROPERTIES_KHR = VkStructureType.QueueFamilyGlobalPriorityPropertiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_MEMORY_OVERALLOCATION_CREATE_INFO_AMD = VkStructureType.DeviceMemoryOverallocationCreateInfoAMD;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_PROPERTIES_EXT = VkStructureType.PhysicalDeviceVertexAttributeDivisorPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_DIVISOR_STATE_CREATE_INFO_EXT = VkStructureType.PipelineVertexInputDivisorStateCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_ATTRIBUTE_DIVISOR_FEATURES_EXT = VkStructureType.PhysicalDeviceVertexAttributeDivisorFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PRESENT_FRAME_TOKEN_GGP = VkStructureType.PresentFrameTokenGgp;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COMPUTE_SHADER_DERIVATIVES_FEATURES_NV = VkStructureType.PhysicalDeviceComputeShaderDerivativesFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_FEATURES_NV = VkStructureType.PhysicalDeviceMeshShaderFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_NV = VkStructureType.PhysicalDeviceMeshShaderPropertiesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_IMAGE_FOOTPRINT_FEATURES_NV = VkStructureType.PhysicalDeviceShaderImageFootprintFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_EXCLUSIVE_SCISSOR_STATE_CREATE_INFO_NV = VkStructureType.PipelineViewportExclusiveScissorStateCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXCLUSIVE_SCISSOR_FEATURES_NV = VkStructureType.PhysicalDeviceExclusiveScissorFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_CHECKPOINT_DATA_NV = VkStructureType.CheckpointDataNV;
        public const VkStructureType VK_STRUCTURE_TYPE_QUEUE_FAMILY_CHECKPOINT_PROPERTIES_NV = VkStructureType.QueueFamilyCheckpointPropertiesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_FUNCTIONS_2_FEATURES_INTEL = VkStructureType.PhysicalDeviceShaderIntegerFunctions2FeaturesIntel;
        public const VkStructureType VK_STRUCTURE_TYPE_QUERY_POOL_PERFORMANCE_QUERY_CREATE_INFO_INTEL = VkStructureType.QueryPoolPerformanceQueryCreateInfoIntel;
        public const VkStructureType VK_STRUCTURE_TYPE_INITIALIZE_PERFORMANCE_API_INFO_INTEL = VkStructureType.InitializePerformanceApiInfoIntel;
        public const VkStructureType VK_STRUCTURE_TYPE_PERFORMANCE_MARKER_INFO_INTEL = VkStructureType.PerformanceMarkerInfoIntel;
        public const VkStructureType VK_STRUCTURE_TYPE_PERFORMANCE_STREAM_MARKER_INFO_INTEL = VkStructureType.PerformanceStreamMarkerInfoIntel;
        public const VkStructureType VK_STRUCTURE_TYPE_PERFORMANCE_OVERRIDE_INFO_INTEL = VkStructureType.PerformanceOverrideInfoIntel;
        public const VkStructureType VK_STRUCTURE_TYPE_PERFORMANCE_CONFIGURATION_ACQUIRE_INFO_INTEL = VkStructureType.PerformanceConfigurationAcquireInfoIntel;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PCI_BUS_INFO_PROPERTIES_EXT = VkStructureType.PhysicalDevicePciBusInfoPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DISPLAY_NATIVE_HDR_SURFACE_CAPABILITIES_AMD = VkStructureType.DisplayNativeHdrSurfaceCapabilitiesAMD;
        public const VkStructureType VK_STRUCTURE_TYPE_SWAPCHAIN_DISPLAY_NATIVE_HDR_CREATE_INFO_AMD = VkStructureType.SwapchainDisplayNativeHdrCreateInfoAMD;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGEPIPE_SURFACE_CREATE_INFO_FUCHSIA = VkStructureType.ImagepipeSurfaceCreateInfoFuchsia;
        public const VkStructureType VK_STRUCTURE_TYPE_METAL_SURFACE_CREATE_INFO_EXT = VkStructureType.MetalSurfaceCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_FEATURES_EXT = VkStructureType.PhysicalDeviceFragmentDensityMapFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_PROPERTIES_EXT = VkStructureType.PhysicalDeviceFragmentDensityMapPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_RENDER_PASS_FRAGMENT_DENSITY_MAP_CREATE_INFO_EXT = VkStructureType.RenderPassFragmentDensityMapCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_FRAGMENT_SHADING_RATE_ATTACHMENT_INFO_KHR = VkStructureType.FragmentShadingRateAttachmentInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_SHADING_RATE_STATE_CREATE_INFO_KHR = VkStructureType.PipelineFragmentShadingRateStateCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_PROPERTIES_KHR = VkStructureType.PhysicalDeviceFragmentShadingRatePropertiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_FEATURES_KHR = VkStructureType.PhysicalDeviceFragmentShadingRateFeaturesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_KHR = VkStructureType.PhysicalDeviceFragmentShadingRateKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_2_AMD = VkStructureType.PhysicalDeviceShaderCoreProperties2AMD;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COHERENT_MEMORY_FEATURES_AMD = VkStructureType.PhysicalDeviceCoherentMemoryFeaturesAMD;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_IMAGE_ATOMIC_INT64_FEATURES_EXT = VkStructureType.PhysicalDeviceShaderImageAtomicInt64FeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_BUDGET_PROPERTIES_EXT = VkStructureType.PhysicalDeviceMemoryBudgetPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_PRIORITY_FEATURES_EXT = VkStructureType.PhysicalDeviceMemoryPriorityFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_PRIORITY_ALLOCATE_INFO_EXT = VkStructureType.MemoryPriorityAllocateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SURFACE_PROTECTED_CAPABILITIES_KHR = VkStructureType.SurfaceProtectedCapabilitiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEDICATED_ALLOCATION_IMAGE_ALIASING_FEATURES_NV = VkStructureType.PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BUFFER_DEVICE_ADDRESS_FEATURES_EXT = VkStructureType.PhysicalDeviceBufferDeviceAddressFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_CREATE_INFO_EXT = VkStructureType.BufferDeviceAddressCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VALIDATION_FEATURES_EXT = VkStructureType.ValidationFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_WAIT_FEATURES_KHR = VkStructureType.PhysicalDevicePresentWaitFeaturesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_FEATURES_NV = VkStructureType.PhysicalDeviceCooperativeMatrixFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_PROPERTIES_NV = VkStructureType.CooperativeMatrixPropertiesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_PROPERTIES_NV = VkStructureType.PhysicalDeviceCooperativeMatrixPropertiesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COVERAGE_REDUCTION_MODE_FEATURES_NV = VkStructureType.PhysicalDeviceCoverageReductionModeFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_COVERAGE_REDUCTION_STATE_CREATE_INFO_NV = VkStructureType.PipelineCoverageReductionStateCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_FRAMEBUFFER_MIXED_SAMPLES_COMBINATION_NV = VkStructureType.FramebufferMixedSamplesCombinationNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_INTERLOCK_FEATURES_EXT = VkStructureType.PhysicalDeviceFragmentShaderInterlockFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_IMAGE_ARRAYS_FEATURES_EXT = VkStructureType.PhysicalDeviceYcbcrImageArraysFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROVOKING_VERTEX_FEATURES_EXT = VkStructureType.PhysicalDeviceProvokingVertexFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_PROVOKING_VERTEX_STATE_CREATE_INFO_EXT = VkStructureType.PipelineRasterizationProvokingVertexStateCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PROVOKING_VERTEX_PROPERTIES_EXT = VkStructureType.PhysicalDeviceProvokingVertexPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SURFACE_FULL_SCREEN_EXCLUSIVE_INFO_EXT = VkStructureType.SurfaceFullScreenExclusiveInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_FULL_SCREEN_EXCLUSIVE_EXT = VkStructureType.SurfaceCapabilitiesFullScreenExclusiveEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SURFACE_FULL_SCREEN_EXCLUSIVE_WIN32_INFO_EXT = VkStructureType.SurfaceFullScreenExclusiveWin32InfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_HEADLESS_SURFACE_CREATE_INFO_EXT = VkStructureType.HeadlessSurfaceCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_FEATURES_EXT = VkStructureType.PhysicalDeviceLineRasterizationFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_RASTERIZATION_LINE_STATE_CREATE_INFO_EXT = VkStructureType.PipelineRasterizationLineStateCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINE_RASTERIZATION_PROPERTIES_EXT = VkStructureType.PhysicalDeviceLineRasterizationPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_FEATURES_EXT = VkStructureType.PhysicalDeviceShaderAtomicFloatFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INDEX_TYPE_UINT8_FEATURES_EXT = VkStructureType.PhysicalDeviceIndexTypeUint8FeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_FEATURES_EXT = VkStructureType.PhysicalDeviceExtendedDynamicStateFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_EXECUTABLE_PROPERTIES_FEATURES_KHR = VkStructureType.PhysicalDevicePipelineExecutablePropertiesFeaturesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_INFO_KHR = VkStructureType.PipelineInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_PROPERTIES_KHR = VkStructureType.PipelineExecutablePropertiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INFO_KHR = VkStructureType.PipelineExecutableInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_STATISTIC_KHR = VkStructureType.PipelineExecutableStatisticKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_EXECUTABLE_INTERNAL_REPRESENTATION_KHR = VkStructureType.PipelineExecutableInternalRepresentationKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_FEATURES_EXT = VkStructureType.PhysicalDeviceHostImageCopyFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_PROPERTIES_EXT = VkStructureType.PhysicalDeviceHostImageCopyPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_TO_IMAGE_COPY_EXT = VkStructureType.MemoryToImageCopyEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_TO_MEMORY_COPY_EXT = VkStructureType.ImageToMemoryCopyEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_COPY_IMAGE_TO_MEMORY_INFO_EXT = VkStructureType.CopyImageToMemoryInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_COPY_MEMORY_TO_IMAGE_INFO_EXT = VkStructureType.CopyMemoryToImageInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_HOST_IMAGE_LAYOUT_TRANSITION_INFO_EXT = VkStructureType.HostImageLayoutTransitionInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_COPY_IMAGE_TO_IMAGE_INFO_EXT = VkStructureType.CopyImageToImageInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SUBRESOURCE_HOST_MEMCPY_SIZE_EXT = VkStructureType.SubresourceHostMemcpySizeEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_HOST_IMAGE_COPY_DEVICE_PERFORMANCE_QUERY_EXT = VkStructureType.HostImageCopyDevicePerformanceQueryEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_MAP_INFO_KHR = VkStructureType.MemoryMapInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_UNMAP_INFO_KHR = VkStructureType.MemoryUnmapInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_ATOMIC_FLOAT_2_FEATURES_EXT = VkStructureType.PhysicalDeviceShaderAtomicFloat2FeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_EXT = VkStructureType.SurfacePresentModeEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SURFACE_PRESENT_SCALING_CAPABILITIES_EXT = VkStructureType.SurfacePresentScalingCapabilitiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SURFACE_PRESENT_MODE_COMPATIBILITY_EXT = VkStructureType.SurfacePresentModeCompatibilityEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SWAPCHAIN_MAINTENANCE_1_FEATURES_EXT = VkStructureType.PhysicalDeviceSwapchainMaintenance1FeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_FENCE_INFO_EXT = VkStructureType.SwapchainPresentFenceInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODES_CREATE_INFO_EXT = VkStructureType.SwapchainPresentModesCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODE_INFO_EXT = VkStructureType.SwapchainPresentModeInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_SCALING_CREATE_INFO_EXT = VkStructureType.SwapchainPresentScalingCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_RELEASE_SWAPCHAIN_IMAGES_INFO_EXT = VkStructureType.ReleaseSwapchainImagesInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_PROPERTIES_NV = VkStructureType.PhysicalDeviceDeviceGeneratedCommandsPropertiesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_GRAPHICS_SHADER_GROUP_CREATE_INFO_NV = VkStructureType.GraphicsShaderGroupCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_SHADER_GROUPS_CREATE_INFO_NV = VkStructureType.GraphicsPipelineShaderGroupsCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_TOKEN_NV = VkStructureType.IndirectCommandsLayoutTokenNV;
        public const VkStructureType VK_STRUCTURE_TYPE_INDIRECT_COMMANDS_LAYOUT_CREATE_INFO_NV = VkStructureType.IndirectCommandsLayoutCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_GENERATED_COMMANDS_INFO_NV = VkStructureType.GeneratedCommandsInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_GENERATED_COMMANDS_MEMORY_REQUIREMENTS_INFO_NV = VkStructureType.GeneratedCommandsMemoryRequirementsInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_FEATURES_NV = VkStructureType.PhysicalDeviceDeviceGeneratedCommandsFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INHERITED_VIEWPORT_SCISSOR_FEATURES_NV = VkStructureType.PhysicalDeviceInheritedViewportScissorFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_VIEWPORT_SCISSOR_INFO_NV = VkStructureType.CommandBufferInheritanceViewportScissorInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_FEATURES_EXT = VkStructureType.PhysicalDeviceTexelBufferAlignmentFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_COMMAND_BUFFER_INHERITANCE_RENDER_PASS_TRANSFORM_INFO_QCOM = VkStructureType.CommandBufferInheritanceRenderPassTransformInfoQcom;
        public const VkStructureType VK_STRUCTURE_TYPE_RENDER_PASS_TRANSFORM_BEGIN_INFO_QCOM = VkStructureType.RenderPassTransformBeginInfoQcom;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_BIAS_CONTROL_FEATURES_EXT = VkStructureType.PhysicalDeviceDepthBiasControlFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DEPTH_BIAS_INFO_EXT = VkStructureType.DepthBiasInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DEPTH_BIAS_REPRESENTATION_INFO_EXT = VkStructureType.DepthBiasRepresentationInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_MEMORY_REPORT_FEATURES_EXT = VkStructureType.PhysicalDeviceDeviceMemoryReportFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_DEVICE_MEMORY_REPORT_CREATE_INFO_EXT = VkStructureType.DeviceDeviceMemoryReportCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_MEMORY_REPORT_CALLBACK_DATA_EXT = VkStructureType.DeviceMemoryReportCallbackDataEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_FEATURES_EXT = VkStructureType.PhysicalDeviceRobustness2FeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_PROPERTIES_EXT = VkStructureType.PhysicalDeviceRobustness2PropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SAMPLER_CUSTOM_BORDER_COLOR_CREATE_INFO_EXT = VkStructureType.SamplerCustomBorderColorCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_PROPERTIES_EXT = VkStructureType.PhysicalDeviceCustomBorderColorPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUSTOM_BORDER_COLOR_FEATURES_EXT = VkStructureType.PhysicalDeviceCustomBorderColorFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_LIBRARY_CREATE_INFO_KHR = VkStructureType.PipelineLibraryCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_BARRIER_FEATURES_NV = VkStructureType.PhysicalDevicePresentBarrierFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_SURFACE_CAPABILITIES_PRESENT_BARRIER_NV = VkStructureType.SurfaceCapabilitiesPresentBarrierNV;
        public const VkStructureType VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_BARRIER_CREATE_INFO_NV = VkStructureType.SwapchainPresentBarrierCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PRESENT_ID_KHR = VkStructureType.PresentIdKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRESENT_ID_FEATURES_KHR = VkStructureType.PhysicalDevicePresentIdFeaturesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_INFO_KHR = VkStructureType.VideoEncodeInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_INFO_KHR = VkStructureType.VideoEncodeRateControlInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_RATE_CONTROL_LAYER_INFO_KHR = VkStructureType.VideoEncodeRateControlLayerInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_CAPABILITIES_KHR = VkStructureType.VideoEncodeCapabilitiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_USAGE_INFO_KHR = VkStructureType.VideoEncodeUsageInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_QUERY_POOL_VIDEO_ENCODE_FEEDBACK_CREATE_INFO_KHR = VkStructureType.QueryPoolVideoEncodeFeedbackCreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VIDEO_ENCODE_QUALITY_LEVEL_INFO_KHR = VkStructureType.PhysicalDeviceVideoEncodeQualityLevelInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUALITY_LEVEL_PROPERTIES_KHR = VkStructureType.VideoEncodeQualityLevelPropertiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_QUALITY_LEVEL_INFO_KHR = VkStructureType.VideoEncodeQualityLevelInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_PARAMETERS_GET_INFO_KHR = VkStructureType.VideoEncodeSessionParametersGetInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_VIDEO_ENCODE_SESSION_PARAMETERS_FEEDBACK_INFO_KHR = VkStructureType.VideoEncodeSessionParametersFeedbackInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DIAGNOSTICS_CONFIG_FEATURES_NV = VkStructureType.PhysicalDeviceDiagnosticsConfigFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_DIAGNOSTICS_CONFIG_CREATE_INFO_NV = VkStructureType.DeviceDiagnosticsConfigCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_REFRESH_OBJECT_LIST_KHR = VkStructureType.RefreshObjectListKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_QUERY_LOW_LATENCY_SUPPORT_NV = VkStructureType.QueryLowLatencySupportNV;
        public const VkStructureType VK_STRUCTURE_TYPE_EXPORT_METAL_OBJECT_CREATE_INFO_EXT = VkStructureType.ExportMetalObjectCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_EXPORT_METAL_OBJECTS_INFO_EXT = VkStructureType.ExportMetalObjectsInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_EXPORT_METAL_DEVICE_INFO_EXT = VkStructureType.ExportMetalDeviceInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_EXPORT_METAL_COMMAND_QUEUE_INFO_EXT = VkStructureType.ExportMetalCommandQueueInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_EXPORT_METAL_BUFFER_INFO_EXT = VkStructureType.ExportMetalBufferInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_METAL_BUFFER_INFO_EXT = VkStructureType.ImportMetalBufferInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_EXPORT_METAL_TEXTURE_INFO_EXT = VkStructureType.ExportMetalTextureInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_METAL_TEXTURE_INFO_EXT = VkStructureType.ImportMetalTextureInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_EXPORT_METAL_IO_SURFACE_INFO_EXT = VkStructureType.ExportMetalIoSurfaceInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_METAL_IO_SURFACE_INFO_EXT = VkStructureType.ImportMetalIoSurfaceInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_EXPORT_METAL_SHARED_EVENT_INFO_EXT = VkStructureType.ExportMetalSharedEventInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_METAL_SHARED_EVENT_INFO_EXT = VkStructureType.ImportMetalSharedEventInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_QUEUE_FAMILY_CHECKPOINT_PROPERTIES_2_NV = VkStructureType.QueueFamilyCheckpointProperties2NV;
        public const VkStructureType VK_STRUCTURE_TYPE_CHECKPOINT_DATA_2_NV = VkStructureType.CheckpointData2NV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_PROPERTIES_EXT = VkStructureType.PhysicalDeviceDescriptorBufferPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_DENSITY_MAP_PROPERTIES_EXT = VkStructureType.PhysicalDeviceDescriptorBufferDensityMapPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_BUFFER_FEATURES_EXT = VkStructureType.PhysicalDeviceDescriptorBufferFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DESCRIPTOR_ADDRESS_INFO_EXT = VkStructureType.DescriptorAddressInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DESCRIPTOR_GET_INFO_EXT = VkStructureType.DescriptorGetInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_BUFFER_CAPTURE_DESCRIPTOR_DATA_INFO_EXT = VkStructureType.BufferCaptureDescriptorDataInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_CAPTURE_DESCRIPTOR_DATA_INFO_EXT = VkStructureType.ImageCaptureDescriptorDataInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_VIEW_CAPTURE_DESCRIPTOR_DATA_INFO_EXT = VkStructureType.ImageViewCaptureDescriptorDataInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SAMPLER_CAPTURE_DESCRIPTOR_DATA_INFO_EXT = VkStructureType.SamplerCaptureDescriptorDataInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_OPAQUE_CAPTURE_DESCRIPTOR_DATA_CREATE_INFO_EXT = VkStructureType.OpaqueCaptureDescriptorDataCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DESCRIPTOR_BUFFER_BINDING_INFO_EXT = VkStructureType.DescriptorBufferBindingInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DESCRIPTOR_BUFFER_BINDING_PUSH_DESCRIPTOR_BUFFER_HANDLE_EXT = VkStructureType.DescriptorBufferBindingPushDescriptorBufferHandleEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_CAPTURE_DESCRIPTOR_DATA_INFO_EXT = VkStructureType.AccelerationStructureCaptureDescriptorDataInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GRAPHICS_PIPELINE_LIBRARY_FEATURES_EXT = VkStructureType.PhysicalDeviceGraphicsPipelineLibraryFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_GRAPHICS_PIPELINE_LIBRARY_PROPERTIES_EXT = VkStructureType.PhysicalDeviceGraphicsPipelineLibraryPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_LIBRARY_CREATE_INFO_EXT = VkStructureType.GraphicsPipelineLibraryCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_EARLY_AND_LATE_FRAGMENT_TESTS_FEATURES_AMD = VkStructureType.PhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_FEATURES_KHR = VkStructureType.PhysicalDeviceFragmentShaderBarycentricFeaturesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADER_BARYCENTRIC_PROPERTIES_KHR = VkStructureType.PhysicalDeviceFragmentShaderBarycentricPropertiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_FEATURES_KHR = VkStructureType.PhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_PROPERTIES_NV = VkStructureType.PhysicalDeviceFragmentShadingRateEnumsPropertiesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_SHADING_RATE_ENUMS_FEATURES_NV = VkStructureType.PhysicalDeviceFragmentShadingRateEnumsFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_FRAGMENT_SHADING_RATE_ENUM_STATE_CREATE_INFO_NV = VkStructureType.PipelineFragmentShadingRateEnumStateCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_GEOMETRY_MOTION_TRIANGLES_DATA_NV = VkStructureType.AccelerationStructureGeometryMotionTrianglesDataNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_MOTION_BLUR_FEATURES_NV = VkStructureType.PhysicalDeviceRayTracingMotionBlurFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_MOTION_INFO_NV = VkStructureType.AccelerationStructureMotionInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_FEATURES_EXT = VkStructureType.PhysicalDeviceMeshShaderFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MESH_SHADER_PROPERTIES_EXT = VkStructureType.PhysicalDeviceMeshShaderPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_2_PLANE_444_FORMATS_FEATURES_EXT = VkStructureType.PhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_FEATURES_EXT = VkStructureType.PhysicalDeviceFragmentDensityMap2FeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_2_PROPERTIES_EXT = VkStructureType.PhysicalDeviceFragmentDensityMap2PropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_COPY_COMMAND_TRANSFORM_INFO_QCOM = VkStructureType.CopyCommandTransformInfoQcom;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_FEATURES_KHR = VkStructureType.PhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_COMPRESSION_CONTROL_FEATURES_EXT = VkStructureType.PhysicalDeviceImageCompressionControlFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_COMPRESSION_CONTROL_EXT = VkStructureType.ImageCompressionControlEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_COMPRESSION_PROPERTIES_EXT = VkStructureType.ImageCompressionPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ATTACHMENT_FEEDBACK_LOOP_LAYOUT_FEATURES_EXT = VkStructureType.PhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_4444_FORMATS_FEATURES_EXT = VkStructureType.PhysicalDevice4444FormatsFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FAULT_FEATURES_EXT = VkStructureType.PhysicalDeviceFaultFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_FAULT_COUNTS_EXT = VkStructureType.DeviceFaultCountsEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_FAULT_INFO_EXT = VkStructureType.DeviceFaultInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RGBA10X6_FORMATS_FEATURES_EXT = VkStructureType.PhysicalDeviceRgba10x6FormatsFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DIRECTFB_SURFACE_CREATE_INFO_EXT = VkStructureType.DirectfbSurfaceCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_VERTEX_INPUT_DYNAMIC_STATE_FEATURES_EXT = VkStructureType.PhysicalDeviceVertexInputDynamicStateFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VERTEX_INPUT_BINDING_DESCRIPTION_2_EXT = VkStructureType.VertexInputBindingDescription2EXT;
        public const VkStructureType VK_STRUCTURE_TYPE_VERTEX_INPUT_ATTRIBUTE_DESCRIPTION_2_EXT = VkStructureType.VertexInputAttributeDescription2EXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRM_PROPERTIES_EXT = VkStructureType.PhysicalDeviceDrmPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ADDRESS_BINDING_REPORT_FEATURES_EXT = VkStructureType.PhysicalDeviceAddressBindingReportFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_ADDRESS_BINDING_CALLBACK_DATA_EXT = VkStructureType.DeviceAddressBindingCallbackDataEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLIP_CONTROL_FEATURES_EXT = VkStructureType.PhysicalDeviceDepthClipControlFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_DEPTH_CLIP_CONTROL_CREATE_INFO_EXT = VkStructureType.PipelineViewportDepthClipControlCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVE_TOPOLOGY_LIST_RESTART_FEATURES_EXT = VkStructureType.PhysicalDevicePrimitiveTopologyListRestartFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_MEMORY_ZIRCON_HANDLE_INFO_FUCHSIA = VkStructureType.ImportMemoryZirconHandleInfoFuchsia;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_ZIRCON_HANDLE_PROPERTIES_FUCHSIA = VkStructureType.MemoryZirconHandlePropertiesFuchsia;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_GET_ZIRCON_HANDLE_INFO_FUCHSIA = VkStructureType.MemoryGetZirconHandleInfoFuchsia;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_ZIRCON_HANDLE_INFO_FUCHSIA = VkStructureType.ImportSemaphoreZirconHandleInfoFuchsia;
        public const VkStructureType VK_STRUCTURE_TYPE_SEMAPHORE_GET_ZIRCON_HANDLE_INFO_FUCHSIA = VkStructureType.SemaphoreGetZirconHandleInfoFuchsia;
        public const VkStructureType VK_STRUCTURE_TYPE_BUFFER_COLLECTION_CREATE_INFO_FUCHSIA = VkStructureType.BufferCollectionCreateInfoFuchsia;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_MEMORY_BUFFER_COLLECTION_FUCHSIA = VkStructureType.ImportMemoryBufferCollectionFuchsia;
        public const VkStructureType VK_STRUCTURE_TYPE_BUFFER_COLLECTION_IMAGE_CREATE_INFO_FUCHSIA = VkStructureType.BufferCollectionImageCreateInfoFuchsia;
        public const VkStructureType VK_STRUCTURE_TYPE_BUFFER_COLLECTION_PROPERTIES_FUCHSIA = VkStructureType.BufferCollectionPropertiesFuchsia;
        public const VkStructureType VK_STRUCTURE_TYPE_BUFFER_CONSTRAINTS_INFO_FUCHSIA = VkStructureType.BufferConstraintsInfoFuchsia;
        public const VkStructureType VK_STRUCTURE_TYPE_BUFFER_COLLECTION_BUFFER_CREATE_INFO_FUCHSIA = VkStructureType.BufferCollectionBufferCreateInfoFuchsia;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_CONSTRAINTS_INFO_FUCHSIA = VkStructureType.ImageConstraintsInfoFuchsia;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_FORMAT_CONSTRAINTS_INFO_FUCHSIA = VkStructureType.ImageFormatConstraintsInfoFuchsia;
        public const VkStructureType VK_STRUCTURE_TYPE_SYSMEM_COLOR_SPACE_FUCHSIA = VkStructureType.SysmemColorSpaceFuchsia;
        public const VkStructureType VK_STRUCTURE_TYPE_BUFFER_COLLECTION_CONSTRAINTS_INFO_FUCHSIA = VkStructureType.BufferCollectionConstraintsInfoFuchsia;
        public const VkStructureType VK_STRUCTURE_TYPE_SUBPASS_SHADING_PIPELINE_CREATE_INFO_HUAWEI = VkStructureType.SubpassShadingPipelineCreateInfoHuawei;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_SHADING_FEATURES_HUAWEI = VkStructureType.PhysicalDeviceSubpassShadingFeaturesHuawei;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_SHADING_PROPERTIES_HUAWEI = VkStructureType.PhysicalDeviceSubpassShadingPropertiesHuawei;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INVOCATION_MASK_FEATURES_HUAWEI = VkStructureType.PhysicalDeviceInvocationMaskFeaturesHuawei;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_GET_REMOTE_ADDRESS_INFO_NV = VkStructureType.MemoryGetRemoteAddressInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_RDMA_FEATURES_NV = VkStructureType.PhysicalDeviceExternalMemoryRdmaFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_PROPERTIES_IDENTIFIER_EXT = VkStructureType.PipelinePropertiesIdentifierEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROPERTIES_FEATURES_EXT = VkStructureType.PhysicalDevicePipelinePropertiesFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_FENCE_SCI_SYNC_INFO_NV = VkStructureType.ImportFenceSciSyncInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_EXPORT_FENCE_SCI_SYNC_INFO_NV = VkStructureType.ExportFenceSciSyncInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_FENCE_GET_SCI_SYNC_INFO_NV = VkStructureType.FenceGetSciSyncInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_SCI_SYNC_ATTRIBUTES_INFO_NV = VkStructureType.SciSyncAttributesInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_SEMAPHORE_SCI_SYNC_INFO_NV = VkStructureType.ImportSemaphoreSciSyncInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_EXPORT_SEMAPHORE_SCI_SYNC_INFO_NV = VkStructureType.ExportSemaphoreSciSyncInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_SEMAPHORE_GET_SCI_SYNC_INFO_NV = VkStructureType.SemaphoreGetSciSyncInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SCI_SYNC_FEATURES_NV = VkStructureType.PhysicalDeviceExternalSciSyncFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_MEMORY_SCI_BUF_INFO_NV = VkStructureType.ImportMemorySciBufInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_EXPORT_MEMORY_SCI_BUF_INFO_NV = VkStructureType.ExportMemorySciBufInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_GET_SCI_BUF_INFO_NV = VkStructureType.MemoryGetSciBufInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_MEMORY_SCI_BUF_PROPERTIES_NV = VkStructureType.MemorySciBufPropertiesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_SCI_BUF_FEATURES_NV = VkStructureType.PhysicalDeviceExternalMemorySciBufFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAME_BOUNDARY_FEATURES_EXT = VkStructureType.PhysicalDeviceFrameBoundaryFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_FRAME_BOUNDARY_EXT = VkStructureType.FrameBoundaryEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_FEATURES_EXT = VkStructureType.PhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SUBPASS_RESOLVE_PERFORMANCE_QUERY_EXT = VkStructureType.SubpassResolvePerformanceQueryEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_INFO_EXT = VkStructureType.MultisampledRenderToSingleSampledInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_2_FEATURES_EXT = VkStructureType.PhysicalDeviceExtendedDynamicState2FeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SCREEN_SURFACE_CREATE_INFO_QNX = VkStructureType.ScreenSurfaceCreateInfoQnx;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COLOR_WRITE_ENABLE_FEATURES_EXT = VkStructureType.PhysicalDeviceColorWriteEnableFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_COLOR_WRITE_CREATE_INFO_EXT = VkStructureType.PipelineColorWriteCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PRIMITIVES_GENERATED_QUERY_FEATURES_EXT = VkStructureType.PhysicalDevicePrimitivesGeneratedQueryFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_MAINTENANCE_1_FEATURES_KHR = VkStructureType.PhysicalDeviceRayTracingMaintenance1FeaturesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_MIN_LOD_FEATURES_EXT = VkStructureType.PhysicalDeviceImageViewMinLodFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_VIEW_MIN_LOD_CREATE_INFO_EXT = VkStructureType.ImageViewMinLodCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTI_DRAW_FEATURES_EXT = VkStructureType.PhysicalDeviceMultiDrawFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTI_DRAW_PROPERTIES_EXT = VkStructureType.PhysicalDeviceMultiDrawPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_2D_VIEW_OF_3D_FEATURES_EXT = VkStructureType.PhysicalDeviceImage2dViewOf3dFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TILE_IMAGE_FEATURES_EXT = VkStructureType.PhysicalDeviceShaderTileImageFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TILE_IMAGE_PROPERTIES_EXT = VkStructureType.PhysicalDeviceShaderTileImagePropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_MICROMAP_BUILD_INFO_EXT = VkStructureType.MicromapBuildInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_MICROMAP_VERSION_INFO_EXT = VkStructureType.MicromapVersionInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_COPY_MICROMAP_INFO_EXT = VkStructureType.CopyMicromapInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_COPY_MICROMAP_TO_MEMORY_INFO_EXT = VkStructureType.CopyMicromapToMemoryInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_COPY_MEMORY_TO_MICROMAP_INFO_EXT = VkStructureType.CopyMemoryToMicromapInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPACITY_MICROMAP_FEATURES_EXT = VkStructureType.PhysicalDeviceOpacityMicromapFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPACITY_MICROMAP_PROPERTIES_EXT = VkStructureType.PhysicalDeviceOpacityMicromapPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_MICROMAP_CREATE_INFO_EXT = VkStructureType.MicromapCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_MICROMAP_BUILD_SIZES_INFO_EXT = VkStructureType.MicromapBuildSizesInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_TRIANGLES_OPACITY_MICROMAP_EXT = VkStructureType.AccelerationStructureTrianglesOpacityMicromapEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DISPLACEMENT_MICROMAP_FEATURES_NV = VkStructureType.PhysicalDeviceDisplacementMicromapFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DISPLACEMENT_MICROMAP_PROPERTIES_NV = VkStructureType.PhysicalDeviceDisplacementMicromapPropertiesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_ACCELERATION_STRUCTURE_TRIANGLES_DISPLACEMENT_MICROMAP_NV = VkStructureType.AccelerationStructureTrianglesDisplacementMicromapNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_FEATURES_HUAWEI = VkStructureType.PhysicalDeviceClusterCullingShaderFeaturesHuawei;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CLUSTER_CULLING_SHADER_PROPERTIES_HUAWEI = VkStructureType.PhysicalDeviceClusterCullingShaderPropertiesHuawei;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BORDER_COLOR_SWIZZLE_FEATURES_EXT = VkStructureType.PhysicalDeviceBorderColorSwizzleFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SAMPLER_BORDER_COLOR_COMPONENT_MAPPING_CREATE_INFO_EXT = VkStructureType.SamplerBorderColorComponentMappingCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PAGEABLE_DEVICE_LOCAL_MEMORY_FEATURES_EXT = VkStructureType.PhysicalDevicePageableDeviceLocalMemoryFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_PROPERTIES_ARM = VkStructureType.PhysicalDeviceShaderCorePropertiesArm;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_SLICED_VIEW_OF_3D_FEATURES_EXT = VkStructureType.PhysicalDeviceImageSlicedViewOf3dFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_VIEW_SLICED_CREATE_INFO_EXT = VkStructureType.ImageViewSlicedCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_SET_HOST_MAPPING_FEATURES_VALVE = VkStructureType.PhysicalDeviceDescriptorSetHostMappingFeaturesValve;
        public const VkStructureType VK_STRUCTURE_TYPE_DESCRIPTOR_SET_BINDING_REFERENCE_VALVE = VkStructureType.DescriptorSetBindingReferenceValve;
        public const VkStructureType VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_HOST_MAPPING_INFO_VALVE = VkStructureType.DescriptorSetLayoutHostMappingInfoValve;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEPTH_CLAMP_ZERO_ONE_FEATURES_EXT = VkStructureType.PhysicalDeviceDepthClampZeroOneFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_NON_SEAMLESS_CUBE_MAP_FEATURES_EXT = VkStructureType.PhysicalDeviceNonSeamlessCubeMapFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_FEATURES_QCOM = VkStructureType.PhysicalDeviceFragmentDensityMapOffsetFeaturesQcom;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_FRAGMENT_DENSITY_MAP_OFFSET_PROPERTIES_QCOM = VkStructureType.PhysicalDeviceFragmentDensityMapOffsetPropertiesQcom;
        public const VkStructureType VK_STRUCTURE_TYPE_SUBPASS_FRAGMENT_DENSITY_MAP_OFFSET_END_INFO_QCOM = VkStructureType.SubpassFragmentDensityMapOffsetEndInfoQcom;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_FEATURES_NV = VkStructureType.PhysicalDeviceCopyMemoryIndirectFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COPY_MEMORY_INDIRECT_PROPERTIES_NV = VkStructureType.PhysicalDeviceCopyMemoryIndirectPropertiesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_FEATURES_NV = VkStructureType.PhysicalDeviceMemoryDecompressionFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_PROPERTIES_NV = VkStructureType.PhysicalDeviceMemoryDecompressionPropertiesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_GENERATED_COMMANDS_COMPUTE_FEATURES_NV = VkStructureType.PhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_COMPUTE_PIPELINE_INDIRECT_BUFFER_INFO_NV = VkStructureType.ComputePipelineIndirectBufferInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_INDIRECT_DEVICE_ADDRESS_INFO_NV = VkStructureType.PipelineIndirectDeviceAddressInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINEAR_COLOR_ATTACHMENT_FEATURES_NV = VkStructureType.PhysicalDeviceLinearColorAttachmentFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_APPLICATION_PARAMETERS_EXT = VkStructureType.ApplicationParametersEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_COMPRESSION_CONTROL_SWAPCHAIN_FEATURES_EXT = VkStructureType.PhysicalDeviceImageCompressionControlSwapchainFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_FEATURES_QCOM = VkStructureType.PhysicalDeviceImageProcessingFeaturesQcom;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_PROPERTIES_QCOM = VkStructureType.PhysicalDeviceImageProcessingPropertiesQcom;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_VIEW_SAMPLE_WEIGHT_CREATE_INFO_QCOM = VkStructureType.ImageViewSampleWeightCreateInfoQcom;
        public const VkStructureType VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_ACQUIRE_UNMODIFIED_EXT = VkStructureType.ExternalMemoryAcquireUnmodifiedEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_3_FEATURES_EXT = VkStructureType.PhysicalDeviceExtendedDynamicState3FeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTENDED_DYNAMIC_STATE_3_PROPERTIES_EXT = VkStructureType.PhysicalDeviceExtendedDynamicState3PropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SUBPASS_MERGE_FEEDBACK_FEATURES_EXT = VkStructureType.PhysicalDeviceSubpassMergeFeedbackFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_RENDER_PASS_CREATION_CONTROL_EXT = VkStructureType.RenderPassCreationControlEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_RENDER_PASS_CREATION_FEEDBACK_CREATE_INFO_EXT = VkStructureType.RenderPassCreationFeedbackCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_RENDER_PASS_SUBPASS_FEEDBACK_CREATE_INFO_EXT = VkStructureType.RenderPassSubpassFeedbackCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_DIRECT_DRIVER_LOADING_INFO_LUNARG = VkStructureType.DirectDriverLoadingInfoLunarg;
        public const VkStructureType VK_STRUCTURE_TYPE_DIRECT_DRIVER_LOADING_LIST_LUNARG = VkStructureType.DirectDriverLoadingListLunarg;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MODULE_IDENTIFIER_FEATURES_EXT = VkStructureType.PhysicalDeviceShaderModuleIdentifierFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_MODULE_IDENTIFIER_PROPERTIES_EXT = VkStructureType.PhysicalDeviceShaderModuleIdentifierPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_MODULE_IDENTIFIER_CREATE_INFO_EXT = VkStructureType.PipelineShaderStageModuleIdentifierCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SHADER_MODULE_IDENTIFIER_EXT = VkStructureType.ShaderModuleIdentifierEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_FEATURES_EXT = VkStructureType.PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPTICAL_FLOW_FEATURES_NV = VkStructureType.PhysicalDeviceOpticalFlowFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPTICAL_FLOW_PROPERTIES_NV = VkStructureType.PhysicalDeviceOpticalFlowPropertiesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_OPTICAL_FLOW_IMAGE_FORMAT_INFO_NV = VkStructureType.OpticalFlowImageFormatInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_OPTICAL_FLOW_IMAGE_FORMAT_PROPERTIES_NV = VkStructureType.OpticalFlowImageFormatPropertiesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_OPTICAL_FLOW_SESSION_CREATE_INFO_NV = VkStructureType.OpticalFlowSessionCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_OPTICAL_FLOW_EXECUTE_INFO_NV = VkStructureType.OpticalFlowExecuteInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_OPTICAL_FLOW_SESSION_CREATE_PRIVATE_DATA_INFO_NV = VkStructureType.OpticalFlowSessionCreatePrivateDataInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LEGACY_DITHERING_FEATURES_EXT = VkStructureType.PhysicalDeviceLegacyDitheringFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_PROTECTED_ACCESS_FEATURES_EXT = VkStructureType.PhysicalDevicePipelineProtectedAccessFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_FEATURES_KHR = VkStructureType.PhysicalDeviceMaintenance5FeaturesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MAINTENANCE_5_PROPERTIES_KHR = VkStructureType.PhysicalDeviceMaintenance5PropertiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_RENDERING_AREA_INFO_KHR = VkStructureType.RenderingAreaInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_IMAGE_SUBRESOURCE_INFO_KHR = VkStructureType.DeviceImageSubresourceInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_SUBRESOURCE_LAYOUT_2_KHR = VkStructureType.SubresourceLayout2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_IMAGE_SUBRESOURCE_2_KHR = VkStructureType.ImageSubresource2KHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PIPELINE_CREATE_FLAGS_2_CREATE_INFO_KHR = VkStructureType.PipelineCreate2CreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_BUFFER_USAGE_FLAGS_2_CREATE_INFO_KHR = VkStructureType.BufferUsage2CreateInfoKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_POSITION_FETCH_FEATURES_KHR = VkStructureType.PhysicalDeviceRayTracingPositionFetchFeaturesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_OBJECT_FEATURES_EXT = VkStructureType.PhysicalDeviceShaderObjectFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_OBJECT_PROPERTIES_EXT = VkStructureType.PhysicalDeviceShaderObjectPropertiesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SHADER_CREATE_INFO_EXT = VkStructureType.ShaderCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TILE_PROPERTIES_FEATURES_QCOM = VkStructureType.PhysicalDeviceTilePropertiesFeaturesQcom;
        public const VkStructureType VK_STRUCTURE_TYPE_TILE_PROPERTIES_QCOM = VkStructureType.TilePropertiesQcom;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_AMIGO_PROFILING_FEATURES_SEC = VkStructureType.PhysicalDeviceAmigoProfilingFeaturesSec;
        public const VkStructureType VK_STRUCTURE_TYPE_AMIGO_PROFILING_SUBMIT_INFO_SEC = VkStructureType.AmigoProfilingSubmitInfoSec;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_VIEWPORTS_FEATURES_QCOM = VkStructureType.PhysicalDeviceMultiviewPerViewViewportsFeaturesQcom;
        public const VkStructureType VK_STRUCTURE_TYPE_SEMAPHORE_SCI_SYNC_POOL_CREATE_INFO_NV = VkStructureType.SemaphoreSciSyncPoolCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_SEMAPHORE_SCI_SYNC_CREATE_INFO_NV = VkStructureType.SemaphoreSciSyncCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_SCI_SYNC_2_FEATURES_NV = VkStructureType.PhysicalDeviceExternalSciSync2FeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_DEVICE_SEMAPHORE_SCI_SYNC_POOL_RESERVATION_CREATE_INFO_NV = VkStructureType.DeviceSemaphoreSciSyncPoolReservationCreateInfoNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_FEATURES_NV = VkStructureType.PhysicalDeviceRayTracingInvocationReorderFeaturesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_RAY_TRACING_INVOCATION_REORDER_PROPERTIES_NV = VkStructureType.PhysicalDeviceRayTracingInvocationReorderPropertiesNV;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MUTABLE_DESCRIPTOR_TYPE_FEATURES_EXT = VkStructureType.PhysicalDeviceMutableDescriptorTypeFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_EXT = VkStructureType.MutableDescriptorTypeCreateInfoEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_BUILTINS_FEATURES_ARM = VkStructureType.PhysicalDeviceShaderCoreBuiltinsFeaturesArm;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CORE_BUILTINS_PROPERTIES_ARM = VkStructureType.PhysicalDeviceShaderCoreBuiltinsPropertiesArm;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PIPELINE_LIBRARY_GROUP_HANDLES_FEATURES_EXT = VkStructureType.PhysicalDevicePipelineLibraryGroupHandlesFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_UNUSED_ATTACHMENTS_FEATURES_EXT = VkStructureType.PhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_FEATURES_KHR = VkStructureType.PhysicalDeviceCooperativeMatrixFeaturesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_COOPERATIVE_MATRIX_PROPERTIES_KHR = VkStructureType.CooperativeMatrixPropertiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_PROPERTIES_KHR = VkStructureType.PhysicalDeviceCooperativeMatrixPropertiesKHR;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTIVIEW_PER_VIEW_RENDER_AREAS_FEATURES_QCOM = VkStructureType.PhysicalDeviceMultiviewPerViewRenderAreasFeaturesQcom;
        public const VkStructureType VK_STRUCTURE_TYPE_MULTIVIEW_PER_VIEW_RENDER_AREAS_RENDER_PASS_BEGIN_INFO_QCOM = VkStructureType.MultiviewPerViewRenderAreasRenderPassBeginInfoQcom;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_2_FEATURES_QCOM = VkStructureType.PhysicalDeviceImageProcessing2FeaturesQcom;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_2_PROPERTIES_QCOM = VkStructureType.PhysicalDeviceImageProcessing2PropertiesQcom;
        public const VkStructureType VK_STRUCTURE_TYPE_SAMPLER_BLOCK_MATCH_WINDOW_CREATE_INFO_QCOM = VkStructureType.SamplerBlockMatchWindowCreateInfoQcom;
        public const VkStructureType VK_STRUCTURE_TYPE_SAMPLER_CUBIC_WEIGHTS_CREATE_INFO_QCOM = VkStructureType.SamplerCubicWeightsCreateInfoQcom;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUBIC_WEIGHTS_FEATURES_QCOM = VkStructureType.PhysicalDeviceCubicWeightsFeaturesQcom;
        public const VkStructureType VK_STRUCTURE_TYPE_BLIT_IMAGE_CUBIC_WEIGHTS_INFO_QCOM = VkStructureType.BlitImageCubicWeightsInfoQcom;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_YCBCR_DEGAMMA_FEATURES_QCOM = VkStructureType.PhysicalDeviceYcbcrDegammaFeaturesQcom;
        public const VkStructureType VK_STRUCTURE_TYPE_SAMPLER_YCBCR_CONVERSION_YCBCR_DEGAMMA_CREATE_INFO_QCOM = VkStructureType.SamplerYcbcrConversionYcbcrDegammaCreateInfoQcom;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_CUBIC_CLAMP_FEATURES_QCOM = VkStructureType.PhysicalDeviceCubicClampFeaturesQcom;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ATTACHMENT_FEEDBACK_LOOP_DYNAMIC_STATE_FEATURES_EXT = VkStructureType.PhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesEXT;
        public const VkStructureType VK_STRUCTURE_TYPE_SCREEN_BUFFER_PROPERTIES_QNX = VkStructureType.ScreenBufferPropertiesQnx;
        public const VkStructureType VK_STRUCTURE_TYPE_SCREEN_BUFFER_FORMAT_PROPERTIES_QNX = VkStructureType.ScreenBufferFormatPropertiesQnx;
        public const VkStructureType VK_STRUCTURE_TYPE_IMPORT_SCREEN_BUFFER_INFO_QNX = VkStructureType.ImportScreenBufferInfoQnx;
        public const VkStructureType VK_STRUCTURE_TYPE_EXTERNAL_FORMAT_QNX = VkStructureType.ExternalFormatQnx;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_SCREEN_BUFFER_FEATURES_QNX = VkStructureType.PhysicalDeviceExternalMemoryScreenBufferFeaturesQnx;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LAYERED_DRIVER_PROPERTIES_MSFT = VkStructureType.PhysicalDeviceLayeredDriverPropertiesMsft;
        public const VkStructureType VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_POOL_OVERALLOCATION_FEATURES_NV = VkStructureType.PhysicalDeviceDescriptorPoolOverallocationFeaturesNV;
    }

    public enum VkSubpassContents : int
    {
        Inline = 0,
        SecondaryCommandBuffers = 1,
    }
    public static partial class RawConstants
    {
        public const VkSubpassContents VK_SUBPASS_CONTENTS_INLINE = VkSubpassContents.Inline;
        public const VkSubpassContents VK_SUBPASS_CONTENTS_SECONDARY_COMMAND_BUFFERS = VkSubpassContents.SecondaryCommandBuffers;
    }

    public enum VkResult : int
    {
        ///<summary>Command completed successfully</summary>
        Success = 0,
        ///<summary>A fence or query has not yet completed</summary>
        NotReady = 1,
        ///<summary>A wait operation has not completed in the specified time</summary>
        Timeout = 2,
        ///<summary>An event is signaled</summary>
        EventSet = 3,
        ///<summary>An event is unsignaled</summary>
        EventReset = 4,
        ///<summary>A return array was too small for the result</summary>
        Incomplete = 5,
        ///<summary>A host memory allocation has failed</summary>
        ErrorOutOfHostMemory = -1,
        ///<summary>A device memory allocation has failed</summary>
        ErrorOutOfDeviceMemory = -2,
        ///<summary>Initialization of an object has failed</summary>
        ErrorInitializationFailed = -3,
        ///<summary>The logical device has been lost. See <<devsandqueues-lost-device>></summary>
        ErrorDeviceLost = -4,
        ///<summary>Mapping of a memory object has failed</summary>
        ErrorMemoryMapFailed = -5,
        ///<summary>Layer specified does not exist</summary>
        ErrorLayerNotPresent = -6,
        ///<summary>Extension specified does not exist</summary>
        ErrorExtensionNotPresent = -7,
        ///<summary>Requested feature is not available on this device</summary>
        ErrorFeatureNotPresent = -8,
        ///<summary>Unable to find a Vulkan driver</summary>
        ErrorIncompatibleDriver = -9,
        ///<summary>Too many objects of the type have already been created</summary>
        ErrorTooManyObjects = -10,
        ///<summary>Requested format is not supported on this device</summary>
        ErrorFormatNotSupported = -11,
        ///<summary>A requested pool allocation has failed due to fragmentation of the pool's memory</summary>
        ErrorFragmentedPool = -12,
        ///<summary>An unknown error has occurred, due to an implementation or application bug</summary>
        ErrorUnknown = -13,
        ErrorOutOfPoolMemory = -1000069000,
        ErrorInvalidExternalHandle = -1000072003,
        ErrorFragmentation = -1000161000,
        ErrorInvalidOpaqueCaptureAddress = -1000257000,
        PipelineCompileRequired = 1000297000,
        ErrorValidationFailed = -1000011001,
        ErrorInvalidPipelineCacheData = -1000298000,
        ErrorNoPipelineMatch = -1000298001,
        ErrorSurfaceLostKHR = -1000000000,
        ErrorNativeWindowInUseKHR = -1000000001,
        SuboptimalKHR = 1000001003,
        ErrorOutOfDateKHR = -1000001004,
        ErrorIncompatibleDisplayKHR = -1000003001,
        ErrorValidationFailedEXT = -1000011001,
        ErrorInvalidShaderNV = -1000012000,
        ErrorImageUsageNotSupportedKHR = -1000023000,
        ErrorVideoPictureLayoutNotSupportedKHR = -1000023001,
        ErrorVideoProfileOperationNotSupportedKHR = -1000023002,
        ErrorVideoProfileFormatNotSupportedKHR = -1000023003,
        ErrorVideoProfileCodecNotSupportedKHR = -1000023004,
        ErrorVideoStdVersionNotSupportedKHR = -1000023005,
        ErrorInvalidDrmFormatModifierPlaneLayoutEXT = -1000158000,
        ErrorNotPermittedKHR = -1000174001,
        ErrorFullScreenExclusiveModeLostEXT = -1000255000,
        ThreadIdleKHR = 1000268000,
        ThreadDoneKHR = 1000268001,
        OperationDeferredKHR = 1000268002,
        OperationNotDeferredKHR = 1000268003,
        ErrorInvalidVideoStdParametersKHR = -1000299000,
        ErrorCompressionExhaustedEXT = -1000338000,
        ErrorIncompatibleShaderBinaryEXT = 1000482000,
    }
    public static partial class RawConstants
    {
        ///<summary>Command completed successfully</summary>
        public const VkResult VK_SUCCESS = VkResult.Success;
        ///<summary>A fence or query has not yet completed</summary>
        public const VkResult VK_NOT_READY = VkResult.NotReady;
        ///<summary>A wait operation has not completed in the specified time</summary>
        public const VkResult VK_TIMEOUT = VkResult.Timeout;
        ///<summary>An event is signaled</summary>
        public const VkResult VK_EVENT_SET = VkResult.EventSet;
        ///<summary>An event is unsignaled</summary>
        public const VkResult VK_EVENT_RESET = VkResult.EventReset;
        ///<summary>A return array was too small for the result</summary>
        public const VkResult VK_INCOMPLETE = VkResult.Incomplete;
        ///<summary>A host memory allocation has failed</summary>
        public const VkResult VK_ERROR_OUT_OF_HOST_MEMORY = VkResult.ErrorOutOfHostMemory;
        ///<summary>A device memory allocation has failed</summary>
        public const VkResult VK_ERROR_OUT_OF_DEVICE_MEMORY = VkResult.ErrorOutOfDeviceMemory;
        ///<summary>Initialization of an object has failed</summary>
        public const VkResult VK_ERROR_INITIALIZATION_FAILED = VkResult.ErrorInitializationFailed;
        ///<summary>The logical device has been lost. See <<devsandqueues-lost-device>></summary>
        public const VkResult VK_ERROR_DEVICE_LOST = VkResult.ErrorDeviceLost;
        ///<summary>Mapping of a memory object has failed</summary>
        public const VkResult VK_ERROR_MEMORY_MAP_FAILED = VkResult.ErrorMemoryMapFailed;
        ///<summary>Layer specified does not exist</summary>
        public const VkResult VK_ERROR_LAYER_NOT_PRESENT = VkResult.ErrorLayerNotPresent;
        ///<summary>Extension specified does not exist</summary>
        public const VkResult VK_ERROR_EXTENSION_NOT_PRESENT = VkResult.ErrorExtensionNotPresent;
        ///<summary>Requested feature is not available on this device</summary>
        public const VkResult VK_ERROR_FEATURE_NOT_PRESENT = VkResult.ErrorFeatureNotPresent;
        ///<summary>Unable to find a Vulkan driver</summary>
        public const VkResult VK_ERROR_INCOMPATIBLE_DRIVER = VkResult.ErrorIncompatibleDriver;
        ///<summary>Too many objects of the type have already been created</summary>
        public const VkResult VK_ERROR_TOO_MANY_OBJECTS = VkResult.ErrorTooManyObjects;
        ///<summary>Requested format is not supported on this device</summary>
        public const VkResult VK_ERROR_FORMAT_NOT_SUPPORTED = VkResult.ErrorFormatNotSupported;
        ///<summary>A requested pool allocation has failed due to fragmentation of the pool's memory</summary>
        public const VkResult VK_ERROR_FRAGMENTED_POOL = VkResult.ErrorFragmentedPool;
        ///<summary>An unknown error has occurred, due to an implementation or application bug</summary>
        public const VkResult VK_ERROR_UNKNOWN = VkResult.ErrorUnknown;
        public const VkResult VK_ERROR_OUT_OF_POOL_MEMORY = VkResult.ErrorOutOfPoolMemory;
        public const VkResult VK_ERROR_INVALID_EXTERNAL_HANDLE = VkResult.ErrorInvalidExternalHandle;
        public const VkResult VK_ERROR_FRAGMENTATION = VkResult.ErrorFragmentation;
        public const VkResult VK_ERROR_INVALID_OPAQUE_CAPTURE_ADDRESS = VkResult.ErrorInvalidOpaqueCaptureAddress;
        public const VkResult VK_PIPELINE_COMPILE_REQUIRED = VkResult.PipelineCompileRequired;
        public const VkResult VK_ERROR_VALIDATION_FAILED = VkResult.ErrorValidationFailed;
        public const VkResult VK_ERROR_INVALID_PIPELINE_CACHE_DATA = VkResult.ErrorInvalidPipelineCacheData;
        public const VkResult VK_ERROR_NO_PIPELINE_MATCH = VkResult.ErrorNoPipelineMatch;
        public const VkResult VK_ERROR_SURFACE_LOST_KHR = VkResult.ErrorSurfaceLostKHR;
        public const VkResult VK_ERROR_NATIVE_WINDOW_IN_USE_KHR = VkResult.ErrorNativeWindowInUseKHR;
        public const VkResult VK_SUBOPTIMAL_KHR = VkResult.SuboptimalKHR;
        public const VkResult VK_ERROR_OUT_OF_DATE_KHR = VkResult.ErrorOutOfDateKHR;
        public const VkResult VK_ERROR_INCOMPATIBLE_DISPLAY_KHR = VkResult.ErrorIncompatibleDisplayKHR;
        public const VkResult VK_ERROR_VALIDATION_FAILED_EXT = VkResult.ErrorValidationFailedEXT;
        public const VkResult VK_ERROR_INVALID_SHADER_NV = VkResult.ErrorInvalidShaderNV;
        public const VkResult VK_ERROR_IMAGE_USAGE_NOT_SUPPORTED_KHR = VkResult.ErrorImageUsageNotSupportedKHR;
        public const VkResult VK_ERROR_VIDEO_PICTURE_LAYOUT_NOT_SUPPORTED_KHR = VkResult.ErrorVideoPictureLayoutNotSupportedKHR;
        public const VkResult VK_ERROR_VIDEO_PROFILE_OPERATION_NOT_SUPPORTED_KHR = VkResult.ErrorVideoProfileOperationNotSupportedKHR;
        public const VkResult VK_ERROR_VIDEO_PROFILE_FORMAT_NOT_SUPPORTED_KHR = VkResult.ErrorVideoProfileFormatNotSupportedKHR;
        public const VkResult VK_ERROR_VIDEO_PROFILE_CODEC_NOT_SUPPORTED_KHR = VkResult.ErrorVideoProfileCodecNotSupportedKHR;
        public const VkResult VK_ERROR_VIDEO_STD_VERSION_NOT_SUPPORTED_KHR = VkResult.ErrorVideoStdVersionNotSupportedKHR;
        public const VkResult VK_ERROR_INVALID_DRM_FORMAT_MODIFIER_PLANE_LAYOUT_EXT = VkResult.ErrorInvalidDrmFormatModifierPlaneLayoutEXT;
        public const VkResult VK_ERROR_NOT_PERMITTED_KHR = VkResult.ErrorNotPermittedKHR;
        public const VkResult VK_ERROR_FULL_SCREEN_EXCLUSIVE_MODE_LOST_EXT = VkResult.ErrorFullScreenExclusiveModeLostEXT;
        public const VkResult VK_THREAD_IDLE_KHR = VkResult.ThreadIdleKHR;
        public const VkResult VK_THREAD_DONE_KHR = VkResult.ThreadDoneKHR;
        public const VkResult VK_OPERATION_DEFERRED_KHR = VkResult.OperationDeferredKHR;
        public const VkResult VK_OPERATION_NOT_DEFERRED_KHR = VkResult.OperationNotDeferredKHR;
        public const VkResult VK_ERROR_INVALID_VIDEO_STD_PARAMETERS_KHR = VkResult.ErrorInvalidVideoStdParametersKHR;
        public const VkResult VK_ERROR_COMPRESSION_EXHAUSTED_EXT = VkResult.ErrorCompressionExhaustedEXT;
        public const VkResult VK_ERROR_INCOMPATIBLE_SHADER_BINARY_EXT = VkResult.ErrorIncompatibleShaderBinaryEXT;
    }

    public enum VkDynamicState : int
    {
        Viewport = 0,
        Scissor = 1,
        LineWidth = 2,
        DepthBias = 3,
        BlendConstants = 4,
        DepthBounds = 5,
        StencilCompareMask = 6,
        StencilWriteMask = 7,
        StencilReference = 8,
        CullMode = 1000267000,
        FrontFace = 1000267001,
        PrimitiveTopology = 1000267002,
        ViewportWithCount = 1000267003,
        ScissorWithCount = 1000267004,
        VertexInputBindingStride = 1000267005,
        DepthTestEnable = 1000267006,
        DepthWriteEnable = 1000267007,
        DepthCompareOp = 1000267008,
        DepthBoundsTestEnable = 1000267009,
        StencilTestEnable = 1000267010,
        StencilOp = 1000267011,
        RasterizerDiscardEnable = 1000377001,
        DepthBiasEnable = 1000377002,
        PrimitiveRestartEnable = 1000377004,
        ViewportWScalingNV = 1000087000,
        DiscardRectangleEXT = 1000099000,
        DiscardRectangleEnableEXT = 1000099001,
        DiscardRectangleModeEXT = 1000099002,
        SampleLocationsEXT = 1000143000,
        RayTracingPipelineStackSizeKHR = 1000347000,
        ViewportShadingRatePaletteNV = 1000164004,
        ViewportCoarseSampleOrderNV = 1000164006,
        ExclusiveScissorEnableNV = 1000205000,
        ExclusiveScissorNV = 1000205001,
        FragmentShadingRateKHR = 1000226000,
        LineStippleEXT = 1000259000,
        VertexInputEXT = 1000352000,
        PatchControlPointsEXT = 1000377000,
        LogicOpEXT = 1000377003,
        ColorWriteEnableEXT = 1000381000,
        TessellationDomainOriginEXT = 1000455002,
        DepthClampEnableEXT = 1000455003,
        PolygonModeEXT = 1000455004,
        RasterizationSamplesEXT = 1000455005,
        SampleMaskEXT = 1000455006,
        AlphaToCoverageEnableEXT = 1000455007,
        AlphaToOneEnableEXT = 1000455008,
        LogicOpEnableEXT = 1000455009,
        ColorBlendEnableEXT = 1000455010,
        ColorBlendEquationEXT = 1000455011,
        ColorWriteMaskEXT = 1000455012,
        RasterizationStreamEXT = 1000455013,
        ConservativeRasterizationModeEXT = 1000455014,
        ExtraPrimitiveOverestimationSizeEXT = 1000455015,
        DepthClipEnableEXT = 1000455016,
        SampleLocationsEnableEXT = 1000455017,
        ColorBlendAdvancedEXT = 1000455018,
        ProvokingVertexModeEXT = 1000455019,
        LineRasterizationModeEXT = 1000455020,
        LineStippleEnableEXT = 1000455021,
        DepthClipNegativeOneToOneEXT = 1000455022,
        ViewportWScalingEnableNV = 1000455023,
        ViewportSwizzleNV = 1000455024,
        CoverageToColorEnableNV = 1000455025,
        CoverageToColorLocationNV = 1000455026,
        CoverageModulationModeNV = 1000455027,
        CoverageModulationTableEnableNV = 1000455028,
        CoverageModulationTableNV = 1000455029,
        ShadingRateImageEnableNV = 1000455030,
        RepresentativeFragmentTestEnableNV = 1000455031,
        CoverageReductionModeNV = 1000455032,
        AttachmentFeedbackLoopEnableEXT = 1000524000,
    }
    public static partial class RawConstants
    {
        public const VkDynamicState VK_DYNAMIC_STATE_VIEWPORT = VkDynamicState.Viewport;
        public const VkDynamicState VK_DYNAMIC_STATE_SCISSOR = VkDynamicState.Scissor;
        public const VkDynamicState VK_DYNAMIC_STATE_LINE_WIDTH = VkDynamicState.LineWidth;
        public const VkDynamicState VK_DYNAMIC_STATE_DEPTH_BIAS = VkDynamicState.DepthBias;
        public const VkDynamicState VK_DYNAMIC_STATE_BLEND_CONSTANTS = VkDynamicState.BlendConstants;
        public const VkDynamicState VK_DYNAMIC_STATE_DEPTH_BOUNDS = VkDynamicState.DepthBounds;
        public const VkDynamicState VK_DYNAMIC_STATE_STENCIL_COMPARE_MASK = VkDynamicState.StencilCompareMask;
        public const VkDynamicState VK_DYNAMIC_STATE_STENCIL_WRITE_MASK = VkDynamicState.StencilWriteMask;
        public const VkDynamicState VK_DYNAMIC_STATE_STENCIL_REFERENCE = VkDynamicState.StencilReference;
        public const VkDynamicState VK_DYNAMIC_STATE_CULL_MODE = VkDynamicState.CullMode;
        public const VkDynamicState VK_DYNAMIC_STATE_FRONT_FACE = VkDynamicState.FrontFace;
        public const VkDynamicState VK_DYNAMIC_STATE_PRIMITIVE_TOPOLOGY = VkDynamicState.PrimitiveTopology;
        public const VkDynamicState VK_DYNAMIC_STATE_VIEWPORT_WITH_COUNT = VkDynamicState.ViewportWithCount;
        public const VkDynamicState VK_DYNAMIC_STATE_SCISSOR_WITH_COUNT = VkDynamicState.ScissorWithCount;
        public const VkDynamicState VK_DYNAMIC_STATE_VERTEX_INPUT_BINDING_STRIDE = VkDynamicState.VertexInputBindingStride;
        public const VkDynamicState VK_DYNAMIC_STATE_DEPTH_TEST_ENABLE = VkDynamicState.DepthTestEnable;
        public const VkDynamicState VK_DYNAMIC_STATE_DEPTH_WRITE_ENABLE = VkDynamicState.DepthWriteEnable;
        public const VkDynamicState VK_DYNAMIC_STATE_DEPTH_COMPARE_OP = VkDynamicState.DepthCompareOp;
        public const VkDynamicState VK_DYNAMIC_STATE_DEPTH_BOUNDS_TEST_ENABLE = VkDynamicState.DepthBoundsTestEnable;
        public const VkDynamicState VK_DYNAMIC_STATE_STENCIL_TEST_ENABLE = VkDynamicState.StencilTestEnable;
        public const VkDynamicState VK_DYNAMIC_STATE_STENCIL_OP = VkDynamicState.StencilOp;
        public const VkDynamicState VK_DYNAMIC_STATE_RASTERIZER_DISCARD_ENABLE = VkDynamicState.RasterizerDiscardEnable;
        public const VkDynamicState VK_DYNAMIC_STATE_DEPTH_BIAS_ENABLE = VkDynamicState.DepthBiasEnable;
        public const VkDynamicState VK_DYNAMIC_STATE_PRIMITIVE_RESTART_ENABLE = VkDynamicState.PrimitiveRestartEnable;
        public const VkDynamicState VK_DYNAMIC_STATE_VIEWPORT_W_SCALING_NV = VkDynamicState.ViewportWScalingNV;
        public const VkDynamicState VK_DYNAMIC_STATE_DISCARD_RECTANGLE_EXT = VkDynamicState.DiscardRectangleEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_DISCARD_RECTANGLE_ENABLE_EXT = VkDynamicState.DiscardRectangleEnableEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_DISCARD_RECTANGLE_MODE_EXT = VkDynamicState.DiscardRectangleModeEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_EXT = VkDynamicState.SampleLocationsEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_RAY_TRACING_PIPELINE_STACK_SIZE_KHR = VkDynamicState.RayTracingPipelineStackSizeKHR;
        public const VkDynamicState VK_DYNAMIC_STATE_VIEWPORT_SHADING_RATE_PALETTE_NV = VkDynamicState.ViewportShadingRatePaletteNV;
        public const VkDynamicState VK_DYNAMIC_STATE_VIEWPORT_COARSE_SAMPLE_ORDER_NV = VkDynamicState.ViewportCoarseSampleOrderNV;
        public const VkDynamicState VK_DYNAMIC_STATE_EXCLUSIVE_SCISSOR_ENABLE_NV = VkDynamicState.ExclusiveScissorEnableNV;
        public const VkDynamicState VK_DYNAMIC_STATE_EXCLUSIVE_SCISSOR_NV = VkDynamicState.ExclusiveScissorNV;
        public const VkDynamicState VK_DYNAMIC_STATE_FRAGMENT_SHADING_RATE_KHR = VkDynamicState.FragmentShadingRateKHR;
        public const VkDynamicState VK_DYNAMIC_STATE_LINE_STIPPLE_EXT = VkDynamicState.LineStippleEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_VERTEX_INPUT_EXT = VkDynamicState.VertexInputEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_PATCH_CONTROL_POINTS_EXT = VkDynamicState.PatchControlPointsEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_LOGIC_OP_EXT = VkDynamicState.LogicOpEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_COLOR_WRITE_ENABLE_EXT = VkDynamicState.ColorWriteEnableEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_TESSELLATION_DOMAIN_ORIGIN_EXT = VkDynamicState.TessellationDomainOriginEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_DEPTH_CLAMP_ENABLE_EXT = VkDynamicState.DepthClampEnableEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_POLYGON_MODE_EXT = VkDynamicState.PolygonModeEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_RASTERIZATION_SAMPLES_EXT = VkDynamicState.RasterizationSamplesEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_SAMPLE_MASK_EXT = VkDynamicState.SampleMaskEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_ALPHA_TO_COVERAGE_ENABLE_EXT = VkDynamicState.AlphaToCoverageEnableEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_ALPHA_TO_ONE_ENABLE_EXT = VkDynamicState.AlphaToOneEnableEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_LOGIC_OP_ENABLE_EXT = VkDynamicState.LogicOpEnableEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_COLOR_BLEND_ENABLE_EXT = VkDynamicState.ColorBlendEnableEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_COLOR_BLEND_EQUATION_EXT = VkDynamicState.ColorBlendEquationEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_COLOR_WRITE_MASK_EXT = VkDynamicState.ColorWriteMaskEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_RASTERIZATION_STREAM_EXT = VkDynamicState.RasterizationStreamEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_CONSERVATIVE_RASTERIZATION_MODE_EXT = VkDynamicState.ConservativeRasterizationModeEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_EXTRA_PRIMITIVE_OVERESTIMATION_SIZE_EXT = VkDynamicState.ExtraPrimitiveOverestimationSizeEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_DEPTH_CLIP_ENABLE_EXT = VkDynamicState.DepthClipEnableEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_SAMPLE_LOCATIONS_ENABLE_EXT = VkDynamicState.SampleLocationsEnableEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_COLOR_BLEND_ADVANCED_EXT = VkDynamicState.ColorBlendAdvancedEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_PROVOKING_VERTEX_MODE_EXT = VkDynamicState.ProvokingVertexModeEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_LINE_RASTERIZATION_MODE_EXT = VkDynamicState.LineRasterizationModeEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_LINE_STIPPLE_ENABLE_EXT = VkDynamicState.LineStippleEnableEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_DEPTH_CLIP_NEGATIVE_ONE_TO_ONE_EXT = VkDynamicState.DepthClipNegativeOneToOneEXT;
        public const VkDynamicState VK_DYNAMIC_STATE_VIEWPORT_W_SCALING_ENABLE_NV = VkDynamicState.ViewportWScalingEnableNV;
        public const VkDynamicState VK_DYNAMIC_STATE_VIEWPORT_SWIZZLE_NV = VkDynamicState.ViewportSwizzleNV;
        public const VkDynamicState VK_DYNAMIC_STATE_COVERAGE_TO_COLOR_ENABLE_NV = VkDynamicState.CoverageToColorEnableNV;
        public const VkDynamicState VK_DYNAMIC_STATE_COVERAGE_TO_COLOR_LOCATION_NV = VkDynamicState.CoverageToColorLocationNV;
        public const VkDynamicState VK_DYNAMIC_STATE_COVERAGE_MODULATION_MODE_NV = VkDynamicState.CoverageModulationModeNV;
        public const VkDynamicState VK_DYNAMIC_STATE_COVERAGE_MODULATION_TABLE_ENABLE_NV = VkDynamicState.CoverageModulationTableEnableNV;
        public const VkDynamicState VK_DYNAMIC_STATE_COVERAGE_MODULATION_TABLE_NV = VkDynamicState.CoverageModulationTableNV;
        public const VkDynamicState VK_DYNAMIC_STATE_SHADING_RATE_IMAGE_ENABLE_NV = VkDynamicState.ShadingRateImageEnableNV;
        public const VkDynamicState VK_DYNAMIC_STATE_REPRESENTATIVE_FRAGMENT_TEST_ENABLE_NV = VkDynamicState.RepresentativeFragmentTestEnableNV;
        public const VkDynamicState VK_DYNAMIC_STATE_COVERAGE_REDUCTION_MODE_NV = VkDynamicState.CoverageReductionModeNV;
        public const VkDynamicState VK_DYNAMIC_STATE_ATTACHMENT_FEEDBACK_LOOP_ENABLE_EXT = VkDynamicState.AttachmentFeedbackLoopEnableEXT;
    }

    public enum VkDescriptorUpdateTemplateType : int
    {
        ///<summary>Create descriptor update template for descriptor set updates</summary>
        DescriptorSet = 0,
        PushDescriptorsKHR = 1,
    }
    public static partial class RawConstants
    {
        ///<summary>Create descriptor update template for descriptor set updates</summary>
        public const VkDescriptorUpdateTemplateType VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET = VkDescriptorUpdateTemplateType.DescriptorSet;
        public const VkDescriptorUpdateTemplateType VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR = VkDescriptorUpdateTemplateType.PushDescriptorsKHR;
    }

    public enum VkObjectType : int
    {
        Unknown = 0,
        Instance = 1,
        PhysicalDevice = 2,
        Device = 3,
        Queue = 4,
        Semaphore = 5,
        CommandBuffer = 6,
        Fence = 7,
        DeviceMemory = 8,
        Buffer = 9,
        Image = 10,
        Event = 11,
        QueryPool = 12,
        BufferView = 13,
        ImageView = 14,
        ShaderModule = 15,
        PipelineCache = 16,
        PipelineLayout = 17,
        RenderPass = 18,
        Pipeline = 19,
        DescriptorSetLayout = 20,
        Sampler = 21,
        DescriptorPool = 22,
        DescriptorSet = 23,
        Framebuffer = 24,
        CommandPool = 25,
        SamplerYcbcrConversion = 1000156000,
        DescriptorUpdateTemplate = 1000085000,
        PrivateDataSlot = 1000295000,
        SurfaceKHR = 1000000000,
        SwapchainKHR = 1000001000,
        DisplayKHR = 1000002000,
        DisplayModeKHR = 1000002001,
        DebugReportCallbackEXT = 1000011000,
        VideoSessionKHR = 1000023000,
        VideoSessionParametersKHR = 1000023001,
        CuModuleNVX = 1000029000,
        CuFunctionNVX = 1000029001,
        DebugUtilsMessengerEXT = 1000128000,
        AccelerationStructureKHR = 1000150000,
        ValidationCacheEXT = 1000160000,
        AccelerationStructureNV = 1000165000,
        PerformanceConfigurationIntel = 1000210000,
        DeferredOperationKHR = 1000268000,
        IndirectCommandsLayoutNV = 1000277000,
        BufferCollectionFuchsia = 1000366000,
        MicromapEXT = 1000396000,
        OpticalFlowSessionNV = 1000464000,
        ShaderEXT = 1000482000,
        SemaphoreSciSyncPoolNV = 1000489000,
    }
    public static partial class RawConstants
    {
        public const VkObjectType VK_OBJECT_TYPE_UNKNOWN = VkObjectType.Unknown;
        public const VkObjectType VK_OBJECT_TYPE_INSTANCE = VkObjectType.Instance;
        public const VkObjectType VK_OBJECT_TYPE_PHYSICAL_DEVICE = VkObjectType.PhysicalDevice;
        public const VkObjectType VK_OBJECT_TYPE_DEVICE = VkObjectType.Device;
        public const VkObjectType VK_OBJECT_TYPE_QUEUE = VkObjectType.Queue;
        public const VkObjectType VK_OBJECT_TYPE_SEMAPHORE = VkObjectType.Semaphore;
        public const VkObjectType VK_OBJECT_TYPE_COMMAND_BUFFER = VkObjectType.CommandBuffer;
        public const VkObjectType VK_OBJECT_TYPE_FENCE = VkObjectType.Fence;
        public const VkObjectType VK_OBJECT_TYPE_DEVICE_MEMORY = VkObjectType.DeviceMemory;
        public const VkObjectType VK_OBJECT_TYPE_BUFFER = VkObjectType.Buffer;
        public const VkObjectType VK_OBJECT_TYPE_IMAGE = VkObjectType.Image;
        public const VkObjectType VK_OBJECT_TYPE_EVENT = VkObjectType.Event;
        public const VkObjectType VK_OBJECT_TYPE_QUERY_POOL = VkObjectType.QueryPool;
        public const VkObjectType VK_OBJECT_TYPE_BUFFER_VIEW = VkObjectType.BufferView;
        public const VkObjectType VK_OBJECT_TYPE_IMAGE_VIEW = VkObjectType.ImageView;
        public const VkObjectType VK_OBJECT_TYPE_SHADER_MODULE = VkObjectType.ShaderModule;
        public const VkObjectType VK_OBJECT_TYPE_PIPELINE_CACHE = VkObjectType.PipelineCache;
        public const VkObjectType VK_OBJECT_TYPE_PIPELINE_LAYOUT = VkObjectType.PipelineLayout;
        public const VkObjectType VK_OBJECT_TYPE_RENDER_PASS = VkObjectType.RenderPass;
        public const VkObjectType VK_OBJECT_TYPE_PIPELINE = VkObjectType.Pipeline;
        public const VkObjectType VK_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT = VkObjectType.DescriptorSetLayout;
        public const VkObjectType VK_OBJECT_TYPE_SAMPLER = VkObjectType.Sampler;
        public const VkObjectType VK_OBJECT_TYPE_DESCRIPTOR_POOL = VkObjectType.DescriptorPool;
        public const VkObjectType VK_OBJECT_TYPE_DESCRIPTOR_SET = VkObjectType.DescriptorSet;
        public const VkObjectType VK_OBJECT_TYPE_FRAMEBUFFER = VkObjectType.Framebuffer;
        public const VkObjectType VK_OBJECT_TYPE_COMMAND_POOL = VkObjectType.CommandPool;
        public const VkObjectType VK_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION = VkObjectType.SamplerYcbcrConversion;
        public const VkObjectType VK_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE = VkObjectType.DescriptorUpdateTemplate;
        public const VkObjectType VK_OBJECT_TYPE_PRIVATE_DATA_SLOT = VkObjectType.PrivateDataSlot;
        public const VkObjectType VK_OBJECT_TYPE_SURFACE_KHR = VkObjectType.SurfaceKHR;
        public const VkObjectType VK_OBJECT_TYPE_SWAPCHAIN_KHR = VkObjectType.SwapchainKHR;
        public const VkObjectType VK_OBJECT_TYPE_DISPLAY_KHR = VkObjectType.DisplayKHR;
        public const VkObjectType VK_OBJECT_TYPE_DISPLAY_MODE_KHR = VkObjectType.DisplayModeKHR;
        public const VkObjectType VK_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT = VkObjectType.DebugReportCallbackEXT;
        public const VkObjectType VK_OBJECT_TYPE_VIDEO_SESSION_KHR = VkObjectType.VideoSessionKHR;
        public const VkObjectType VK_OBJECT_TYPE_VIDEO_SESSION_PARAMETERS_KHR = VkObjectType.VideoSessionParametersKHR;
        public const VkObjectType VK_OBJECT_TYPE_CU_MODULE_NVX = VkObjectType.CuModuleNVX;
        public const VkObjectType VK_OBJECT_TYPE_CU_FUNCTION_NVX = VkObjectType.CuFunctionNVX;
        public const VkObjectType VK_OBJECT_TYPE_DEBUG_UTILS_MESSENGER_EXT = VkObjectType.DebugUtilsMessengerEXT;
        public const VkObjectType VK_OBJECT_TYPE_ACCELERATION_STRUCTURE_KHR = VkObjectType.AccelerationStructureKHR;
        public const VkObjectType VK_OBJECT_TYPE_VALIDATION_CACHE_EXT = VkObjectType.ValidationCacheEXT;
        public const VkObjectType VK_OBJECT_TYPE_ACCELERATION_STRUCTURE_NV = VkObjectType.AccelerationStructureNV;
        public const VkObjectType VK_OBJECT_TYPE_PERFORMANCE_CONFIGURATION_INTEL = VkObjectType.PerformanceConfigurationIntel;
        public const VkObjectType VK_OBJECT_TYPE_DEFERRED_OPERATION_KHR = VkObjectType.DeferredOperationKHR;
        public const VkObjectType VK_OBJECT_TYPE_INDIRECT_COMMANDS_LAYOUT_NV = VkObjectType.IndirectCommandsLayoutNV;
        public const VkObjectType VK_OBJECT_TYPE_BUFFER_COLLECTION_FUCHSIA = VkObjectType.BufferCollectionFuchsia;
        public const VkObjectType VK_OBJECT_TYPE_MICROMAP_EXT = VkObjectType.MicromapEXT;
        public const VkObjectType VK_OBJECT_TYPE_OPTICAL_FLOW_SESSION_NV = VkObjectType.OpticalFlowSessionNV;
        public const VkObjectType VK_OBJECT_TYPE_SHADER_EXT = VkObjectType.ShaderEXT;
        public const VkObjectType VK_OBJECT_TYPE_SEMAPHORE_SCI_SYNC_POOL_NV = VkObjectType.SemaphoreSciSyncPoolNV;
    }

    public enum VkRayTracingInvocationReorderModeNV : int
    {
        VK_RAY_TRACING_INVOCATION_REORDER_MODE_NONE_NV = 0,
        VK_RAY_TRACING_INVOCATION_REORDER_MODE_REORDER_NV = 1,
    }
    public static partial class RawConstants
    {
        public const VkRayTracingInvocationReorderModeNV VK_RAY_TRACING_INVOCATION_REORDER_MODE_NONE_NV = VkRayTracingInvocationReorderModeNV.VK_RAY_TRACING_INVOCATION_REORDER_MODE_NONE_NV;
        public const VkRayTracingInvocationReorderModeNV VK_RAY_TRACING_INVOCATION_REORDER_MODE_REORDER_NV = VkRayTracingInvocationReorderModeNV.VK_RAY_TRACING_INVOCATION_REORDER_MODE_REORDER_NV;
    }

    public enum VkDirectDriverLoadingModeLUNARG : int
    {
        VK_DIRECT_DRIVER_LOADING_MODE_EXCLUSIVE_LUNARG = 0,
        VK_DIRECT_DRIVER_LOADING_MODE_INCLUSIVE_LUNARG = 1,
    }
    public static partial class RawConstants
    {
        public const VkDirectDriverLoadingModeLUNARG VK_DIRECT_DRIVER_LOADING_MODE_EXCLUSIVE_LUNARG = VkDirectDriverLoadingModeLUNARG.VK_DIRECT_DRIVER_LOADING_MODE_EXCLUSIVE_LUNARG;
        public const VkDirectDriverLoadingModeLUNARG VK_DIRECT_DRIVER_LOADING_MODE_INCLUSIVE_LUNARG = VkDirectDriverLoadingModeLUNARG.VK_DIRECT_DRIVER_LOADING_MODE_INCLUSIVE_LUNARG;
    }

    [Flags]
    public enum VkQueueFlags : int
    {
        None = 0,
        ///<summary>Queue supports graphics operations</summary>
        Graphics = 1,
        ///<summary>Queue supports compute operations</summary>
        Compute = 2,
        ///<summary>Queue supports transfer operations</summary>
        Transfer = 4,
        ///<summary>Queue supports sparse resource memory management operations</summary>
        SparseBinding = 8,
        Protected = 16,
        VideoDecodeKHR = 32,
        Reserved9EXT = 512,
        VideoEncodeKHR = 64,
        Reserved7Qcom = 128,
        Reserved11Arm = 2048,
        OpticalFlowNV = 256,
        Reserved10EXT = 1024,
    }
    public static partial class RawConstants
    {
        ///<summary>Queue supports graphics operations</summary>
        public const VkQueueFlags VK_QUEUE_GRAPHICS_BIT = VkQueueFlags.Graphics;
        ///<summary>Queue supports compute operations</summary>
        public const VkQueueFlags VK_QUEUE_COMPUTE_BIT = VkQueueFlags.Compute;
        ///<summary>Queue supports transfer operations</summary>
        public const VkQueueFlags VK_QUEUE_TRANSFER_BIT = VkQueueFlags.Transfer;
        ///<summary>Queue supports sparse resource memory management operations</summary>
        public const VkQueueFlags VK_QUEUE_SPARSE_BINDING_BIT = VkQueueFlags.SparseBinding;
        public const VkQueueFlags VK_QUEUE_PROTECTED_BIT = VkQueueFlags.Protected;
        public const VkQueueFlags VK_QUEUE_VIDEO_DECODE_BIT_KHR = VkQueueFlags.VideoDecodeKHR;
        public const VkQueueFlags VK_QUEUE_RESERVED_9_BIT_EXT = VkQueueFlags.Reserved9EXT;
        public const VkQueueFlags VK_QUEUE_VIDEO_ENCODE_BIT_KHR = VkQueueFlags.VideoEncodeKHR;
        public const VkQueueFlags VK_QUEUE_RESERVED_7_BIT_QCOM = VkQueueFlags.Reserved7Qcom;
        public const VkQueueFlags VK_QUEUE_RESERVED_11_BIT_ARM = VkQueueFlags.Reserved11Arm;
        public const VkQueueFlags VK_QUEUE_OPTICAL_FLOW_BIT_NV = VkQueueFlags.OpticalFlowNV;
        public const VkQueueFlags VK_QUEUE_RESERVED_10_BIT_EXT = VkQueueFlags.Reserved10EXT;
    }

    [Flags]
    public enum VkCullModeFlags : int
    {
        None = 0,
        Front = 1,
        Back = 2,
        FrontAndBack = 3,
    }
    public static partial class RawConstants
    {
        public const VkCullModeFlags VK_CULL_MODE_NONE = VkCullModeFlags.None;
        public const VkCullModeFlags VK_CULL_MODE_FRONT_BIT = VkCullModeFlags.Front;
        public const VkCullModeFlags VK_CULL_MODE_BACK_BIT = VkCullModeFlags.Back;
        public const VkCullModeFlags VK_CULL_MODE_FRONT_AND_BACK = VkCullModeFlags.FrontAndBack;
    }

    [Flags]
    public enum VkRenderPassCreateFlags : int
    {
        None = 0,
        Reserved0KHR = 1,
        TransformQcom = 2,
    }
    public static partial class RawConstants
    {
        public const VkRenderPassCreateFlags VK_RENDER_PASS_CREATE_RESERVED_0_BIT_KHR = VkRenderPassCreateFlags.Reserved0KHR;
        public const VkRenderPassCreateFlags VK_RENDER_PASS_CREATE_TRANSFORM_BIT_QCOM = VkRenderPassCreateFlags.TransformQcom;
    }

    [Flags]
    public enum VkDeviceQueueCreateFlags : int
    {
        None = 0,
        Protected = 1,
        Reserved1Qcom = 2,
    }
    public static partial class RawConstants
    {
        public const VkDeviceQueueCreateFlags VK_DEVICE_QUEUE_CREATE_PROTECTED_BIT = VkDeviceQueueCreateFlags.Protected;
        public const VkDeviceQueueCreateFlags VK_DEVICE_QUEUE_CREATE_RESERVED_1_BIT_QCOM = VkDeviceQueueCreateFlags.Reserved1Qcom;
    }

    [Flags]
    public enum VkMemoryPropertyFlags : int
    {
        None = 0,
        ///<summary>If otherwise stated, then allocate memory on device</summary>
        DeviceLocal = 1,
        ///<summary>Memory is mappable by host</summary>
        HostVisible = 2,
        ///<summary>Memory will have i/o coherency. If not set, application may need to use vkFlushMappedMemoryRanges and vkInvalidateMappedMemoryRanges to flush/invalidate host cache</summary>
        HostCoherent = 4,
        ///<summary>Memory will be cached by the host</summary>
        HostCached = 8,
        ///<summary>Memory may be allocated by the driver when it is required</summary>
        LazilyAllocated = 16,
        Protected = 32,
        DeviceCoherentAMD = 64,
        DeviceUncachedAMD = 128,
        RdmaCapableNV = 256,
    }
    public static partial class RawConstants
    {
        ///<summary>If otherwise stated, then allocate memory on device</summary>
        public const VkMemoryPropertyFlags VK_MEMORY_PROPERTY_DEVICE_LOCAL_BIT = VkMemoryPropertyFlags.DeviceLocal;
        ///<summary>Memory is mappable by host</summary>
        public const VkMemoryPropertyFlags VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT = VkMemoryPropertyFlags.HostVisible;
        ///<summary>Memory will have i/o coherency. If not set, application may need to use vkFlushMappedMemoryRanges and vkInvalidateMappedMemoryRanges to flush/invalidate host cache</summary>
        public const VkMemoryPropertyFlags VK_MEMORY_PROPERTY_HOST_COHERENT_BIT = VkMemoryPropertyFlags.HostCoherent;
        ///<summary>Memory will be cached by the host</summary>
        public const VkMemoryPropertyFlags VK_MEMORY_PROPERTY_HOST_CACHED_BIT = VkMemoryPropertyFlags.HostCached;
        ///<summary>Memory may be allocated by the driver when it is required</summary>
        public const VkMemoryPropertyFlags VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT = VkMemoryPropertyFlags.LazilyAllocated;
        public const VkMemoryPropertyFlags VK_MEMORY_PROPERTY_PROTECTED_BIT = VkMemoryPropertyFlags.Protected;
        public const VkMemoryPropertyFlags VK_MEMORY_PROPERTY_DEVICE_COHERENT_BIT_AMD = VkMemoryPropertyFlags.DeviceCoherentAMD;
        public const VkMemoryPropertyFlags VK_MEMORY_PROPERTY_DEVICE_UNCACHED_BIT_AMD = VkMemoryPropertyFlags.DeviceUncachedAMD;
        public const VkMemoryPropertyFlags VK_MEMORY_PROPERTY_RDMA_CAPABLE_BIT_NV = VkMemoryPropertyFlags.RdmaCapableNV;
    }

    [Flags]
    public enum VkMemoryHeapFlags : int
    {
        None = 0,
        ///<summary>If set, heap represents device memory</summary>
        DeviceLocal = 1,
        MultiInstance = 2,
        SeuSafe = 4,
    }
    public static partial class RawConstants
    {
        ///<summary>If set, heap represents device memory</summary>
        public const VkMemoryHeapFlags VK_MEMORY_HEAP_DEVICE_LOCAL_BIT = VkMemoryHeapFlags.DeviceLocal;
        public const VkMemoryHeapFlags VK_MEMORY_HEAP_MULTI_INSTANCE_BIT = VkMemoryHeapFlags.MultiInstance;
        public const VkMemoryHeapFlags VK_MEMORY_HEAP_SEU_SAFE_BIT = VkMemoryHeapFlags.SeuSafe;
    }

    [Flags]
    public enum VkAccessFlags : int
    {
        ///<summary>Controls coherency of indirect command reads</summary>
        IndirectCommandRead = 1,
        ///<summary>Controls coherency of index reads</summary>
        IndexRead = 2,
        ///<summary>Controls coherency of vertex attribute reads</summary>
        VertexAttributeRead = 4,
        ///<summary>Controls coherency of uniform buffer reads</summary>
        UniformRead = 8,
        ///<summary>Controls coherency of input attachment reads</summary>
        InputAttachmentRead = 16,
        ///<summary>Controls coherency of shader reads</summary>
        ShaderRead = 32,
        ///<summary>Controls coherency of shader writes</summary>
        ShaderWrite = 64,
        ///<summary>Controls coherency of color attachment reads</summary>
        ColorAttachmentRead = 128,
        ///<summary>Controls coherency of color attachment writes</summary>
        ColorAttachmentWrite = 256,
        ///<summary>Controls coherency of depth/stencil attachment reads</summary>
        DepthStencilAttachmentRead = 512,
        ///<summary>Controls coherency of depth/stencil attachment writes</summary>
        DepthStencilAttachmentWrite = 1024,
        ///<summary>Controls coherency of transfer reads</summary>
        TransferRead = 2048,
        ///<summary>Controls coherency of transfer writes</summary>
        TransferWrite = 4096,
        ///<summary>Controls coherency of host reads</summary>
        HostRead = 8192,
        ///<summary>Controls coherency of host writes</summary>
        HostWrite = 16384,
        ///<summary>Controls coherency of memory reads</summary>
        MemoryRead = 32768,
        ///<summary>Controls coherency of memory writes</summary>
        MemoryWrite = 65536,
        None = 0,
        TransformFeedbackWriteEXT = 33554432,
        TransformFeedbackCounterReadEXT = 67108864,
        TransformFeedbackCounterWriteEXT = 134217728,
        ConditionalRenderingReadEXT = 1048576,
        ColorAttachmentReadNoncoherentEXT = 524288,
        AccelerationStructureReadKHR = 2097152,
        AccelerationStructureWriteKHR = 4194304,
        FragmentDensityMapReadEXT = 16777216,
        FragmentShadingRateAttachmentReadKHR = 8388608,
        CommandPreprocessReadNV = 131072,
        CommandPreprocessWriteNV = 262144,
    }
    public static partial class RawConstants
    {
        ///<summary>Controls coherency of indirect command reads</summary>
        public const VkAccessFlags VK_ACCESS_INDIRECT_COMMAND_READ_BIT = VkAccessFlags.IndirectCommandRead;
        ///<summary>Controls coherency of index reads</summary>
        public const VkAccessFlags VK_ACCESS_INDEX_READ_BIT = VkAccessFlags.IndexRead;
        ///<summary>Controls coherency of vertex attribute reads</summary>
        public const VkAccessFlags VK_ACCESS_VERTEX_ATTRIBUTE_READ_BIT = VkAccessFlags.VertexAttributeRead;
        ///<summary>Controls coherency of uniform buffer reads</summary>
        public const VkAccessFlags VK_ACCESS_UNIFORM_READ_BIT = VkAccessFlags.UniformRead;
        ///<summary>Controls coherency of input attachment reads</summary>
        public const VkAccessFlags VK_ACCESS_INPUT_ATTACHMENT_READ_BIT = VkAccessFlags.InputAttachmentRead;
        ///<summary>Controls coherency of shader reads</summary>
        public const VkAccessFlags VK_ACCESS_SHADER_READ_BIT = VkAccessFlags.ShaderRead;
        ///<summary>Controls coherency of shader writes</summary>
        public const VkAccessFlags VK_ACCESS_SHADER_WRITE_BIT = VkAccessFlags.ShaderWrite;
        ///<summary>Controls coherency of color attachment reads</summary>
        public const VkAccessFlags VK_ACCESS_COLOR_ATTACHMENT_READ_BIT = VkAccessFlags.ColorAttachmentRead;
        ///<summary>Controls coherency of color attachment writes</summary>
        public const VkAccessFlags VK_ACCESS_COLOR_ATTACHMENT_WRITE_BIT = VkAccessFlags.ColorAttachmentWrite;
        ///<summary>Controls coherency of depth/stencil attachment reads</summary>
        public const VkAccessFlags VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_READ_BIT = VkAccessFlags.DepthStencilAttachmentRead;
        ///<summary>Controls coherency of depth/stencil attachment writes</summary>
        public const VkAccessFlags VK_ACCESS_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT = VkAccessFlags.DepthStencilAttachmentWrite;
        ///<summary>Controls coherency of transfer reads</summary>
        public const VkAccessFlags VK_ACCESS_TRANSFER_READ_BIT = VkAccessFlags.TransferRead;
        ///<summary>Controls coherency of transfer writes</summary>
        public const VkAccessFlags VK_ACCESS_TRANSFER_WRITE_BIT = VkAccessFlags.TransferWrite;
        ///<summary>Controls coherency of host reads</summary>
        public const VkAccessFlags VK_ACCESS_HOST_READ_BIT = VkAccessFlags.HostRead;
        ///<summary>Controls coherency of host writes</summary>
        public const VkAccessFlags VK_ACCESS_HOST_WRITE_BIT = VkAccessFlags.HostWrite;
        ///<summary>Controls coherency of memory reads</summary>
        public const VkAccessFlags VK_ACCESS_MEMORY_READ_BIT = VkAccessFlags.MemoryRead;
        ///<summary>Controls coherency of memory writes</summary>
        public const VkAccessFlags VK_ACCESS_MEMORY_WRITE_BIT = VkAccessFlags.MemoryWrite;
        public const VkAccessFlags VK_ACCESS_NONE = VkAccessFlags.None;
        public const VkAccessFlags VK_ACCESS_TRANSFORM_FEEDBACK_WRITE_BIT_EXT = VkAccessFlags.TransformFeedbackWriteEXT;
        public const VkAccessFlags VK_ACCESS_TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT = VkAccessFlags.TransformFeedbackCounterReadEXT;
        public const VkAccessFlags VK_ACCESS_TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT = VkAccessFlags.TransformFeedbackCounterWriteEXT;
        public const VkAccessFlags VK_ACCESS_CONDITIONAL_RENDERING_READ_BIT_EXT = VkAccessFlags.ConditionalRenderingReadEXT;
        public const VkAccessFlags VK_ACCESS_COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT = VkAccessFlags.ColorAttachmentReadNoncoherentEXT;
        public const VkAccessFlags VK_ACCESS_ACCELERATION_STRUCTURE_READ_BIT_KHR = VkAccessFlags.AccelerationStructureReadKHR;
        public const VkAccessFlags VK_ACCESS_ACCELERATION_STRUCTURE_WRITE_BIT_KHR = VkAccessFlags.AccelerationStructureWriteKHR;
        public const VkAccessFlags VK_ACCESS_FRAGMENT_DENSITY_MAP_READ_BIT_EXT = VkAccessFlags.FragmentDensityMapReadEXT;
        public const VkAccessFlags VK_ACCESS_FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR = VkAccessFlags.FragmentShadingRateAttachmentReadKHR;
        public const VkAccessFlags VK_ACCESS_COMMAND_PREPROCESS_READ_BIT_NV = VkAccessFlags.CommandPreprocessReadNV;
        public const VkAccessFlags VK_ACCESS_COMMAND_PREPROCESS_WRITE_BIT_NV = VkAccessFlags.CommandPreprocessWriteNV;
    }

    [Flags]
    public enum VkBufferUsageFlags : int
    {
        None = 0,
        ///<summary>Can be used as a source of transfer operations</summary>
        TransferSrc = 1,
        ///<summary>Can be used as a destination of transfer operations</summary>
        TransferDst = 2,
        ///<summary>Can be used as TBO</summary>
        UniformTexelBuffer = 4,
        ///<summary>Can be used as IBO</summary>
        StorageTexelBuffer = 8,
        ///<summary>Can be used as UBO</summary>
        UniformBuffer = 16,
        ///<summary>Can be used as SSBO</summary>
        StorageBuffer = 32,
        ///<summary>Can be used as source of fixed-function index fetch (index buffer)</summary>
        IndexBuffer = 64,
        ///<summary>Can be used as source of fixed-function vertex fetch (VBO)</summary>
        VertexBuffer = 128,
        ///<summary>Can be the source of indirect parameters (e.g. indirect buffer, parameter buffer)</summary>
        IndirectBuffer = 256,
        ShaderDeviceAddress = 131072,
        VideoDecodeSrcKHR = 8192,
        VideoDecodeDstKHR = 16384,
        TransformFeedbackBufferEXT = 2048,
        TransformFeedbackCounterBufferEXT = 4096,
        ConditionalRenderingEXT = 512,
        ExecutionGraphScratchAmdx = 33554432,
        AccelerationStructureBuildInputReadOnlyKHR = 524288,
        AccelerationStructureStorageKHR = 1048576,
        ShaderBindingTableKHR = 1024,
        Reserved18Qcom = 262144,
        VideoEncodeDstKHR = 32768,
        VideoEncodeSrcKHR = 65536,
        Reserved27Qcom = 134217728,
        SamplerDescriptorBufferEXT = 2097152,
        ResourceDescriptorBufferEXT = 4194304,
        PushDescriptorsDescriptorBufferEXT = 67108864,
        MicromapBuildInputReadOnlyEXT = 8388608,
        MicromapStorageEXT = 16777216,
    }
    public static partial class RawConstants
    {
        ///<summary>Can be used as a source of transfer operations</summary>
        public const VkBufferUsageFlags VK_BUFFER_USAGE_TRANSFER_SRC_BIT = VkBufferUsageFlags.TransferSrc;
        ///<summary>Can be used as a destination of transfer operations</summary>
        public const VkBufferUsageFlags VK_BUFFER_USAGE_TRANSFER_DST_BIT = VkBufferUsageFlags.TransferDst;
        ///<summary>Can be used as TBO</summary>
        public const VkBufferUsageFlags VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT = VkBufferUsageFlags.UniformTexelBuffer;
        ///<summary>Can be used as IBO</summary>
        public const VkBufferUsageFlags VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT = VkBufferUsageFlags.StorageTexelBuffer;
        ///<summary>Can be used as UBO</summary>
        public const VkBufferUsageFlags VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT = VkBufferUsageFlags.UniformBuffer;
        ///<summary>Can be used as SSBO</summary>
        public const VkBufferUsageFlags VK_BUFFER_USAGE_STORAGE_BUFFER_BIT = VkBufferUsageFlags.StorageBuffer;
        ///<summary>Can be used as source of fixed-function index fetch (index buffer)</summary>
        public const VkBufferUsageFlags VK_BUFFER_USAGE_INDEX_BUFFER_BIT = VkBufferUsageFlags.IndexBuffer;
        ///<summary>Can be used as source of fixed-function vertex fetch (VBO)</summary>
        public const VkBufferUsageFlags VK_BUFFER_USAGE_VERTEX_BUFFER_BIT = VkBufferUsageFlags.VertexBuffer;
        ///<summary>Can be the source of indirect parameters (e.g. indirect buffer, parameter buffer)</summary>
        public const VkBufferUsageFlags VK_BUFFER_USAGE_INDIRECT_BUFFER_BIT = VkBufferUsageFlags.IndirectBuffer;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT = VkBufferUsageFlags.ShaderDeviceAddress;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_VIDEO_DECODE_SRC_BIT_KHR = VkBufferUsageFlags.VideoDecodeSrcKHR;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_VIDEO_DECODE_DST_BIT_KHR = VkBufferUsageFlags.VideoDecodeDstKHR;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_TRANSFORM_FEEDBACK_BUFFER_BIT_EXT = VkBufferUsageFlags.TransformFeedbackBufferEXT;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_TRANSFORM_FEEDBACK_COUNTER_BUFFER_BIT_EXT = VkBufferUsageFlags.TransformFeedbackCounterBufferEXT;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_CONDITIONAL_RENDERING_BIT_EXT = VkBufferUsageFlags.ConditionalRenderingEXT;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_EXECUTION_GRAPH_SCRATCH_BIT_AMDX = VkBufferUsageFlags.ExecutionGraphScratchAmdx;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_ACCELERATION_STRUCTURE_BUILD_INPUT_READ_ONLY_BIT_KHR = VkBufferUsageFlags.AccelerationStructureBuildInputReadOnlyKHR;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_ACCELERATION_STRUCTURE_STORAGE_BIT_KHR = VkBufferUsageFlags.AccelerationStructureStorageKHR;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_SHADER_BINDING_TABLE_BIT_KHR = VkBufferUsageFlags.ShaderBindingTableKHR;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_RESERVED_18_BIT_QCOM = VkBufferUsageFlags.Reserved18Qcom;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_VIDEO_ENCODE_DST_BIT_KHR = VkBufferUsageFlags.VideoEncodeDstKHR;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_VIDEO_ENCODE_SRC_BIT_KHR = VkBufferUsageFlags.VideoEncodeSrcKHR;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_RESERVED_27_BIT_QCOM = VkBufferUsageFlags.Reserved27Qcom;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_SAMPLER_DESCRIPTOR_BUFFER_BIT_EXT = VkBufferUsageFlags.SamplerDescriptorBufferEXT;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_RESOURCE_DESCRIPTOR_BUFFER_BIT_EXT = VkBufferUsageFlags.ResourceDescriptorBufferEXT;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_PUSH_DESCRIPTORS_DESCRIPTOR_BUFFER_BIT_EXT = VkBufferUsageFlags.PushDescriptorsDescriptorBufferEXT;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_MICROMAP_BUILD_INPUT_READ_ONLY_BIT_EXT = VkBufferUsageFlags.MicromapBuildInputReadOnlyEXT;
        public const VkBufferUsageFlags VK_BUFFER_USAGE_MICROMAP_STORAGE_BIT_EXT = VkBufferUsageFlags.MicromapStorageEXT;
    }

    [Flags]
    public enum VkBufferUsageFlags2KHR : long
    {
        None = 0,
        TransferSrcKHR = 1,
        TransferDstKHR = 2,
        UniformTexelBufferKHR = 4,
        StorageTexelBufferKHR = 8,
        UniformBufferKHR = 16,
        StorageBufferKHR = 32,
        IndexBufferKHR = 64,
        VertexBufferKHR = 128,
        IndirectBufferKHR = 256,
        ExecutionGraphScratchAmdx = 33554432,
        Reserved18Qcom = 262144,
        ConditionalRenderingEXT = 512,
        ShaderBindingTableKHR = 1024,
        TransformFeedbackBufferEXT = 2048,
        TransformFeedbackCounterBufferEXT = 4096,
        VideoDecodeSrcKHR = 8192,
        VideoDecodeDstKHR = 16384,
        VideoEncodeDstKHR = 32768,
        VideoEncodeSrcKHR = 65536,
        ShaderDeviceAddressKHR = 131072,
        AccelerationStructureBuildInputReadOnlyKHR = 524288,
        AccelerationStructureStorageKHR = 1048576,
        SamplerDescriptorBufferEXT = 2097152,
        ResourceDescriptorBufferEXT = 4194304,
        PushDescriptorsDescriptorBufferEXT = 67108864,
        MicromapBuildInputReadOnlyEXT = 8388608,
        MicromapStorageEXT = 16777216,
    }
    public static partial class RawConstants
    {
        public const VkBufferUsageFlags2KHR VK_BUFFER_USAGE_2_TRANSFER_SRC_BIT_KHR = VkBufferUsageFlags2KHR.TransferSrcKHR;
        public const VkBufferUsageFlags2KHR VK_BUFFER_USAGE_2_TRANSFER_DST_BIT_KHR = VkBufferUsageFlags2KHR.TransferDstKHR;
        public const VkBufferUsageFlags2KHR VK_BUFFER_USAGE_2_UNIFORM_TEXEL_BUFFER_BIT_KHR = VkBufferUsageFlags2KHR.UniformTexelBufferKHR;
        public const VkBufferUsageFlags2KHR VK_BUFFER_USAGE_2_STORAGE_TEXEL_BUFFER_BIT_KHR = VkBufferUsageFlags2KHR.StorageTexelBufferKHR;
        public const VkBufferUsageFlags2KHR VK_BUFFER_USAGE_2_UNIFORM_BUFFER_BIT_KHR = VkBufferUsageFlags2KHR.UniformBufferKHR;
        public const VkBufferUsageFlags2KHR VK_BUFFER_USAGE_2_STORAGE_BUFFER_BIT_KHR = VkBufferUsageFlags2KHR.StorageBufferKHR;
        public const VkBufferUsageFlags2KHR VK_BUFFER_USAGE_2_INDEX_BUFFER_BIT_KHR = VkBufferUsageFlags2KHR.IndexBufferKHR;
        public const VkBufferUsageFlags2KHR VK_BUFFER_USAGE_2_VERTEX_BUFFER_BIT_KHR = VkBufferUsageFlags2KHR.VertexBufferKHR;
        public const VkBufferUsageFlags2KHR VK_BUFFER_USAGE_2_INDIRECT_BUFFER_BIT_KHR = VkBufferUsageFlags2KHR.IndirectBufferKHR;
        public const VkBufferUsageFlags2KHR VK_BUFFER_USAGE_2_EXECUTION_GRAPH_SCRATCH_BIT_AMDX = VkBufferUsageFlags2KHR.ExecutionGraphScratchAmdx;
        public const VkBufferUsageFlags2KHR VK_BUFFER_USAGE_2_RESERVED_18_BIT_QCOM = VkBufferUsageFlags2KHR.Reserved18Qcom;
        public const VkBufferUsageFlags2KHR VK_BUFFER_USAGE_2_CONDITIONAL_RENDERING_BIT_EXT = VkBufferUsageFlags2KHR.ConditionalRenderingEXT;
        public const VkBufferUsageFlags2KHR VK_BUFFER_USAGE_2_SHADER_BINDING_TABLE_BIT_KHR = VkBufferUsageFlags2KHR.ShaderBindingTableKHR;
        public const VkBufferUsageFlags2KHR VK_BUFFER_USAGE_2_TRANSFORM_FEEDBACK_BUFFER_BIT_EXT = VkBufferUsageFlags2KHR.TransformFeedbackBufferEXT;
        public const VkBufferUsageFlags2KHR VK_BUFFER_USAGE_2_TRANSFORM_FEEDBACK_COUNTER_BUFFER_BIT_EXT = VkBufferUsageFlags2KHR.TransformFeedbackCounterBufferEXT;
        public const VkBufferUsageFlags2KHR VK_BUFFER_USAGE_2_VIDEO_DECODE_SRC_BIT_KHR = VkBufferUsageFlags2KHR.VideoDecodeSrcKHR;
        public const VkBufferUsageFlags2KHR VK_BUFFER_USAGE_2_VIDEO_DECODE_DST_BIT_KHR = VkBufferUsageFlags2KHR.VideoDecodeDstKHR;
        public const VkBufferUsageFlags2KHR VK_BUFFER_USAGE_2_VIDEO_ENCODE_DST_BIT_KHR = VkBufferUsageFlags2KHR.VideoEncodeDstKHR;
        public const VkBufferUsageFlags2KHR VK_BUFFER_USAGE_2_VIDEO_ENCODE_SRC_BIT_KHR = VkBufferUsageFlags2KHR.VideoEncodeSrcKHR;
        public const VkBufferUsageFlags2KHR VK_BUFFER_USAGE_2_SHADER_DEVICE_ADDRESS_BIT_KHR = VkBufferUsageFlags2KHR.ShaderDeviceAddressKHR;
        public const VkBufferUsageFlags2KHR VK_BUFFER_USAGE_2_ACCELERATION_STRUCTURE_BUILD_INPUT_READ_ONLY_BIT_KHR = VkBufferUsageFlags2KHR.AccelerationStructureBuildInputReadOnlyKHR;
        public const VkBufferUsageFlags2KHR VK_BUFFER_USAGE_2_ACCELERATION_STRUCTURE_STORAGE_BIT_KHR = VkBufferUsageFlags2KHR.AccelerationStructureStorageKHR;
        public const VkBufferUsageFlags2KHR VK_BUFFER_USAGE_2_SAMPLER_DESCRIPTOR_BUFFER_BIT_EXT = VkBufferUsageFlags2KHR.SamplerDescriptorBufferEXT;
        public const VkBufferUsageFlags2KHR VK_BUFFER_USAGE_2_RESOURCE_DESCRIPTOR_BUFFER_BIT_EXT = VkBufferUsageFlags2KHR.ResourceDescriptorBufferEXT;
        public const VkBufferUsageFlags2KHR VK_BUFFER_USAGE_2_PUSH_DESCRIPTORS_DESCRIPTOR_BUFFER_BIT_EXT = VkBufferUsageFlags2KHR.PushDescriptorsDescriptorBufferEXT;
        public const VkBufferUsageFlags2KHR VK_BUFFER_USAGE_2_MICROMAP_BUILD_INPUT_READ_ONLY_BIT_EXT = VkBufferUsageFlags2KHR.MicromapBuildInputReadOnlyEXT;
        public const VkBufferUsageFlags2KHR VK_BUFFER_USAGE_2_MICROMAP_STORAGE_BIT_EXT = VkBufferUsageFlags2KHR.MicromapStorageEXT;
    }

    [Flags]
    public enum VkBufferCreateFlags : int
    {
        None = 0,
        ///<summary>Buffer should support sparse backing</summary>
        SparseBinding = 1,
        ///<summary>Buffer should support sparse backing with partial residency</summary>
        SparseResidency = 2,
        ///<summary>Buffer should support constant data access to physical memory ranges mapped into multiple locations of sparse buffers</summary>
        SparseAliased = 4,
        Protected = 8,
        DeviceAddressCaptureReplay = 16,
        DescriptorBufferCaptureReplayEXT = 32,
        Reserved6KHR = 64,
    }
    public static partial class RawConstants
    {
        ///<summary>Buffer should support sparse backing</summary>
        public const VkBufferCreateFlags VK_BUFFER_CREATE_SPARSE_BINDING_BIT = VkBufferCreateFlags.SparseBinding;
        ///<summary>Buffer should support sparse backing with partial residency</summary>
        public const VkBufferCreateFlags VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT = VkBufferCreateFlags.SparseResidency;
        ///<summary>Buffer should support constant data access to physical memory ranges mapped into multiple locations of sparse buffers</summary>
        public const VkBufferCreateFlags VK_BUFFER_CREATE_SPARSE_ALIASED_BIT = VkBufferCreateFlags.SparseAliased;
        public const VkBufferCreateFlags VK_BUFFER_CREATE_PROTECTED_BIT = VkBufferCreateFlags.Protected;
        public const VkBufferCreateFlags VK_BUFFER_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT = VkBufferCreateFlags.DeviceAddressCaptureReplay;
        public const VkBufferCreateFlags VK_BUFFER_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT = VkBufferCreateFlags.DescriptorBufferCaptureReplayEXT;
        public const VkBufferCreateFlags VK_BUFFER_CREATE_RESERVED_6_BIT_KHR = VkBufferCreateFlags.Reserved6KHR;
    }

    [Flags]
    public enum VkShaderStageFlags : int
    {
        None = 0,
        Vertex = 1,
        TessellationControl = 2,
        TessellationEvaluation = 4,
        Geometry = 8,
        Fragment = 16,
        Compute = 32,
        AllGraphics = 31,
        All = 2147483647,
        RaygenKHR = 256,
        AnyHitKHR = 512,
        ClosestHitKHR = 1024,
        MissKHR = 2048,
        IntersectionKHR = 4096,
        CallableKHR = 8192,
        TaskEXT = 64,
        MeshEXT = 128,
        SubpassShadingHuawei = 16384,
        ClusterCullingHuawei = 524288,
    }
    public static partial class RawConstants
    {
        public const VkShaderStageFlags VK_SHADER_STAGE_VERTEX_BIT = VkShaderStageFlags.Vertex;
        public const VkShaderStageFlags VK_SHADER_STAGE_TESSELLATION_CONTROL_BIT = VkShaderStageFlags.TessellationControl;
        public const VkShaderStageFlags VK_SHADER_STAGE_TESSELLATION_EVALUATION_BIT = VkShaderStageFlags.TessellationEvaluation;
        public const VkShaderStageFlags VK_SHADER_STAGE_GEOMETRY_BIT = VkShaderStageFlags.Geometry;
        public const VkShaderStageFlags VK_SHADER_STAGE_FRAGMENT_BIT = VkShaderStageFlags.Fragment;
        public const VkShaderStageFlags VK_SHADER_STAGE_COMPUTE_BIT = VkShaderStageFlags.Compute;
        public const VkShaderStageFlags VK_SHADER_STAGE_ALL_GRAPHICS = VkShaderStageFlags.AllGraphics;
        public const VkShaderStageFlags VK_SHADER_STAGE_ALL = VkShaderStageFlags.All;
        public const VkShaderStageFlags VK_SHADER_STAGE_RAYGEN_BIT_KHR = VkShaderStageFlags.RaygenKHR;
        public const VkShaderStageFlags VK_SHADER_STAGE_ANY_HIT_BIT_KHR = VkShaderStageFlags.AnyHitKHR;
        public const VkShaderStageFlags VK_SHADER_STAGE_CLOSEST_HIT_BIT_KHR = VkShaderStageFlags.ClosestHitKHR;
        public const VkShaderStageFlags VK_SHADER_STAGE_MISS_BIT_KHR = VkShaderStageFlags.MissKHR;
        public const VkShaderStageFlags VK_SHADER_STAGE_INTERSECTION_BIT_KHR = VkShaderStageFlags.IntersectionKHR;
        public const VkShaderStageFlags VK_SHADER_STAGE_CALLABLE_BIT_KHR = VkShaderStageFlags.CallableKHR;
        public const VkShaderStageFlags VK_SHADER_STAGE_TASK_BIT_EXT = VkShaderStageFlags.TaskEXT;
        public const VkShaderStageFlags VK_SHADER_STAGE_MESH_BIT_EXT = VkShaderStageFlags.MeshEXT;
        public const VkShaderStageFlags VK_SHADER_STAGE_SUBPASS_SHADING_BIT_HUAWEI = VkShaderStageFlags.SubpassShadingHuawei;
        public const VkShaderStageFlags VK_SHADER_STAGE_CLUSTER_CULLING_BIT_HUAWEI = VkShaderStageFlags.ClusterCullingHuawei;
    }

    [Flags]
    public enum VkImageUsageFlags : int
    {
        None = 0,
        ///<summary>Can be used as a source of transfer operations</summary>
        TransferSrc = 1,
        ///<summary>Can be used as a destination of transfer operations</summary>
        TransferDst = 2,
        ///<summary>Can be sampled from (SAMPLED_IMAGE and COMBINED_IMAGE_SAMPLER descriptor types)</summary>
        Sampled = 4,
        ///<summary>Can be used as storage image (STORAGE_IMAGE descriptor type)</summary>
        Storage = 8,
        ///<summary>Can be used as framebuffer color attachment</summary>
        ColorAttachment = 16,
        ///<summary>Can be used as framebuffer depth/stencil attachment</summary>
        DepthStencilAttachment = 32,
        ///<summary>Image data not needed outside of rendering</summary>
        TransientAttachment = 64,
        ///<summary>Can be used as framebuffer input attachment</summary>
        InputAttachment = 128,
        VideoDecodeDstKHR = 1024,
        VideoDecodeSrcKHR = 2048,
        VideoDecodeDpbKHR = 4096,
        Reserved16Qcom = 65536,
        Reserved17Qcom = 131072,
        FragmentDensityMapEXT = 512,
        FragmentShadingRateAttachmentKHR = 256,
        HostTransferEXT = 4194304,
        VideoEncodeDstKHR = 8192,
        VideoEncodeSrcKHR = 16384,
        VideoEncodeDpbKHR = 32768,
        AttachmentFeedbackLoopEXT = 524288,
        InvocationMaskHuawei = 262144,
        SampleWeightQcom = 1048576,
        SampleBlockMatchQcom = 2097152,
        Reserved24Coreavi = 16777216,
        Reserved23EXT = 8388608,
    }
    public static partial class RawConstants
    {
        ///<summary>Can be used as a source of transfer operations</summary>
        public const VkImageUsageFlags VK_IMAGE_USAGE_TRANSFER_SRC_BIT = VkImageUsageFlags.TransferSrc;
        ///<summary>Can be used as a destination of transfer operations</summary>
        public const VkImageUsageFlags VK_IMAGE_USAGE_TRANSFER_DST_BIT = VkImageUsageFlags.TransferDst;
        ///<summary>Can be sampled from (SAMPLED_IMAGE and COMBINED_IMAGE_SAMPLER descriptor types)</summary>
        public const VkImageUsageFlags VK_IMAGE_USAGE_SAMPLED_BIT = VkImageUsageFlags.Sampled;
        ///<summary>Can be used as storage image (STORAGE_IMAGE descriptor type)</summary>
        public const VkImageUsageFlags VK_IMAGE_USAGE_STORAGE_BIT = VkImageUsageFlags.Storage;
        ///<summary>Can be used as framebuffer color attachment</summary>
        public const VkImageUsageFlags VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT = VkImageUsageFlags.ColorAttachment;
        ///<summary>Can be used as framebuffer depth/stencil attachment</summary>
        public const VkImageUsageFlags VK_IMAGE_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT = VkImageUsageFlags.DepthStencilAttachment;
        ///<summary>Image data not needed outside of rendering</summary>
        public const VkImageUsageFlags VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT = VkImageUsageFlags.TransientAttachment;
        ///<summary>Can be used as framebuffer input attachment</summary>
        public const VkImageUsageFlags VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT = VkImageUsageFlags.InputAttachment;
        public const VkImageUsageFlags VK_IMAGE_USAGE_VIDEO_DECODE_DST_BIT_KHR = VkImageUsageFlags.VideoDecodeDstKHR;
        public const VkImageUsageFlags VK_IMAGE_USAGE_VIDEO_DECODE_SRC_BIT_KHR = VkImageUsageFlags.VideoDecodeSrcKHR;
        public const VkImageUsageFlags VK_IMAGE_USAGE_VIDEO_DECODE_DPB_BIT_KHR = VkImageUsageFlags.VideoDecodeDpbKHR;
        public const VkImageUsageFlags VK_IMAGE_USAGE_RESERVED_16_BIT_QCOM = VkImageUsageFlags.Reserved16Qcom;
        public const VkImageUsageFlags VK_IMAGE_USAGE_RESERVED_17_BIT_QCOM = VkImageUsageFlags.Reserved17Qcom;
        public const VkImageUsageFlags VK_IMAGE_USAGE_FRAGMENT_DENSITY_MAP_BIT_EXT = VkImageUsageFlags.FragmentDensityMapEXT;
        public const VkImageUsageFlags VK_IMAGE_USAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = VkImageUsageFlags.FragmentShadingRateAttachmentKHR;
        public const VkImageUsageFlags VK_IMAGE_USAGE_HOST_TRANSFER_BIT_EXT = VkImageUsageFlags.HostTransferEXT;
        public const VkImageUsageFlags VK_IMAGE_USAGE_VIDEO_ENCODE_DST_BIT_KHR = VkImageUsageFlags.VideoEncodeDstKHR;
        public const VkImageUsageFlags VK_IMAGE_USAGE_VIDEO_ENCODE_SRC_BIT_KHR = VkImageUsageFlags.VideoEncodeSrcKHR;
        public const VkImageUsageFlags VK_IMAGE_USAGE_VIDEO_ENCODE_DPB_BIT_KHR = VkImageUsageFlags.VideoEncodeDpbKHR;
        public const VkImageUsageFlags VK_IMAGE_USAGE_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT = VkImageUsageFlags.AttachmentFeedbackLoopEXT;
        public const VkImageUsageFlags VK_IMAGE_USAGE_INVOCATION_MASK_BIT_HUAWEI = VkImageUsageFlags.InvocationMaskHuawei;
        public const VkImageUsageFlags VK_IMAGE_USAGE_SAMPLE_WEIGHT_BIT_QCOM = VkImageUsageFlags.SampleWeightQcom;
        public const VkImageUsageFlags VK_IMAGE_USAGE_SAMPLE_BLOCK_MATCH_BIT_QCOM = VkImageUsageFlags.SampleBlockMatchQcom;
        public const VkImageUsageFlags VK_IMAGE_USAGE_RESERVED_24_BIT_COREAVI = VkImageUsageFlags.Reserved24Coreavi;
        public const VkImageUsageFlags VK_IMAGE_USAGE_RESERVED_23_BIT_EXT = VkImageUsageFlags.Reserved23EXT;
    }

    [Flags]
    public enum VkImageCreateFlags : int
    {
        None = 0,
        ///<summary>Image should support sparse backing</summary>
        SparseBinding = 1,
        ///<summary>Image should support sparse backing with partial residency</summary>
        SparseResidency = 2,
        ///<summary>Image should support constant data access to physical memory ranges mapped into multiple locations of sparse images</summary>
        SparseAliased = 4,
        ///<summary>Allows image views to have different format than the base image</summary>
        MutableFormat = 8,
        ///<summary>Allows creating image views with cube type from the created image</summary>
        CubeCompatible = 16,
        Alias = 1024,
        SplitInstanceBindRegions = 64,
        _2dArrayCompatible = 32,
        BlockTexelViewCompatible = 128,
        ExtendedUsage = 256,
        Protected = 2048,
        Disjoint = 512,
        CornerSampledNV = 8192,
        SampleLocationsCompatibleDepthEXT = 4096,
        SubsampledEXT = 16384,
        Reserved19EXT = 524288,
        DescriptorBufferCaptureReplayEXT = 65536,
        MultisampledRenderToSingleSampledEXT = 262144,
        _2dViewCompatibleEXT = 131072,
        FragmentDensityMapOffsetQcom = 32768,
        Reserved20KHR = 1048576,
    }
    public static partial class RawConstants
    {
        ///<summary>Image should support sparse backing</summary>
        public const VkImageCreateFlags VK_IMAGE_CREATE_SPARSE_BINDING_BIT = VkImageCreateFlags.SparseBinding;
        ///<summary>Image should support sparse backing with partial residency</summary>
        public const VkImageCreateFlags VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT = VkImageCreateFlags.SparseResidency;
        ///<summary>Image should support constant data access to physical memory ranges mapped into multiple locations of sparse images</summary>
        public const VkImageCreateFlags VK_IMAGE_CREATE_SPARSE_ALIASED_BIT = VkImageCreateFlags.SparseAliased;
        ///<summary>Allows image views to have different format than the base image</summary>
        public const VkImageCreateFlags VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT = VkImageCreateFlags.MutableFormat;
        ///<summary>Allows creating image views with cube type from the created image</summary>
        public const VkImageCreateFlags VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT = VkImageCreateFlags.CubeCompatible;
        public const VkImageCreateFlags VK_IMAGE_CREATE_ALIAS_BIT = VkImageCreateFlags.Alias;
        public const VkImageCreateFlags VK_IMAGE_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT = VkImageCreateFlags.SplitInstanceBindRegions;
        public const VkImageCreateFlags VK_IMAGE_CREATE_2D_ARRAY_COMPATIBLE_BIT = VkImageCreateFlags._2dArrayCompatible;
        public const VkImageCreateFlags VK_IMAGE_CREATE_BLOCK_TEXEL_VIEW_COMPATIBLE_BIT = VkImageCreateFlags.BlockTexelViewCompatible;
        public const VkImageCreateFlags VK_IMAGE_CREATE_EXTENDED_USAGE_BIT = VkImageCreateFlags.ExtendedUsage;
        public const VkImageCreateFlags VK_IMAGE_CREATE_PROTECTED_BIT = VkImageCreateFlags.Protected;
        public const VkImageCreateFlags VK_IMAGE_CREATE_DISJOINT_BIT = VkImageCreateFlags.Disjoint;
        public const VkImageCreateFlags VK_IMAGE_CREATE_CORNER_SAMPLED_BIT_NV = VkImageCreateFlags.CornerSampledNV;
        public const VkImageCreateFlags VK_IMAGE_CREATE_SAMPLE_LOCATIONS_COMPATIBLE_DEPTH_BIT_EXT = VkImageCreateFlags.SampleLocationsCompatibleDepthEXT;
        public const VkImageCreateFlags VK_IMAGE_CREATE_SUBSAMPLED_BIT_EXT = VkImageCreateFlags.SubsampledEXT;
        public const VkImageCreateFlags VK_IMAGE_CREATE_RESERVED_19_BIT_EXT = VkImageCreateFlags.Reserved19EXT;
        public const VkImageCreateFlags VK_IMAGE_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT = VkImageCreateFlags.DescriptorBufferCaptureReplayEXT;
        public const VkImageCreateFlags VK_IMAGE_CREATE_MULTISAMPLED_RENDER_TO_SINGLE_SAMPLED_BIT_EXT = VkImageCreateFlags.MultisampledRenderToSingleSampledEXT;
        public const VkImageCreateFlags VK_IMAGE_CREATE_2D_VIEW_COMPATIBLE_BIT_EXT = VkImageCreateFlags._2dViewCompatibleEXT;
        public const VkImageCreateFlags VK_IMAGE_CREATE_FRAGMENT_DENSITY_MAP_OFFSET_BIT_QCOM = VkImageCreateFlags.FragmentDensityMapOffsetQcom;
        public const VkImageCreateFlags VK_IMAGE_CREATE_RESERVED_20_BIT_KHR = VkImageCreateFlags.Reserved20KHR;
    }

    [Flags]
    public enum VkImageViewCreateFlags : int
    {
        None = 0,
        FragmentDensityMapDynamicEXT = 1,
        DescriptorBufferCaptureReplayEXT = 4,
        FragmentDensityMapDeferredEXT = 2,
    }
    public static partial class RawConstants
    {
        public const VkImageViewCreateFlags VK_IMAGE_VIEW_CREATE_FRAGMENT_DENSITY_MAP_DYNAMIC_BIT_EXT = VkImageViewCreateFlags.FragmentDensityMapDynamicEXT;
        public const VkImageViewCreateFlags VK_IMAGE_VIEW_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT = VkImageViewCreateFlags.DescriptorBufferCaptureReplayEXT;
        public const VkImageViewCreateFlags VK_IMAGE_VIEW_CREATE_FRAGMENT_DENSITY_MAP_DEFERRED_BIT_EXT = VkImageViewCreateFlags.FragmentDensityMapDeferredEXT;
    }

    [Flags]
    public enum VkSamplerCreateFlags : int
    {
        None = 0,
        SubsampledEXT = 1,
        SubsampledCoarseReconstructionEXT = 2,
        DescriptorBufferCaptureReplayEXT = 8,
        NonSeamlessCubeMapEXT = 4,
        ImageProcessingQcom = 16,
    }
    public static partial class RawConstants
    {
        public const VkSamplerCreateFlags VK_SAMPLER_CREATE_SUBSAMPLED_BIT_EXT = VkSamplerCreateFlags.SubsampledEXT;
        public const VkSamplerCreateFlags VK_SAMPLER_CREATE_SUBSAMPLED_COARSE_RECONSTRUCTION_BIT_EXT = VkSamplerCreateFlags.SubsampledCoarseReconstructionEXT;
        public const VkSamplerCreateFlags VK_SAMPLER_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT = VkSamplerCreateFlags.DescriptorBufferCaptureReplayEXT;
        public const VkSamplerCreateFlags VK_SAMPLER_CREATE_NON_SEAMLESS_CUBE_MAP_BIT_EXT = VkSamplerCreateFlags.NonSeamlessCubeMapEXT;
        public const VkSamplerCreateFlags VK_SAMPLER_CREATE_IMAGE_PROCESSING_BIT_QCOM = VkSamplerCreateFlags.ImageProcessingQcom;
    }

    [Flags]
    public enum VkPipelineCreateFlags : int
    {
        None = 0,
        DisableOptimization = 1,
        AllowDerivatives = 2,
        Derivative = 4,
        ViewIndexFromDeviceIndex = 8,
        DispatchBase = 16,
        FailOnPipelineCompileRequired = 256,
        EarlyReturnOnFailure = 512,
        RenderingFragmentShadingRateAttachmentKHR = 2097152,
        RenderingFragmentDensityMapAttachmentEXT = 4194304,
        RayTracingNoNullAnyHitShadersKHR = 16384,
        RayTracingNoNullClosestHitShadersKHR = 32768,
        RayTracingNoNullMissShadersKHR = 65536,
        RayTracingNoNullIntersectionShadersKHR = 131072,
        RayTracingSkipTrianglesKHR = 4096,
        RayTracingSkipAabbsKHR = 8192,
        RayTracingShaderGroupHandleCaptureReplayKHR = 524288,
        DeferCompileNV = 32,
        CaptureStatisticsKHR = 64,
        CaptureInternalRepresentationsKHR = 128,
        IndirectBindableNV = 262144,
        LibraryKHR = 2048,
        DescriptorBufferEXT = 536870912,
        RetainLinkTimeOptimizationInfoEXT = 8388608,
        LinkTimeOptimizationEXT = 1024,
        RayTracingAllowMotionNV = 1048576,
        ColorAttachmentFeedbackLoopEXT = 33554432,
        DepthStencilAttachmentFeedbackLoopEXT = 67108864,
        RayTracingOpacityMicromapEXT = 16777216,
        RayTracingDisplacementMicromapNV = 268435456,
        NoProtectedAccessEXT = 134217728,
        ProtectedAccessOnlyEXT = 1073741824,
    }
    public static partial class RawConstants
    {
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_DISABLE_OPTIMIZATION_BIT = VkPipelineCreateFlags.DisableOptimization;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT = VkPipelineCreateFlags.AllowDerivatives;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_DERIVATIVE_BIT = VkPipelineCreateFlags.Derivative;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_VIEW_INDEX_FROM_DEVICE_INDEX_BIT = VkPipelineCreateFlags.ViewIndexFromDeviceIndex;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_DISPATCH_BASE_BIT = VkPipelineCreateFlags.DispatchBase;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT = VkPipelineCreateFlags.FailOnPipelineCompileRequired;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_EARLY_RETURN_ON_FAILURE_BIT = VkPipelineCreateFlags.EarlyReturnOnFailure;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = VkPipelineCreateFlags.RenderingFragmentShadingRateAttachmentKHR;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT = VkPipelineCreateFlags.RenderingFragmentDensityMapAttachmentEXT;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_ANY_HIT_SHADERS_BIT_KHR = VkPipelineCreateFlags.RayTracingNoNullAnyHitShadersKHR;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_CLOSEST_HIT_SHADERS_BIT_KHR = VkPipelineCreateFlags.RayTracingNoNullClosestHitShadersKHR;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_MISS_SHADERS_BIT_KHR = VkPipelineCreateFlags.RayTracingNoNullMissShadersKHR;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_RAY_TRACING_NO_NULL_INTERSECTION_SHADERS_BIT_KHR = VkPipelineCreateFlags.RayTracingNoNullIntersectionShadersKHR;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_RAY_TRACING_SKIP_TRIANGLES_BIT_KHR = VkPipelineCreateFlags.RayTracingSkipTrianglesKHR;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_RAY_TRACING_SKIP_AABBS_BIT_KHR = VkPipelineCreateFlags.RayTracingSkipAabbsKHR;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_RAY_TRACING_SHADER_GROUP_HANDLE_CAPTURE_REPLAY_BIT_KHR = VkPipelineCreateFlags.RayTracingShaderGroupHandleCaptureReplayKHR;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_DEFER_COMPILE_BIT_NV = VkPipelineCreateFlags.DeferCompileNV;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_CAPTURE_STATISTICS_BIT_KHR = VkPipelineCreateFlags.CaptureStatisticsKHR;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_CAPTURE_INTERNAL_REPRESENTATIONS_BIT_KHR = VkPipelineCreateFlags.CaptureInternalRepresentationsKHR;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_INDIRECT_BINDABLE_BIT_NV = VkPipelineCreateFlags.IndirectBindableNV;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_LIBRARY_BIT_KHR = VkPipelineCreateFlags.LibraryKHR;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_DESCRIPTOR_BUFFER_BIT_EXT = VkPipelineCreateFlags.DescriptorBufferEXT;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_RETAIN_LINK_TIME_OPTIMIZATION_INFO_BIT_EXT = VkPipelineCreateFlags.RetainLinkTimeOptimizationInfoEXT;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_LINK_TIME_OPTIMIZATION_BIT_EXT = VkPipelineCreateFlags.LinkTimeOptimizationEXT;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_RAY_TRACING_ALLOW_MOTION_BIT_NV = VkPipelineCreateFlags.RayTracingAllowMotionNV;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_COLOR_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT = VkPipelineCreateFlags.ColorAttachmentFeedbackLoopEXT;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_DEPTH_STENCIL_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT = VkPipelineCreateFlags.DepthStencilAttachmentFeedbackLoopEXT;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_RAY_TRACING_OPACITY_MICROMAP_BIT_EXT = VkPipelineCreateFlags.RayTracingOpacityMicromapEXT;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_RAY_TRACING_DISPLACEMENT_MICROMAP_BIT_NV = VkPipelineCreateFlags.RayTracingDisplacementMicromapNV;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_NO_PROTECTED_ACCESS_BIT_EXT = VkPipelineCreateFlags.NoProtectedAccessEXT;
        public const VkPipelineCreateFlags VK_PIPELINE_CREATE_PROTECTED_ACCESS_ONLY_BIT_EXT = VkPipelineCreateFlags.ProtectedAccessOnlyEXT;
    }

    [Flags]
    public enum VkPipelineCreateFlags2KHR : long
    {
        None = 0,
        DisableOptimizationKHR = 1,
        AllowDerivativesKHR = 2,
        DerivativeKHR = 4,
        ViewIndexFromDeviceIndexKHR = 8,
        DispatchBaseKHR = 16,
        DeferCompileNV = 32,
        CaptureStatisticsKHR = 64,
        CaptureInternalRepresentationsKHR = 128,
        FailOnPipelineCompileRequiredKHR = 256,
        EarlyReturnOnFailureKHR = 512,
        LinkTimeOptimizationEXT = 1024,
        RetainLinkTimeOptimizationInfoEXT = 8388608,
        LibraryKHR = 2048,
        RayTracingSkipTrianglesKHR = 4096,
        RayTracingSkipAabbsKHR = 8192,
        RayTracingNoNullAnyHitShadersKHR = 16384,
        RayTracingNoNullClosestHitShadersKHR = 32768,
        RayTracingNoNullMissShadersKHR = 65536,
        RayTracingNoNullIntersectionShadersKHR = 131072,
        RayTracingShaderGroupHandleCaptureReplayKHR = 524288,
        IndirectBindableNV = 262144,
        RayTracingAllowMotionNV = 1048576,
        RenderingFragmentShadingRateAttachmentKHR = 2097152,
        RenderingFragmentDensityMapAttachmentEXT = 4194304,
        RayTracingOpacityMicromapEXT = 16777216,
        ColorAttachmentFeedbackLoopEXT = 33554432,
        DepthStencilAttachmentFeedbackLoopEXT = 67108864,
        NoProtectedAccessEXT = 134217728,
        ProtectedAccessOnlyEXT = 1073741824,
        RayTracingDisplacementMicromapNV = 268435456,
        DescriptorBufferEXT = 536870912,
        Reserved31KHR = -2147483648,
    }
    public static partial class RawConstants
    {
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_DISABLE_OPTIMIZATION_BIT_KHR = VkPipelineCreateFlags2KHR.DisableOptimizationKHR;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_ALLOW_DERIVATIVES_BIT_KHR = VkPipelineCreateFlags2KHR.AllowDerivativesKHR;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_DERIVATIVE_BIT_KHR = VkPipelineCreateFlags2KHR.DerivativeKHR;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_VIEW_INDEX_FROM_DEVICE_INDEX_BIT_KHR = VkPipelineCreateFlags2KHR.ViewIndexFromDeviceIndexKHR;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_DISPATCH_BASE_BIT_KHR = VkPipelineCreateFlags2KHR.DispatchBaseKHR;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_DEFER_COMPILE_BIT_NV = VkPipelineCreateFlags2KHR.DeferCompileNV;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_CAPTURE_STATISTICS_BIT_KHR = VkPipelineCreateFlags2KHR.CaptureStatisticsKHR;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_CAPTURE_INTERNAL_REPRESENTATIONS_BIT_KHR = VkPipelineCreateFlags2KHR.CaptureInternalRepresentationsKHR;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_FAIL_ON_PIPELINE_COMPILE_REQUIRED_BIT_KHR = VkPipelineCreateFlags2KHR.FailOnPipelineCompileRequiredKHR;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_EARLY_RETURN_ON_FAILURE_BIT_KHR = VkPipelineCreateFlags2KHR.EarlyReturnOnFailureKHR;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_LINK_TIME_OPTIMIZATION_BIT_EXT = VkPipelineCreateFlags2KHR.LinkTimeOptimizationEXT;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_RETAIN_LINK_TIME_OPTIMIZATION_INFO_BIT_EXT = VkPipelineCreateFlags2KHR.RetainLinkTimeOptimizationInfoEXT;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_LIBRARY_BIT_KHR = VkPipelineCreateFlags2KHR.LibraryKHR;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_RAY_TRACING_SKIP_TRIANGLES_BIT_KHR = VkPipelineCreateFlags2KHR.RayTracingSkipTrianglesKHR;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_RAY_TRACING_SKIP_AABBS_BIT_KHR = VkPipelineCreateFlags2KHR.RayTracingSkipAabbsKHR;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_ANY_HIT_SHADERS_BIT_KHR = VkPipelineCreateFlags2KHR.RayTracingNoNullAnyHitShadersKHR;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_CLOSEST_HIT_SHADERS_BIT_KHR = VkPipelineCreateFlags2KHR.RayTracingNoNullClosestHitShadersKHR;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_MISS_SHADERS_BIT_KHR = VkPipelineCreateFlags2KHR.RayTracingNoNullMissShadersKHR;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_RAY_TRACING_NO_NULL_INTERSECTION_SHADERS_BIT_KHR = VkPipelineCreateFlags2KHR.RayTracingNoNullIntersectionShadersKHR;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_RAY_TRACING_SHADER_GROUP_HANDLE_CAPTURE_REPLAY_BIT_KHR = VkPipelineCreateFlags2KHR.RayTracingShaderGroupHandleCaptureReplayKHR;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_INDIRECT_BINDABLE_BIT_NV = VkPipelineCreateFlags2KHR.IndirectBindableNV;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_RAY_TRACING_ALLOW_MOTION_BIT_NV = VkPipelineCreateFlags2KHR.RayTracingAllowMotionNV;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_RENDERING_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = VkPipelineCreateFlags2KHR.RenderingFragmentShadingRateAttachmentKHR;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_RENDERING_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT = VkPipelineCreateFlags2KHR.RenderingFragmentDensityMapAttachmentEXT;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_RAY_TRACING_OPACITY_MICROMAP_BIT_EXT = VkPipelineCreateFlags2KHR.RayTracingOpacityMicromapEXT;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_COLOR_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT = VkPipelineCreateFlags2KHR.ColorAttachmentFeedbackLoopEXT;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_DEPTH_STENCIL_ATTACHMENT_FEEDBACK_LOOP_BIT_EXT = VkPipelineCreateFlags2KHR.DepthStencilAttachmentFeedbackLoopEXT;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_NO_PROTECTED_ACCESS_BIT_EXT = VkPipelineCreateFlags2KHR.NoProtectedAccessEXT;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_PROTECTED_ACCESS_ONLY_BIT_EXT = VkPipelineCreateFlags2KHR.ProtectedAccessOnlyEXT;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_RAY_TRACING_DISPLACEMENT_MICROMAP_BIT_NV = VkPipelineCreateFlags2KHR.RayTracingDisplacementMicromapNV;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_DESCRIPTOR_BUFFER_BIT_EXT = VkPipelineCreateFlags2KHR.DescriptorBufferEXT;
        public const VkPipelineCreateFlags2KHR VK_PIPELINE_CREATE_2_RESERVED_31_BIT_KHR = VkPipelineCreateFlags2KHR.Reserved31KHR;
    }

    [Flags]
    public enum VkPipelineShaderStageCreateFlags : int
    {
        None = 0,
        AllowVaryingSubgroupSize = 1,
        RequireFullSubgroups = 2,
        Reserved3KHR = 8,
    }
    public static partial class RawConstants
    {
        public const VkPipelineShaderStageCreateFlags VK_PIPELINE_SHADER_STAGE_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BIT = VkPipelineShaderStageCreateFlags.AllowVaryingSubgroupSize;
        public const VkPipelineShaderStageCreateFlags VK_PIPELINE_SHADER_STAGE_CREATE_REQUIRE_FULL_SUBGROUPS_BIT = VkPipelineShaderStageCreateFlags.RequireFullSubgroups;
        public const VkPipelineShaderStageCreateFlags VK_PIPELINE_SHADER_STAGE_CREATE_RESERVED_3_BIT_KHR = VkPipelineShaderStageCreateFlags.Reserved3KHR;
    }

    [Flags]
    public enum VkColorComponentFlags : int
    {
        None = 0,
        R = 1,
        G = 2,
        B = 4,
        A = 8,
    }
    public static partial class RawConstants
    {
        public const VkColorComponentFlags VK_COLOR_COMPONENT_R_BIT = VkColorComponentFlags.R;
        public const VkColorComponentFlags VK_COLOR_COMPONENT_G_BIT = VkColorComponentFlags.G;
        public const VkColorComponentFlags VK_COLOR_COMPONENT_B_BIT = VkColorComponentFlags.B;
        public const VkColorComponentFlags VK_COLOR_COMPONENT_A_BIT = VkColorComponentFlags.A;
    }

    [Flags]
    public enum VkFenceCreateFlags : int
    {
        None = 0,
        Signaled = 1,
    }
    public static partial class RawConstants
    {
        public const VkFenceCreateFlags VK_FENCE_CREATE_SIGNALED_BIT = VkFenceCreateFlags.Signaled;
    }

    [Flags]
    public enum VkSemaphoreCreateFlagBits : int
    {
        None = 0,
    }
    public static partial class RawConstants
    {
    }

    [Flags]
    public enum VkFormatFeatureFlags : int
    {
        None = 0,
        ///<summary>Format can be used for sampled images (SAMPLED_IMAGE and COMBINED_IMAGE_SAMPLER descriptor types)</summary>
        SampledImage = 1,
        ///<summary>Format can be used for storage images (STORAGE_IMAGE descriptor type)</summary>
        StorageImage = 2,
        ///<summary>Format supports atomic operations in case it is used for storage images</summary>
        StorageImageAtomic = 4,
        ///<summary>Format can be used for uniform texel buffers (TBOs)</summary>
        UniformTexelBuffer = 8,
        ///<summary>Format can be used for storage texel buffers (IBOs)</summary>
        StorageTexelBuffer = 16,
        ///<summary>Format supports atomic operations in case it is used for storage texel buffers</summary>
        StorageTexelBufferAtomic = 32,
        ///<summary>Format can be used for vertex buffers (VBOs)</summary>
        VertexBuffer = 64,
        ///<summary>Format can be used for color attachment images</summary>
        ColorAttachment = 128,
        ///<summary>Format supports blending in case it is used for color attachment images</summary>
        ColorAttachmentBlend = 256,
        ///<summary>Format can be used for depth/stencil attachment images</summary>
        DepthStencilAttachment = 512,
        ///<summary>Format can be used as the source image of blits with vkCmdBlitImage</summary>
        BlitSrc = 1024,
        ///<summary>Format can be used as the destination image of blits with vkCmdBlitImage</summary>
        BlitDst = 2048,
        ///<summary>Format can be filtered with VK_FILTER_LINEAR when being sampled</summary>
        SampledImageFilterLinear = 4096,
        TransferSrc = 16384,
        TransferDst = 32768,
        MidpointChromaSamples = 131072,
        SampledImageYcbcrConversionLinearFilter = 262144,
        SampledImageYcbcrConversionSeparateReconstructionFilter = 524288,
        SampledImageYcbcrConversionChromaReconstructionExplicit = 1048576,
        SampledImageYcbcrConversionChromaReconstructionExplicitForceable = 2097152,
        Disjoint = 4194304,
        CositedChromaSamples = 8388608,
        SampledImageFilterMinmax = 65536,
        VideoDecodeOutputKHR = 33554432,
        VideoDecodeDpbKHR = 67108864,
        AccelerationStructureVertexBufferKHR = 536870912,
        SampledImageFilterCubicEXT = 8192,
        FragmentDensityMapEXT = 16777216,
        FragmentShadingRateAttachmentKHR = 1073741824,
        VideoEncodeInputKHR = 134217728,
        VideoEncodeDpbKHR = 268435456,
    }
    public static partial class RawConstants
    {
        ///<summary>Format can be used for sampled images (SAMPLED_IMAGE and COMBINED_IMAGE_SAMPLER descriptor types)</summary>
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT = VkFormatFeatureFlags.SampledImage;
        ///<summary>Format can be used for storage images (STORAGE_IMAGE descriptor type)</summary>
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT = VkFormatFeatureFlags.StorageImage;
        ///<summary>Format supports atomic operations in case it is used for storage images</summary>
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_STORAGE_IMAGE_ATOMIC_BIT = VkFormatFeatureFlags.StorageImageAtomic;
        ///<summary>Format can be used for uniform texel buffers (TBOs)</summary>
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_UNIFORM_TEXEL_BUFFER_BIT = VkFormatFeatureFlags.UniformTexelBuffer;
        ///<summary>Format can be used for storage texel buffers (IBOs)</summary>
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_BIT = VkFormatFeatureFlags.StorageTexelBuffer;
        ///<summary>Format supports atomic operations in case it is used for storage texel buffers</summary>
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_ATOMIC_BIT = VkFormatFeatureFlags.StorageTexelBufferAtomic;
        ///<summary>Format can be used for vertex buffers (VBOs)</summary>
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_VERTEX_BUFFER_BIT = VkFormatFeatureFlags.VertexBuffer;
        ///<summary>Format can be used for color attachment images</summary>
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT = VkFormatFeatureFlags.ColorAttachment;
        ///<summary>Format supports blending in case it is used for color attachment images</summary>
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BLEND_BIT = VkFormatFeatureFlags.ColorAttachmentBlend;
        ///<summary>Format can be used for depth/stencil attachment images</summary>
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT = VkFormatFeatureFlags.DepthStencilAttachment;
        ///<summary>Format can be used as the source image of blits with vkCmdBlitImage</summary>
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_BLIT_SRC_BIT = VkFormatFeatureFlags.BlitSrc;
        ///<summary>Format can be used as the destination image of blits with vkCmdBlitImage</summary>
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_BLIT_DST_BIT = VkFormatFeatureFlags.BlitDst;
        ///<summary>Format can be filtered with VK_FILTER_LINEAR when being sampled</summary>
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_LINEAR_BIT = VkFormatFeatureFlags.SampledImageFilterLinear;
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_TRANSFER_SRC_BIT = VkFormatFeatureFlags.TransferSrc;
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_TRANSFER_DST_BIT = VkFormatFeatureFlags.TransferDst;
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_MIDPOINT_CHROMA_SAMPLES_BIT = VkFormatFeatureFlags.MidpointChromaSamples;
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT = VkFormatFeatureFlags.SampledImageYcbcrConversionLinearFilter;
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT = VkFormatFeatureFlags.SampledImageYcbcrConversionSeparateReconstructionFilter;
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT = VkFormatFeatureFlags.SampledImageYcbcrConversionChromaReconstructionExplicit;
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT = VkFormatFeatureFlags.SampledImageYcbcrConversionChromaReconstructionExplicitForceable;
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_DISJOINT_BIT = VkFormatFeatureFlags.Disjoint;
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_COSITED_CHROMA_SAMPLES_BIT = VkFormatFeatureFlags.CositedChromaSamples;
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_MINMAX_BIT = VkFormatFeatureFlags.SampledImageFilterMinmax;
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_VIDEO_DECODE_OUTPUT_BIT_KHR = VkFormatFeatureFlags.VideoDecodeOutputKHR;
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_VIDEO_DECODE_DPB_BIT_KHR = VkFormatFeatureFlags.VideoDecodeDpbKHR;
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_ACCELERATION_STRUCTURE_VERTEX_BUFFER_BIT_KHR = VkFormatFeatureFlags.AccelerationStructureVertexBufferKHR;
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_SAMPLED_IMAGE_FILTER_CUBIC_BIT_EXT = VkFormatFeatureFlags.SampledImageFilterCubicEXT;
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_FRAGMENT_DENSITY_MAP_BIT_EXT = VkFormatFeatureFlags.FragmentDensityMapEXT;
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = VkFormatFeatureFlags.FragmentShadingRateAttachmentKHR;
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_VIDEO_ENCODE_INPUT_BIT_KHR = VkFormatFeatureFlags.VideoEncodeInputKHR;
        public const VkFormatFeatureFlags VK_FORMAT_FEATURE_VIDEO_ENCODE_DPB_BIT_KHR = VkFormatFeatureFlags.VideoEncodeDpbKHR;
    }

    [Flags]
    public enum VkQueryControlFlags : int
    {
        None = 0,
        ///<summary>Require precise results to be collected by the query</summary>
        Precise = 1,
    }
    public static partial class RawConstants
    {
        ///<summary>Require precise results to be collected by the query</summary>
        public const VkQueryControlFlags VK_QUERY_CONTROL_PRECISE_BIT = VkQueryControlFlags.Precise;
    }

    [Flags]
    public enum VkQueryResultFlags : int
    {
        None = 0,
        ///<summary>Results of the queries are written to the destination buffer as 64-bit values</summary>
        _64 = 1,
        ///<summary>Results of the queries are waited on before proceeding with the result copy</summary>
        Wait = 2,
        ///<summary>Besides the results of the query, the availability of the results is also written</summary>
        WithAvailability = 4,
        ///<summary>Copy the partial results of the query even if the final results are not available</summary>
        Partial = 8,
        WithStatusKHR = 16,
    }
    public static partial class RawConstants
    {
        ///<summary>Results of the queries are written to the destination buffer as 64-bit values</summary>
        public const VkQueryResultFlags VK_QUERY_RESULT_64_BIT = VkQueryResultFlags._64;
        ///<summary>Results of the queries are waited on before proceeding with the result copy</summary>
        public const VkQueryResultFlags VK_QUERY_RESULT_WAIT_BIT = VkQueryResultFlags.Wait;
        ///<summary>Besides the results of the query, the availability of the results is also written</summary>
        public const VkQueryResultFlags VK_QUERY_RESULT_WITH_AVAILABILITY_BIT = VkQueryResultFlags.WithAvailability;
        ///<summary>Copy the partial results of the query even if the final results are not available</summary>
        public const VkQueryResultFlags VK_QUERY_RESULT_PARTIAL_BIT = VkQueryResultFlags.Partial;
        public const VkQueryResultFlags VK_QUERY_RESULT_WITH_STATUS_BIT_KHR = VkQueryResultFlags.WithStatusKHR;
    }

    [Flags]
    public enum VkCommandBufferUsageFlags : int
    {
        None = 0,
        OneTimeSubmit = 1,
        RenderPassContinue = 2,
        ///<summary>Command buffer may be submitted/executed more than once simultaneously</summary>
        SimultaneousUse = 4,
    }
    public static partial class RawConstants
    {
        public const VkCommandBufferUsageFlags VK_COMMAND_BUFFER_USAGE_ONE_TIME_SUBMIT_BIT = VkCommandBufferUsageFlags.OneTimeSubmit;
        public const VkCommandBufferUsageFlags VK_COMMAND_BUFFER_USAGE_RENDER_PASS_CONTINUE_BIT = VkCommandBufferUsageFlags.RenderPassContinue;
        ///<summary>Command buffer may be submitted/executed more than once simultaneously</summary>
        public const VkCommandBufferUsageFlags VK_COMMAND_BUFFER_USAGE_SIMULTANEOUS_USE_BIT = VkCommandBufferUsageFlags.SimultaneousUse;
    }

    [Flags]
    public enum VkQueryPipelineStatisticFlags : int
    {
        None = 0,
        ///<summary>Optional</summary>
        InputAssemblyVertices = 1,
        ///<summary>Optional</summary>
        InputAssemblyPrimitives = 2,
        ///<summary>Optional</summary>
        VertexShaderInvocations = 4,
        ///<summary>Optional</summary>
        GeometryShaderInvocations = 8,
        ///<summary>Optional</summary>
        GeometryShaderPrimitives = 16,
        ///<summary>Optional</summary>
        ClippingInvocations = 32,
        ///<summary>Optional</summary>
        ClippingPrimitives = 64,
        ///<summary>Optional</summary>
        FragmentShaderInvocations = 128,
        ///<summary>Optional</summary>
        TessellationControlShaderPatches = 256,
        ///<summary>Optional</summary>
        TessellationEvaluationShaderInvocations = 512,
        ///<summary>Optional</summary>
        ComputeShaderInvocations = 1024,
        TaskShaderInvocationsEXT = 2048,
        MeshShaderInvocationsEXT = 4096,
        ClusterCullingShaderInvocationsHuawei = 8192,
    }
    public static partial class RawConstants
    {
        ///<summary>Optional</summary>
        public const VkQueryPipelineStatisticFlags VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_VERTICES_BIT = VkQueryPipelineStatisticFlags.InputAssemblyVertices;
        ///<summary>Optional</summary>
        public const VkQueryPipelineStatisticFlags VK_QUERY_PIPELINE_STATISTIC_INPUT_ASSEMBLY_PRIMITIVES_BIT = VkQueryPipelineStatisticFlags.InputAssemblyPrimitives;
        ///<summary>Optional</summary>
        public const VkQueryPipelineStatisticFlags VK_QUERY_PIPELINE_STATISTIC_VERTEX_SHADER_INVOCATIONS_BIT = VkQueryPipelineStatisticFlags.VertexShaderInvocations;
        ///<summary>Optional</summary>
        public const VkQueryPipelineStatisticFlags VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_INVOCATIONS_BIT = VkQueryPipelineStatisticFlags.GeometryShaderInvocations;
        ///<summary>Optional</summary>
        public const VkQueryPipelineStatisticFlags VK_QUERY_PIPELINE_STATISTIC_GEOMETRY_SHADER_PRIMITIVES_BIT = VkQueryPipelineStatisticFlags.GeometryShaderPrimitives;
        ///<summary>Optional</summary>
        public const VkQueryPipelineStatisticFlags VK_QUERY_PIPELINE_STATISTIC_CLIPPING_INVOCATIONS_BIT = VkQueryPipelineStatisticFlags.ClippingInvocations;
        ///<summary>Optional</summary>
        public const VkQueryPipelineStatisticFlags VK_QUERY_PIPELINE_STATISTIC_CLIPPING_PRIMITIVES_BIT = VkQueryPipelineStatisticFlags.ClippingPrimitives;
        ///<summary>Optional</summary>
        public const VkQueryPipelineStatisticFlags VK_QUERY_PIPELINE_STATISTIC_FRAGMENT_SHADER_INVOCATIONS_BIT = VkQueryPipelineStatisticFlags.FragmentShaderInvocations;
        ///<summary>Optional</summary>
        public const VkQueryPipelineStatisticFlags VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_CONTROL_SHADER_PATCHES_BIT = VkQueryPipelineStatisticFlags.TessellationControlShaderPatches;
        ///<summary>Optional</summary>
        public const VkQueryPipelineStatisticFlags VK_QUERY_PIPELINE_STATISTIC_TESSELLATION_EVALUATION_SHADER_INVOCATIONS_BIT = VkQueryPipelineStatisticFlags.TessellationEvaluationShaderInvocations;
        ///<summary>Optional</summary>
        public const VkQueryPipelineStatisticFlags VK_QUERY_PIPELINE_STATISTIC_COMPUTE_SHADER_INVOCATIONS_BIT = VkQueryPipelineStatisticFlags.ComputeShaderInvocations;
        public const VkQueryPipelineStatisticFlags VK_QUERY_PIPELINE_STATISTIC_TASK_SHADER_INVOCATIONS_BIT_EXT = VkQueryPipelineStatisticFlags.TaskShaderInvocationsEXT;
        public const VkQueryPipelineStatisticFlags VK_QUERY_PIPELINE_STATISTIC_MESH_SHADER_INVOCATIONS_BIT_EXT = VkQueryPipelineStatisticFlags.MeshShaderInvocationsEXT;
        public const VkQueryPipelineStatisticFlags VK_QUERY_PIPELINE_STATISTIC_CLUSTER_CULLING_SHADER_INVOCATIONS_BIT_HUAWEI = VkQueryPipelineStatisticFlags.ClusterCullingShaderInvocationsHuawei;
    }

    [Flags]
    public enum VkImageAspectFlags : int
    {
        Color = 1,
        Depth = 2,
        Stencil = 4,
        Metadata = 8,
        Plane0 = 16,
        Plane1 = 32,
        Plane2 = 64,
        None = 0,
        MemoryPlane0EXT = 128,
        MemoryPlane1EXT = 256,
        MemoryPlane2EXT = 512,
        MemoryPlane3EXT = 1024,
    }
    public static partial class RawConstants
    {
        public const VkImageAspectFlags VK_IMAGE_ASPECT_COLOR_BIT = VkImageAspectFlags.Color;
        public const VkImageAspectFlags VK_IMAGE_ASPECT_DEPTH_BIT = VkImageAspectFlags.Depth;
        public const VkImageAspectFlags VK_IMAGE_ASPECT_STENCIL_BIT = VkImageAspectFlags.Stencil;
        public const VkImageAspectFlags VK_IMAGE_ASPECT_METADATA_BIT = VkImageAspectFlags.Metadata;
        public const VkImageAspectFlags VK_IMAGE_ASPECT_PLANE_0_BIT = VkImageAspectFlags.Plane0;
        public const VkImageAspectFlags VK_IMAGE_ASPECT_PLANE_1_BIT = VkImageAspectFlags.Plane1;
        public const VkImageAspectFlags VK_IMAGE_ASPECT_PLANE_2_BIT = VkImageAspectFlags.Plane2;
        public const VkImageAspectFlags VK_IMAGE_ASPECT_NONE = VkImageAspectFlags.None;
        public const VkImageAspectFlags VK_IMAGE_ASPECT_MEMORY_PLANE_0_BIT_EXT = VkImageAspectFlags.MemoryPlane0EXT;
        public const VkImageAspectFlags VK_IMAGE_ASPECT_MEMORY_PLANE_1_BIT_EXT = VkImageAspectFlags.MemoryPlane1EXT;
        public const VkImageAspectFlags VK_IMAGE_ASPECT_MEMORY_PLANE_2_BIT_EXT = VkImageAspectFlags.MemoryPlane2EXT;
        public const VkImageAspectFlags VK_IMAGE_ASPECT_MEMORY_PLANE_3_BIT_EXT = VkImageAspectFlags.MemoryPlane3EXT;
    }

    [Flags]
    public enum VkSparseImageFormatFlags : int
    {
        None = 0,
        ///<summary>Image uses a single mip tail region for all array layers</summary>
        SingleMiptail = 1,
        ///<summary>Image requires mip level dimensions to be an integer multiple of the sparse image block dimensions for non-tail mip levels.</summary>
        AlignedMipSize = 2,
        ///<summary>Image uses a non-standard sparse image block dimensions</summary>
        NonstandardBlockSize = 4,
    }
    public static partial class RawConstants
    {
        ///<summary>Image uses a single mip tail region for all array layers</summary>
        public const VkSparseImageFormatFlags VK_SPARSE_IMAGE_FORMAT_SINGLE_MIPTAIL_BIT = VkSparseImageFormatFlags.SingleMiptail;
        ///<summary>Image requires mip level dimensions to be an integer multiple of the sparse image block dimensions for non-tail mip levels.</summary>
        public const VkSparseImageFormatFlags VK_SPARSE_IMAGE_FORMAT_ALIGNED_MIP_SIZE_BIT = VkSparseImageFormatFlags.AlignedMipSize;
        ///<summary>Image uses a non-standard sparse image block dimensions</summary>
        public const VkSparseImageFormatFlags VK_SPARSE_IMAGE_FORMAT_NONSTANDARD_BLOCK_SIZE_BIT = VkSparseImageFormatFlags.NonstandardBlockSize;
    }

    [Flags]
    public enum VkSparseMemoryBindFlags : int
    {
        None = 0,
        ///<summary>Operation binds resource metadata to memory</summary>
        Metadata = 1,
    }
    public static partial class RawConstants
    {
        ///<summary>Operation binds resource metadata to memory</summary>
        public const VkSparseMemoryBindFlags VK_SPARSE_MEMORY_BIND_METADATA_BIT = VkSparseMemoryBindFlags.Metadata;
    }

    [Flags]
    public enum VkPipelineStageFlags : int
    {
        ///<summary>Before subsequent commands are processed</summary>
        TopOfPipe = 1,
        ///<summary>Draw/DispatchIndirect command fetch</summary>
        DrawIndirect = 2,
        ///<summary>Vertex/index fetch</summary>
        VertexInput = 4,
        ///<summary>Vertex shading</summary>
        VertexShader = 8,
        ///<summary>Tessellation control shading</summary>
        TessellationControlShader = 16,
        ///<summary>Tessellation evaluation shading</summary>
        TessellationEvaluationShader = 32,
        ///<summary>Geometry shading</summary>
        GeometryShader = 64,
        ///<summary>Fragment shading</summary>
        FragmentShader = 128,
        ///<summary>Early fragment (depth and stencil) tests</summary>
        EarlyFragmentTests = 256,
        ///<summary>Late fragment (depth and stencil) tests</summary>
        LateFragmentTests = 512,
        ///<summary>Color attachment writes</summary>
        ColorAttachmentOutput = 1024,
        ///<summary>Compute shading</summary>
        ComputeShader = 2048,
        ///<summary>Transfer/copy operations</summary>
        Transfer = 4096,
        ///<summary>After previous commands have completed</summary>
        BottomOfPipe = 8192,
        ///<summary>Indicates host (CPU) is a source/sink of the dependency</summary>
        Host = 16384,
        ///<summary>All stages of the graphics pipeline</summary>
        AllGraphics = 32768,
        ///<summary>All stages supported on the queue</summary>
        AllCommands = 65536,
        None = 0,
        TransformFeedbackEXT = 16777216,
        ConditionalRenderingEXT = 262144,
        AccelerationStructureBuildKHR = 33554432,
        RayTracingShaderKHR = 2097152,
        FragmentDensityProcessEXT = 8388608,
        FragmentShadingRateAttachmentKHR = 4194304,
        CommandPreprocessNV = 131072,
        TaskShaderEXT = 524288,
        MeshShaderEXT = 1048576,
    }
    public static partial class RawConstants
    {
        ///<summary>Before subsequent commands are processed</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_TOP_OF_PIPE_BIT = VkPipelineStageFlags.TopOfPipe;
        ///<summary>Draw/DispatchIndirect command fetch</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_DRAW_INDIRECT_BIT = VkPipelineStageFlags.DrawIndirect;
        ///<summary>Vertex/index fetch</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_VERTEX_INPUT_BIT = VkPipelineStageFlags.VertexInput;
        ///<summary>Vertex shading</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_VERTEX_SHADER_BIT = VkPipelineStageFlags.VertexShader;
        ///<summary>Tessellation control shading</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_TESSELLATION_CONTROL_SHADER_BIT = VkPipelineStageFlags.TessellationControlShader;
        ///<summary>Tessellation evaluation shading</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_TESSELLATION_EVALUATION_SHADER_BIT = VkPipelineStageFlags.TessellationEvaluationShader;
        ///<summary>Geometry shading</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT = VkPipelineStageFlags.GeometryShader;
        ///<summary>Fragment shading</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_FRAGMENT_SHADER_BIT = VkPipelineStageFlags.FragmentShader;
        ///<summary>Early fragment (depth and stencil) tests</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT = VkPipelineStageFlags.EarlyFragmentTests;
        ///<summary>Late fragment (depth and stencil) tests</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT = VkPipelineStageFlags.LateFragmentTests;
        ///<summary>Color attachment writes</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT = VkPipelineStageFlags.ColorAttachmentOutput;
        ///<summary>Compute shading</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_COMPUTE_SHADER_BIT = VkPipelineStageFlags.ComputeShader;
        ///<summary>Transfer/copy operations</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_TRANSFER_BIT = VkPipelineStageFlags.Transfer;
        ///<summary>After previous commands have completed</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_BOTTOM_OF_PIPE_BIT = VkPipelineStageFlags.BottomOfPipe;
        ///<summary>Indicates host (CPU) is a source/sink of the dependency</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_HOST_BIT = VkPipelineStageFlags.Host;
        ///<summary>All stages of the graphics pipeline</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_ALL_GRAPHICS_BIT = VkPipelineStageFlags.AllGraphics;
        ///<summary>All stages supported on the queue</summary>
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_ALL_COMMANDS_BIT = VkPipelineStageFlags.AllCommands;
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_NONE = VkPipelineStageFlags.None;
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_TRANSFORM_FEEDBACK_BIT_EXT = VkPipelineStageFlags.TransformFeedbackEXT;
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_CONDITIONAL_RENDERING_BIT_EXT = VkPipelineStageFlags.ConditionalRenderingEXT;
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_ACCELERATION_STRUCTURE_BUILD_BIT_KHR = VkPipelineStageFlags.AccelerationStructureBuildKHR;
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_RAY_TRACING_SHADER_BIT_KHR = VkPipelineStageFlags.RayTracingShaderKHR;
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_FRAGMENT_DENSITY_PROCESS_BIT_EXT = VkPipelineStageFlags.FragmentDensityProcessEXT;
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = VkPipelineStageFlags.FragmentShadingRateAttachmentKHR;
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_COMMAND_PREPROCESS_BIT_NV = VkPipelineStageFlags.CommandPreprocessNV;
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_TASK_SHADER_BIT_EXT = VkPipelineStageFlags.TaskShaderEXT;
        public const VkPipelineStageFlags VK_PIPELINE_STAGE_MESH_SHADER_BIT_EXT = VkPipelineStageFlags.MeshShaderEXT;
    }

    [Flags]
    public enum VkCommandPoolCreateFlags : int
    {
        None = 0,
        ///<summary>Command buffers have a short lifetime</summary>
        Transient = 1,
        ///<summary>Command buffers may release their memory individually</summary>
        ResetCommandBuffer = 2,
        Protected = 4,
    }
    public static partial class RawConstants
    {
        ///<summary>Command buffers have a short lifetime</summary>
        public const VkCommandPoolCreateFlags VK_COMMAND_POOL_CREATE_TRANSIENT_BIT = VkCommandPoolCreateFlags.Transient;
        ///<summary>Command buffers may release their memory individually</summary>
        public const VkCommandPoolCreateFlags VK_COMMAND_POOL_CREATE_RESET_COMMAND_BUFFER_BIT = VkCommandPoolCreateFlags.ResetCommandBuffer;
        public const VkCommandPoolCreateFlags VK_COMMAND_POOL_CREATE_PROTECTED_BIT = VkCommandPoolCreateFlags.Protected;
    }

    [Flags]
    public enum VkCommandPoolResetFlags : int
    {
        None = 0,
        ///<summary>Release resources owned by the pool</summary>
        ReleaseResources = 1,
        Reserved1Coreavi = 2,
    }
    public static partial class RawConstants
    {
        ///<summary>Release resources owned by the pool</summary>
        public const VkCommandPoolResetFlags VK_COMMAND_POOL_RESET_RELEASE_RESOURCES_BIT = VkCommandPoolResetFlags.ReleaseResources;
        public const VkCommandPoolResetFlags VK_COMMAND_POOL_RESET_RESERVED_1_BIT_COREAVI = VkCommandPoolResetFlags.Reserved1Coreavi;
    }

    [Flags]
    public enum VkCommandBufferResetFlags : int
    {
        None = 0,
        ///<summary>Release resources owned by the buffer</summary>
        ReleaseResources = 1,
    }
    public static partial class RawConstants
    {
        ///<summary>Release resources owned by the buffer</summary>
        public const VkCommandBufferResetFlags VK_COMMAND_BUFFER_RESET_RELEASE_RESOURCES_BIT = VkCommandBufferResetFlags.ReleaseResources;
    }

    [Flags]
    public enum VkSampleCountFlags : int
    {
        None = 0,
        ///<summary>Sample count 1 supported</summary>
        Count1 = 1,
        ///<summary>Sample count 2 supported</summary>
        Count2 = 2,
        ///<summary>Sample count 4 supported</summary>
        Count4 = 4,
        ///<summary>Sample count 8 supported</summary>
        Count8 = 8,
        ///<summary>Sample count 16 supported</summary>
        Count16 = 16,
        ///<summary>Sample count 32 supported</summary>
        Count32 = 32,
        ///<summary>Sample count 64 supported</summary>
        Count64 = 64,
    }
    public static partial class RawConstants
    {
        ///<summary>Sample count 1 supported</summary>
        public const VkSampleCountFlags VK_SAMPLE_COUNT_1_BIT = VkSampleCountFlags.Count1;
        ///<summary>Sample count 2 supported</summary>
        public const VkSampleCountFlags VK_SAMPLE_COUNT_2_BIT = VkSampleCountFlags.Count2;
        ///<summary>Sample count 4 supported</summary>
        public const VkSampleCountFlags VK_SAMPLE_COUNT_4_BIT = VkSampleCountFlags.Count4;
        ///<summary>Sample count 8 supported</summary>
        public const VkSampleCountFlags VK_SAMPLE_COUNT_8_BIT = VkSampleCountFlags.Count8;
        ///<summary>Sample count 16 supported</summary>
        public const VkSampleCountFlags VK_SAMPLE_COUNT_16_BIT = VkSampleCountFlags.Count16;
        ///<summary>Sample count 32 supported</summary>
        public const VkSampleCountFlags VK_SAMPLE_COUNT_32_BIT = VkSampleCountFlags.Count32;
        ///<summary>Sample count 64 supported</summary>
        public const VkSampleCountFlags VK_SAMPLE_COUNT_64_BIT = VkSampleCountFlags.Count64;
    }

    [Flags]
    public enum VkAttachmentDescriptionFlags : int
    {
        None = 0,
        ///<summary>The attachment may alias physical memory of another attachment in the same render pass</summary>
        MayAlias = 1,
    }
    public static partial class RawConstants
    {
        ///<summary>The attachment may alias physical memory of another attachment in the same render pass</summary>
        public const VkAttachmentDescriptionFlags VK_ATTACHMENT_DESCRIPTION_MAY_ALIAS_BIT = VkAttachmentDescriptionFlags.MayAlias;
    }

    [Flags]
    public enum VkStencilFaceFlags : int
    {
        None = 0,
        ///<summary>Front face</summary>
        Front = 1,
        ///<summary>Back face</summary>
        Back = 2,
        ///<summary>Front and back faces</summary>
        FrontAndBack = 3,
    }
    public static partial class RawConstants
    {
        ///<summary>Front face</summary>
        public const VkStencilFaceFlags VK_STENCIL_FACE_FRONT_BIT = VkStencilFaceFlags.Front;
        ///<summary>Back face</summary>
        public const VkStencilFaceFlags VK_STENCIL_FACE_BACK_BIT = VkStencilFaceFlags.Back;
        ///<summary>Front and back faces</summary>
        public const VkStencilFaceFlags VK_STENCIL_FACE_FRONT_AND_BACK = VkStencilFaceFlags.FrontAndBack;
    }

    [Flags]
    public enum VkDescriptorPoolCreateFlags : int
    {
        None = 0,
        ///<summary>Descriptor sets may be freed individually</summary>
        FreeDescriptorSet = 1,
        UpdateAfterBind = 2,
        HostOnlyEXT = 4,
        AllowOverallocationSetsNV = 8,
        AllowOverallocationPoolsNV = 16,
    }
    public static partial class RawConstants
    {
        ///<summary>Descriptor sets may be freed individually</summary>
        public const VkDescriptorPoolCreateFlags VK_DESCRIPTOR_POOL_CREATE_FREE_DESCRIPTOR_SET_BIT = VkDescriptorPoolCreateFlags.FreeDescriptorSet;
        public const VkDescriptorPoolCreateFlags VK_DESCRIPTOR_POOL_CREATE_UPDATE_AFTER_BIND_BIT = VkDescriptorPoolCreateFlags.UpdateAfterBind;
        public const VkDescriptorPoolCreateFlags VK_DESCRIPTOR_POOL_CREATE_HOST_ONLY_BIT_EXT = VkDescriptorPoolCreateFlags.HostOnlyEXT;
        public const VkDescriptorPoolCreateFlags VK_DESCRIPTOR_POOL_CREATE_ALLOW_OVERALLOCATION_SETS_BIT_NV = VkDescriptorPoolCreateFlags.AllowOverallocationSetsNV;
        public const VkDescriptorPoolCreateFlags VK_DESCRIPTOR_POOL_CREATE_ALLOW_OVERALLOCATION_POOLS_BIT_NV = VkDescriptorPoolCreateFlags.AllowOverallocationPoolsNV;
    }

    [Flags]
    public enum VkDependencyFlags : int
    {
        None = 0,
        ///<summary>Dependency is per pixel region </summary>
        ByRegion = 1,
        DeviceGroup = 4,
        ViewLocal = 2,
        FeedbackLoopEXT = 8,
    }
    public static partial class RawConstants
    {
        ///<summary>Dependency is per pixel region </summary>
        public const VkDependencyFlags VK_DEPENDENCY_BY_REGION_BIT = VkDependencyFlags.ByRegion;
        public const VkDependencyFlags VK_DEPENDENCY_DEVICE_GROUP_BIT = VkDependencyFlags.DeviceGroup;
        public const VkDependencyFlags VK_DEPENDENCY_VIEW_LOCAL_BIT = VkDependencyFlags.ViewLocal;
        public const VkDependencyFlags VK_DEPENDENCY_FEEDBACK_LOOP_BIT_EXT = VkDependencyFlags.FeedbackLoopEXT;
    }

    public enum VkSemaphoreType : int
    {
        Binary = 0,
        Timeline = 1,
    }
    public static partial class RawConstants
    {
        public const VkSemaphoreType VK_SEMAPHORE_TYPE_BINARY = VkSemaphoreType.Binary;
        public const VkSemaphoreType VK_SEMAPHORE_TYPE_TIMELINE = VkSemaphoreType.Timeline;
    }

    [Flags]
    public enum VkSemaphoreWaitFlags : int
    {
        None = 0,
        Any = 1,
    }
    public static partial class RawConstants
    {
        public const VkSemaphoreWaitFlags VK_SEMAPHORE_WAIT_ANY_BIT = VkSemaphoreWaitFlags.Any;
    }

    public enum VkPresentModeKHR : int
    {
        ImmediateKHR = 0,
        MailboxKHR = 1,
        FifoKHR = 2,
        FifoRelaxedKHR = 3,
        SharedDemandRefreshKHR = 1000111000,
        SharedContinuousRefreshKHR = 1000111001,
    }
    public static partial class RawConstants
    {
        public const VkPresentModeKHR VK_PRESENT_MODE_IMMEDIATE_KHR = VkPresentModeKHR.ImmediateKHR;
        public const VkPresentModeKHR VK_PRESENT_MODE_MAILBOX_KHR = VkPresentModeKHR.MailboxKHR;
        public const VkPresentModeKHR VK_PRESENT_MODE_FIFO_KHR = VkPresentModeKHR.FifoKHR;
        public const VkPresentModeKHR VK_PRESENT_MODE_FIFO_RELAXED_KHR = VkPresentModeKHR.FifoRelaxedKHR;
        public const VkPresentModeKHR VK_PRESENT_MODE_SHARED_DEMAND_REFRESH_KHR = VkPresentModeKHR.SharedDemandRefreshKHR;
        public const VkPresentModeKHR VK_PRESENT_MODE_SHARED_CONTINUOUS_REFRESH_KHR = VkPresentModeKHR.SharedContinuousRefreshKHR;
    }

    public enum VkColorSpaceKHR : int
    {
        SrgbNonlinearKHR = 0,
        DisplayP3NonlinearEXT = 1000104001,
        ExtendedSrgbLinearEXT = 1000104002,
        DisplayP3LinearEXT = 1000104003,
        DciP3NonlinearEXT = 1000104004,
        Bt709LinearEXT = 1000104005,
        Bt709NonlinearEXT = 1000104006,
        Bt2020LinearEXT = 1000104007,
        Hdr10St2084EXT = 1000104008,
        DolbyvisionEXT = 1000104009,
        Hdr10HlgEXT = 1000104010,
        AdobergbLinearEXT = 1000104011,
        AdobergbNonlinearEXT = 1000104012,
        PassThroughEXT = 1000104013,
        ExtendedSrgbNonlinearEXT = 1000104014,
        DisplayNativeAMD = 1000213000,
    }
    public static partial class RawConstants
    {
        public const VkColorSpaceKHR VK_COLOR_SPACE_SRGB_NONLINEAR_KHR = VkColorSpaceKHR.SrgbNonlinearKHR;
        public const VkColorSpaceKHR VK_COLOR_SPACE_DISPLAY_P3_NONLINEAR_EXT = VkColorSpaceKHR.DisplayP3NonlinearEXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_EXTENDED_SRGB_LINEAR_EXT = VkColorSpaceKHR.ExtendedSrgbLinearEXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_DISPLAY_P3_LINEAR_EXT = VkColorSpaceKHR.DisplayP3LinearEXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_DCI_P3_NONLINEAR_EXT = VkColorSpaceKHR.DciP3NonlinearEXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_BT709_LINEAR_EXT = VkColorSpaceKHR.Bt709LinearEXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_BT709_NONLINEAR_EXT = VkColorSpaceKHR.Bt709NonlinearEXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_BT2020_LINEAR_EXT = VkColorSpaceKHR.Bt2020LinearEXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_HDR10_ST2084_EXT = VkColorSpaceKHR.Hdr10St2084EXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_DOLBYVISION_EXT = VkColorSpaceKHR.DolbyvisionEXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_HDR10_HLG_EXT = VkColorSpaceKHR.Hdr10HlgEXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_ADOBERGB_LINEAR_EXT = VkColorSpaceKHR.AdobergbLinearEXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_ADOBERGB_NONLINEAR_EXT = VkColorSpaceKHR.AdobergbNonlinearEXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_PASS_THROUGH_EXT = VkColorSpaceKHR.PassThroughEXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_EXTENDED_SRGB_NONLINEAR_EXT = VkColorSpaceKHR.ExtendedSrgbNonlinearEXT;
        public const VkColorSpaceKHR VK_COLOR_SPACE_DISPLAY_NATIVE_AMD = VkColorSpaceKHR.DisplayNativeAMD;
    }

    [Flags]
    public enum VkDisplayPlaneAlphaFlagsKHR : int
    {
        None = 0,
        OpaqueKHR = 1,
        GlobalKHR = 2,
        PerPixelKHR = 4,
        PerPixelPremultipliedKHR = 8,
    }
    public static partial class RawConstants
    {
        public const VkDisplayPlaneAlphaFlagsKHR VK_DISPLAY_PLANE_ALPHA_OPAQUE_BIT_KHR = VkDisplayPlaneAlphaFlagsKHR.OpaqueKHR;
        public const VkDisplayPlaneAlphaFlagsKHR VK_DISPLAY_PLANE_ALPHA_GLOBAL_BIT_KHR = VkDisplayPlaneAlphaFlagsKHR.GlobalKHR;
        public const VkDisplayPlaneAlphaFlagsKHR VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_BIT_KHR = VkDisplayPlaneAlphaFlagsKHR.PerPixelKHR;
        public const VkDisplayPlaneAlphaFlagsKHR VK_DISPLAY_PLANE_ALPHA_PER_PIXEL_PREMULTIPLIED_BIT_KHR = VkDisplayPlaneAlphaFlagsKHR.PerPixelPremultipliedKHR;
    }

    [Flags]
    public enum VkCompositeAlphaFlagsKHR : int
    {
        None = 0,
        OpaqueKHR = 1,
        PreMultipliedKHR = 2,
        PostMultipliedKHR = 4,
        InheritKHR = 8,
    }
    public static partial class RawConstants
    {
        public const VkCompositeAlphaFlagsKHR VK_COMPOSITE_ALPHA_OPAQUE_BIT_KHR = VkCompositeAlphaFlagsKHR.OpaqueKHR;
        public const VkCompositeAlphaFlagsKHR VK_COMPOSITE_ALPHA_PRE_MULTIPLIED_BIT_KHR = VkCompositeAlphaFlagsKHR.PreMultipliedKHR;
        public const VkCompositeAlphaFlagsKHR VK_COMPOSITE_ALPHA_POST_MULTIPLIED_BIT_KHR = VkCompositeAlphaFlagsKHR.PostMultipliedKHR;
        public const VkCompositeAlphaFlagsKHR VK_COMPOSITE_ALPHA_INHERIT_BIT_KHR = VkCompositeAlphaFlagsKHR.InheritKHR;
    }

    [Flags]
    public enum VkSurfaceTransformFlagsKHR : int
    {
        None = 0,
        IdentityKHR = 1,
        Rotate90KHR = 2,
        Rotate180KHR = 4,
        Rotate270KHR = 8,
        HorizontalMirrorKHR = 16,
        HorizontalMirrorRotate90KHR = 32,
        HorizontalMirrorRotate180KHR = 64,
        HorizontalMirrorRotate270KHR = 128,
        InheritKHR = 256,
    }
    public static partial class RawConstants
    {
        public const VkSurfaceTransformFlagsKHR VK_SURFACE_TRANSFORM_IDENTITY_BIT_KHR = VkSurfaceTransformFlagsKHR.IdentityKHR;
        public const VkSurfaceTransformFlagsKHR VK_SURFACE_TRANSFORM_ROTATE_90_BIT_KHR = VkSurfaceTransformFlagsKHR.Rotate90KHR;
        public const VkSurfaceTransformFlagsKHR VK_SURFACE_TRANSFORM_ROTATE_180_BIT_KHR = VkSurfaceTransformFlagsKHR.Rotate180KHR;
        public const VkSurfaceTransformFlagsKHR VK_SURFACE_TRANSFORM_ROTATE_270_BIT_KHR = VkSurfaceTransformFlagsKHR.Rotate270KHR;
        public const VkSurfaceTransformFlagsKHR VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_BIT_KHR = VkSurfaceTransformFlagsKHR.HorizontalMirrorKHR;
        public const VkSurfaceTransformFlagsKHR VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_90_BIT_KHR = VkSurfaceTransformFlagsKHR.HorizontalMirrorRotate90KHR;
        public const VkSurfaceTransformFlagsKHR VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_180_BIT_KHR = VkSurfaceTransformFlagsKHR.HorizontalMirrorRotate180KHR;
        public const VkSurfaceTransformFlagsKHR VK_SURFACE_TRANSFORM_HORIZONTAL_MIRROR_ROTATE_270_BIT_KHR = VkSurfaceTransformFlagsKHR.HorizontalMirrorRotate270KHR;
        public const VkSurfaceTransformFlagsKHR VK_SURFACE_TRANSFORM_INHERIT_BIT_KHR = VkSurfaceTransformFlagsKHR.InheritKHR;
    }

    [Flags]
    public enum VkSwapchainImageUsageFlagsANDROID : int
    {
        None = 0,
        SharedAndroid = 1,
    }
    public static partial class RawConstants
    {
        public const VkSwapchainImageUsageFlagsANDROID VK_SWAPCHAIN_IMAGE_USAGE_SHARED_BIT_ANDROID = VkSwapchainImageUsageFlagsANDROID.SharedAndroid;
    }

    public enum VkTimeDomainEXT : int
    {
        DeviceEXT = 0,
        ClockMonotonicEXT = 1,
        ClockMonotonicRawEXT = 2,
        QueryPerformanceCounterEXT = 3,
    }
    public static partial class RawConstants
    {
        public const VkTimeDomainEXT VK_TIME_DOMAIN_DEVICE_EXT = VkTimeDomainEXT.DeviceEXT;
        public const VkTimeDomainEXT VK_TIME_DOMAIN_CLOCK_MONOTONIC_EXT = VkTimeDomainEXT.ClockMonotonicEXT;
        public const VkTimeDomainEXT VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_EXT = VkTimeDomainEXT.ClockMonotonicRawEXT;
        public const VkTimeDomainEXT VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_EXT = VkTimeDomainEXT.QueryPerformanceCounterEXT;
    }

    [Flags]
    public enum VkDebugReportFlagsEXT : int
    {
        None = 0,
        InformationEXT = 1,
        WarningEXT = 2,
        PerformanceWarningEXT = 4,
        ErrorEXT = 8,
        DebugEXT = 16,
    }
    public static partial class RawConstants
    {
        public const VkDebugReportFlagsEXT VK_DEBUG_REPORT_INFORMATION_BIT_EXT = VkDebugReportFlagsEXT.InformationEXT;
        public const VkDebugReportFlagsEXT VK_DEBUG_REPORT_WARNING_BIT_EXT = VkDebugReportFlagsEXT.WarningEXT;
        public const VkDebugReportFlagsEXT VK_DEBUG_REPORT_PERFORMANCE_WARNING_BIT_EXT = VkDebugReportFlagsEXT.PerformanceWarningEXT;
        public const VkDebugReportFlagsEXT VK_DEBUG_REPORT_ERROR_BIT_EXT = VkDebugReportFlagsEXT.ErrorEXT;
        public const VkDebugReportFlagsEXT VK_DEBUG_REPORT_DEBUG_BIT_EXT = VkDebugReportFlagsEXT.DebugEXT;
    }

    public enum VkDebugReportObjectTypeEXT : int
    {
        UnknownEXT = 0,
        InstanceEXT = 1,
        PhysicalDeviceEXT = 2,
        DeviceEXT = 3,
        QueueEXT = 4,
        SemaphoreEXT = 5,
        CommandBufferEXT = 6,
        FenceEXT = 7,
        DeviceMemoryEXT = 8,
        BufferEXT = 9,
        ImageEXT = 10,
        EventEXT = 11,
        QueryPoolEXT = 12,
        BufferViewEXT = 13,
        ImageViewEXT = 14,
        ShaderModuleEXT = 15,
        PipelineCacheEXT = 16,
        PipelineLayoutEXT = 17,
        RenderPassEXT = 18,
        PipelineEXT = 19,
        DescriptorSetLayoutEXT = 20,
        SamplerEXT = 21,
        DescriptorPoolEXT = 22,
        DescriptorSetEXT = 23,
        FramebufferEXT = 24,
        CommandPoolEXT = 25,
        SurfaceKHREXT = 26,
        SwapchainKHREXT = 27,
        DebugReportCallbackEXTEXT = 28,
        DisplayKHREXT = 29,
        DisplayModeKHREXT = 30,
        ValidationCacheEXTEXT = 33,
        SamplerYcbcrConversionEXT = 1000156000,
        DescriptorUpdateTemplateEXT = 1000085000,
        CuModuleNVXEXT = 1000029000,
        CuFunctionNVXEXT = 1000029001,
        AccelerationStructureKHREXT = 1000150000,
        AccelerationStructureNVEXT = 1000165000,
        BufferCollectionFuchsiaEXT = 1000366000,
    }
    public static partial class RawConstants
    {
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_UNKNOWN_EXT = VkDebugReportObjectTypeEXT.UnknownEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_INSTANCE_EXT = VkDebugReportObjectTypeEXT.InstanceEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_PHYSICAL_DEVICE_EXT = VkDebugReportObjectTypeEXT.PhysicalDeviceEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_EXT = VkDebugReportObjectTypeEXT.DeviceEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_QUEUE_EXT = VkDebugReportObjectTypeEXT.QueueEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_SEMAPHORE_EXT = VkDebugReportObjectTypeEXT.SemaphoreEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_BUFFER_EXT = VkDebugReportObjectTypeEXT.CommandBufferEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_FENCE_EXT = VkDebugReportObjectTypeEXT.FenceEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_DEVICE_MEMORY_EXT = VkDebugReportObjectTypeEXT.DeviceMemoryEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_EXT = VkDebugReportObjectTypeEXT.BufferEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_EXT = VkDebugReportObjectTypeEXT.ImageEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_EVENT_EXT = VkDebugReportObjectTypeEXT.EventEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_QUERY_POOL_EXT = VkDebugReportObjectTypeEXT.QueryPoolEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_VIEW_EXT = VkDebugReportObjectTypeEXT.BufferViewEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_IMAGE_VIEW_EXT = VkDebugReportObjectTypeEXT.ImageViewEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_SHADER_MODULE_EXT = VkDebugReportObjectTypeEXT.ShaderModuleEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_CACHE_EXT = VkDebugReportObjectTypeEXT.PipelineCacheEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_LAYOUT_EXT = VkDebugReportObjectTypeEXT.PipelineLayoutEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_RENDER_PASS_EXT = VkDebugReportObjectTypeEXT.RenderPassEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_PIPELINE_EXT = VkDebugReportObjectTypeEXT.PipelineEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_LAYOUT_EXT = VkDebugReportObjectTypeEXT.DescriptorSetLayoutEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_EXT = VkDebugReportObjectTypeEXT.SamplerEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_POOL_EXT = VkDebugReportObjectTypeEXT.DescriptorPoolEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_SET_EXT = VkDebugReportObjectTypeEXT.DescriptorSetEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_FRAMEBUFFER_EXT = VkDebugReportObjectTypeEXT.FramebufferEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_COMMAND_POOL_EXT = VkDebugReportObjectTypeEXT.CommandPoolEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_SURFACE_KHR_EXT = VkDebugReportObjectTypeEXT.SurfaceKHREXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_SWAPCHAIN_KHR_EXT = VkDebugReportObjectTypeEXT.SwapchainKHREXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_DEBUG_REPORT_CALLBACK_EXT_EXT = VkDebugReportObjectTypeEXT.DebugReportCallbackEXTEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_KHR_EXT = VkDebugReportObjectTypeEXT.DisplayKHREXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_DISPLAY_MODE_KHR_EXT = VkDebugReportObjectTypeEXT.DisplayModeKHREXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_VALIDATION_CACHE_EXT_EXT = VkDebugReportObjectTypeEXT.ValidationCacheEXTEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_SAMPLER_YCBCR_CONVERSION_EXT = VkDebugReportObjectTypeEXT.SamplerYcbcrConversionEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_DESCRIPTOR_UPDATE_TEMPLATE_EXT = VkDebugReportObjectTypeEXT.DescriptorUpdateTemplateEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_CU_MODULE_NVX_EXT = VkDebugReportObjectTypeEXT.CuModuleNVXEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_CU_FUNCTION_NVX_EXT = VkDebugReportObjectTypeEXT.CuFunctionNVXEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_ACCELERATION_STRUCTURE_KHR_EXT = VkDebugReportObjectTypeEXT.AccelerationStructureKHREXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_ACCELERATION_STRUCTURE_NV_EXT = VkDebugReportObjectTypeEXT.AccelerationStructureNVEXT;
        public const VkDebugReportObjectTypeEXT VK_DEBUG_REPORT_OBJECT_TYPE_BUFFER_COLLECTION_FUCHSIA_EXT = VkDebugReportObjectTypeEXT.BufferCollectionFuchsiaEXT;
    }

    public enum VkDeviceMemoryReportEventTypeEXT : int
    {
        AllocateEXT = 0,
        FreeEXT = 1,
        ImportEXT = 2,
        UnimportEXT = 3,
        AllocationFailedEXT = 4,
    }
    public static partial class RawConstants
    {
        public const VkDeviceMemoryReportEventTypeEXT VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATE_EXT = VkDeviceMemoryReportEventTypeEXT.AllocateEXT;
        public const VkDeviceMemoryReportEventTypeEXT VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_FREE_EXT = VkDeviceMemoryReportEventTypeEXT.FreeEXT;
        public const VkDeviceMemoryReportEventTypeEXT VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_IMPORT_EXT = VkDeviceMemoryReportEventTypeEXT.ImportEXT;
        public const VkDeviceMemoryReportEventTypeEXT VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_UNIMPORT_EXT = VkDeviceMemoryReportEventTypeEXT.UnimportEXT;
        public const VkDeviceMemoryReportEventTypeEXT VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATION_FAILED_EXT = VkDeviceMemoryReportEventTypeEXT.AllocationFailedEXT;
    }

    public enum VkRasterizationOrderAMD : int
    {
        StrictAMD = 0,
        RelaxedAMD = 1,
    }
    public static partial class RawConstants
    {
        public const VkRasterizationOrderAMD VK_RASTERIZATION_ORDER_STRICT_AMD = VkRasterizationOrderAMD.StrictAMD;
        public const VkRasterizationOrderAMD VK_RASTERIZATION_ORDER_RELAXED_AMD = VkRasterizationOrderAMD.RelaxedAMD;
    }

    [Flags]
    public enum VkExternalMemoryHandleTypeFlagsNV : int
    {
        None = 0,
        OpaqueWin32NV = 1,
        OpaqueWin32KmtNV = 2,
        D3d11ImageNV = 4,
        D3d11ImageKmtNV = 8,
    }
    public static partial class RawConstants
    {
        public const VkExternalMemoryHandleTypeFlagsNV VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT_NV = VkExternalMemoryHandleTypeFlagsNV.OpaqueWin32NV;
        public const VkExternalMemoryHandleTypeFlagsNV VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_NV = VkExternalMemoryHandleTypeFlagsNV.OpaqueWin32KmtNV;
        public const VkExternalMemoryHandleTypeFlagsNV VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_BIT_NV = VkExternalMemoryHandleTypeFlagsNV.D3d11ImageNV;
        public const VkExternalMemoryHandleTypeFlagsNV VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_KMT_BIT_NV = VkExternalMemoryHandleTypeFlagsNV.D3d11ImageKmtNV;
    }

    [Flags]
    public enum VkExternalMemoryFeatureFlagsNV : int
    {
        None = 0,
        DedicatedOnlyNV = 1,
        ExportableNV = 2,
        ImportableNV = 4,
    }
    public static partial class RawConstants
    {
        public const VkExternalMemoryFeatureFlagsNV VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT_NV = VkExternalMemoryFeatureFlagsNV.DedicatedOnlyNV;
        public const VkExternalMemoryFeatureFlagsNV VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT_NV = VkExternalMemoryFeatureFlagsNV.ExportableNV;
        public const VkExternalMemoryFeatureFlagsNV VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT_NV = VkExternalMemoryFeatureFlagsNV.ImportableNV;
    }

    public enum VkValidationCheckEXT : int
    {
        AllEXT = 0,
        ShadersEXT = 1,
    }
    public static partial class RawConstants
    {
        public const VkValidationCheckEXT VK_VALIDATION_CHECK_ALL_EXT = VkValidationCheckEXT.AllEXT;
        public const VkValidationCheckEXT VK_VALIDATION_CHECK_SHADERS_EXT = VkValidationCheckEXT.ShadersEXT;
    }

    public enum VkValidationFeatureEnableEXT : int
    {
        GpuAssistedEXT = 0,
        GpuAssistedReserveBindingSlotEXT = 1,
        BestPracticesEXT = 2,
        DebugPrintfEXT = 3,
        SynchronizationValidationEXT = 4,
    }
    public static partial class RawConstants
    {
        public const VkValidationFeatureEnableEXT VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_EXT = VkValidationFeatureEnableEXT.GpuAssistedEXT;
        public const VkValidationFeatureEnableEXT VK_VALIDATION_FEATURE_ENABLE_GPU_ASSISTED_RESERVE_BINDING_SLOT_EXT = VkValidationFeatureEnableEXT.GpuAssistedReserveBindingSlotEXT;
        public const VkValidationFeatureEnableEXT VK_VALIDATION_FEATURE_ENABLE_BEST_PRACTICES_EXT = VkValidationFeatureEnableEXT.BestPracticesEXT;
        public const VkValidationFeatureEnableEXT VK_VALIDATION_FEATURE_ENABLE_DEBUG_PRINTF_EXT = VkValidationFeatureEnableEXT.DebugPrintfEXT;
        public const VkValidationFeatureEnableEXT VK_VALIDATION_FEATURE_ENABLE_SYNCHRONIZATION_VALIDATION_EXT = VkValidationFeatureEnableEXT.SynchronizationValidationEXT;
    }

    public enum VkValidationFeatureDisableEXT : int
    {
        AllEXT = 0,
        ShadersEXT = 1,
        ThreadSafetyEXT = 2,
        ApiParametersEXT = 3,
        ObjectLifetimesEXT = 4,
        CoreChecksEXT = 5,
        UniqueHandlesEXT = 6,
        ShaderValidationCacheEXT = 7,
    }
    public static partial class RawConstants
    {
        public const VkValidationFeatureDisableEXT VK_VALIDATION_FEATURE_DISABLE_ALL_EXT = VkValidationFeatureDisableEXT.AllEXT;
        public const VkValidationFeatureDisableEXT VK_VALIDATION_FEATURE_DISABLE_SHADERS_EXT = VkValidationFeatureDisableEXT.ShadersEXT;
        public const VkValidationFeatureDisableEXT VK_VALIDATION_FEATURE_DISABLE_THREAD_SAFETY_EXT = VkValidationFeatureDisableEXT.ThreadSafetyEXT;
        public const VkValidationFeatureDisableEXT VK_VALIDATION_FEATURE_DISABLE_API_PARAMETERS_EXT = VkValidationFeatureDisableEXT.ApiParametersEXT;
        public const VkValidationFeatureDisableEXT VK_VALIDATION_FEATURE_DISABLE_OBJECT_LIFETIMES_EXT = VkValidationFeatureDisableEXT.ObjectLifetimesEXT;
        public const VkValidationFeatureDisableEXT VK_VALIDATION_FEATURE_DISABLE_CORE_CHECKS_EXT = VkValidationFeatureDisableEXT.CoreChecksEXT;
        public const VkValidationFeatureDisableEXT VK_VALIDATION_FEATURE_DISABLE_UNIQUE_HANDLES_EXT = VkValidationFeatureDisableEXT.UniqueHandlesEXT;
        public const VkValidationFeatureDisableEXT VK_VALIDATION_FEATURE_DISABLE_SHADER_VALIDATION_CACHE_EXT = VkValidationFeatureDisableEXT.ShaderValidationCacheEXT;
    }

    [Flags]
    public enum VkSubgroupFeatureFlags : int
    {
        None = 0,
        ///<summary>Basic subgroup operations</summary>
        Basic = 1,
        ///<summary>Vote subgroup operations</summary>
        Vote = 2,
        ///<summary>Arithmetic subgroup operations</summary>
        Arithmetic = 4,
        ///<summary>Ballot subgroup operations</summary>
        Ballot = 8,
        ///<summary>Shuffle subgroup operations</summary>
        Shuffle = 16,
        ///<summary>Shuffle relative subgroup operations</summary>
        ShuffleRelative = 32,
        ///<summary>Clustered subgroup operations</summary>
        Clustered = 64,
        ///<summary>Quad subgroup operations</summary>
        Quad = 128,
        PartitionedNV = 256,
    }
    public static partial class RawConstants
    {
        ///<summary>Basic subgroup operations</summary>
        public const VkSubgroupFeatureFlags VK_SUBGROUP_FEATURE_BASIC_BIT = VkSubgroupFeatureFlags.Basic;
        ///<summary>Vote subgroup operations</summary>
        public const VkSubgroupFeatureFlags VK_SUBGROUP_FEATURE_VOTE_BIT = VkSubgroupFeatureFlags.Vote;
        ///<summary>Arithmetic subgroup operations</summary>
        public const VkSubgroupFeatureFlags VK_SUBGROUP_FEATURE_ARITHMETIC_BIT = VkSubgroupFeatureFlags.Arithmetic;
        ///<summary>Ballot subgroup operations</summary>
        public const VkSubgroupFeatureFlags VK_SUBGROUP_FEATURE_BALLOT_BIT = VkSubgroupFeatureFlags.Ballot;
        ///<summary>Shuffle subgroup operations</summary>
        public const VkSubgroupFeatureFlags VK_SUBGROUP_FEATURE_SHUFFLE_BIT = VkSubgroupFeatureFlags.Shuffle;
        ///<summary>Shuffle relative subgroup operations</summary>
        public const VkSubgroupFeatureFlags VK_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT = VkSubgroupFeatureFlags.ShuffleRelative;
        ///<summary>Clustered subgroup operations</summary>
        public const VkSubgroupFeatureFlags VK_SUBGROUP_FEATURE_CLUSTERED_BIT = VkSubgroupFeatureFlags.Clustered;
        ///<summary>Quad subgroup operations</summary>
        public const VkSubgroupFeatureFlags VK_SUBGROUP_FEATURE_QUAD_BIT = VkSubgroupFeatureFlags.Quad;
        public const VkSubgroupFeatureFlags VK_SUBGROUP_FEATURE_PARTITIONED_BIT_NV = VkSubgroupFeatureFlags.PartitionedNV;
    }

    [Flags]
    public enum VkIndirectCommandsLayoutUsageFlagsNV : int
    {
        None = 0,
        ExplicitPreprocessNV = 1,
        IndexedSequencesNV = 2,
        UnorderedSequencesNV = 4,
    }
    public static partial class RawConstants
    {
        public const VkIndirectCommandsLayoutUsageFlagsNV VK_INDIRECT_COMMANDS_LAYOUT_USAGE_EXPLICIT_PREPROCESS_BIT_NV = VkIndirectCommandsLayoutUsageFlagsNV.ExplicitPreprocessNV;
        public const VkIndirectCommandsLayoutUsageFlagsNV VK_INDIRECT_COMMANDS_LAYOUT_USAGE_INDEXED_SEQUENCES_BIT_NV = VkIndirectCommandsLayoutUsageFlagsNV.IndexedSequencesNV;
        public const VkIndirectCommandsLayoutUsageFlagsNV VK_INDIRECT_COMMANDS_LAYOUT_USAGE_UNORDERED_SEQUENCES_BIT_NV = VkIndirectCommandsLayoutUsageFlagsNV.UnorderedSequencesNV;
    }

    [Flags]
    public enum VkIndirectStateFlagsNV : int
    {
        None = 0,
        FlagFrontfaceNV = 1,
    }
    public static partial class RawConstants
    {
        public const VkIndirectStateFlagsNV VK_INDIRECT_STATE_FLAG_FRONTFACE_BIT_NV = VkIndirectStateFlagsNV.FlagFrontfaceNV;
    }

    public enum VkIndirectCommandsTokenTypeNV : int
    {
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_SHADER_GROUP_NV = 0,
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_STATE_FLAGS_NV = 1,
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_NV = 2,
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_VERTEX_BUFFER_NV = 3,
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_CONSTANT_NV = 4,
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_NV = 5,
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_NV = 6,
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_TASKS_NV = 7,
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_NV = 1000328000,
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_PIPELINE_NV = 1000428003,
        VK_INDIRECT_COMMANDS_TOKEN_TYPE_DISPATCH_NV = 1000428004,
    }
    public static partial class RawConstants
    {
        public const VkIndirectCommandsTokenTypeNV VK_INDIRECT_COMMANDS_TOKEN_TYPE_SHADER_GROUP_NV = VkIndirectCommandsTokenTypeNV.VK_INDIRECT_COMMANDS_TOKEN_TYPE_SHADER_GROUP_NV;
        public const VkIndirectCommandsTokenTypeNV VK_INDIRECT_COMMANDS_TOKEN_TYPE_STATE_FLAGS_NV = VkIndirectCommandsTokenTypeNV.VK_INDIRECT_COMMANDS_TOKEN_TYPE_STATE_FLAGS_NV;
        public const VkIndirectCommandsTokenTypeNV VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_NV = VkIndirectCommandsTokenTypeNV.VK_INDIRECT_COMMANDS_TOKEN_TYPE_INDEX_BUFFER_NV;
        public const VkIndirectCommandsTokenTypeNV VK_INDIRECT_COMMANDS_TOKEN_TYPE_VERTEX_BUFFER_NV = VkIndirectCommandsTokenTypeNV.VK_INDIRECT_COMMANDS_TOKEN_TYPE_VERTEX_BUFFER_NV;
        public const VkIndirectCommandsTokenTypeNV VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_CONSTANT_NV = VkIndirectCommandsTokenTypeNV.VK_INDIRECT_COMMANDS_TOKEN_TYPE_PUSH_CONSTANT_NV;
        public const VkIndirectCommandsTokenTypeNV VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_NV = VkIndirectCommandsTokenTypeNV.VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_INDEXED_NV;
        public const VkIndirectCommandsTokenTypeNV VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_NV = VkIndirectCommandsTokenTypeNV.VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_NV;
        public const VkIndirectCommandsTokenTypeNV VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_TASKS_NV = VkIndirectCommandsTokenTypeNV.VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_TASKS_NV;
        public const VkIndirectCommandsTokenTypeNV VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_NV = VkIndirectCommandsTokenTypeNV.VK_INDIRECT_COMMANDS_TOKEN_TYPE_DRAW_MESH_TASKS_NV;
        public const VkIndirectCommandsTokenTypeNV VK_INDIRECT_COMMANDS_TOKEN_TYPE_PIPELINE_NV = VkIndirectCommandsTokenTypeNV.VK_INDIRECT_COMMANDS_TOKEN_TYPE_PIPELINE_NV;
        public const VkIndirectCommandsTokenTypeNV VK_INDIRECT_COMMANDS_TOKEN_TYPE_DISPATCH_NV = VkIndirectCommandsTokenTypeNV.VK_INDIRECT_COMMANDS_TOKEN_TYPE_DISPATCH_NV;
    }

    [Flags]
    public enum VkPrivateDataSlotCreateFlagBits : int
    {
        None = 0,
        Reserved0NV = 1,
    }
    public static partial class RawConstants
    {
        public const VkPrivateDataSlotCreateFlagBits VK_PRIVATE_DATA_SLOT_CREATE_RESERVED_0_BIT_NV = VkPrivateDataSlotCreateFlagBits.Reserved0NV;
    }

    [Flags]
    public enum VkDescriptorSetLayoutCreateFlags : int
    {
        None = 0,
        UpdateAfterBindPool = 2,
        PushDescriptorKHR = 1,
        DescriptorBufferEXT = 16,
        EmbeddedImmutableSamplersEXT = 32,
        Reserved3AMD = 8,
        IndirectBindableNV = 128,
        HostOnlyPoolEXT = 4,
        Reserved6EXT = 64,
    }
    public static partial class RawConstants
    {
        public const VkDescriptorSetLayoutCreateFlags VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT = VkDescriptorSetLayoutCreateFlags.UpdateAfterBindPool;
        public const VkDescriptorSetLayoutCreateFlags VK_DESCRIPTOR_SET_LAYOUT_CREATE_PUSH_DESCRIPTOR_BIT_KHR = VkDescriptorSetLayoutCreateFlags.PushDescriptorKHR;
        public const VkDescriptorSetLayoutCreateFlags VK_DESCRIPTOR_SET_LAYOUT_CREATE_DESCRIPTOR_BUFFER_BIT_EXT = VkDescriptorSetLayoutCreateFlags.DescriptorBufferEXT;
        public const VkDescriptorSetLayoutCreateFlags VK_DESCRIPTOR_SET_LAYOUT_CREATE_EMBEDDED_IMMUTABLE_SAMPLERS_BIT_EXT = VkDescriptorSetLayoutCreateFlags.EmbeddedImmutableSamplersEXT;
        public const VkDescriptorSetLayoutCreateFlags VK_DESCRIPTOR_SET_LAYOUT_CREATE_RESERVED_3_BIT_AMD = VkDescriptorSetLayoutCreateFlags.Reserved3AMD;
        public const VkDescriptorSetLayoutCreateFlags VK_DESCRIPTOR_SET_LAYOUT_CREATE_INDIRECT_BINDABLE_BIT_NV = VkDescriptorSetLayoutCreateFlags.IndirectBindableNV;
        public const VkDescriptorSetLayoutCreateFlags VK_DESCRIPTOR_SET_LAYOUT_CREATE_HOST_ONLY_POOL_BIT_EXT = VkDescriptorSetLayoutCreateFlags.HostOnlyPoolEXT;
        public const VkDescriptorSetLayoutCreateFlags VK_DESCRIPTOR_SET_LAYOUT_CREATE_RESERVED_6_BIT_EXT = VkDescriptorSetLayoutCreateFlags.Reserved6EXT;
    }

    [Flags]
    public enum VkExternalMemoryHandleTypeFlags : int
    {
        None = 0,
        OpaqueFd = 1,
        OpaqueWin32 = 2,
        OpaqueWin32Kmt = 4,
        D3d11Texture = 8,
        D3d11TextureKmt = 16,
        D3d12Heap = 32,
        D3d12Resource = 64,
        DmaBufEXT = 512,
        AndroidHardwareBufferAndroid = 1024,
        HostAllocationEXT = 128,
        HostMappedForeignMemoryEXT = 256,
        ZirconVmoFuchsia = 2048,
        RdmaAddressNV = 4096,
        SciBufNV = 8192,
        ScreenBufferQnx = 16384,
    }
    public static partial class RawConstants
    {
        public const VkExternalMemoryHandleTypeFlags VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_FD_BIT = VkExternalMemoryHandleTypeFlags.OpaqueFd;
        public const VkExternalMemoryHandleTypeFlags VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT = VkExternalMemoryHandleTypeFlags.OpaqueWin32;
        public const VkExternalMemoryHandleTypeFlags VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT = VkExternalMemoryHandleTypeFlags.OpaqueWin32Kmt;
        public const VkExternalMemoryHandleTypeFlags VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_BIT = VkExternalMemoryHandleTypeFlags.D3d11Texture;
        public const VkExternalMemoryHandleTypeFlags VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_TEXTURE_KMT_BIT = VkExternalMemoryHandleTypeFlags.D3d11TextureKmt;
        public const VkExternalMemoryHandleTypeFlags VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_HEAP_BIT = VkExternalMemoryHandleTypeFlags.D3d12Heap;
        public const VkExternalMemoryHandleTypeFlags VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D12_RESOURCE_BIT = VkExternalMemoryHandleTypeFlags.D3d12Resource;
        public const VkExternalMemoryHandleTypeFlags VK_EXTERNAL_MEMORY_HANDLE_TYPE_DMA_BUF_BIT_EXT = VkExternalMemoryHandleTypeFlags.DmaBufEXT;
        public const VkExternalMemoryHandleTypeFlags VK_EXTERNAL_MEMORY_HANDLE_TYPE_ANDROID_HARDWARE_BUFFER_BIT_ANDROID = VkExternalMemoryHandleTypeFlags.AndroidHardwareBufferAndroid;
        public const VkExternalMemoryHandleTypeFlags VK_EXTERNAL_MEMORY_HANDLE_TYPE_HOST_ALLOCATION_BIT_EXT = VkExternalMemoryHandleTypeFlags.HostAllocationEXT;
        public const VkExternalMemoryHandleTypeFlags VK_EXTERNAL_MEMORY_HANDLE_TYPE_HOST_MAPPED_FOREIGN_MEMORY_BIT_EXT = VkExternalMemoryHandleTypeFlags.HostMappedForeignMemoryEXT;
        public const VkExternalMemoryHandleTypeFlags VK_EXTERNAL_MEMORY_HANDLE_TYPE_ZIRCON_VMO_BIT_FUCHSIA = VkExternalMemoryHandleTypeFlags.ZirconVmoFuchsia;
        public const VkExternalMemoryHandleTypeFlags VK_EXTERNAL_MEMORY_HANDLE_TYPE_RDMA_ADDRESS_BIT_NV = VkExternalMemoryHandleTypeFlags.RdmaAddressNV;
        public const VkExternalMemoryHandleTypeFlags VK_EXTERNAL_MEMORY_HANDLE_TYPE_SCI_BUF_BIT_NV = VkExternalMemoryHandleTypeFlags.SciBufNV;
        public const VkExternalMemoryHandleTypeFlags VK_EXTERNAL_MEMORY_HANDLE_TYPE_SCREEN_BUFFER_BIT_QNX = VkExternalMemoryHandleTypeFlags.ScreenBufferQnx;
    }

    [Flags]
    public enum VkExternalMemoryFeatureFlags : int
    {
        None = 0,
        DedicatedOnly = 1,
        Exportable = 2,
        Importable = 4,
    }
    public static partial class RawConstants
    {
        public const VkExternalMemoryFeatureFlags VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT = VkExternalMemoryFeatureFlags.DedicatedOnly;
        public const VkExternalMemoryFeatureFlags VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT = VkExternalMemoryFeatureFlags.Exportable;
        public const VkExternalMemoryFeatureFlags VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT = VkExternalMemoryFeatureFlags.Importable;
    }

    [Flags]
    public enum VkExternalSemaphoreHandleTypeFlags : int
    {
        None = 0,
        OpaqueFd = 1,
        OpaqueWin32 = 2,
        OpaqueWin32Kmt = 4,
        D3d12Fence = 8,
        SyncFd = 16,
        ZirconEventFuchsia = 128,
        SciSyncObjNV = 32,
    }
    public static partial class RawConstants
    {
        public const VkExternalSemaphoreHandleTypeFlags VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_FD_BIT = VkExternalSemaphoreHandleTypeFlags.OpaqueFd;
        public const VkExternalSemaphoreHandleTypeFlags VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_BIT = VkExternalSemaphoreHandleTypeFlags.OpaqueWin32;
        public const VkExternalSemaphoreHandleTypeFlags VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT = VkExternalSemaphoreHandleTypeFlags.OpaqueWin32Kmt;
        public const VkExternalSemaphoreHandleTypeFlags VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_D3D12_FENCE_BIT = VkExternalSemaphoreHandleTypeFlags.D3d12Fence;
        public const VkExternalSemaphoreHandleTypeFlags VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_SYNC_FD_BIT = VkExternalSemaphoreHandleTypeFlags.SyncFd;
        public const VkExternalSemaphoreHandleTypeFlags VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_ZIRCON_EVENT_BIT_FUCHSIA = VkExternalSemaphoreHandleTypeFlags.ZirconEventFuchsia;
        public const VkExternalSemaphoreHandleTypeFlags VK_EXTERNAL_SEMAPHORE_HANDLE_TYPE_SCI_SYNC_OBJ_BIT_NV = VkExternalSemaphoreHandleTypeFlags.SciSyncObjNV;
    }

    [Flags]
    public enum VkExternalSemaphoreFeatureFlags : int
    {
        None = 0,
        Exportable = 1,
        Importable = 2,
    }
    public static partial class RawConstants
    {
        public const VkExternalSemaphoreFeatureFlags VK_EXTERNAL_SEMAPHORE_FEATURE_EXPORTABLE_BIT = VkExternalSemaphoreFeatureFlags.Exportable;
        public const VkExternalSemaphoreFeatureFlags VK_EXTERNAL_SEMAPHORE_FEATURE_IMPORTABLE_BIT = VkExternalSemaphoreFeatureFlags.Importable;
    }

    [Flags]
    public enum VkSemaphoreImportFlags : int
    {
        None = 0,
        Temporary = 1,
    }
    public static partial class RawConstants
    {
        public const VkSemaphoreImportFlags VK_SEMAPHORE_IMPORT_TEMPORARY_BIT = VkSemaphoreImportFlags.Temporary;
    }

    [Flags]
    public enum VkExternalFenceHandleTypeFlags : int
    {
        None = 0,
        OpaqueFd = 1,
        OpaqueWin32 = 2,
        OpaqueWin32Kmt = 4,
        SyncFd = 8,
        SciSyncObjNV = 16,
        SciSyncFenceNV = 32,
    }
    public static partial class RawConstants
    {
        public const VkExternalFenceHandleTypeFlags VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_FD_BIT = VkExternalFenceHandleTypeFlags.OpaqueFd;
        public const VkExternalFenceHandleTypeFlags VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_BIT = VkExternalFenceHandleTypeFlags.OpaqueWin32;
        public const VkExternalFenceHandleTypeFlags VK_EXTERNAL_FENCE_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT = VkExternalFenceHandleTypeFlags.OpaqueWin32Kmt;
        public const VkExternalFenceHandleTypeFlags VK_EXTERNAL_FENCE_HANDLE_TYPE_SYNC_FD_BIT = VkExternalFenceHandleTypeFlags.SyncFd;
        public const VkExternalFenceHandleTypeFlags VK_EXTERNAL_FENCE_HANDLE_TYPE_SCI_SYNC_OBJ_BIT_NV = VkExternalFenceHandleTypeFlags.SciSyncObjNV;
        public const VkExternalFenceHandleTypeFlags VK_EXTERNAL_FENCE_HANDLE_TYPE_SCI_SYNC_FENCE_BIT_NV = VkExternalFenceHandleTypeFlags.SciSyncFenceNV;
    }

    [Flags]
    public enum VkExternalFenceFeatureFlags : int
    {
        None = 0,
        Exportable = 1,
        Importable = 2,
    }
    public static partial class RawConstants
    {
        public const VkExternalFenceFeatureFlags VK_EXTERNAL_FENCE_FEATURE_EXPORTABLE_BIT = VkExternalFenceFeatureFlags.Exportable;
        public const VkExternalFenceFeatureFlags VK_EXTERNAL_FENCE_FEATURE_IMPORTABLE_BIT = VkExternalFenceFeatureFlags.Importable;
    }

    [Flags]
    public enum VkFenceImportFlags : int
    {
        None = 0,
        Temporary = 1,
    }
    public static partial class RawConstants
    {
        public const VkFenceImportFlags VK_FENCE_IMPORT_TEMPORARY_BIT = VkFenceImportFlags.Temporary;
    }

    [Flags]
    public enum VkSurfaceCounterFlagsEXT : int
    {
        None = 0,
        VblankEXT = 1,
    }
    public static partial class RawConstants
    {
        public const VkSurfaceCounterFlagsEXT VK_SURFACE_COUNTER_VBLANK_BIT_EXT = VkSurfaceCounterFlagsEXT.VblankEXT;
    }

    public enum VkDisplayPowerStateEXT : int
    {
        OffEXT = 0,
        SuspendEXT = 1,
        OnEXT = 2,
    }
    public static partial class RawConstants
    {
        public const VkDisplayPowerStateEXT VK_DISPLAY_POWER_STATE_OFF_EXT = VkDisplayPowerStateEXT.OffEXT;
        public const VkDisplayPowerStateEXT VK_DISPLAY_POWER_STATE_SUSPEND_EXT = VkDisplayPowerStateEXT.SuspendEXT;
        public const VkDisplayPowerStateEXT VK_DISPLAY_POWER_STATE_ON_EXT = VkDisplayPowerStateEXT.OnEXT;
    }

    public enum VkDeviceEventTypeEXT : int
    {
        DisplayHotplugEXT = 0,
    }
    public static partial class RawConstants
    {
        public const VkDeviceEventTypeEXT VK_DEVICE_EVENT_TYPE_DISPLAY_HOTPLUG_EXT = VkDeviceEventTypeEXT.DisplayHotplugEXT;
    }

    public enum VkDisplayEventTypeEXT : int
    {
        FirstPixelOutEXT = 0,
    }
    public static partial class RawConstants
    {
        public const VkDisplayEventTypeEXT VK_DISPLAY_EVENT_TYPE_FIRST_PIXEL_OUT_EXT = VkDisplayEventTypeEXT.FirstPixelOutEXT;
    }

    [Flags]
    public enum VkPeerMemoryFeatureFlags : int
    {
        None = 0,
        ///<summary>Can read with vkCmdCopy commands</summary>
        CopySrc = 1,
        ///<summary>Can write with vkCmdCopy commands</summary>
        CopyDst = 2,
        ///<summary>Can read with any access type/command</summary>
        GenericSrc = 4,
        ///<summary>Can write with and access type/command</summary>
        GenericDst = 8,
    }
    public static partial class RawConstants
    {
        ///<summary>Can read with vkCmdCopy commands</summary>
        public const VkPeerMemoryFeatureFlags VK_PEER_MEMORY_FEATURE_COPY_SRC_BIT = VkPeerMemoryFeatureFlags.CopySrc;
        ///<summary>Can write with vkCmdCopy commands</summary>
        public const VkPeerMemoryFeatureFlags VK_PEER_MEMORY_FEATURE_COPY_DST_BIT = VkPeerMemoryFeatureFlags.CopyDst;
        ///<summary>Can read with any access type/command</summary>
        public const VkPeerMemoryFeatureFlags VK_PEER_MEMORY_FEATURE_GENERIC_SRC_BIT = VkPeerMemoryFeatureFlags.GenericSrc;
        ///<summary>Can write with and access type/command</summary>
        public const VkPeerMemoryFeatureFlags VK_PEER_MEMORY_FEATURE_GENERIC_DST_BIT = VkPeerMemoryFeatureFlags.GenericDst;
    }

    [Flags]
    public enum VkMemoryAllocateFlags : int
    {
        None = 0,
        ///<summary>Force allocation on specific devices</summary>
        DeviceMask = 1,
        DeviceAddress = 2,
        DeviceAddressCaptureReplay = 4,
    }
    public static partial class RawConstants
    {
        ///<summary>Force allocation on specific devices</summary>
        public const VkMemoryAllocateFlags VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT = VkMemoryAllocateFlags.DeviceMask;
        public const VkMemoryAllocateFlags VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT = VkMemoryAllocateFlags.DeviceAddress;
        public const VkMemoryAllocateFlags VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT = VkMemoryAllocateFlags.DeviceAddressCaptureReplay;
    }

    [Flags]
    public enum VkDeviceGroupPresentModeFlagsKHR : int
    {
        None = 0,
        ///<summary>Present from local memory</summary>
        LocalKHR = 1,
        ///<summary>Present from remote memory</summary>
        RemoteKHR = 2,
        ///<summary>Present sum of local and/or remote memory</summary>
        SumKHR = 4,
        ///<summary>Each physical device presents from local memory</summary>
        LocalMultiDeviceKHR = 8,
    }
    public static partial class RawConstants
    {
        ///<summary>Present from local memory</summary>
        public const VkDeviceGroupPresentModeFlagsKHR VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_BIT_KHR = VkDeviceGroupPresentModeFlagsKHR.LocalKHR;
        ///<summary>Present from remote memory</summary>
        public const VkDeviceGroupPresentModeFlagsKHR VK_DEVICE_GROUP_PRESENT_MODE_REMOTE_BIT_KHR = VkDeviceGroupPresentModeFlagsKHR.RemoteKHR;
        ///<summary>Present sum of local and/or remote memory</summary>
        public const VkDeviceGroupPresentModeFlagsKHR VK_DEVICE_GROUP_PRESENT_MODE_SUM_BIT_KHR = VkDeviceGroupPresentModeFlagsKHR.SumKHR;
        ///<summary>Each physical device presents from local memory</summary>
        public const VkDeviceGroupPresentModeFlagsKHR VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_MULTI_DEVICE_BIT_KHR = VkDeviceGroupPresentModeFlagsKHR.LocalMultiDeviceKHR;
    }

    [Flags]
    public enum VkSwapchainCreateFlagsKHR : int
    {
        None = 0,
        SplitInstanceBindRegionsKHR = 1,
        ProtectedKHR = 2,
        MutableFormatKHR = 4,
        DeferredMemoryAllocationEXT = 8,
        Reserved4EXT = 16,
    }
    public static partial class RawConstants
    {
        public const VkSwapchainCreateFlagsKHR VK_SWAPCHAIN_CREATE_SPLIT_INSTANCE_BIND_REGIONS_BIT_KHR = VkSwapchainCreateFlagsKHR.SplitInstanceBindRegionsKHR;
        public const VkSwapchainCreateFlagsKHR VK_SWAPCHAIN_CREATE_PROTECTED_BIT_KHR = VkSwapchainCreateFlagsKHR.ProtectedKHR;
        public const VkSwapchainCreateFlagsKHR VK_SWAPCHAIN_CREATE_MUTABLE_FORMAT_BIT_KHR = VkSwapchainCreateFlagsKHR.MutableFormatKHR;
        public const VkSwapchainCreateFlagsKHR VK_SWAPCHAIN_CREATE_DEFERRED_MEMORY_ALLOCATION_BIT_EXT = VkSwapchainCreateFlagsKHR.DeferredMemoryAllocationEXT;
        public const VkSwapchainCreateFlagsKHR VK_SWAPCHAIN_CREATE_RESERVED_4_BIT_EXT = VkSwapchainCreateFlagsKHR.Reserved4EXT;
    }

    public enum VkViewportCoordinateSwizzleNV : int
    {
        VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_X_NV = 0,
        VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_X_NV = 1,
        VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Y_NV = 2,
        VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Y_NV = 3,
        VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Z_NV = 4,
        VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Z_NV = 5,
        VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_W_NV = 6,
        VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_W_NV = 7,
    }
    public static partial class RawConstants
    {
        public const VkViewportCoordinateSwizzleNV VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_X_NV = VkViewportCoordinateSwizzleNV.VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_X_NV;
        public const VkViewportCoordinateSwizzleNV VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_X_NV = VkViewportCoordinateSwizzleNV.VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_X_NV;
        public const VkViewportCoordinateSwizzleNV VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Y_NV = VkViewportCoordinateSwizzleNV.VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Y_NV;
        public const VkViewportCoordinateSwizzleNV VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Y_NV = VkViewportCoordinateSwizzleNV.VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Y_NV;
        public const VkViewportCoordinateSwizzleNV VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Z_NV = VkViewportCoordinateSwizzleNV.VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Z_NV;
        public const VkViewportCoordinateSwizzleNV VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Z_NV = VkViewportCoordinateSwizzleNV.VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Z_NV;
        public const VkViewportCoordinateSwizzleNV VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_W_NV = VkViewportCoordinateSwizzleNV.VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_W_NV;
        public const VkViewportCoordinateSwizzleNV VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_W_NV = VkViewportCoordinateSwizzleNV.VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_W_NV;
    }

    public enum VkDiscardRectangleModeEXT : int
    {
        InclusiveEXT = 0,
        ExclusiveEXT = 1,
    }
    public static partial class RawConstants
    {
        public const VkDiscardRectangleModeEXT VK_DISCARD_RECTANGLE_MODE_INCLUSIVE_EXT = VkDiscardRectangleModeEXT.InclusiveEXT;
        public const VkDiscardRectangleModeEXT VK_DISCARD_RECTANGLE_MODE_EXCLUSIVE_EXT = VkDiscardRectangleModeEXT.ExclusiveEXT;
    }

    [Flags]
    public enum VkSubpassDescriptionFlags : int
    {
        None = 0,
        PerViewAttributesNVX = 1,
        PerViewPositionXOnlyNVX = 2,
        FragmentRegionQcom = 4,
        ShaderResolveQcom = 8,
        RasterizationOrderAttachmentColorAccessEXT = 16,
        RasterizationOrderAttachmentDepthAccessEXT = 32,
        RasterizationOrderAttachmentStencilAccessEXT = 64,
        EnableLegacyDitheringEXT = 128,
    }
    public static partial class RawConstants
    {
        public const VkSubpassDescriptionFlags VK_SUBPASS_DESCRIPTION_PER_VIEW_ATTRIBUTES_BIT_NVX = VkSubpassDescriptionFlags.PerViewAttributesNVX;
        public const VkSubpassDescriptionFlags VK_SUBPASS_DESCRIPTION_PER_VIEW_POSITION_X_ONLY_BIT_NVX = VkSubpassDescriptionFlags.PerViewPositionXOnlyNVX;
        public const VkSubpassDescriptionFlags VK_SUBPASS_DESCRIPTION_FRAGMENT_REGION_BIT_QCOM = VkSubpassDescriptionFlags.FragmentRegionQcom;
        public const VkSubpassDescriptionFlags VK_SUBPASS_DESCRIPTION_SHADER_RESOLVE_BIT_QCOM = VkSubpassDescriptionFlags.ShaderResolveQcom;
        public const VkSubpassDescriptionFlags VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_COLOR_ACCESS_BIT_EXT = VkSubpassDescriptionFlags.RasterizationOrderAttachmentColorAccessEXT;
        public const VkSubpassDescriptionFlags VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_EXT = VkSubpassDescriptionFlags.RasterizationOrderAttachmentDepthAccessEXT;
        public const VkSubpassDescriptionFlags VK_SUBPASS_DESCRIPTION_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_EXT = VkSubpassDescriptionFlags.RasterizationOrderAttachmentStencilAccessEXT;
        public const VkSubpassDescriptionFlags VK_SUBPASS_DESCRIPTION_ENABLE_LEGACY_DITHERING_BIT_EXT = VkSubpassDescriptionFlags.EnableLegacyDitheringEXT;
    }

    public enum VkPointClippingBehavior : int
    {
        AllClipPlanes = 0,
        UserClipPlanesOnly = 1,
    }
    public static partial class RawConstants
    {
        public const VkPointClippingBehavior VK_POINT_CLIPPING_BEHAVIOR_ALL_CLIP_PLANES = VkPointClippingBehavior.AllClipPlanes;
        public const VkPointClippingBehavior VK_POINT_CLIPPING_BEHAVIOR_USER_CLIP_PLANES_ONLY = VkPointClippingBehavior.UserClipPlanesOnly;
    }

    public enum VkSamplerReductionMode : int
    {
        WeightedAverage = 0,
        Min = 1,
        Max = 2,
        WeightedAverageRangeclampQcom = 1000521000,
    }
    public static partial class RawConstants
    {
        public const VkSamplerReductionMode VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE = VkSamplerReductionMode.WeightedAverage;
        public const VkSamplerReductionMode VK_SAMPLER_REDUCTION_MODE_MIN = VkSamplerReductionMode.Min;
        public const VkSamplerReductionMode VK_SAMPLER_REDUCTION_MODE_MAX = VkSamplerReductionMode.Max;
        public const VkSamplerReductionMode VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE_RANGECLAMP_QCOM = VkSamplerReductionMode.WeightedAverageRangeclampQcom;
    }

    public enum VkTessellationDomainOrigin : int
    {
        UpperLeft = 0,
        LowerLeft = 1,
    }
    public static partial class RawConstants
    {
        public const VkTessellationDomainOrigin VK_TESSELLATION_DOMAIN_ORIGIN_UPPER_LEFT = VkTessellationDomainOrigin.UpperLeft;
        public const VkTessellationDomainOrigin VK_TESSELLATION_DOMAIN_ORIGIN_LOWER_LEFT = VkTessellationDomainOrigin.LowerLeft;
    }

    public enum VkSamplerYcbcrModelConversion : int
    {
        RgbIdentity = 0,
        ///<summary>just range expansion</summary>
        YcbcrIdentity = 1,
        ///<summary>aka HD YUV</summary>
        Ycbcr709 = 2,
        ///<summary>aka SD YUV</summary>
        Ycbcr601 = 3,
        ///<summary>aka UHD YUV</summary>
        Ycbcr2020 = 4,
    }
    public static partial class RawConstants
    {
        public const VkSamplerYcbcrModelConversion VK_SAMPLER_YCBCR_MODEL_CONVERSION_RGB_IDENTITY = VkSamplerYcbcrModelConversion.RgbIdentity;
        ///<summary>just range expansion</summary>
        public const VkSamplerYcbcrModelConversion VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_IDENTITY = VkSamplerYcbcrModelConversion.YcbcrIdentity;
        ///<summary>aka HD YUV</summary>
        public const VkSamplerYcbcrModelConversion VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_709 = VkSamplerYcbcrModelConversion.Ycbcr709;
        ///<summary>aka SD YUV</summary>
        public const VkSamplerYcbcrModelConversion VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_601 = VkSamplerYcbcrModelConversion.Ycbcr601;
        ///<summary>aka UHD YUV</summary>
        public const VkSamplerYcbcrModelConversion VK_SAMPLER_YCBCR_MODEL_CONVERSION_YCBCR_2020 = VkSamplerYcbcrModelConversion.Ycbcr2020;
    }

    public enum VkSamplerYcbcrRange : int
    {
        ///<summary>Luma 0..1 maps to 0..255, chroma -0.5..0.5 to 1..255 (clamped)</summary>
        ItuFull = 0,
        ///<summary>Luma 0..1 maps to 16..235, chroma -0.5..0.5 to 16..240</summary>
        ItuNarrow = 1,
    }
    public static partial class RawConstants
    {
        ///<summary>Luma 0..1 maps to 0..255, chroma -0.5..0.5 to 1..255 (clamped)</summary>
        public const VkSamplerYcbcrRange VK_SAMPLER_YCBCR_RANGE_ITU_FULL = VkSamplerYcbcrRange.ItuFull;
        ///<summary>Luma 0..1 maps to 16..235, chroma -0.5..0.5 to 16..240</summary>
        public const VkSamplerYcbcrRange VK_SAMPLER_YCBCR_RANGE_ITU_NARROW = VkSamplerYcbcrRange.ItuNarrow;
    }

    public enum VkChromaLocation : int
    {
        CositedEven = 0,
        Midpoint = 1,
    }
    public static partial class RawConstants
    {
        public const VkChromaLocation VK_CHROMA_LOCATION_COSITED_EVEN = VkChromaLocation.CositedEven;
        public const VkChromaLocation VK_CHROMA_LOCATION_MIDPOINT = VkChromaLocation.Midpoint;
    }

    public enum VkBlendOverlapEXT : int
    {
        UncorrelatedEXT = 0,
        DisjointEXT = 1,
        ConjointEXT = 2,
    }
    public static partial class RawConstants
    {
        public const VkBlendOverlapEXT VK_BLEND_OVERLAP_UNCORRELATED_EXT = VkBlendOverlapEXT.UncorrelatedEXT;
        public const VkBlendOverlapEXT VK_BLEND_OVERLAP_DISJOINT_EXT = VkBlendOverlapEXT.DisjointEXT;
        public const VkBlendOverlapEXT VK_BLEND_OVERLAP_CONJOINT_EXT = VkBlendOverlapEXT.ConjointEXT;
    }

    public enum VkCoverageModulationModeNV : int
    {
        VK_COVERAGE_MODULATION_MODE_NONE_NV = 0,
        VK_COVERAGE_MODULATION_MODE_RGB_NV = 1,
        VK_COVERAGE_MODULATION_MODE_ALPHA_NV = 2,
        VK_COVERAGE_MODULATION_MODE_RGBA_NV = 3,
    }
    public static partial class RawConstants
    {
        public const VkCoverageModulationModeNV VK_COVERAGE_MODULATION_MODE_NONE_NV = VkCoverageModulationModeNV.VK_COVERAGE_MODULATION_MODE_NONE_NV;
        public const VkCoverageModulationModeNV VK_COVERAGE_MODULATION_MODE_RGB_NV = VkCoverageModulationModeNV.VK_COVERAGE_MODULATION_MODE_RGB_NV;
        public const VkCoverageModulationModeNV VK_COVERAGE_MODULATION_MODE_ALPHA_NV = VkCoverageModulationModeNV.VK_COVERAGE_MODULATION_MODE_ALPHA_NV;
        public const VkCoverageModulationModeNV VK_COVERAGE_MODULATION_MODE_RGBA_NV = VkCoverageModulationModeNV.VK_COVERAGE_MODULATION_MODE_RGBA_NV;
    }

    public enum VkCoverageReductionModeNV : int
    {
        VK_COVERAGE_REDUCTION_MODE_MERGE_NV = 0,
        VK_COVERAGE_REDUCTION_MODE_TRUNCATE_NV = 1,
    }
    public static partial class RawConstants
    {
        public const VkCoverageReductionModeNV VK_COVERAGE_REDUCTION_MODE_MERGE_NV = VkCoverageReductionModeNV.VK_COVERAGE_REDUCTION_MODE_MERGE_NV;
        public const VkCoverageReductionModeNV VK_COVERAGE_REDUCTION_MODE_TRUNCATE_NV = VkCoverageReductionModeNV.VK_COVERAGE_REDUCTION_MODE_TRUNCATE_NV;
    }

    public enum VkValidationCacheHeaderVersionEXT : int
    {
        OneEXT = 1,
    }
    public static partial class RawConstants
    {
        public const VkValidationCacheHeaderVersionEXT VK_VALIDATION_CACHE_HEADER_VERSION_ONE_EXT = VkValidationCacheHeaderVersionEXT.OneEXT;
    }

    public enum VkShaderInfoTypeAMD : int
    {
        StatisticsAMD = 0,
        BinaryAMD = 1,
        DisassemblyAMD = 2,
    }
    public static partial class RawConstants
    {
        public const VkShaderInfoTypeAMD VK_SHADER_INFO_TYPE_STATISTICS_AMD = VkShaderInfoTypeAMD.StatisticsAMD;
        public const VkShaderInfoTypeAMD VK_SHADER_INFO_TYPE_BINARY_AMD = VkShaderInfoTypeAMD.BinaryAMD;
        public const VkShaderInfoTypeAMD VK_SHADER_INFO_TYPE_DISASSEMBLY_AMD = VkShaderInfoTypeAMD.DisassemblyAMD;
    }

    public enum VkQueueGlobalPriorityKHR : int
    {
        LowKHR = 128,
        MediumKHR = 256,
        HighKHR = 512,
        RealtimeKHR = 1024,
    }
    public static partial class RawConstants
    {
        public const VkQueueGlobalPriorityKHR VK_QUEUE_GLOBAL_PRIORITY_LOW_KHR = VkQueueGlobalPriorityKHR.LowKHR;
        public const VkQueueGlobalPriorityKHR VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_KHR = VkQueueGlobalPriorityKHR.MediumKHR;
        public const VkQueueGlobalPriorityKHR VK_QUEUE_GLOBAL_PRIORITY_HIGH_KHR = VkQueueGlobalPriorityKHR.HighKHR;
        public const VkQueueGlobalPriorityKHR VK_QUEUE_GLOBAL_PRIORITY_REALTIME_KHR = VkQueueGlobalPriorityKHR.RealtimeKHR;
    }

    [Flags]
    public enum VkDebugUtilsMessageSeverityFlagsEXT : int
    {
        None = 0,
        VerboseEXT = 1,
        InfoEXT = 16,
        WarningEXT = 256,
        ErrorEXT = 4096,
    }
    public static partial class RawConstants
    {
        public const VkDebugUtilsMessageSeverityFlagsEXT VK_DEBUG_UTILS_MESSAGE_SEVERITY_VERBOSE_BIT_EXT = VkDebugUtilsMessageSeverityFlagsEXT.VerboseEXT;
        public const VkDebugUtilsMessageSeverityFlagsEXT VK_DEBUG_UTILS_MESSAGE_SEVERITY_INFO_BIT_EXT = VkDebugUtilsMessageSeverityFlagsEXT.InfoEXT;
        public const VkDebugUtilsMessageSeverityFlagsEXT VK_DEBUG_UTILS_MESSAGE_SEVERITY_WARNING_BIT_EXT = VkDebugUtilsMessageSeverityFlagsEXT.WarningEXT;
        public const VkDebugUtilsMessageSeverityFlagsEXT VK_DEBUG_UTILS_MESSAGE_SEVERITY_ERROR_BIT_EXT = VkDebugUtilsMessageSeverityFlagsEXT.ErrorEXT;
    }

    [Flags]
    public enum VkDebugUtilsMessageTypeFlagsEXT : int
    {
        None = 0,
        GeneralEXT = 1,
        ValidationEXT = 2,
        PerformanceEXT = 4,
        DeviceAddressBindingEXT = 8,
    }
    public static partial class RawConstants
    {
        public const VkDebugUtilsMessageTypeFlagsEXT VK_DEBUG_UTILS_MESSAGE_TYPE_GENERAL_BIT_EXT = VkDebugUtilsMessageTypeFlagsEXT.GeneralEXT;
        public const VkDebugUtilsMessageTypeFlagsEXT VK_DEBUG_UTILS_MESSAGE_TYPE_VALIDATION_BIT_EXT = VkDebugUtilsMessageTypeFlagsEXT.ValidationEXT;
        public const VkDebugUtilsMessageTypeFlagsEXT VK_DEBUG_UTILS_MESSAGE_TYPE_PERFORMANCE_BIT_EXT = VkDebugUtilsMessageTypeFlagsEXT.PerformanceEXT;
        public const VkDebugUtilsMessageTypeFlagsEXT VK_DEBUG_UTILS_MESSAGE_TYPE_DEVICE_ADDRESS_BINDING_BIT_EXT = VkDebugUtilsMessageTypeFlagsEXT.DeviceAddressBindingEXT;
    }

    public enum VkConservativeRasterizationModeEXT : int
    {
        DisabledEXT = 0,
        OverestimateEXT = 1,
        UnderestimateEXT = 2,
    }
    public static partial class RawConstants
    {
        public const VkConservativeRasterizationModeEXT VK_CONSERVATIVE_RASTERIZATION_MODE_DISABLED_EXT = VkConservativeRasterizationModeEXT.DisabledEXT;
        public const VkConservativeRasterizationModeEXT VK_CONSERVATIVE_RASTERIZATION_MODE_OVERESTIMATE_EXT = VkConservativeRasterizationModeEXT.OverestimateEXT;
        public const VkConservativeRasterizationModeEXT VK_CONSERVATIVE_RASTERIZATION_MODE_UNDERESTIMATE_EXT = VkConservativeRasterizationModeEXT.UnderestimateEXT;
    }

    [Flags]
    public enum VkDescriptorBindingFlags : int
    {
        None = 0,
        UpdateAfterBind = 1,
        UpdateUnusedWhilePending = 2,
        PartiallyBound = 4,
        VariableDescriptorCount = 8,
        Reserved4Qcom = 16,
    }
    public static partial class RawConstants
    {
        public const VkDescriptorBindingFlags VK_DESCRIPTOR_BINDING_UPDATE_AFTER_BIND_BIT = VkDescriptorBindingFlags.UpdateAfterBind;
        public const VkDescriptorBindingFlags VK_DESCRIPTOR_BINDING_UPDATE_UNUSED_WHILE_PENDING_BIT = VkDescriptorBindingFlags.UpdateUnusedWhilePending;
        public const VkDescriptorBindingFlags VK_DESCRIPTOR_BINDING_PARTIALLY_BOUND_BIT = VkDescriptorBindingFlags.PartiallyBound;
        public const VkDescriptorBindingFlags VK_DESCRIPTOR_BINDING_VARIABLE_DESCRIPTOR_COUNT_BIT = VkDescriptorBindingFlags.VariableDescriptorCount;
        public const VkDescriptorBindingFlags VK_DESCRIPTOR_BINDING_RESERVED_4_BIT_QCOM = VkDescriptorBindingFlags.Reserved4Qcom;
    }

    public enum VkVendorId : int
    {
        ///<summary>Vivante vendor ID</summary>
        Viv = 65537,
        ///<summary>VeriSilicon vendor ID</summary>
        Vsi = 65538,
        ///<summary>Kazan Software Renderer</summary>
        Kazan = 65539,
        ///<summary>Codeplay Software Ltd. vendor ID</summary>
        Codeplay = 65540,
        ///<summary>Mesa vendor ID</summary>
        Mesa = 65541,
        ///<summary>PoCL vendor ID</summary>
        Pocl = 65542,
        ///<summary>Mobileye vendor ID</summary>
        Mobileye = 65543,
    }
    public static partial class RawConstants
    {
        ///<summary>Vivante vendor ID</summary>
        public const VkVendorId VK_VENDOR_ID_VIV = VkVendorId.Viv;
        ///<summary>VeriSilicon vendor ID</summary>
        public const VkVendorId VK_VENDOR_ID_VSI = VkVendorId.Vsi;
        ///<summary>Kazan Software Renderer</summary>
        public const VkVendorId VK_VENDOR_ID_KAZAN = VkVendorId.Kazan;
        ///<summary>Codeplay Software Ltd. vendor ID</summary>
        public const VkVendorId VK_VENDOR_ID_CODEPLAY = VkVendorId.Codeplay;
        ///<summary>Mesa vendor ID</summary>
        public const VkVendorId VK_VENDOR_ID_MESA = VkVendorId.Mesa;
        ///<summary>PoCL vendor ID</summary>
        public const VkVendorId VK_VENDOR_ID_POCL = VkVendorId.Pocl;
        ///<summary>Mobileye vendor ID</summary>
        public const VkVendorId VK_VENDOR_ID_MOBILEYE = VkVendorId.Mobileye;
    }

    public enum VkDriverId : int
    {
        ///<summary>Advanced Micro Devices, Inc.</summary>
        AMDProprietary = 1,
        ///<summary>Advanced Micro Devices, Inc.</summary>
        AMDOpenSource = 2,
        ///<summary>Mesa open source project</summary>
        MesaRadv = 3,
        ///<summary>NVIDIA Corporation</summary>
        NvidiaProprietary = 4,
        ///<summary>Intel Corporation</summary>
        IntelProprietaryWindows = 5,
        ///<summary>Intel Corporation</summary>
        IntelOpenSourceMesa = 6,
        ///<summary>Imagination Technologies</summary>
        ImaginationProprietary = 7,
        ///<summary>Qualcomm Technologies, Inc.</summary>
        QualcommProprietary = 8,
        ///<summary>Arm Limited</summary>
        ArmProprietary = 9,
        ///<summary>Google LLC</summary>
        GoogleSwiftshader = 10,
        ///<summary>Google LLC</summary>
        GgpProprietary = 11,
        ///<summary>Broadcom Inc.</summary>
        BroadcomProprietary = 12,
        ///<summary>Mesa</summary>
        MesaLlvmpipe = 13,
        ///<summary>MoltenVK</summary>
        Moltenvk = 14,
        ///<summary>Core Avionics & Industrial Inc.</summary>
        CoreaviProprietary = 15,
        ///<summary>Juice Technologies, Inc.</summary>
        JuiceProprietary = 16,
        ///<summary>Verisilicon, Inc.</summary>
        VerisiliconProprietary = 17,
        ///<summary>Mesa open source project</summary>
        MesaTurnip = 18,
        ///<summary>Mesa open source project</summary>
        MesaV3dv = 19,
        ///<summary>Mesa open source project</summary>
        MesaPanvk = 20,
        ///<summary>Samsung Electronics Co., Ltd.</summary>
        SamsungProprietary = 21,
        ///<summary>Mesa open source project</summary>
        MesaVenus = 22,
        ///<summary>Mesa open source project</summary>
        MesaDozen = 23,
        ///<summary>Mesa open source project</summary>
        MesaNvk = 24,
        ///<summary>Imagination Technologies</summary>
        ImaginationOpenSourceMesa = 25,
        ///<summary>Mesa open source project</summary>
        MesaAgxv = 26,
    }
    public static partial class RawConstants
    {
        ///<summary>Advanced Micro Devices, Inc.</summary>
        public const VkDriverId VK_DRIVER_ID_AMD_PROPRIETARY = VkDriverId.AMDProprietary;
        ///<summary>Advanced Micro Devices, Inc.</summary>
        public const VkDriverId VK_DRIVER_ID_AMD_OPEN_SOURCE = VkDriverId.AMDOpenSource;
        ///<summary>Mesa open source project</summary>
        public const VkDriverId VK_DRIVER_ID_MESA_RADV = VkDriverId.MesaRadv;
        ///<summary>NVIDIA Corporation</summary>
        public const VkDriverId VK_DRIVER_ID_NVIDIA_PROPRIETARY = VkDriverId.NvidiaProprietary;
        ///<summary>Intel Corporation</summary>
        public const VkDriverId VK_DRIVER_ID_INTEL_PROPRIETARY_WINDOWS = VkDriverId.IntelProprietaryWindows;
        ///<summary>Intel Corporation</summary>
        public const VkDriverId VK_DRIVER_ID_INTEL_OPEN_SOURCE_MESA = VkDriverId.IntelOpenSourceMesa;
        ///<summary>Imagination Technologies</summary>
        public const VkDriverId VK_DRIVER_ID_IMAGINATION_PROPRIETARY = VkDriverId.ImaginationProprietary;
        ///<summary>Qualcomm Technologies, Inc.</summary>
        public const VkDriverId VK_DRIVER_ID_QUALCOMM_PROPRIETARY = VkDriverId.QualcommProprietary;
        ///<summary>Arm Limited</summary>
        public const VkDriverId VK_DRIVER_ID_ARM_PROPRIETARY = VkDriverId.ArmProprietary;
        ///<summary>Google LLC</summary>
        public const VkDriverId VK_DRIVER_ID_GOOGLE_SWIFTSHADER = VkDriverId.GoogleSwiftshader;
        ///<summary>Google LLC</summary>
        public const VkDriverId VK_DRIVER_ID_GGP_PROPRIETARY = VkDriverId.GgpProprietary;
        ///<summary>Broadcom Inc.</summary>
        public const VkDriverId VK_DRIVER_ID_BROADCOM_PROPRIETARY = VkDriverId.BroadcomProprietary;
        ///<summary>Mesa</summary>
        public const VkDriverId VK_DRIVER_ID_MESA_LLVMPIPE = VkDriverId.MesaLlvmpipe;
        ///<summary>MoltenVK</summary>
        public const VkDriverId VK_DRIVER_ID_MOLTENVK = VkDriverId.Moltenvk;
        ///<summary>Core Avionics & Industrial Inc.</summary>
        public const VkDriverId VK_DRIVER_ID_COREAVI_PROPRIETARY = VkDriverId.CoreaviProprietary;
        ///<summary>Juice Technologies, Inc.</summary>
        public const VkDriverId VK_DRIVER_ID_JUICE_PROPRIETARY = VkDriverId.JuiceProprietary;
        ///<summary>Verisilicon, Inc.</summary>
        public const VkDriverId VK_DRIVER_ID_VERISILICON_PROPRIETARY = VkDriverId.VerisiliconProprietary;
        ///<summary>Mesa open source project</summary>
        public const VkDriverId VK_DRIVER_ID_MESA_TURNIP = VkDriverId.MesaTurnip;
        ///<summary>Mesa open source project</summary>
        public const VkDriverId VK_DRIVER_ID_MESA_V3DV = VkDriverId.MesaV3dv;
        ///<summary>Mesa open source project</summary>
        public const VkDriverId VK_DRIVER_ID_MESA_PANVK = VkDriverId.MesaPanvk;
        ///<summary>Samsung Electronics Co., Ltd.</summary>
        public const VkDriverId VK_DRIVER_ID_SAMSUNG_PROPRIETARY = VkDriverId.SamsungProprietary;
        ///<summary>Mesa open source project</summary>
        public const VkDriverId VK_DRIVER_ID_MESA_VENUS = VkDriverId.MesaVenus;
        ///<summary>Mesa open source project</summary>
        public const VkDriverId VK_DRIVER_ID_MESA_DOZEN = VkDriverId.MesaDozen;
        ///<summary>Mesa open source project</summary>
        public const VkDriverId VK_DRIVER_ID_MESA_NVK = VkDriverId.MesaNvk;
        ///<summary>Imagination Technologies</summary>
        public const VkDriverId VK_DRIVER_ID_IMAGINATION_OPEN_SOURCE_MESA = VkDriverId.ImaginationOpenSourceMesa;
        ///<summary>Mesa open source project</summary>
        public const VkDriverId VK_DRIVER_ID_MESA_AGXV = VkDriverId.MesaAgxv;
    }

    [Flags]
    public enum VkConditionalRenderingFlagsEXT : int
    {
        None = 0,
        InvertedEXT = 1,
    }
    public static partial class RawConstants
    {
        public const VkConditionalRenderingFlagsEXT VK_CONDITIONAL_RENDERING_INVERTED_BIT_EXT = VkConditionalRenderingFlagsEXT.InvertedEXT;
    }

    [Flags]
    public enum VkResolveModeFlags : int
    {
        None = 0,
        SampleZero = 1,
        Average = 2,
        Min = 4,
        Max = 8,
        Extension469Flag4Android = 16,
    }
    public static partial class RawConstants
    {
        public const VkResolveModeFlags VK_RESOLVE_MODE_NONE = VkResolveModeFlags.None;
        public const VkResolveModeFlags VK_RESOLVE_MODE_SAMPLE_ZERO_BIT = VkResolveModeFlags.SampleZero;
        public const VkResolveModeFlags VK_RESOLVE_MODE_AVERAGE_BIT = VkResolveModeFlags.Average;
        public const VkResolveModeFlags VK_RESOLVE_MODE_MIN_BIT = VkResolveModeFlags.Min;
        public const VkResolveModeFlags VK_RESOLVE_MODE_MAX_BIT = VkResolveModeFlags.Max;
        public const VkResolveModeFlags VK_RESOLVE_MODE_EXTENSION_469_FLAG_4_BIT_ANDROID = VkResolveModeFlags.Extension469Flag4Android;
    }

    public enum VkShadingRatePaletteEntryNV : int
    {
        VK_SHADING_RATE_PALETTE_ENTRY_NO_INVOCATIONS_NV = 0,
        VK_SHADING_RATE_PALETTE_ENTRY_16_INVOCATIONS_PER_PIXEL_NV = 1,
        VK_SHADING_RATE_PALETTE_ENTRY_8_INVOCATIONS_PER_PIXEL_NV = 2,
        VK_SHADING_RATE_PALETTE_ENTRY_4_INVOCATIONS_PER_PIXEL_NV = 3,
        VK_SHADING_RATE_PALETTE_ENTRY_2_INVOCATIONS_PER_PIXEL_NV = 4,
        VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_PIXEL_NV = 5,
        VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X1_PIXELS_NV = 6,
        VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_1X2_PIXELS_NV = 7,
        VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X2_PIXELS_NV = 8,
        VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X2_PIXELS_NV = 9,
        VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X4_PIXELS_NV = 10,
        VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X4_PIXELS_NV = 11,
    }
    public static partial class RawConstants
    {
        public const VkShadingRatePaletteEntryNV VK_SHADING_RATE_PALETTE_ENTRY_NO_INVOCATIONS_NV = VkShadingRatePaletteEntryNV.VK_SHADING_RATE_PALETTE_ENTRY_NO_INVOCATIONS_NV;
        public const VkShadingRatePaletteEntryNV VK_SHADING_RATE_PALETTE_ENTRY_16_INVOCATIONS_PER_PIXEL_NV = VkShadingRatePaletteEntryNV.VK_SHADING_RATE_PALETTE_ENTRY_16_INVOCATIONS_PER_PIXEL_NV;
        public const VkShadingRatePaletteEntryNV VK_SHADING_RATE_PALETTE_ENTRY_8_INVOCATIONS_PER_PIXEL_NV = VkShadingRatePaletteEntryNV.VK_SHADING_RATE_PALETTE_ENTRY_8_INVOCATIONS_PER_PIXEL_NV;
        public const VkShadingRatePaletteEntryNV VK_SHADING_RATE_PALETTE_ENTRY_4_INVOCATIONS_PER_PIXEL_NV = VkShadingRatePaletteEntryNV.VK_SHADING_RATE_PALETTE_ENTRY_4_INVOCATIONS_PER_PIXEL_NV;
        public const VkShadingRatePaletteEntryNV VK_SHADING_RATE_PALETTE_ENTRY_2_INVOCATIONS_PER_PIXEL_NV = VkShadingRatePaletteEntryNV.VK_SHADING_RATE_PALETTE_ENTRY_2_INVOCATIONS_PER_PIXEL_NV;
        public const VkShadingRatePaletteEntryNV VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_PIXEL_NV = VkShadingRatePaletteEntryNV.VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_PIXEL_NV;
        public const VkShadingRatePaletteEntryNV VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X1_PIXELS_NV = VkShadingRatePaletteEntryNV.VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X1_PIXELS_NV;
        public const VkShadingRatePaletteEntryNV VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_1X2_PIXELS_NV = VkShadingRatePaletteEntryNV.VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_1X2_PIXELS_NV;
        public const VkShadingRatePaletteEntryNV VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X2_PIXELS_NV = VkShadingRatePaletteEntryNV.VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X2_PIXELS_NV;
        public const VkShadingRatePaletteEntryNV VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X2_PIXELS_NV = VkShadingRatePaletteEntryNV.VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X2_PIXELS_NV;
        public const VkShadingRatePaletteEntryNV VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X4_PIXELS_NV = VkShadingRatePaletteEntryNV.VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_2X4_PIXELS_NV;
        public const VkShadingRatePaletteEntryNV VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X4_PIXELS_NV = VkShadingRatePaletteEntryNV.VK_SHADING_RATE_PALETTE_ENTRY_1_INVOCATION_PER_4X4_PIXELS_NV;
    }

    public enum VkCoarseSampleOrderTypeNV : int
    {
        VK_COARSE_SAMPLE_ORDER_TYPE_DEFAULT_NV = 0,
        VK_COARSE_SAMPLE_ORDER_TYPE_CUSTOM_NV = 1,
        VK_COARSE_SAMPLE_ORDER_TYPE_PIXEL_MAJOR_NV = 2,
        VK_COARSE_SAMPLE_ORDER_TYPE_SAMPLE_MAJOR_NV = 3,
    }
    public static partial class RawConstants
    {
        public const VkCoarseSampleOrderTypeNV VK_COARSE_SAMPLE_ORDER_TYPE_DEFAULT_NV = VkCoarseSampleOrderTypeNV.VK_COARSE_SAMPLE_ORDER_TYPE_DEFAULT_NV;
        public const VkCoarseSampleOrderTypeNV VK_COARSE_SAMPLE_ORDER_TYPE_CUSTOM_NV = VkCoarseSampleOrderTypeNV.VK_COARSE_SAMPLE_ORDER_TYPE_CUSTOM_NV;
        public const VkCoarseSampleOrderTypeNV VK_COARSE_SAMPLE_ORDER_TYPE_PIXEL_MAJOR_NV = VkCoarseSampleOrderTypeNV.VK_COARSE_SAMPLE_ORDER_TYPE_PIXEL_MAJOR_NV;
        public const VkCoarseSampleOrderTypeNV VK_COARSE_SAMPLE_ORDER_TYPE_SAMPLE_MAJOR_NV = VkCoarseSampleOrderTypeNV.VK_COARSE_SAMPLE_ORDER_TYPE_SAMPLE_MAJOR_NV;
    }

    [Flags]
    public enum VkGeometryInstanceFlagsKHR : int
    {
        None = 0,
        TriangleFacingCullDisableKHR = 1,
        TriangleFlipFacingKHR = 2,
        ForceOpaqueKHR = 4,
        ForceNoOpaqueKHR = 8,
        ForceOpacityMicromap2StateEXT = 16,
        DisableOpacityMicromapsEXT = 32,
    }
    public static partial class RawConstants
    {
        public const VkGeometryInstanceFlagsKHR VK_GEOMETRY_INSTANCE_TRIANGLE_FACING_CULL_DISABLE_BIT_KHR = VkGeometryInstanceFlagsKHR.TriangleFacingCullDisableKHR;
        public const VkGeometryInstanceFlagsKHR VK_GEOMETRY_INSTANCE_TRIANGLE_FLIP_FACING_BIT_KHR = VkGeometryInstanceFlagsKHR.TriangleFlipFacingKHR;
        public const VkGeometryInstanceFlagsKHR VK_GEOMETRY_INSTANCE_FORCE_OPAQUE_BIT_KHR = VkGeometryInstanceFlagsKHR.ForceOpaqueKHR;
        public const VkGeometryInstanceFlagsKHR VK_GEOMETRY_INSTANCE_FORCE_NO_OPAQUE_BIT_KHR = VkGeometryInstanceFlagsKHR.ForceNoOpaqueKHR;
        public const VkGeometryInstanceFlagsKHR VK_GEOMETRY_INSTANCE_FORCE_OPACITY_MICROMAP_2_STATE_EXT = VkGeometryInstanceFlagsKHR.ForceOpacityMicromap2StateEXT;
        public const VkGeometryInstanceFlagsKHR VK_GEOMETRY_INSTANCE_DISABLE_OPACITY_MICROMAPS_EXT = VkGeometryInstanceFlagsKHR.DisableOpacityMicromapsEXT;
    }

    [Flags]
    public enum VkGeometryFlagsKHR : int
    {
        None = 0,
        OpaqueKHR = 1,
        NoDuplicateAnyHitInvocationKHR = 2,
    }
    public static partial class RawConstants
    {
        public const VkGeometryFlagsKHR VK_GEOMETRY_OPAQUE_BIT_KHR = VkGeometryFlagsKHR.OpaqueKHR;
        public const VkGeometryFlagsKHR VK_GEOMETRY_NO_DUPLICATE_ANY_HIT_INVOCATION_BIT_KHR = VkGeometryFlagsKHR.NoDuplicateAnyHitInvocationKHR;
    }

    [Flags]
    public enum VkBuildAccelerationStructureFlagsKHR : int
    {
        None = 0,
        AllowUpdateKHR = 1,
        AllowCompactionKHR = 2,
        PreferFastTraceKHR = 4,
        PreferFastBuildKHR = 8,
        LowMemoryKHR = 16,
        MotionNV = 32,
        AllowOpacityMicromapUpdateEXT = 64,
        AllowDisableOpacityMicromapsEXT = 128,
        AllowOpacityMicromapDataUpdateEXT = 256,
        AllowDisplacementMicromapUpdateNV = 512,
        AllowDataAccessKHR = 2048,
    }
    public static partial class RawConstants
    {
        public const VkBuildAccelerationStructureFlagsKHR VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_UPDATE_BIT_KHR = VkBuildAccelerationStructureFlagsKHR.AllowUpdateKHR;
        public const VkBuildAccelerationStructureFlagsKHR VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_COMPACTION_BIT_KHR = VkBuildAccelerationStructureFlagsKHR.AllowCompactionKHR;
        public const VkBuildAccelerationStructureFlagsKHR VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_TRACE_BIT_KHR = VkBuildAccelerationStructureFlagsKHR.PreferFastTraceKHR;
        public const VkBuildAccelerationStructureFlagsKHR VK_BUILD_ACCELERATION_STRUCTURE_PREFER_FAST_BUILD_BIT_KHR = VkBuildAccelerationStructureFlagsKHR.PreferFastBuildKHR;
        public const VkBuildAccelerationStructureFlagsKHR VK_BUILD_ACCELERATION_STRUCTURE_LOW_MEMORY_BIT_KHR = VkBuildAccelerationStructureFlagsKHR.LowMemoryKHR;
        public const VkBuildAccelerationStructureFlagsKHR VK_BUILD_ACCELERATION_STRUCTURE_MOTION_BIT_NV = VkBuildAccelerationStructureFlagsKHR.MotionNV;
        public const VkBuildAccelerationStructureFlagsKHR VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_OPACITY_MICROMAP_UPDATE_EXT = VkBuildAccelerationStructureFlagsKHR.AllowOpacityMicromapUpdateEXT;
        public const VkBuildAccelerationStructureFlagsKHR VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DISABLE_OPACITY_MICROMAPS_EXT = VkBuildAccelerationStructureFlagsKHR.AllowDisableOpacityMicromapsEXT;
        public const VkBuildAccelerationStructureFlagsKHR VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_OPACITY_MICROMAP_DATA_UPDATE_EXT = VkBuildAccelerationStructureFlagsKHR.AllowOpacityMicromapDataUpdateEXT;
        public const VkBuildAccelerationStructureFlagsKHR VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DISPLACEMENT_MICROMAP_UPDATE_NV = VkBuildAccelerationStructureFlagsKHR.AllowDisplacementMicromapUpdateNV;
        public const VkBuildAccelerationStructureFlagsKHR VK_BUILD_ACCELERATION_STRUCTURE_ALLOW_DATA_ACCESS_KHR = VkBuildAccelerationStructureFlagsKHR.AllowDataAccessKHR;
    }

    [Flags]
    public enum VkAccelerationStructureCreateFlagsKHR : int
    {
        None = 0,
        DeviceAddressCaptureReplayKHR = 1,
        DescriptorBufferCaptureReplayEXT = 8,
        MotionNV = 4,
    }
    public static partial class RawConstants
    {
        public const VkAccelerationStructureCreateFlagsKHR VK_ACCELERATION_STRUCTURE_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR = VkAccelerationStructureCreateFlagsKHR.DeviceAddressCaptureReplayKHR;
        public const VkAccelerationStructureCreateFlagsKHR VK_ACCELERATION_STRUCTURE_CREATE_DESCRIPTOR_BUFFER_CAPTURE_REPLAY_BIT_EXT = VkAccelerationStructureCreateFlagsKHR.DescriptorBufferCaptureReplayEXT;
        public const VkAccelerationStructureCreateFlagsKHR VK_ACCELERATION_STRUCTURE_CREATE_MOTION_BIT_NV = VkAccelerationStructureCreateFlagsKHR.MotionNV;
    }

    public enum VkCopyAccelerationStructureModeKHR : int
    {
        CloneKHR = 0,
        CompactKHR = 1,
        SerializeKHR = 2,
        DeserializeKHR = 3,
    }
    public static partial class RawConstants
    {
        public const VkCopyAccelerationStructureModeKHR VK_COPY_ACCELERATION_STRUCTURE_MODE_CLONE_KHR = VkCopyAccelerationStructureModeKHR.CloneKHR;
        public const VkCopyAccelerationStructureModeKHR VK_COPY_ACCELERATION_STRUCTURE_MODE_COMPACT_KHR = VkCopyAccelerationStructureModeKHR.CompactKHR;
        public const VkCopyAccelerationStructureModeKHR VK_COPY_ACCELERATION_STRUCTURE_MODE_SERIALIZE_KHR = VkCopyAccelerationStructureModeKHR.SerializeKHR;
        public const VkCopyAccelerationStructureModeKHR VK_COPY_ACCELERATION_STRUCTURE_MODE_DESERIALIZE_KHR = VkCopyAccelerationStructureModeKHR.DeserializeKHR;
    }

    public enum VkBuildAccelerationStructureModeKHR : int
    {
        BuildKHR = 0,
        UpdateKHR = 1,
    }
    public static partial class RawConstants
    {
        public const VkBuildAccelerationStructureModeKHR VK_BUILD_ACCELERATION_STRUCTURE_MODE_BUILD_KHR = VkBuildAccelerationStructureModeKHR.BuildKHR;
        public const VkBuildAccelerationStructureModeKHR VK_BUILD_ACCELERATION_STRUCTURE_MODE_UPDATE_KHR = VkBuildAccelerationStructureModeKHR.UpdateKHR;
    }

    public enum VkAccelerationStructureTypeKHR : int
    {
        TopLevelKHR = 0,
        BottomLevelKHR = 1,
        GenericKHR = 2,
    }
    public static partial class RawConstants
    {
        public const VkAccelerationStructureTypeKHR VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_KHR = VkAccelerationStructureTypeKHR.TopLevelKHR;
        public const VkAccelerationStructureTypeKHR VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_KHR = VkAccelerationStructureTypeKHR.BottomLevelKHR;
        public const VkAccelerationStructureTypeKHR VK_ACCELERATION_STRUCTURE_TYPE_GENERIC_KHR = VkAccelerationStructureTypeKHR.GenericKHR;
    }

    public enum VkGeometryTypeKHR : int
    {
        TrianglesKHR = 0,
        AabbsKHR = 1,
        InstancesKHR = 2,
    }
    public static partial class RawConstants
    {
        public const VkGeometryTypeKHR VK_GEOMETRY_TYPE_TRIANGLES_KHR = VkGeometryTypeKHR.TrianglesKHR;
        public const VkGeometryTypeKHR VK_GEOMETRY_TYPE_AABBS_KHR = VkGeometryTypeKHR.AabbsKHR;
        public const VkGeometryTypeKHR VK_GEOMETRY_TYPE_INSTANCES_KHR = VkGeometryTypeKHR.InstancesKHR;
    }

    public enum VkAccelerationStructureMemoryRequirementsTypeNV : int
    {
        VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_OBJECT_NV = 0,
        VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_BUILD_SCRATCH_NV = 1,
        VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_UPDATE_SCRATCH_NV = 2,
    }
    public static partial class RawConstants
    {
        public const VkAccelerationStructureMemoryRequirementsTypeNV VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_OBJECT_NV = VkAccelerationStructureMemoryRequirementsTypeNV.VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_OBJECT_NV;
        public const VkAccelerationStructureMemoryRequirementsTypeNV VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_BUILD_SCRATCH_NV = VkAccelerationStructureMemoryRequirementsTypeNV.VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_BUILD_SCRATCH_NV;
        public const VkAccelerationStructureMemoryRequirementsTypeNV VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_UPDATE_SCRATCH_NV = VkAccelerationStructureMemoryRequirementsTypeNV.VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_UPDATE_SCRATCH_NV;
    }

    public enum VkAccelerationStructureBuildTypeKHR : int
    {
        HostKHR = 0,
        DeviceKHR = 1,
        HostOrDeviceKHR = 2,
    }
    public static partial class RawConstants
    {
        public const VkAccelerationStructureBuildTypeKHR VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_KHR = VkAccelerationStructureBuildTypeKHR.HostKHR;
        public const VkAccelerationStructureBuildTypeKHR VK_ACCELERATION_STRUCTURE_BUILD_TYPE_DEVICE_KHR = VkAccelerationStructureBuildTypeKHR.DeviceKHR;
        public const VkAccelerationStructureBuildTypeKHR VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_OR_DEVICE_KHR = VkAccelerationStructureBuildTypeKHR.HostOrDeviceKHR;
    }

    public enum VkRayTracingShaderGroupTypeKHR : int
    {
        GeneralKHR = 0,
        TrianglesHitGroupKHR = 1,
        ProceduralHitGroupKHR = 2,
    }
    public static partial class RawConstants
    {
        public const VkRayTracingShaderGroupTypeKHR VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_KHR = VkRayTracingShaderGroupTypeKHR.GeneralKHR;
        public const VkRayTracingShaderGroupTypeKHR VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_KHR = VkRayTracingShaderGroupTypeKHR.TrianglesHitGroupKHR;
        public const VkRayTracingShaderGroupTypeKHR VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_KHR = VkRayTracingShaderGroupTypeKHR.ProceduralHitGroupKHR;
    }

    public enum VkAccelerationStructureCompatibilityKHR : int
    {
        CompatibleKHR = 0,
        IncompatibleKHR = 1,
    }
    public static partial class RawConstants
    {
        public const VkAccelerationStructureCompatibilityKHR VK_ACCELERATION_STRUCTURE_COMPATIBILITY_COMPATIBLE_KHR = VkAccelerationStructureCompatibilityKHR.CompatibleKHR;
        public const VkAccelerationStructureCompatibilityKHR VK_ACCELERATION_STRUCTURE_COMPATIBILITY_INCOMPATIBLE_KHR = VkAccelerationStructureCompatibilityKHR.IncompatibleKHR;
    }

    public enum VkShaderGroupShaderKHR : int
    {
        GeneralKHR = 0,
        ClosestHitKHR = 1,
        AnyHitKHR = 2,
        IntersectionKHR = 3,
    }
    public static partial class RawConstants
    {
        public const VkShaderGroupShaderKHR VK_SHADER_GROUP_SHADER_GENERAL_KHR = VkShaderGroupShaderKHR.GeneralKHR;
        public const VkShaderGroupShaderKHR VK_SHADER_GROUP_SHADER_CLOSEST_HIT_KHR = VkShaderGroupShaderKHR.ClosestHitKHR;
        public const VkShaderGroupShaderKHR VK_SHADER_GROUP_SHADER_ANY_HIT_KHR = VkShaderGroupShaderKHR.AnyHitKHR;
        public const VkShaderGroupShaderKHR VK_SHADER_GROUP_SHADER_INTERSECTION_KHR = VkShaderGroupShaderKHR.IntersectionKHR;
    }

    public enum VkMemoryOverallocationBehaviorAMD : int
    {
        DefaultAMD = 0,
        AllowedAMD = 1,
        DisallowedAMD = 2,
    }
    public static partial class RawConstants
    {
        public const VkMemoryOverallocationBehaviorAMD VK_MEMORY_OVERALLOCATION_BEHAVIOR_DEFAULT_AMD = VkMemoryOverallocationBehaviorAMD.DefaultAMD;
        public const VkMemoryOverallocationBehaviorAMD VK_MEMORY_OVERALLOCATION_BEHAVIOR_ALLOWED_AMD = VkMemoryOverallocationBehaviorAMD.AllowedAMD;
        public const VkMemoryOverallocationBehaviorAMD VK_MEMORY_OVERALLOCATION_BEHAVIOR_DISALLOWED_AMD = VkMemoryOverallocationBehaviorAMD.DisallowedAMD;
    }

    [Flags]
    public enum VkFramebufferCreateFlags : int
    {
        None = 0,
        Imageless = 1,
    }
    public static partial class RawConstants
    {
        public const VkFramebufferCreateFlags VK_FRAMEBUFFER_CREATE_IMAGELESS_BIT = VkFramebufferCreateFlags.Imageless;
    }

    [Flags]
    public enum VkDeviceDiagnosticsConfigFlagsNV : int
    {
        None = 0,
        EnableShaderDebugInfoNV = 1,
        EnableResourceTrackingNV = 2,
        EnableAutomaticCheckpointsNV = 4,
        EnableShaderErrorReportingNV = 8,
    }
    public static partial class RawConstants
    {
        public const VkDeviceDiagnosticsConfigFlagsNV VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_SHADER_DEBUG_INFO_BIT_NV = VkDeviceDiagnosticsConfigFlagsNV.EnableShaderDebugInfoNV;
        public const VkDeviceDiagnosticsConfigFlagsNV VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_RESOURCE_TRACKING_BIT_NV = VkDeviceDiagnosticsConfigFlagsNV.EnableResourceTrackingNV;
        public const VkDeviceDiagnosticsConfigFlagsNV VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_AUTOMATIC_CHECKPOINTS_BIT_NV = VkDeviceDiagnosticsConfigFlagsNV.EnableAutomaticCheckpointsNV;
        public const VkDeviceDiagnosticsConfigFlagsNV VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_SHADER_ERROR_REPORTING_BIT_NV = VkDeviceDiagnosticsConfigFlagsNV.EnableShaderErrorReportingNV;
    }

    [Flags]
    public enum VkPipelineCreationFeedbackFlags : int
    {
        None = 0,
        Valid = 1,
        ApplicationPipelineCacheHit = 2,
        BasePipelineAcceleration = 4,
    }
    public static partial class RawConstants
    {
        public const VkPipelineCreationFeedbackFlags VK_PIPELINE_CREATION_FEEDBACK_VALID_BIT = VkPipelineCreationFeedbackFlags.Valid;
        public const VkPipelineCreationFeedbackFlags VK_PIPELINE_CREATION_FEEDBACK_APPLICATION_PIPELINE_CACHE_HIT_BIT = VkPipelineCreationFeedbackFlags.ApplicationPipelineCacheHit;
        public const VkPipelineCreationFeedbackFlags VK_PIPELINE_CREATION_FEEDBACK_BASE_PIPELINE_ACCELERATION_BIT = VkPipelineCreationFeedbackFlags.BasePipelineAcceleration;
    }

    public enum VkFullScreenExclusiveEXT : int
    {
        DefaultEXT = 0,
        AllowedEXT = 1,
        DisallowedEXT = 2,
        ApplicationControlledEXT = 3,
    }
    public static partial class RawConstants
    {
        public const VkFullScreenExclusiveEXT VK_FULL_SCREEN_EXCLUSIVE_DEFAULT_EXT = VkFullScreenExclusiveEXT.DefaultEXT;
        public const VkFullScreenExclusiveEXT VK_FULL_SCREEN_EXCLUSIVE_ALLOWED_EXT = VkFullScreenExclusiveEXT.AllowedEXT;
        public const VkFullScreenExclusiveEXT VK_FULL_SCREEN_EXCLUSIVE_DISALLOWED_EXT = VkFullScreenExclusiveEXT.DisallowedEXT;
        public const VkFullScreenExclusiveEXT VK_FULL_SCREEN_EXCLUSIVE_APPLICATION_CONTROLLED_EXT = VkFullScreenExclusiveEXT.ApplicationControlledEXT;
    }

    public enum VkPerformanceCounterScopeKHR : int
    {
        CommandBufferKHR = 0,
        RenderPassKHR = 1,
        CommandKHR = 2,
    }
    public static partial class RawConstants
    {
        public const VkPerformanceCounterScopeKHR VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_BUFFER_KHR = VkPerformanceCounterScopeKHR.CommandBufferKHR;
        public const VkPerformanceCounterScopeKHR VK_PERFORMANCE_COUNTER_SCOPE_RENDER_PASS_KHR = VkPerformanceCounterScopeKHR.RenderPassKHR;
        public const VkPerformanceCounterScopeKHR VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_KHR = VkPerformanceCounterScopeKHR.CommandKHR;
    }

    [Flags]
    public enum VkMemoryDecompressionMethodFlagsNV : long
    {
        None = 0,
        Gdeflate10NV = 1,
    }
    public static partial class RawConstants
    {
        public const VkMemoryDecompressionMethodFlagsNV VK_MEMORY_DECOMPRESSION_METHOD_GDEFLATE_1_0_BIT_NV = VkMemoryDecompressionMethodFlagsNV.Gdeflate10NV;
    }

    public enum VkPerformanceCounterUnitKHR : int
    {
        GenericKHR = 0,
        PercentageKHR = 1,
        NanosecondsKHR = 2,
        BytesKHR = 3,
        BytesPerSecondKHR = 4,
        KelvinKHR = 5,
        WattsKHR = 6,
        VoltsKHR = 7,
        AmpsKHR = 8,
        HertzKHR = 9,
        CyclesKHR = 10,
    }
    public static partial class RawConstants
    {
        public const VkPerformanceCounterUnitKHR VK_PERFORMANCE_COUNTER_UNIT_GENERIC_KHR = VkPerformanceCounterUnitKHR.GenericKHR;
        public const VkPerformanceCounterUnitKHR VK_PERFORMANCE_COUNTER_UNIT_PERCENTAGE_KHR = VkPerformanceCounterUnitKHR.PercentageKHR;
        public const VkPerformanceCounterUnitKHR VK_PERFORMANCE_COUNTER_UNIT_NANOSECONDS_KHR = VkPerformanceCounterUnitKHR.NanosecondsKHR;
        public const VkPerformanceCounterUnitKHR VK_PERFORMANCE_COUNTER_UNIT_BYTES_KHR = VkPerformanceCounterUnitKHR.BytesKHR;
        public const VkPerformanceCounterUnitKHR VK_PERFORMANCE_COUNTER_UNIT_BYTES_PER_SECOND_KHR = VkPerformanceCounterUnitKHR.BytesPerSecondKHR;
        public const VkPerformanceCounterUnitKHR VK_PERFORMANCE_COUNTER_UNIT_KELVIN_KHR = VkPerformanceCounterUnitKHR.KelvinKHR;
        public const VkPerformanceCounterUnitKHR VK_PERFORMANCE_COUNTER_UNIT_WATTS_KHR = VkPerformanceCounterUnitKHR.WattsKHR;
        public const VkPerformanceCounterUnitKHR VK_PERFORMANCE_COUNTER_UNIT_VOLTS_KHR = VkPerformanceCounterUnitKHR.VoltsKHR;
        public const VkPerformanceCounterUnitKHR VK_PERFORMANCE_COUNTER_UNIT_AMPS_KHR = VkPerformanceCounterUnitKHR.AmpsKHR;
        public const VkPerformanceCounterUnitKHR VK_PERFORMANCE_COUNTER_UNIT_HERTZ_KHR = VkPerformanceCounterUnitKHR.HertzKHR;
        public const VkPerformanceCounterUnitKHR VK_PERFORMANCE_COUNTER_UNIT_CYCLES_KHR = VkPerformanceCounterUnitKHR.CyclesKHR;
    }

    public enum VkPerformanceCounterStorageKHR : int
    {
        Int32KHR = 0,
        Int64KHR = 1,
        Uint32KHR = 2,
        Uint64KHR = 3,
        Float32KHR = 4,
        Float64KHR = 5,
    }
    public static partial class RawConstants
    {
        public const VkPerformanceCounterStorageKHR VK_PERFORMANCE_COUNTER_STORAGE_INT32_KHR = VkPerformanceCounterStorageKHR.Int32KHR;
        public const VkPerformanceCounterStorageKHR VK_PERFORMANCE_COUNTER_STORAGE_INT64_KHR = VkPerformanceCounterStorageKHR.Int64KHR;
        public const VkPerformanceCounterStorageKHR VK_PERFORMANCE_COUNTER_STORAGE_UINT32_KHR = VkPerformanceCounterStorageKHR.Uint32KHR;
        public const VkPerformanceCounterStorageKHR VK_PERFORMANCE_COUNTER_STORAGE_UINT64_KHR = VkPerformanceCounterStorageKHR.Uint64KHR;
        public const VkPerformanceCounterStorageKHR VK_PERFORMANCE_COUNTER_STORAGE_FLOAT32_KHR = VkPerformanceCounterStorageKHR.Float32KHR;
        public const VkPerformanceCounterStorageKHR VK_PERFORMANCE_COUNTER_STORAGE_FLOAT64_KHR = VkPerformanceCounterStorageKHR.Float64KHR;
    }

    [Flags]
    public enum VkPerformanceCounterDescriptionFlagsKHR : int
    {
        None = 0,
        PerformanceImpactingKHR = 1,
        ConcurrentlyImpactedKHR = 2,
    }
    public static partial class RawConstants
    {
        public const VkPerformanceCounterDescriptionFlagsKHR VK_PERFORMANCE_COUNTER_DESCRIPTION_PERFORMANCE_IMPACTING_BIT_KHR = VkPerformanceCounterDescriptionFlagsKHR.PerformanceImpactingKHR;
        public const VkPerformanceCounterDescriptionFlagsKHR VK_PERFORMANCE_COUNTER_DESCRIPTION_CONCURRENTLY_IMPACTED_BIT_KHR = VkPerformanceCounterDescriptionFlagsKHR.ConcurrentlyImpactedKHR;
    }

    [Flags]
    public enum VkAcquireProfilingLockFlagsKHR : int
    {
        None = 0,
    }
    public static partial class RawConstants
    {
    }

    [Flags]
    public enum VkShaderCorePropertiesFlagsAMD : int
    {
        None = 0,
    }
    public static partial class RawConstants
    {
    }

    [Flags]
    public enum VkRefreshObjectFlagsKHR : int
    {
        None = 0,
    }
    public static partial class RawConstants
    {
    }

    public enum VkPerformanceConfigurationTypeINTEL : int
    {
        VK_PERFORMANCE_CONFIGURATION_TYPE_COMMAND_QUEUE_METRICS_DISCOVERY_ACTIVATED_INTEL = 0,
    }
    public static partial class RawConstants
    {
        public const VkPerformanceConfigurationTypeINTEL VK_PERFORMANCE_CONFIGURATION_TYPE_COMMAND_QUEUE_METRICS_DISCOVERY_ACTIVATED_INTEL = VkPerformanceConfigurationTypeINTEL.VK_PERFORMANCE_CONFIGURATION_TYPE_COMMAND_QUEUE_METRICS_DISCOVERY_ACTIVATED_INTEL;
    }

    public enum VkQueryPoolSamplingModeINTEL : int
    {
        VK_QUERY_POOL_SAMPLING_MODE_MANUAL_INTEL = 0,
    }
    public static partial class RawConstants
    {
        public const VkQueryPoolSamplingModeINTEL VK_QUERY_POOL_SAMPLING_MODE_MANUAL_INTEL = VkQueryPoolSamplingModeINTEL.VK_QUERY_POOL_SAMPLING_MODE_MANUAL_INTEL;
    }

    public enum VkPerformanceOverrideTypeINTEL : int
    {
        VK_PERFORMANCE_OVERRIDE_TYPE_NULL_HARDWARE_INTEL = 0,
        VK_PERFORMANCE_OVERRIDE_TYPE_FLUSH_GPU_CACHES_INTEL = 1,
    }
    public static partial class RawConstants
    {
        public const VkPerformanceOverrideTypeINTEL VK_PERFORMANCE_OVERRIDE_TYPE_NULL_HARDWARE_INTEL = VkPerformanceOverrideTypeINTEL.VK_PERFORMANCE_OVERRIDE_TYPE_NULL_HARDWARE_INTEL;
        public const VkPerformanceOverrideTypeINTEL VK_PERFORMANCE_OVERRIDE_TYPE_FLUSH_GPU_CACHES_INTEL = VkPerformanceOverrideTypeINTEL.VK_PERFORMANCE_OVERRIDE_TYPE_FLUSH_GPU_CACHES_INTEL;
    }

    public enum VkPerformanceParameterTypeINTEL : int
    {
        VK_PERFORMANCE_PARAMETER_TYPE_HW_COUNTERS_SUPPORTED_INTEL = 0,
        VK_PERFORMANCE_PARAMETER_TYPE_STREAM_MARKER_VALID_BITS_INTEL = 1,
    }
    public static partial class RawConstants
    {
        public const VkPerformanceParameterTypeINTEL VK_PERFORMANCE_PARAMETER_TYPE_HW_COUNTERS_SUPPORTED_INTEL = VkPerformanceParameterTypeINTEL.VK_PERFORMANCE_PARAMETER_TYPE_HW_COUNTERS_SUPPORTED_INTEL;
        public const VkPerformanceParameterTypeINTEL VK_PERFORMANCE_PARAMETER_TYPE_STREAM_MARKER_VALID_BITS_INTEL = VkPerformanceParameterTypeINTEL.VK_PERFORMANCE_PARAMETER_TYPE_STREAM_MARKER_VALID_BITS_INTEL;
    }

    public enum VkPerformanceValueTypeINTEL : int
    {
        VK_PERFORMANCE_VALUE_TYPE_UINT32_INTEL = 0,
        VK_PERFORMANCE_VALUE_TYPE_UINT64_INTEL = 1,
        VK_PERFORMANCE_VALUE_TYPE_FLOAT_INTEL = 2,
        VK_PERFORMANCE_VALUE_TYPE_BOOL_INTEL = 3,
        VK_PERFORMANCE_VALUE_TYPE_STRING_INTEL = 4,
    }
    public static partial class RawConstants
    {
        public const VkPerformanceValueTypeINTEL VK_PERFORMANCE_VALUE_TYPE_UINT32_INTEL = VkPerformanceValueTypeINTEL.VK_PERFORMANCE_VALUE_TYPE_UINT32_INTEL;
        public const VkPerformanceValueTypeINTEL VK_PERFORMANCE_VALUE_TYPE_UINT64_INTEL = VkPerformanceValueTypeINTEL.VK_PERFORMANCE_VALUE_TYPE_UINT64_INTEL;
        public const VkPerformanceValueTypeINTEL VK_PERFORMANCE_VALUE_TYPE_FLOAT_INTEL = VkPerformanceValueTypeINTEL.VK_PERFORMANCE_VALUE_TYPE_FLOAT_INTEL;
        public const VkPerformanceValueTypeINTEL VK_PERFORMANCE_VALUE_TYPE_BOOL_INTEL = VkPerformanceValueTypeINTEL.VK_PERFORMANCE_VALUE_TYPE_BOOL_INTEL;
        public const VkPerformanceValueTypeINTEL VK_PERFORMANCE_VALUE_TYPE_STRING_INTEL = VkPerformanceValueTypeINTEL.VK_PERFORMANCE_VALUE_TYPE_STRING_INTEL;
    }

    public enum VkShaderFloatControlsIndependence : int
    {
        _32Only = 0,
        All = 1,
        None = 2,
    }
    public static partial class RawConstants
    {
        public const VkShaderFloatControlsIndependence VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_32_BIT_ONLY = VkShaderFloatControlsIndependence._32Only;
        public const VkShaderFloatControlsIndependence VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_ALL = VkShaderFloatControlsIndependence.All;
        public const VkShaderFloatControlsIndependence VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_NONE = VkShaderFloatControlsIndependence.None;
    }

    public enum VkPipelineExecutableStatisticFormatKHR : int
    {
        Bool32KHR = 0,
        Int64KHR = 1,
        Uint64KHR = 2,
        Float64KHR = 3,
    }
    public static partial class RawConstants
    {
        public const VkPipelineExecutableStatisticFormatKHR VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_BOOL32_KHR = VkPipelineExecutableStatisticFormatKHR.Bool32KHR;
        public const VkPipelineExecutableStatisticFormatKHR VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_INT64_KHR = VkPipelineExecutableStatisticFormatKHR.Int64KHR;
        public const VkPipelineExecutableStatisticFormatKHR VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_UINT64_KHR = VkPipelineExecutableStatisticFormatKHR.Uint64KHR;
        public const VkPipelineExecutableStatisticFormatKHR VK_PIPELINE_EXECUTABLE_STATISTIC_FORMAT_FLOAT64_KHR = VkPipelineExecutableStatisticFormatKHR.Float64KHR;
    }

    public enum VkLineRasterizationModeEXT : int
    {
        DefaultEXT = 0,
        RectangularEXT = 1,
        BresenhamEXT = 2,
        RectangularSmoothEXT = 3,
    }
    public static partial class RawConstants
    {
        public const VkLineRasterizationModeEXT VK_LINE_RASTERIZATION_MODE_DEFAULT_EXT = VkLineRasterizationModeEXT.DefaultEXT;
        public const VkLineRasterizationModeEXT VK_LINE_RASTERIZATION_MODE_RECTANGULAR_EXT = VkLineRasterizationModeEXT.RectangularEXT;
        public const VkLineRasterizationModeEXT VK_LINE_RASTERIZATION_MODE_BRESENHAM_EXT = VkLineRasterizationModeEXT.BresenhamEXT;
        public const VkLineRasterizationModeEXT VK_LINE_RASTERIZATION_MODE_RECTANGULAR_SMOOTH_EXT = VkLineRasterizationModeEXT.RectangularSmoothEXT;
    }

    [Flags]
    public enum VkShaderModuleCreateFlagBits : int
    {
        None = 0,
    }
    public static partial class RawConstants
    {
    }

    [Flags]
    public enum VkPipelineCompilerControlFlagsAMD : int
    {
        None = 0,
    }
    public static partial class RawConstants
    {
    }

    public enum VkFaultLevel : int
    {
        Unassigned = 0,
        Critical = 1,
        Recoverable = 2,
        Warning = 3,
    }
    public static partial class RawConstants
    {
        public const VkFaultLevel VK_FAULT_LEVEL_UNASSIGNED = VkFaultLevel.Unassigned;
        public const VkFaultLevel VK_FAULT_LEVEL_CRITICAL = VkFaultLevel.Critical;
        public const VkFaultLevel VK_FAULT_LEVEL_RECOVERABLE = VkFaultLevel.Recoverable;
        public const VkFaultLevel VK_FAULT_LEVEL_WARNING = VkFaultLevel.Warning;
    }

    public enum VkFaultType : int
    {
        Invalid = 0,
        Unassigned = 1,
        Implementation = 2,
        System = 3,
        PhysicalDevice = 4,
        CommandBufferFull = 5,
        InvalidApiUsage = 6,
    }
    public static partial class RawConstants
    {
        public const VkFaultType VK_FAULT_TYPE_INVALID = VkFaultType.Invalid;
        public const VkFaultType VK_FAULT_TYPE_UNASSIGNED = VkFaultType.Unassigned;
        public const VkFaultType VK_FAULT_TYPE_IMPLEMENTATION = VkFaultType.Implementation;
        public const VkFaultType VK_FAULT_TYPE_SYSTEM = VkFaultType.System;
        public const VkFaultType VK_FAULT_TYPE_PHYSICAL_DEVICE = VkFaultType.PhysicalDevice;
        public const VkFaultType VK_FAULT_TYPE_COMMAND_BUFFER_FULL = VkFaultType.CommandBufferFull;
        public const VkFaultType VK_FAULT_TYPE_INVALID_API_USAGE = VkFaultType.InvalidApiUsage;
    }

    public enum VkFaultQueryBehavior : int
    {
        GetAndClearAllFaults = 0,
    }
    public static partial class RawConstants
    {
        public const VkFaultQueryBehavior VK_FAULT_QUERY_BEHAVIOR_GET_AND_CLEAR_ALL_FAULTS = VkFaultQueryBehavior.GetAndClearAllFaults;
    }

    [Flags]
    public enum VkToolPurposeFlags : int
    {
        None = 0,
        Validation = 1,
        Profiling = 2,
        Tracing = 4,
        AdditionalFeatures = 8,
        ModifyingFeatures = 16,
        DebugReportingEXT = 32,
        DebugMarkersEXT = 64,
    }
    public static partial class RawConstants
    {
        public const VkToolPurposeFlags VK_TOOL_PURPOSE_VALIDATION_BIT = VkToolPurposeFlags.Validation;
        public const VkToolPurposeFlags VK_TOOL_PURPOSE_PROFILING_BIT = VkToolPurposeFlags.Profiling;
        public const VkToolPurposeFlags VK_TOOL_PURPOSE_TRACING_BIT = VkToolPurposeFlags.Tracing;
        public const VkToolPurposeFlags VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT = VkToolPurposeFlags.AdditionalFeatures;
        public const VkToolPurposeFlags VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT = VkToolPurposeFlags.ModifyingFeatures;
        public const VkToolPurposeFlags VK_TOOL_PURPOSE_DEBUG_REPORTING_BIT_EXT = VkToolPurposeFlags.DebugReportingEXT;
        public const VkToolPurposeFlags VK_TOOL_PURPOSE_DEBUG_MARKERS_BIT_EXT = VkToolPurposeFlags.DebugMarkersEXT;
    }

    public enum VkPipelineMatchControl : int
    {
        ApplicationUuidExactMatch = 0,
    }
    public static partial class RawConstants
    {
        public const VkPipelineMatchControl VK_PIPELINE_MATCH_CONTROL_APPLICATION_UUID_EXACT_MATCH = VkPipelineMatchControl.ApplicationUuidExactMatch;
    }

    public enum VkFragmentShadingRateCombinerOpKHR : int
    {
        KeepKHR = 0,
        ReplaceKHR = 1,
        MinKHR = 2,
        MaxKHR = 3,
        MulKHR = 4,
    }
    public static partial class RawConstants
    {
        public const VkFragmentShadingRateCombinerOpKHR VK_FRAGMENT_SHADING_RATE_COMBINER_OP_KEEP_KHR = VkFragmentShadingRateCombinerOpKHR.KeepKHR;
        public const VkFragmentShadingRateCombinerOpKHR VK_FRAGMENT_SHADING_RATE_COMBINER_OP_REPLACE_KHR = VkFragmentShadingRateCombinerOpKHR.ReplaceKHR;
        public const VkFragmentShadingRateCombinerOpKHR VK_FRAGMENT_SHADING_RATE_COMBINER_OP_MIN_KHR = VkFragmentShadingRateCombinerOpKHR.MinKHR;
        public const VkFragmentShadingRateCombinerOpKHR VK_FRAGMENT_SHADING_RATE_COMBINER_OP_MAX_KHR = VkFragmentShadingRateCombinerOpKHR.MaxKHR;
        public const VkFragmentShadingRateCombinerOpKHR VK_FRAGMENT_SHADING_RATE_COMBINER_OP_MUL_KHR = VkFragmentShadingRateCombinerOpKHR.MulKHR;
    }

    public enum VkFragmentShadingRateNV : int
    {
        VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_PIXEL_NV = 0,
        VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_1X2_PIXELS_NV = 1,
        VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X1_PIXELS_NV = 4,
        VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X2_PIXELS_NV = 5,
        VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X4_PIXELS_NV = 6,
        VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X2_PIXELS_NV = 9,
        VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X4_PIXELS_NV = 10,
        VK_FRAGMENT_SHADING_RATE_2_INVOCATIONS_PER_PIXEL_NV = 11,
        VK_FRAGMENT_SHADING_RATE_4_INVOCATIONS_PER_PIXEL_NV = 12,
        VK_FRAGMENT_SHADING_RATE_8_INVOCATIONS_PER_PIXEL_NV = 13,
        VK_FRAGMENT_SHADING_RATE_16_INVOCATIONS_PER_PIXEL_NV = 14,
        VK_FRAGMENT_SHADING_RATE_NO_INVOCATIONS_NV = 15,
    }
    public static partial class RawConstants
    {
        public const VkFragmentShadingRateNV VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_PIXEL_NV = VkFragmentShadingRateNV.VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_PIXEL_NV;
        public const VkFragmentShadingRateNV VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_1X2_PIXELS_NV = VkFragmentShadingRateNV.VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_1X2_PIXELS_NV;
        public const VkFragmentShadingRateNV VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X1_PIXELS_NV = VkFragmentShadingRateNV.VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X1_PIXELS_NV;
        public const VkFragmentShadingRateNV VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X2_PIXELS_NV = VkFragmentShadingRateNV.VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X2_PIXELS_NV;
        public const VkFragmentShadingRateNV VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X4_PIXELS_NV = VkFragmentShadingRateNV.VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_2X4_PIXELS_NV;
        public const VkFragmentShadingRateNV VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X2_PIXELS_NV = VkFragmentShadingRateNV.VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X2_PIXELS_NV;
        public const VkFragmentShadingRateNV VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X4_PIXELS_NV = VkFragmentShadingRateNV.VK_FRAGMENT_SHADING_RATE_1_INVOCATION_PER_4X4_PIXELS_NV;
        public const VkFragmentShadingRateNV VK_FRAGMENT_SHADING_RATE_2_INVOCATIONS_PER_PIXEL_NV = VkFragmentShadingRateNV.VK_FRAGMENT_SHADING_RATE_2_INVOCATIONS_PER_PIXEL_NV;
        public const VkFragmentShadingRateNV VK_FRAGMENT_SHADING_RATE_4_INVOCATIONS_PER_PIXEL_NV = VkFragmentShadingRateNV.VK_FRAGMENT_SHADING_RATE_4_INVOCATIONS_PER_PIXEL_NV;
        public const VkFragmentShadingRateNV VK_FRAGMENT_SHADING_RATE_8_INVOCATIONS_PER_PIXEL_NV = VkFragmentShadingRateNV.VK_FRAGMENT_SHADING_RATE_8_INVOCATIONS_PER_PIXEL_NV;
        public const VkFragmentShadingRateNV VK_FRAGMENT_SHADING_RATE_16_INVOCATIONS_PER_PIXEL_NV = VkFragmentShadingRateNV.VK_FRAGMENT_SHADING_RATE_16_INVOCATIONS_PER_PIXEL_NV;
        public const VkFragmentShadingRateNV VK_FRAGMENT_SHADING_RATE_NO_INVOCATIONS_NV = VkFragmentShadingRateNV.VK_FRAGMENT_SHADING_RATE_NO_INVOCATIONS_NV;
    }

    public enum VkFragmentShadingRateTypeNV : int
    {
        VK_FRAGMENT_SHADING_RATE_TYPE_FRAGMENT_SIZE_NV = 0,
        VK_FRAGMENT_SHADING_RATE_TYPE_ENUMS_NV = 1,
    }
    public static partial class RawConstants
    {
        public const VkFragmentShadingRateTypeNV VK_FRAGMENT_SHADING_RATE_TYPE_FRAGMENT_SIZE_NV = VkFragmentShadingRateTypeNV.VK_FRAGMENT_SHADING_RATE_TYPE_FRAGMENT_SIZE_NV;
        public const VkFragmentShadingRateTypeNV VK_FRAGMENT_SHADING_RATE_TYPE_ENUMS_NV = VkFragmentShadingRateTypeNV.VK_FRAGMENT_SHADING_RATE_TYPE_ENUMS_NV;
    }

    public enum VkSubpassMergeStatusEXT : int
    {
        MergedEXT = 0,
        DisallowedEXT = 1,
        NotMergedSideEffectsEXT = 2,
        NotMergedSamplesMismatchEXT = 3,
        NotMergedViewsMismatchEXT = 4,
        NotMergedAliasingEXT = 5,
        NotMergedDependenciesEXT = 6,
        NotMergedIncompatibleInputAttachmentEXT = 7,
        NotMergedTooManyAttachmentsEXT = 8,
        NotMergedInsufficientStorageEXT = 9,
        NotMergedDepthStencilCountEXT = 10,
        NotMergedResolveAttachmentReuseEXT = 11,
        NotMergedSingleSubpassEXT = 12,
        NotMergedUnspecifiedEXT = 13,
    }
    public static partial class RawConstants
    {
        public const VkSubpassMergeStatusEXT VK_SUBPASS_MERGE_STATUS_MERGED_EXT = VkSubpassMergeStatusEXT.MergedEXT;
        public const VkSubpassMergeStatusEXT VK_SUBPASS_MERGE_STATUS_DISALLOWED_EXT = VkSubpassMergeStatusEXT.DisallowedEXT;
        public const VkSubpassMergeStatusEXT VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SIDE_EFFECTS_EXT = VkSubpassMergeStatusEXT.NotMergedSideEffectsEXT;
        public const VkSubpassMergeStatusEXT VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SAMPLES_MISMATCH_EXT = VkSubpassMergeStatusEXT.NotMergedSamplesMismatchEXT;
        public const VkSubpassMergeStatusEXT VK_SUBPASS_MERGE_STATUS_NOT_MERGED_VIEWS_MISMATCH_EXT = VkSubpassMergeStatusEXT.NotMergedViewsMismatchEXT;
        public const VkSubpassMergeStatusEXT VK_SUBPASS_MERGE_STATUS_NOT_MERGED_ALIASING_EXT = VkSubpassMergeStatusEXT.NotMergedAliasingEXT;
        public const VkSubpassMergeStatusEXT VK_SUBPASS_MERGE_STATUS_NOT_MERGED_DEPENDENCIES_EXT = VkSubpassMergeStatusEXT.NotMergedDependenciesEXT;
        public const VkSubpassMergeStatusEXT VK_SUBPASS_MERGE_STATUS_NOT_MERGED_INCOMPATIBLE_INPUT_ATTACHMENT_EXT = VkSubpassMergeStatusEXT.NotMergedIncompatibleInputAttachmentEXT;
        public const VkSubpassMergeStatusEXT VK_SUBPASS_MERGE_STATUS_NOT_MERGED_TOO_MANY_ATTACHMENTS_EXT = VkSubpassMergeStatusEXT.NotMergedTooManyAttachmentsEXT;
        public const VkSubpassMergeStatusEXT VK_SUBPASS_MERGE_STATUS_NOT_MERGED_INSUFFICIENT_STORAGE_EXT = VkSubpassMergeStatusEXT.NotMergedInsufficientStorageEXT;
        public const VkSubpassMergeStatusEXT VK_SUBPASS_MERGE_STATUS_NOT_MERGED_DEPTH_STENCIL_COUNT_EXT = VkSubpassMergeStatusEXT.NotMergedDepthStencilCountEXT;
        public const VkSubpassMergeStatusEXT VK_SUBPASS_MERGE_STATUS_NOT_MERGED_RESOLVE_ATTACHMENT_REUSE_EXT = VkSubpassMergeStatusEXT.NotMergedResolveAttachmentReuseEXT;
        public const VkSubpassMergeStatusEXT VK_SUBPASS_MERGE_STATUS_NOT_MERGED_SINGLE_SUBPASS_EXT = VkSubpassMergeStatusEXT.NotMergedSingleSubpassEXT;
        public const VkSubpassMergeStatusEXT VK_SUBPASS_MERGE_STATUS_NOT_MERGED_UNSPECIFIED_EXT = VkSubpassMergeStatusEXT.NotMergedUnspecifiedEXT;
    }

    [Flags]
    public enum VkAccessFlags2 : long
    {
        None = 0,
        IndirectCommandRead = 1,
        IndexRead = 2,
        VertexAttributeRead = 4,
        UniformRead = 8,
        InputAttachmentRead = 16,
        ShaderRead = 32,
        ShaderWrite = 64,
        ColorAttachmentRead = 128,
        ColorAttachmentWrite = 256,
        DepthStencilAttachmentRead = 512,
        DepthStencilAttachmentWrite = 1024,
        TransferRead = 2048,
        TransferWrite = 4096,
        HostRead = 8192,
        HostWrite = 16384,
        MemoryRead = 32768,
        MemoryWrite = 65536,
        ShaderSampledRead = 4294967296,
        ShaderStorageRead = 8589934592,
        ShaderStorageWrite = 17179869184,
        VideoDecodeReadKHR = 8,
        VideoDecodeWriteKHR = 16,
        Reserved46Intel = 16384,
        VideoEncodeReadKHR = 32,
        VideoEncodeWriteKHR = 64,
        Reserved51Qcom = 524288,
        Reserved52Qcom = 1048576,
        Reserved53Qcom = 2097152,
        Reserved54Qcom = 4194304,
        TransformFeedbackWriteEXT = 33554432,
        TransformFeedbackCounterReadEXT = 67108864,
        TransformFeedbackCounterWriteEXT = 134217728,
        ConditionalRenderingReadEXT = 1048576,
        CommandPreprocessReadNV = 131072,
        CommandPreprocessWriteNV = 262144,
        FragmentShadingRateAttachmentReadKHR = 8388608,
        AccelerationStructureReadKHR = 2097152,
        AccelerationStructureWriteKHR = 4194304,
        FragmentDensityMapReadEXT = 16777216,
        ColorAttachmentReadNoncoherentEXT = 524288,
        DescriptorBufferReadEXT = 512,
        InvocationMaskReadHuawei = 128,
        ShaderBindingTableReadKHR = 256,
        MicromapReadEXT = 4096,
        MicromapWriteEXT = 8192,
        Reserved49Arm = 131072,
        Reserved50Arm = 262144,
        OpticalFlowReadNV = 1024,
        OpticalFlowWriteNV = 2048,
        Reserved47EXT = 32768,
        Reserved48EXT = 65536,
    }
    public static partial class RawConstants
    {
        public const VkAccessFlags2 VK_ACCESS_2_NONE = VkAccessFlags2.None;
        public const VkAccessFlags2 VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT = VkAccessFlags2.IndirectCommandRead;
        public const VkAccessFlags2 VK_ACCESS_2_INDEX_READ_BIT = VkAccessFlags2.IndexRead;
        public const VkAccessFlags2 VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT = VkAccessFlags2.VertexAttributeRead;
        public const VkAccessFlags2 VK_ACCESS_2_UNIFORM_READ_BIT = VkAccessFlags2.UniformRead;
        public const VkAccessFlags2 VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT = VkAccessFlags2.InputAttachmentRead;
        public const VkAccessFlags2 VK_ACCESS_2_SHADER_READ_BIT = VkAccessFlags2.ShaderRead;
        public const VkAccessFlags2 VK_ACCESS_2_SHADER_WRITE_BIT = VkAccessFlags2.ShaderWrite;
        public const VkAccessFlags2 VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT = VkAccessFlags2.ColorAttachmentRead;
        public const VkAccessFlags2 VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT = VkAccessFlags2.ColorAttachmentWrite;
        public const VkAccessFlags2 VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT = VkAccessFlags2.DepthStencilAttachmentRead;
        public const VkAccessFlags2 VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT = VkAccessFlags2.DepthStencilAttachmentWrite;
        public const VkAccessFlags2 VK_ACCESS_2_TRANSFER_READ_BIT = VkAccessFlags2.TransferRead;
        public const VkAccessFlags2 VK_ACCESS_2_TRANSFER_WRITE_BIT = VkAccessFlags2.TransferWrite;
        public const VkAccessFlags2 VK_ACCESS_2_HOST_READ_BIT = VkAccessFlags2.HostRead;
        public const VkAccessFlags2 VK_ACCESS_2_HOST_WRITE_BIT = VkAccessFlags2.HostWrite;
        public const VkAccessFlags2 VK_ACCESS_2_MEMORY_READ_BIT = VkAccessFlags2.MemoryRead;
        public const VkAccessFlags2 VK_ACCESS_2_MEMORY_WRITE_BIT = VkAccessFlags2.MemoryWrite;
        public const VkAccessFlags2 VK_ACCESS_2_SHADER_SAMPLED_READ_BIT = VkAccessFlags2.ShaderSampledRead;
        public const VkAccessFlags2 VK_ACCESS_2_SHADER_STORAGE_READ_BIT = VkAccessFlags2.ShaderStorageRead;
        public const VkAccessFlags2 VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT = VkAccessFlags2.ShaderStorageWrite;
        public const VkAccessFlags2 VK_ACCESS_2_VIDEO_DECODE_READ_BIT_KHR = VkAccessFlags2.VideoDecodeReadKHR;
        public const VkAccessFlags2 VK_ACCESS_2_VIDEO_DECODE_WRITE_BIT_KHR = VkAccessFlags2.VideoDecodeWriteKHR;
        public const VkAccessFlags2 VK_ACCESS_2_RESERVED_46_BIT_INTEL = VkAccessFlags2.Reserved46Intel;
        public const VkAccessFlags2 VK_ACCESS_2_VIDEO_ENCODE_READ_BIT_KHR = VkAccessFlags2.VideoEncodeReadKHR;
        public const VkAccessFlags2 VK_ACCESS_2_VIDEO_ENCODE_WRITE_BIT_KHR = VkAccessFlags2.VideoEncodeWriteKHR;
        public const VkAccessFlags2 VK_ACCESS_2_RESERVED_51_BIT_QCOM = VkAccessFlags2.Reserved51Qcom;
        public const VkAccessFlags2 VK_ACCESS_2_RESERVED_52_BIT_QCOM = VkAccessFlags2.Reserved52Qcom;
        public const VkAccessFlags2 VK_ACCESS_2_RESERVED_53_BIT_QCOM = VkAccessFlags2.Reserved53Qcom;
        public const VkAccessFlags2 VK_ACCESS_2_RESERVED_54_BIT_QCOM = VkAccessFlags2.Reserved54Qcom;
        public const VkAccessFlags2 VK_ACCESS_2_TRANSFORM_FEEDBACK_WRITE_BIT_EXT = VkAccessFlags2.TransformFeedbackWriteEXT;
        public const VkAccessFlags2 VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT = VkAccessFlags2.TransformFeedbackCounterReadEXT;
        public const VkAccessFlags2 VK_ACCESS_2_TRANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT = VkAccessFlags2.TransformFeedbackCounterWriteEXT;
        public const VkAccessFlags2 VK_ACCESS_2_CONDITIONAL_RENDERING_READ_BIT_EXT = VkAccessFlags2.ConditionalRenderingReadEXT;
        public const VkAccessFlags2 VK_ACCESS_2_COMMAND_PREPROCESS_READ_BIT_NV = VkAccessFlags2.CommandPreprocessReadNV;
        public const VkAccessFlags2 VK_ACCESS_2_COMMAND_PREPROCESS_WRITE_BIT_NV = VkAccessFlags2.CommandPreprocessWriteNV;
        public const VkAccessFlags2 VK_ACCESS_2_FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR = VkAccessFlags2.FragmentShadingRateAttachmentReadKHR;
        public const VkAccessFlags2 VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_KHR = VkAccessFlags2.AccelerationStructureReadKHR;
        public const VkAccessFlags2 VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_KHR = VkAccessFlags2.AccelerationStructureWriteKHR;
        public const VkAccessFlags2 VK_ACCESS_2_FRAGMENT_DENSITY_MAP_READ_BIT_EXT = VkAccessFlags2.FragmentDensityMapReadEXT;
        public const VkAccessFlags2 VK_ACCESS_2_COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT = VkAccessFlags2.ColorAttachmentReadNoncoherentEXT;
        public const VkAccessFlags2 VK_ACCESS_2_DESCRIPTOR_BUFFER_READ_BIT_EXT = VkAccessFlags2.DescriptorBufferReadEXT;
        public const VkAccessFlags2 VK_ACCESS_2_INVOCATION_MASK_READ_BIT_HUAWEI = VkAccessFlags2.InvocationMaskReadHuawei;
        public const VkAccessFlags2 VK_ACCESS_2_SHADER_BINDING_TABLE_READ_BIT_KHR = VkAccessFlags2.ShaderBindingTableReadKHR;
        public const VkAccessFlags2 VK_ACCESS_2_MICROMAP_READ_BIT_EXT = VkAccessFlags2.MicromapReadEXT;
        public const VkAccessFlags2 VK_ACCESS_2_MICROMAP_WRITE_BIT_EXT = VkAccessFlags2.MicromapWriteEXT;
        public const VkAccessFlags2 VK_ACCESS_2_RESERVED_49_BIT_ARM = VkAccessFlags2.Reserved49Arm;
        public const VkAccessFlags2 VK_ACCESS_2_RESERVED_50_BIT_ARM = VkAccessFlags2.Reserved50Arm;
        public const VkAccessFlags2 VK_ACCESS_2_OPTICAL_FLOW_READ_BIT_NV = VkAccessFlags2.OpticalFlowReadNV;
        public const VkAccessFlags2 VK_ACCESS_2_OPTICAL_FLOW_WRITE_BIT_NV = VkAccessFlags2.OpticalFlowWriteNV;
        public const VkAccessFlags2 VK_ACCESS_2_RESERVED_47_BIT_EXT = VkAccessFlags2.Reserved47EXT;
        public const VkAccessFlags2 VK_ACCESS_2_RESERVED_48_BIT_EXT = VkAccessFlags2.Reserved48EXT;
    }

    [Flags]
    public enum VkPipelineStageFlags2 : long
    {
        None = 0,
        TopOfPipe = 1,
        DrawIndirect = 2,
        VertexInput = 4,
        VertexShader = 8,
        TessellationControlShader = 16,
        TessellationEvaluationShader = 32,
        GeometryShader = 64,
        FragmentShader = 128,
        EarlyFragmentTests = 256,
        LateFragmentTests = 512,
        ColorAttachmentOutput = 1024,
        ComputeShader = 2048,
        AllTransfer = 4096,
        BottomOfPipe = 8192,
        Host = 16384,
        AllGraphics = 32768,
        AllCommands = 65536,
        Copy = 4294967296,
        Resolve = 8589934592,
        Blit = 17179869184,
        Clear = 34359738368,
        IndexInput = 68719476736,
        VertexAttributeInput = 137438953472,
        PreRasterizationShaders = 274877906944,
        VideoDecodeKHR = 67108864,
        VideoEncodeKHR = 134217728,
        TransformFeedbackEXT = 16777216,
        ConditionalRenderingEXT = 262144,
        CommandPreprocessNV = 131072,
        FragmentShadingRateAttachmentKHR = 4194304,
        AccelerationStructureBuildKHR = 33554432,
        RayTracingShaderKHR = 2097152,
        FragmentDensityProcessEXT = 8388608,
        TaskShaderEXT = 524288,
        MeshShaderEXT = 1048576,
        SubpassShaderHuawei = 128,
        InvocationMaskHuawei = 256,
        AccelerationStructureCopyKHR = 268435456,
        MicromapBuildEXT = 1073741824,
        ClusterCullingShaderHuawei = 512,
        Reserved43Arm = 2048,
        OpticalFlowNV = 536870912,
        Reserved42EXT = 1024,
    }
    public static partial class RawConstants
    {
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_NONE = VkPipelineStageFlags2.None;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_TOP_OF_PIPE_BIT = VkPipelineStageFlags2.TopOfPipe;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT = VkPipelineStageFlags2.DrawIndirect;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_VERTEX_INPUT_BIT = VkPipelineStageFlags2.VertexInput;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_VERTEX_SHADER_BIT = VkPipelineStageFlags2.VertexShader;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_TESSELLATION_CONTROL_SHADER_BIT = VkPipelineStageFlags2.TessellationControlShader;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_TESSELLATION_EVALUATION_SHADER_BIT = VkPipelineStageFlags2.TessellationEvaluationShader;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_GEOMETRY_SHADER_BIT = VkPipelineStageFlags2.GeometryShader;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT = VkPipelineStageFlags2.FragmentShader;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT = VkPipelineStageFlags2.EarlyFragmentTests;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT = VkPipelineStageFlags2.LateFragmentTests;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT = VkPipelineStageFlags2.ColorAttachmentOutput;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_COMPUTE_SHADER_BIT = VkPipelineStageFlags2.ComputeShader;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT = VkPipelineStageFlags2.AllTransfer;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_BOTTOM_OF_PIPE_BIT = VkPipelineStageFlags2.BottomOfPipe;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_HOST_BIT = VkPipelineStageFlags2.Host;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_ALL_GRAPHICS_BIT = VkPipelineStageFlags2.AllGraphics;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT = VkPipelineStageFlags2.AllCommands;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_COPY_BIT = VkPipelineStageFlags2.Copy;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_RESOLVE_BIT = VkPipelineStageFlags2.Resolve;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_BLIT_BIT = VkPipelineStageFlags2.Blit;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_CLEAR_BIT = VkPipelineStageFlags2.Clear;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_INDEX_INPUT_BIT = VkPipelineStageFlags2.IndexInput;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT = VkPipelineStageFlags2.VertexAttributeInput;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_PRE_RASTERIZATION_SHADERS_BIT = VkPipelineStageFlags2.PreRasterizationShaders;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_VIDEO_DECODE_BIT_KHR = VkPipelineStageFlags2.VideoDecodeKHR;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_VIDEO_ENCODE_BIT_KHR = VkPipelineStageFlags2.VideoEncodeKHR;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_TRANSFORM_FEEDBACK_BIT_EXT = VkPipelineStageFlags2.TransformFeedbackEXT;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_CONDITIONAL_RENDERING_BIT_EXT = VkPipelineStageFlags2.ConditionalRenderingEXT;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_COMMAND_PREPROCESS_BIT_NV = VkPipelineStageFlags2.CommandPreprocessNV;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = VkPipelineStageFlags2.FragmentShadingRateAttachmentKHR;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_KHR = VkPipelineStageFlags2.AccelerationStructureBuildKHR;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_RAY_TRACING_SHADER_BIT_KHR = VkPipelineStageFlags2.RayTracingShaderKHR;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_FRAGMENT_DENSITY_PROCESS_BIT_EXT = VkPipelineStageFlags2.FragmentDensityProcessEXT;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_TASK_SHADER_BIT_EXT = VkPipelineStageFlags2.TaskShaderEXT;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_MESH_SHADER_BIT_EXT = VkPipelineStageFlags2.MeshShaderEXT;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_SUBPASS_SHADER_BIT_HUAWEI = VkPipelineStageFlags2.SubpassShaderHuawei;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_INVOCATION_MASK_BIT_HUAWEI = VkPipelineStageFlags2.InvocationMaskHuawei;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_COPY_BIT_KHR = VkPipelineStageFlags2.AccelerationStructureCopyKHR;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_MICROMAP_BUILD_BIT_EXT = VkPipelineStageFlags2.MicromapBuildEXT;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_CLUSTER_CULLING_SHADER_BIT_HUAWEI = VkPipelineStageFlags2.ClusterCullingShaderHuawei;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_RESERVED_43_BIT_ARM = VkPipelineStageFlags2.Reserved43Arm;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_OPTICAL_FLOW_BIT_NV = VkPipelineStageFlags2.OpticalFlowNV;
        public const VkPipelineStageFlags2 VK_PIPELINE_STAGE_2_RESERVED_42_BIT_EXT = VkPipelineStageFlags2.Reserved42EXT;
    }

    [Flags]
    public enum VkSubmitFlags : int
    {
        None = 0,
        Protected = 1,
    }
    public static partial class RawConstants
    {
        public const VkSubmitFlags VK_SUBMIT_PROTECTED_BIT = VkSubmitFlags.Protected;
    }

    [Flags]
    public enum VkEventCreateFlags : int
    {
        None = 0,
        DeviceOnly = 1,
    }
    public static partial class RawConstants
    {
        public const VkEventCreateFlags VK_EVENT_CREATE_DEVICE_ONLY_BIT = VkEventCreateFlags.DeviceOnly;
    }

    [Flags]
    public enum VkPipelineLayoutCreateFlags : int
    {
        None = 0,
        Reserved0AMD = 1,
        IndependentSetsEXT = 2,
    }
    public static partial class RawConstants
    {
        public const VkPipelineLayoutCreateFlags VK_PIPELINE_LAYOUT_CREATE_RESERVED_0_BIT_AMD = VkPipelineLayoutCreateFlags.Reserved0AMD;
        public const VkPipelineLayoutCreateFlags VK_PIPELINE_LAYOUT_CREATE_INDEPENDENT_SETS_BIT_EXT = VkPipelineLayoutCreateFlags.IndependentSetsEXT;
    }

    public enum VkSciSyncClientTypeNV : int
    {
        VK_SCI_SYNC_CLIENT_TYPE_SIGNALER_NV = 0,
        VK_SCI_SYNC_CLIENT_TYPE_WAITER_NV = 1,
        VK_SCI_SYNC_CLIENT_TYPE_SIGNALER_WAITER_NV = 2,
    }
    public static partial class RawConstants
    {
        public const VkSciSyncClientTypeNV VK_SCI_SYNC_CLIENT_TYPE_SIGNALER_NV = VkSciSyncClientTypeNV.VK_SCI_SYNC_CLIENT_TYPE_SIGNALER_NV;
        public const VkSciSyncClientTypeNV VK_SCI_SYNC_CLIENT_TYPE_WAITER_NV = VkSciSyncClientTypeNV.VK_SCI_SYNC_CLIENT_TYPE_WAITER_NV;
        public const VkSciSyncClientTypeNV VK_SCI_SYNC_CLIENT_TYPE_SIGNALER_WAITER_NV = VkSciSyncClientTypeNV.VK_SCI_SYNC_CLIENT_TYPE_SIGNALER_WAITER_NV;
    }

    public enum VkSciSyncPrimitiveTypeNV : int
    {
        VK_SCI_SYNC_PRIMITIVE_TYPE_FENCE_NV = 0,
        VK_SCI_SYNC_PRIMITIVE_TYPE_SEMAPHORE_NV = 1,
    }
    public static partial class RawConstants
    {
        public const VkSciSyncPrimitiveTypeNV VK_SCI_SYNC_PRIMITIVE_TYPE_FENCE_NV = VkSciSyncPrimitiveTypeNV.VK_SCI_SYNC_PRIMITIVE_TYPE_FENCE_NV;
        public const VkSciSyncPrimitiveTypeNV VK_SCI_SYNC_PRIMITIVE_TYPE_SEMAPHORE_NV = VkSciSyncPrimitiveTypeNV.VK_SCI_SYNC_PRIMITIVE_TYPE_SEMAPHORE_NV;
    }

    public enum VkProvokingVertexModeEXT : int
    {
        FirstVertexEXT = 0,
        LastVertexEXT = 1,
    }
    public static partial class RawConstants
    {
        public const VkProvokingVertexModeEXT VK_PROVOKING_VERTEX_MODE_FIRST_VERTEX_EXT = VkProvokingVertexModeEXT.FirstVertexEXT;
        public const VkProvokingVertexModeEXT VK_PROVOKING_VERTEX_MODE_LAST_VERTEX_EXT = VkProvokingVertexModeEXT.LastVertexEXT;
    }

    public enum VkPipelineCacheValidationVersion : int
    {
        SafetyCriticalOne = 1,
    }
    public static partial class RawConstants
    {
        public const VkPipelineCacheValidationVersion VK_PIPELINE_CACHE_VALIDATION_VERSION_SAFETY_CRITICAL_ONE = VkPipelineCacheValidationVersion.SafetyCriticalOne;
    }

    public enum VkAccelerationStructureMotionInstanceTypeNV : int
    {
        VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_STATIC_NV = 0,
        VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_MATRIX_MOTION_NV = 1,
        VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_SRT_MOTION_NV = 2,
    }
    public static partial class RawConstants
    {
        public const VkAccelerationStructureMotionInstanceTypeNV VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_STATIC_NV = VkAccelerationStructureMotionInstanceTypeNV.VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_STATIC_NV;
        public const VkAccelerationStructureMotionInstanceTypeNV VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_MATRIX_MOTION_NV = VkAccelerationStructureMotionInstanceTypeNV.VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_MATRIX_MOTION_NV;
        public const VkAccelerationStructureMotionInstanceTypeNV VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_SRT_MOTION_NV = VkAccelerationStructureMotionInstanceTypeNV.VK_ACCELERATION_STRUCTURE_MOTION_INSTANCE_TYPE_SRT_MOTION_NV;
    }

    [Flags]
    public enum VkPipelineColorBlendStateCreateFlagBits : int
    {
        None = 0,
        RasterizationOrderAttachmentAccessEXT = 1,
    }
    public static partial class RawConstants
    {
        public const VkPipelineColorBlendStateCreateFlagBits VK_PIPELINE_COLOR_BLEND_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_ACCESS_BIT_EXT = VkPipelineColorBlendStateCreateFlagBits.RasterizationOrderAttachmentAccessEXT;
    }

    [Flags]
    public enum VkPipelineDepthStencilStateCreateFlagBits : int
    {
        None = 0,
        RasterizationOrderAttachmentDepthAccessEXT = 1,
        RasterizationOrderAttachmentStencilAccessEXT = 2,
    }
    public static partial class RawConstants
    {
        public const VkPipelineDepthStencilStateCreateFlagBits VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_DEPTH_ACCESS_BIT_EXT = VkPipelineDepthStencilStateCreateFlagBits.RasterizationOrderAttachmentDepthAccessEXT;
        public const VkPipelineDepthStencilStateCreateFlagBits VK_PIPELINE_DEPTH_STENCIL_STATE_CREATE_RASTERIZATION_ORDER_ATTACHMENT_STENCIL_ACCESS_BIT_EXT = VkPipelineDepthStencilStateCreateFlagBits.RasterizationOrderAttachmentStencilAccessEXT;
    }

    [Flags]
    public enum VkGraphicsPipelineLibraryFlagsEXT : int
    {
        None = 0,
        VertexInputInterfaceEXT = 1,
        PreRasterizationShadersEXT = 2,
        FragmentShaderEXT = 4,
        FragmentOutputInterfaceEXT = 8,
    }
    public static partial class RawConstants
    {
        public const VkGraphicsPipelineLibraryFlagsEXT VK_GRAPHICS_PIPELINE_LIBRARY_VERTEX_INPUT_INTERFACE_BIT_EXT = VkGraphicsPipelineLibraryFlagsEXT.VertexInputInterfaceEXT;
        public const VkGraphicsPipelineLibraryFlagsEXT VK_GRAPHICS_PIPELINE_LIBRARY_PRE_RASTERIZATION_SHADERS_BIT_EXT = VkGraphicsPipelineLibraryFlagsEXT.PreRasterizationShadersEXT;
        public const VkGraphicsPipelineLibraryFlagsEXT VK_GRAPHICS_PIPELINE_LIBRARY_FRAGMENT_SHADER_BIT_EXT = VkGraphicsPipelineLibraryFlagsEXT.FragmentShaderEXT;
        public const VkGraphicsPipelineLibraryFlagsEXT VK_GRAPHICS_PIPELINE_LIBRARY_FRAGMENT_OUTPUT_INTERFACE_BIT_EXT = VkGraphicsPipelineLibraryFlagsEXT.FragmentOutputInterfaceEXT;
    }

    [Flags]
    public enum VkDeviceAddressBindingFlagsEXT : int
    {
        None = 0,
        InternalObjectEXT = 1,
    }
    public static partial class RawConstants
    {
        public const VkDeviceAddressBindingFlagsEXT VK_DEVICE_ADDRESS_BINDING_INTERNAL_OBJECT_BIT_EXT = VkDeviceAddressBindingFlagsEXT.InternalObjectEXT;
    }

    public enum VkDeviceAddressBindingTypeEXT : int
    {
        BindEXT = 0,
        UnbindEXT = 1,
    }
    public static partial class RawConstants
    {
        public const VkDeviceAddressBindingTypeEXT VK_DEVICE_ADDRESS_BINDING_TYPE_BIND_EXT = VkDeviceAddressBindingTypeEXT.BindEXT;
        public const VkDeviceAddressBindingTypeEXT VK_DEVICE_ADDRESS_BINDING_TYPE_UNBIND_EXT = VkDeviceAddressBindingTypeEXT.UnbindEXT;
    }

    [Flags]
    public enum VkFrameBoundaryFlagsEXT : int
    {
        None = 0,
        FrameEndEXT = 1,
    }
    public static partial class RawConstants
    {
        public const VkFrameBoundaryFlagsEXT VK_FRAME_BOUNDARY_FRAME_END_BIT_EXT = VkFrameBoundaryFlagsEXT.FrameEndEXT;
    }

    [Flags]
    public enum VkPresentScalingFlagsEXT : int
    {
        None = 0,
        OneToOneEXT = 1,
        AspectRatioStretchEXT = 2,
        StretchEXT = 4,
    }
    public static partial class RawConstants
    {
        public const VkPresentScalingFlagsEXT VK_PRESENT_SCALING_ONE_TO_ONE_BIT_EXT = VkPresentScalingFlagsEXT.OneToOneEXT;
        public const VkPresentScalingFlagsEXT VK_PRESENT_SCALING_ASPECT_RATIO_STRETCH_BIT_EXT = VkPresentScalingFlagsEXT.AspectRatioStretchEXT;
        public const VkPresentScalingFlagsEXT VK_PRESENT_SCALING_STRETCH_BIT_EXT = VkPresentScalingFlagsEXT.StretchEXT;
    }

    [Flags]
    public enum VkPresentGravityFlagsEXT : int
    {
        None = 0,
        MinEXT = 1,
        MaxEXT = 2,
        CenteredEXT = 4,
    }
    public static partial class RawConstants
    {
        public const VkPresentGravityFlagsEXT VK_PRESENT_GRAVITY_MIN_BIT_EXT = VkPresentGravityFlagsEXT.MinEXT;
        public const VkPresentGravityFlagsEXT VK_PRESENT_GRAVITY_MAX_BIT_EXT = VkPresentGravityFlagsEXT.MaxEXT;
        public const VkPresentGravityFlagsEXT VK_PRESENT_GRAVITY_CENTERED_BIT_EXT = VkPresentGravityFlagsEXT.CenteredEXT;
    }

    [Flags]
    public enum VkVideoCodecOperationFlagsKHR : int
    {
        None = 0,
        NoneKHR = 0,
        EncodeH264EXT = 65536,
        EncodeH265EXT = 131072,
        DecodeH264KHR = 1,
        DecodeH265KHR = 2,
    }
    public static partial class RawConstants
    {
        public const VkVideoCodecOperationFlagsKHR VK_VIDEO_CODEC_OPERATION_NONE_KHR = VkVideoCodecOperationFlagsKHR.NoneKHR;
        public const VkVideoCodecOperationFlagsKHR VK_VIDEO_CODEC_OPERATION_ENCODE_H264_BIT_EXT = VkVideoCodecOperationFlagsKHR.EncodeH264EXT;
        public const VkVideoCodecOperationFlagsKHR VK_VIDEO_CODEC_OPERATION_ENCODE_H265_BIT_EXT = VkVideoCodecOperationFlagsKHR.EncodeH265EXT;
        public const VkVideoCodecOperationFlagsKHR VK_VIDEO_CODEC_OPERATION_DECODE_H264_BIT_KHR = VkVideoCodecOperationFlagsKHR.DecodeH264KHR;
        public const VkVideoCodecOperationFlagsKHR VK_VIDEO_CODEC_OPERATION_DECODE_H265_BIT_KHR = VkVideoCodecOperationFlagsKHR.DecodeH265KHR;
    }

    [Flags]
    public enum VkVideoChromaSubsamplingFlagsKHR : int
    {
        None = 0,
        InvalidKHR = 0,
        MonochromeKHR = 1,
        _420KHR = 2,
        _422KHR = 4,
        _444KHR = 8,
    }
    public static partial class RawConstants
    {
        public const VkVideoChromaSubsamplingFlagsKHR VK_VIDEO_CHROMA_SUBSAMPLING_INVALID_KHR = VkVideoChromaSubsamplingFlagsKHR.InvalidKHR;
        public const VkVideoChromaSubsamplingFlagsKHR VK_VIDEO_CHROMA_SUBSAMPLING_MONOCHROME_BIT_KHR = VkVideoChromaSubsamplingFlagsKHR.MonochromeKHR;
        public const VkVideoChromaSubsamplingFlagsKHR VK_VIDEO_CHROMA_SUBSAMPLING_420_BIT_KHR = VkVideoChromaSubsamplingFlagsKHR._420KHR;
        public const VkVideoChromaSubsamplingFlagsKHR VK_VIDEO_CHROMA_SUBSAMPLING_422_BIT_KHR = VkVideoChromaSubsamplingFlagsKHR._422KHR;
        public const VkVideoChromaSubsamplingFlagsKHR VK_VIDEO_CHROMA_SUBSAMPLING_444_BIT_KHR = VkVideoChromaSubsamplingFlagsKHR._444KHR;
    }

    [Flags]
    public enum VkVideoComponentBitDepthFlagsKHR : int
    {
        None = 0,
        InvalidKHR = 0,
        _8KHR = 1,
        _10KHR = 4,
        _12KHR = 16,
    }
    public static partial class RawConstants
    {
        public const VkVideoComponentBitDepthFlagsKHR VK_VIDEO_COMPONENT_BIT_DEPTH_INVALID_KHR = VkVideoComponentBitDepthFlagsKHR.InvalidKHR;
        public const VkVideoComponentBitDepthFlagsKHR VK_VIDEO_COMPONENT_BIT_DEPTH_8_BIT_KHR = VkVideoComponentBitDepthFlagsKHR._8KHR;
        public const VkVideoComponentBitDepthFlagsKHR VK_VIDEO_COMPONENT_BIT_DEPTH_10_BIT_KHR = VkVideoComponentBitDepthFlagsKHR._10KHR;
        public const VkVideoComponentBitDepthFlagsKHR VK_VIDEO_COMPONENT_BIT_DEPTH_12_BIT_KHR = VkVideoComponentBitDepthFlagsKHR._12KHR;
    }

    [Flags]
    public enum VkVideoCapabilityFlagsKHR : int
    {
        None = 0,
        ProtectedContentKHR = 1,
        SeparateReferenceImagesKHR = 2,
    }
    public static partial class RawConstants
    {
        public const VkVideoCapabilityFlagsKHR VK_VIDEO_CAPABILITY_PROTECTED_CONTENT_BIT_KHR = VkVideoCapabilityFlagsKHR.ProtectedContentKHR;
        public const VkVideoCapabilityFlagsKHR VK_VIDEO_CAPABILITY_SEPARATE_REFERENCE_IMAGES_BIT_KHR = VkVideoCapabilityFlagsKHR.SeparateReferenceImagesKHR;
    }

    [Flags]
    public enum VkVideoSessionCreateFlagsKHR : int
    {
        None = 0,
        ProtectedContentKHR = 1,
        AllowEncodeParameterOptimizationsKHR = 2,
    }
    public static partial class RawConstants
    {
        public const VkVideoSessionCreateFlagsKHR VK_VIDEO_SESSION_CREATE_PROTECTED_CONTENT_BIT_KHR = VkVideoSessionCreateFlagsKHR.ProtectedContentKHR;
        public const VkVideoSessionCreateFlagsKHR VK_VIDEO_SESSION_CREATE_ALLOW_ENCODE_PARAMETER_OPTIMIZATIONS_BIT_KHR = VkVideoSessionCreateFlagsKHR.AllowEncodeParameterOptimizationsKHR;
    }

    [Flags]
    public enum VkVideoDecodeH264PictureLayoutFlagsKHR : int
    {
        None = 0,
        ProgressiveKHR = 0,
        InterlacedInterleavedLinesKHR = 1,
        InterlacedSeparatePlanesKHR = 2,
    }
    public static partial class RawConstants
    {
        public const VkVideoDecodeH264PictureLayoutFlagsKHR VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_PROGRESSIVE_KHR = VkVideoDecodeH264PictureLayoutFlagsKHR.ProgressiveKHR;
        public const VkVideoDecodeH264PictureLayoutFlagsKHR VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_INTERLACED_INTERLEAVED_LINES_BIT_KHR = VkVideoDecodeH264PictureLayoutFlagsKHR.InterlacedInterleavedLinesKHR;
        public const VkVideoDecodeH264PictureLayoutFlagsKHR VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_INTERLACED_SEPARATE_PLANES_BIT_KHR = VkVideoDecodeH264PictureLayoutFlagsKHR.InterlacedSeparatePlanesKHR;
    }

    [Flags]
    public enum VkVideoCodingControlFlagsKHR : int
    {
        None = 0,
        ResetKHR = 1,
        EncodeRateControlKHR = 2,
        EncodeQualityLevelKHR = 4,
    }
    public static partial class RawConstants
    {
        public const VkVideoCodingControlFlagsKHR VK_VIDEO_CODING_CONTROL_RESET_BIT_KHR = VkVideoCodingControlFlagsKHR.ResetKHR;
        public const VkVideoCodingControlFlagsKHR VK_VIDEO_CODING_CONTROL_ENCODE_RATE_CONTROL_BIT_KHR = VkVideoCodingControlFlagsKHR.EncodeRateControlKHR;
        public const VkVideoCodingControlFlagsKHR VK_VIDEO_CODING_CONTROL_ENCODE_QUALITY_LEVEL_BIT_KHR = VkVideoCodingControlFlagsKHR.EncodeQualityLevelKHR;
    }

    public enum VkQueryResultStatusKHR : int
    {
        ErrorKHR = -1,
        NotReadyKHR = 0,
        CompleteKHR = 1,
        InsufficientBitstreamBufferRangeKHR = -1000299000,
    }
    public static partial class RawConstants
    {
        public const VkQueryResultStatusKHR VK_QUERY_RESULT_STATUS_ERROR_KHR = VkQueryResultStatusKHR.ErrorKHR;
        public const VkQueryResultStatusKHR VK_QUERY_RESULT_STATUS_NOT_READY_KHR = VkQueryResultStatusKHR.NotReadyKHR;
        public const VkQueryResultStatusKHR VK_QUERY_RESULT_STATUS_COMPLETE_KHR = VkQueryResultStatusKHR.CompleteKHR;
        public const VkQueryResultStatusKHR VK_QUERY_RESULT_STATUS_INSUFFICIENT_BITSTREAM_BUFFER_RANGE_KHR = VkQueryResultStatusKHR.InsufficientBitstreamBufferRangeKHR;
    }

    [Flags]
    public enum VkVideoDecodeUsageFlagsKHR : int
    {
        None = 0,
        DefaultKHR = 0,
        TranscodingKHR = 1,
        OfflineKHR = 2,
        StreamingKHR = 4,
    }
    public static partial class RawConstants
    {
        public const VkVideoDecodeUsageFlagsKHR VK_VIDEO_DECODE_USAGE_DEFAULT_KHR = VkVideoDecodeUsageFlagsKHR.DefaultKHR;
        public const VkVideoDecodeUsageFlagsKHR VK_VIDEO_DECODE_USAGE_TRANSCODING_BIT_KHR = VkVideoDecodeUsageFlagsKHR.TranscodingKHR;
        public const VkVideoDecodeUsageFlagsKHR VK_VIDEO_DECODE_USAGE_OFFLINE_BIT_KHR = VkVideoDecodeUsageFlagsKHR.OfflineKHR;
        public const VkVideoDecodeUsageFlagsKHR VK_VIDEO_DECODE_USAGE_STREAMING_BIT_KHR = VkVideoDecodeUsageFlagsKHR.StreamingKHR;
    }

    [Flags]
    public enum VkVideoDecodeCapabilityFlagsKHR : int
    {
        None = 0,
        DpbAndOutputCoincideKHR = 1,
        DpbAndOutputDistinctKHR = 2,
    }
    public static partial class RawConstants
    {
        public const VkVideoDecodeCapabilityFlagsKHR VK_VIDEO_DECODE_CAPABILITY_DPB_AND_OUTPUT_COINCIDE_BIT_KHR = VkVideoDecodeCapabilityFlagsKHR.DpbAndOutputCoincideKHR;
        public const VkVideoDecodeCapabilityFlagsKHR VK_VIDEO_DECODE_CAPABILITY_DPB_AND_OUTPUT_DISTINCT_BIT_KHR = VkVideoDecodeCapabilityFlagsKHR.DpbAndOutputDistinctKHR;
    }

    [Flags]
    public enum VkVideoEncodeUsageFlagsKHR : int
    {
        None = 0,
        DefaultKHR = 0,
        TranscodingKHR = 1,
        StreamingKHR = 2,
        RecordingKHR = 4,
        ConferencingKHR = 8,
    }
    public static partial class RawConstants
    {
        public const VkVideoEncodeUsageFlagsKHR VK_VIDEO_ENCODE_USAGE_DEFAULT_KHR = VkVideoEncodeUsageFlagsKHR.DefaultKHR;
        public const VkVideoEncodeUsageFlagsKHR VK_VIDEO_ENCODE_USAGE_TRANSCODING_BIT_KHR = VkVideoEncodeUsageFlagsKHR.TranscodingKHR;
        public const VkVideoEncodeUsageFlagsKHR VK_VIDEO_ENCODE_USAGE_STREAMING_BIT_KHR = VkVideoEncodeUsageFlagsKHR.StreamingKHR;
        public const VkVideoEncodeUsageFlagsKHR VK_VIDEO_ENCODE_USAGE_RECORDING_BIT_KHR = VkVideoEncodeUsageFlagsKHR.RecordingKHR;
        public const VkVideoEncodeUsageFlagsKHR VK_VIDEO_ENCODE_USAGE_CONFERENCING_BIT_KHR = VkVideoEncodeUsageFlagsKHR.ConferencingKHR;
    }

    [Flags]
    public enum VkVideoEncodeContentFlagsKHR : int
    {
        None = 0,
        DefaultKHR = 0,
        CameraKHR = 1,
        DesktopKHR = 2,
        RenderedKHR = 4,
    }
    public static partial class RawConstants
    {
        public const VkVideoEncodeContentFlagsKHR VK_VIDEO_ENCODE_CONTENT_DEFAULT_KHR = VkVideoEncodeContentFlagsKHR.DefaultKHR;
        public const VkVideoEncodeContentFlagsKHR VK_VIDEO_ENCODE_CONTENT_CAMERA_BIT_KHR = VkVideoEncodeContentFlagsKHR.CameraKHR;
        public const VkVideoEncodeContentFlagsKHR VK_VIDEO_ENCODE_CONTENT_DESKTOP_BIT_KHR = VkVideoEncodeContentFlagsKHR.DesktopKHR;
        public const VkVideoEncodeContentFlagsKHR VK_VIDEO_ENCODE_CONTENT_RENDERED_BIT_KHR = VkVideoEncodeContentFlagsKHR.RenderedKHR;
    }

    public enum VkVideoEncodeTuningModeKHR : int
    {
        DefaultKHR = 0,
        HighQualityKHR = 1,
        LowLatencyKHR = 2,
        UltraLowLatencyKHR = 3,
        LosslessKHR = 4,
    }
    public static partial class RawConstants
    {
        public const VkVideoEncodeTuningModeKHR VK_VIDEO_ENCODE_TUNING_MODE_DEFAULT_KHR = VkVideoEncodeTuningModeKHR.DefaultKHR;
        public const VkVideoEncodeTuningModeKHR VK_VIDEO_ENCODE_TUNING_MODE_HIGH_QUALITY_KHR = VkVideoEncodeTuningModeKHR.HighQualityKHR;
        public const VkVideoEncodeTuningModeKHR VK_VIDEO_ENCODE_TUNING_MODE_LOW_LATENCY_KHR = VkVideoEncodeTuningModeKHR.LowLatencyKHR;
        public const VkVideoEncodeTuningModeKHR VK_VIDEO_ENCODE_TUNING_MODE_ULTRA_LOW_LATENCY_KHR = VkVideoEncodeTuningModeKHR.UltraLowLatencyKHR;
        public const VkVideoEncodeTuningModeKHR VK_VIDEO_ENCODE_TUNING_MODE_LOSSLESS_KHR = VkVideoEncodeTuningModeKHR.LosslessKHR;
    }

    [Flags]
    public enum VkVideoEncodeCapabilityFlagsKHR : int
    {
        None = 0,
        PrecedingExternallyEncodedBytesKHR = 1,
        InsufficientBitstreamBufferRangeDetectionKHR = 2,
    }
    public static partial class RawConstants
    {
        public const VkVideoEncodeCapabilityFlagsKHR VK_VIDEO_ENCODE_CAPABILITY_PRECEDING_EXTERNALLY_ENCODED_BYTES_BIT_KHR = VkVideoEncodeCapabilityFlagsKHR.PrecedingExternallyEncodedBytesKHR;
        public const VkVideoEncodeCapabilityFlagsKHR VK_VIDEO_ENCODE_CAPABILITY_INSUFFICIENT_BITSTREAM_BUFFER_RANGE_DETECTION_BIT_KHR = VkVideoEncodeCapabilityFlagsKHR.InsufficientBitstreamBufferRangeDetectionKHR;
    }

    [Flags]
    public enum VkVideoEncodeFeedbackFlagsKHR : int
    {
        None = 0,
        BitstreamBufferOffsetKHR = 1,
        BitstreamBytesWrittenKHR = 2,
        BitstreamHasOverridesKHR = 4,
    }
    public static partial class RawConstants
    {
        public const VkVideoEncodeFeedbackFlagsKHR VK_VIDEO_ENCODE_FEEDBACK_BITSTREAM_BUFFER_OFFSET_BIT_KHR = VkVideoEncodeFeedbackFlagsKHR.BitstreamBufferOffsetKHR;
        public const VkVideoEncodeFeedbackFlagsKHR VK_VIDEO_ENCODE_FEEDBACK_BITSTREAM_BYTES_WRITTEN_BIT_KHR = VkVideoEncodeFeedbackFlagsKHR.BitstreamBytesWrittenKHR;
        public const VkVideoEncodeFeedbackFlagsKHR VK_VIDEO_ENCODE_FEEDBACK_BITSTREAM_HAS_OVERRIDES_BIT_KHR = VkVideoEncodeFeedbackFlagsKHR.BitstreamHasOverridesKHR;
    }

    [Flags]
    public enum VkVideoEncodeRateControlModeFlagsKHR : int
    {
        None = 0,
        DefaultKHR = 0,
        DisabledKHR = 1,
        CbrKHR = 2,
        VbrKHR = 4,
    }
    public static partial class RawConstants
    {
        public const VkVideoEncodeRateControlModeFlagsKHR VK_VIDEO_ENCODE_RATE_CONTROL_MODE_DEFAULT_KHR = VkVideoEncodeRateControlModeFlagsKHR.DefaultKHR;
        public const VkVideoEncodeRateControlModeFlagsKHR VK_VIDEO_ENCODE_RATE_CONTROL_MODE_DISABLED_BIT_KHR = VkVideoEncodeRateControlModeFlagsKHR.DisabledKHR;
        public const VkVideoEncodeRateControlModeFlagsKHR VK_VIDEO_ENCODE_RATE_CONTROL_MODE_CBR_BIT_KHR = VkVideoEncodeRateControlModeFlagsKHR.CbrKHR;
        public const VkVideoEncodeRateControlModeFlagsKHR VK_VIDEO_ENCODE_RATE_CONTROL_MODE_VBR_BIT_KHR = VkVideoEncodeRateControlModeFlagsKHR.VbrKHR;
    }

    [Flags]
    public enum VkVideoEncodeH264CapabilityFlagsEXT : int
    {
        None = 0,
        HrdComplianceEXT = 1,
        PredictionWeightTableGeneratedEXT = 2,
        RowUnalignedSliceEXT = 4,
        DifferentSliceTypeEXT = 8,
        BFrameInL0ListEXT = 16,
        BFrameInL1ListEXT = 32,
        PerPictureTypeMinMaxQpEXT = 64,
        PerSliceConstantQpEXT = 128,
        GeneratePrefixNaluEXT = 256,
    }
    public static partial class RawConstants
    {
        public const VkVideoEncodeH264CapabilityFlagsEXT VK_VIDEO_ENCODE_H264_CAPABILITY_HRD_COMPLIANCE_BIT_EXT = VkVideoEncodeH264CapabilityFlagsEXT.HrdComplianceEXT;
        public const VkVideoEncodeH264CapabilityFlagsEXT VK_VIDEO_ENCODE_H264_CAPABILITY_PREDICTION_WEIGHT_TABLE_GENERATED_BIT_EXT = VkVideoEncodeH264CapabilityFlagsEXT.PredictionWeightTableGeneratedEXT;
        public const VkVideoEncodeH264CapabilityFlagsEXT VK_VIDEO_ENCODE_H264_CAPABILITY_ROW_UNALIGNED_SLICE_BIT_EXT = VkVideoEncodeH264CapabilityFlagsEXT.RowUnalignedSliceEXT;
        public const VkVideoEncodeH264CapabilityFlagsEXT VK_VIDEO_ENCODE_H264_CAPABILITY_DIFFERENT_SLICE_TYPE_BIT_EXT = VkVideoEncodeH264CapabilityFlagsEXT.DifferentSliceTypeEXT;
        public const VkVideoEncodeH264CapabilityFlagsEXT VK_VIDEO_ENCODE_H264_CAPABILITY_B_FRAME_IN_L0_LIST_BIT_EXT = VkVideoEncodeH264CapabilityFlagsEXT.BFrameInL0ListEXT;
        public const VkVideoEncodeH264CapabilityFlagsEXT VK_VIDEO_ENCODE_H264_CAPABILITY_B_FRAME_IN_L1_LIST_BIT_EXT = VkVideoEncodeH264CapabilityFlagsEXT.BFrameInL1ListEXT;
        public const VkVideoEncodeH264CapabilityFlagsEXT VK_VIDEO_ENCODE_H264_CAPABILITY_PER_PICTURE_TYPE_MIN_MAX_QP_BIT_EXT = VkVideoEncodeH264CapabilityFlagsEXT.PerPictureTypeMinMaxQpEXT;
        public const VkVideoEncodeH264CapabilityFlagsEXT VK_VIDEO_ENCODE_H264_CAPABILITY_PER_SLICE_CONSTANT_QP_BIT_EXT = VkVideoEncodeH264CapabilityFlagsEXT.PerSliceConstantQpEXT;
        public const VkVideoEncodeH264CapabilityFlagsEXT VK_VIDEO_ENCODE_H264_CAPABILITY_GENERATE_PREFIX_NALU_BIT_EXT = VkVideoEncodeH264CapabilityFlagsEXT.GeneratePrefixNaluEXT;
    }

    [Flags]
    public enum VkVideoEncodeH264StdFlagsEXT : int
    {
        None = 0,
        SeparateColorPlaneFlagSetEXT = 1,
        QpprimeYZeroTransformBypassFlagSetEXT = 2,
        ScalingMatrixPresentFlagSetEXT = 4,
        ChromaQpIndexOffsetEXT = 8,
        SecondChromaQpIndexOffsetEXT = 16,
        PicInitQpMinus26EXT = 32,
        WeightedPredFlagSetEXT = 64,
        WeightedBipredIdcExplicitEXT = 128,
        WeightedBipredIdcImplicitEXT = 256,
        Transform8x8ModeFlagSetEXT = 512,
        DirectSpatialMvPredFlagUnsetEXT = 1024,
        EntropyCodingModeFlagUnsetEXT = 2048,
        EntropyCodingModeFlagSetEXT = 4096,
        Direct8x8InferenceFlagUnsetEXT = 8192,
        ConstrainedIntraPredFlagSetEXT = 16384,
        DeblockingFilterDisabledEXT = 32768,
        DeblockingFilterEnabledEXT = 65536,
        DeblockingFilterPartialEXT = 131072,
        SliceQpDeltaEXT = 524288,
        DifferentSliceQpDeltaEXT = 1048576,
    }
    public static partial class RawConstants
    {
        public const VkVideoEncodeH264StdFlagsEXT VK_VIDEO_ENCODE_H264_STD_SEPARATE_COLOR_PLANE_FLAG_SET_BIT_EXT = VkVideoEncodeH264StdFlagsEXT.SeparateColorPlaneFlagSetEXT;
        public const VkVideoEncodeH264StdFlagsEXT VK_VIDEO_ENCODE_H264_STD_QPPRIME_Y_ZERO_TRANSFORM_BYPASS_FLAG_SET_BIT_EXT = VkVideoEncodeH264StdFlagsEXT.QpprimeYZeroTransformBypassFlagSetEXT;
        public const VkVideoEncodeH264StdFlagsEXT VK_VIDEO_ENCODE_H264_STD_SCALING_MATRIX_PRESENT_FLAG_SET_BIT_EXT = VkVideoEncodeH264StdFlagsEXT.ScalingMatrixPresentFlagSetEXT;
        public const VkVideoEncodeH264StdFlagsEXT VK_VIDEO_ENCODE_H264_STD_CHROMA_QP_INDEX_OFFSET_BIT_EXT = VkVideoEncodeH264StdFlagsEXT.ChromaQpIndexOffsetEXT;
        public const VkVideoEncodeH264StdFlagsEXT VK_VIDEO_ENCODE_H264_STD_SECOND_CHROMA_QP_INDEX_OFFSET_BIT_EXT = VkVideoEncodeH264StdFlagsEXT.SecondChromaQpIndexOffsetEXT;
        public const VkVideoEncodeH264StdFlagsEXT VK_VIDEO_ENCODE_H264_STD_PIC_INIT_QP_MINUS26_BIT_EXT = VkVideoEncodeH264StdFlagsEXT.PicInitQpMinus26EXT;
        public const VkVideoEncodeH264StdFlagsEXT VK_VIDEO_ENCODE_H264_STD_WEIGHTED_PRED_FLAG_SET_BIT_EXT = VkVideoEncodeH264StdFlagsEXT.WeightedPredFlagSetEXT;
        public const VkVideoEncodeH264StdFlagsEXT VK_VIDEO_ENCODE_H264_STD_WEIGHTED_BIPRED_IDC_EXPLICIT_BIT_EXT = VkVideoEncodeH264StdFlagsEXT.WeightedBipredIdcExplicitEXT;
        public const VkVideoEncodeH264StdFlagsEXT VK_VIDEO_ENCODE_H264_STD_WEIGHTED_BIPRED_IDC_IMPLICIT_BIT_EXT = VkVideoEncodeH264StdFlagsEXT.WeightedBipredIdcImplicitEXT;
        public const VkVideoEncodeH264StdFlagsEXT VK_VIDEO_ENCODE_H264_STD_TRANSFORM_8X8_MODE_FLAG_SET_BIT_EXT = VkVideoEncodeH264StdFlagsEXT.Transform8x8ModeFlagSetEXT;
        public const VkVideoEncodeH264StdFlagsEXT VK_VIDEO_ENCODE_H264_STD_DIRECT_SPATIAL_MV_PRED_FLAG_UNSET_BIT_EXT = VkVideoEncodeH264StdFlagsEXT.DirectSpatialMvPredFlagUnsetEXT;
        public const VkVideoEncodeH264StdFlagsEXT VK_VIDEO_ENCODE_H264_STD_ENTROPY_CODING_MODE_FLAG_UNSET_BIT_EXT = VkVideoEncodeH264StdFlagsEXT.EntropyCodingModeFlagUnsetEXT;
        public const VkVideoEncodeH264StdFlagsEXT VK_VIDEO_ENCODE_H264_STD_ENTROPY_CODING_MODE_FLAG_SET_BIT_EXT = VkVideoEncodeH264StdFlagsEXT.EntropyCodingModeFlagSetEXT;
        public const VkVideoEncodeH264StdFlagsEXT VK_VIDEO_ENCODE_H264_STD_DIRECT_8X8_INFERENCE_FLAG_UNSET_BIT_EXT = VkVideoEncodeH264StdFlagsEXT.Direct8x8InferenceFlagUnsetEXT;
        public const VkVideoEncodeH264StdFlagsEXT VK_VIDEO_ENCODE_H264_STD_CONSTRAINED_INTRA_PRED_FLAG_SET_BIT_EXT = VkVideoEncodeH264StdFlagsEXT.ConstrainedIntraPredFlagSetEXT;
        public const VkVideoEncodeH264StdFlagsEXT VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_DISABLED_BIT_EXT = VkVideoEncodeH264StdFlagsEXT.DeblockingFilterDisabledEXT;
        public const VkVideoEncodeH264StdFlagsEXT VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_ENABLED_BIT_EXT = VkVideoEncodeH264StdFlagsEXT.DeblockingFilterEnabledEXT;
        public const VkVideoEncodeH264StdFlagsEXT VK_VIDEO_ENCODE_H264_STD_DEBLOCKING_FILTER_PARTIAL_BIT_EXT = VkVideoEncodeH264StdFlagsEXT.DeblockingFilterPartialEXT;
        public const VkVideoEncodeH264StdFlagsEXT VK_VIDEO_ENCODE_H264_STD_SLICE_QP_DELTA_BIT_EXT = VkVideoEncodeH264StdFlagsEXT.SliceQpDeltaEXT;
        public const VkVideoEncodeH264StdFlagsEXT VK_VIDEO_ENCODE_H264_STD_DIFFERENT_SLICE_QP_DELTA_BIT_EXT = VkVideoEncodeH264StdFlagsEXT.DifferentSliceQpDeltaEXT;
    }

    [Flags]
    public enum VkVideoEncodeH264RateControlFlagsEXT : int
    {
        None = 0,
        AttemptHrdComplianceEXT = 1,
        RegularGopEXT = 2,
        ReferencePatternFlatEXT = 4,
        ReferencePatternDyadicEXT = 8,
        TemporalLayerPatternDyadicEXT = 16,
    }
    public static partial class RawConstants
    {
        public const VkVideoEncodeH264RateControlFlagsEXT VK_VIDEO_ENCODE_H264_RATE_CONTROL_ATTEMPT_HRD_COMPLIANCE_BIT_EXT = VkVideoEncodeH264RateControlFlagsEXT.AttemptHrdComplianceEXT;
        public const VkVideoEncodeH264RateControlFlagsEXT VK_VIDEO_ENCODE_H264_RATE_CONTROL_REGULAR_GOP_BIT_EXT = VkVideoEncodeH264RateControlFlagsEXT.RegularGopEXT;
        public const VkVideoEncodeH264RateControlFlagsEXT VK_VIDEO_ENCODE_H264_RATE_CONTROL_REFERENCE_PATTERN_FLAT_BIT_EXT = VkVideoEncodeH264RateControlFlagsEXT.ReferencePatternFlatEXT;
        public const VkVideoEncodeH264RateControlFlagsEXT VK_VIDEO_ENCODE_H264_RATE_CONTROL_REFERENCE_PATTERN_DYADIC_BIT_EXT = VkVideoEncodeH264RateControlFlagsEXT.ReferencePatternDyadicEXT;
        public const VkVideoEncodeH264RateControlFlagsEXT VK_VIDEO_ENCODE_H264_RATE_CONTROL_TEMPORAL_LAYER_PATTERN_DYADIC_BIT_EXT = VkVideoEncodeH264RateControlFlagsEXT.TemporalLayerPatternDyadicEXT;
    }

    [Flags]
    public enum VkHostImageCopyFlagsEXT : int
    {
        None = 0,
        MemcpyEXT = 1,
    }
    public static partial class RawConstants
    {
        public const VkHostImageCopyFlagsEXT VK_HOST_IMAGE_COPY_MEMCPY_EXT = VkHostImageCopyFlagsEXT.MemcpyEXT;
    }

    [Flags]
    public enum VkImageFormatConstraintsFlagBitsFUCHSIA : int
    {
        None = 0,
    }
    public static partial class RawConstants
    {
    }

    [Flags]
    public enum VkImageConstraintsInfoFlagsFUCHSIA : int
    {
        None = 0,
        CpuReadRarelyFuchsia = 1,
        CpuReadOftenFuchsia = 2,
        CpuWriteRarelyFuchsia = 4,
        CpuWriteOftenFuchsia = 8,
        ProtectedOptionalFuchsia = 16,
    }
    public static partial class RawConstants
    {
        public const VkImageConstraintsInfoFlagsFUCHSIA VK_IMAGE_CONSTRAINTS_INFO_CPU_READ_RARELY_FUCHSIA = VkImageConstraintsInfoFlagsFUCHSIA.CpuReadRarelyFuchsia;
        public const VkImageConstraintsInfoFlagsFUCHSIA VK_IMAGE_CONSTRAINTS_INFO_CPU_READ_OFTEN_FUCHSIA = VkImageConstraintsInfoFlagsFUCHSIA.CpuReadOftenFuchsia;
        public const VkImageConstraintsInfoFlagsFUCHSIA VK_IMAGE_CONSTRAINTS_INFO_CPU_WRITE_RARELY_FUCHSIA = VkImageConstraintsInfoFlagsFUCHSIA.CpuWriteRarelyFuchsia;
        public const VkImageConstraintsInfoFlagsFUCHSIA VK_IMAGE_CONSTRAINTS_INFO_CPU_WRITE_OFTEN_FUCHSIA = VkImageConstraintsInfoFlagsFUCHSIA.CpuWriteOftenFuchsia;
        public const VkImageConstraintsInfoFlagsFUCHSIA VK_IMAGE_CONSTRAINTS_INFO_PROTECTED_OPTIONAL_FUCHSIA = VkImageConstraintsInfoFlagsFUCHSIA.ProtectedOptionalFuchsia;
    }

    [Flags]
    public enum VkFormatFeatureFlags2 : long
    {
        None = 0,
        SampledImage = 1,
        StorageImage = 2,
        StorageImageAtomic = 4,
        UniformTexelBuffer = 8,
        StorageTexelBuffer = 16,
        StorageTexelBufferAtomic = 32,
        VertexBuffer = 64,
        ColorAttachment = 128,
        ColorAttachmentBlend = 256,
        DepthStencilAttachment = 512,
        BlitSrc = 1024,
        BlitDst = 2048,
        SampledImageFilterLinear = 4096,
        SampledImageFilterCubic = 8192,
        TransferSrc = 16384,
        TransferDst = 32768,
        SampledImageFilterMinmax = 65536,
        MidpointChromaSamples = 131072,
        SampledImageYcbcrConversionLinearFilter = 262144,
        SampledImageYcbcrConversionSeparateReconstructionFilter = 524288,
        SampledImageYcbcrConversionChromaReconstructionExplicit = 1048576,
        SampledImageYcbcrConversionChromaReconstructionExplicitForceable = 2097152,
        Disjoint = 4194304,
        CositedChromaSamples = 8388608,
        StorageReadWithoutFormat = 2147483648,
        StorageWriteWithoutFormat = 4294967296,
        SampledImageDepthComparison = 8589934592,
        VideoDecodeOutputKHR = 33554432,
        VideoDecodeDpbKHR = 67108864,
        AccelerationStructureVertexBufferKHR = 536870912,
        FragmentDensityMapEXT = 16777216,
        FragmentShadingRateAttachmentKHR = 1073741824,
        Reserved44EXT = 4096,
        Reserved45EXT = 8192,
        HostImageTransferEXT = 16384,
        VideoEncodeInputKHR = 134217728,
        VideoEncodeDpbKHR = 268435456,
        LinearColorAttachmentNV = 64,
        WeightImageQcom = 4,
        WeightSampledImageQcom = 8,
        BlockMatchingQcom = 16,
        BoxFilterSampledQcom = 32,
        Reserved47Arm = 32768,
        Reserved39EXT = 128,
        OpticalFlowImageNV = 256,
        OpticalFlowVectorNV = 512,
        OpticalFlowCostNV = 1024,
        Reserved48EXT = 65536,
    }
    public static partial class RawConstants
    {
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT = VkFormatFeatureFlags2.SampledImage;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_STORAGE_IMAGE_BIT = VkFormatFeatureFlags2.StorageImage;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_STORAGE_IMAGE_ATOMIC_BIT = VkFormatFeatureFlags2.StorageImageAtomic;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_UNIFORM_TEXEL_BUFFER_BIT = VkFormatFeatureFlags2.UniformTexelBuffer;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_BIT = VkFormatFeatureFlags2.StorageTexelBuffer;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_STORAGE_TEXEL_BUFFER_ATOMIC_BIT = VkFormatFeatureFlags2.StorageTexelBufferAtomic;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_VERTEX_BUFFER_BIT = VkFormatFeatureFlags2.VertexBuffer;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BIT = VkFormatFeatureFlags2.ColorAttachment;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BLEND_BIT = VkFormatFeatureFlags2.ColorAttachmentBlend;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_DEPTH_STENCIL_ATTACHMENT_BIT = VkFormatFeatureFlags2.DepthStencilAttachment;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_BLIT_SRC_BIT = VkFormatFeatureFlags2.BlitSrc;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_BLIT_DST_BIT = VkFormatFeatureFlags2.BlitDst;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_LINEAR_BIT = VkFormatFeatureFlags2.SampledImageFilterLinear;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_CUBIC_BIT = VkFormatFeatureFlags2.SampledImageFilterCubic;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_TRANSFER_SRC_BIT = VkFormatFeatureFlags2.TransferSrc;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_TRANSFER_DST_BIT = VkFormatFeatureFlags2.TransferDst;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_MINMAX_BIT = VkFormatFeatureFlags2.SampledImageFilterMinmax;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_MIDPOINT_CHROMA_SAMPLES_BIT = VkFormatFeatureFlags2.MidpointChromaSamples;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT = VkFormatFeatureFlags2.SampledImageYcbcrConversionLinearFilter;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT = VkFormatFeatureFlags2.SampledImageYcbcrConversionSeparateReconstructionFilter;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT = VkFormatFeatureFlags2.SampledImageYcbcrConversionChromaReconstructionExplicit;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT = VkFormatFeatureFlags2.SampledImageYcbcrConversionChromaReconstructionExplicitForceable;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_DISJOINT_BIT = VkFormatFeatureFlags2.Disjoint;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_COSITED_CHROMA_SAMPLES_BIT = VkFormatFeatureFlags2.CositedChromaSamples;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_STORAGE_READ_WITHOUT_FORMAT_BIT = VkFormatFeatureFlags2.StorageReadWithoutFormat;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_STORAGE_WRITE_WITHOUT_FORMAT_BIT = VkFormatFeatureFlags2.StorageWriteWithoutFormat;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_DEPTH_COMPARISON_BIT = VkFormatFeatureFlags2.SampledImageDepthComparison;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_VIDEO_DECODE_OUTPUT_BIT_KHR = VkFormatFeatureFlags2.VideoDecodeOutputKHR;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_VIDEO_DECODE_DPB_BIT_KHR = VkFormatFeatureFlags2.VideoDecodeDpbKHR;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_ACCELERATION_STRUCTURE_VERTEX_BUFFER_BIT_KHR = VkFormatFeatureFlags2.AccelerationStructureVertexBufferKHR;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_FRAGMENT_DENSITY_MAP_BIT_EXT = VkFormatFeatureFlags2.FragmentDensityMapEXT;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = VkFormatFeatureFlags2.FragmentShadingRateAttachmentKHR;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_RESERVED_44_BIT_EXT = VkFormatFeatureFlags2.Reserved44EXT;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_RESERVED_45_BIT_EXT = VkFormatFeatureFlags2.Reserved45EXT;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_HOST_IMAGE_TRANSFER_BIT_EXT = VkFormatFeatureFlags2.HostImageTransferEXT;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_VIDEO_ENCODE_INPUT_BIT_KHR = VkFormatFeatureFlags2.VideoEncodeInputKHR;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_VIDEO_ENCODE_DPB_BIT_KHR = VkFormatFeatureFlags2.VideoEncodeDpbKHR;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_LINEAR_COLOR_ATTACHMENT_BIT_NV = VkFormatFeatureFlags2.LinearColorAttachmentNV;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_WEIGHT_IMAGE_BIT_QCOM = VkFormatFeatureFlags2.WeightImageQcom;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_WEIGHT_SAMPLED_IMAGE_BIT_QCOM = VkFormatFeatureFlags2.WeightSampledImageQcom;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_BLOCK_MATCHING_BIT_QCOM = VkFormatFeatureFlags2.BlockMatchingQcom;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_BOX_FILTER_SAMPLED_BIT_QCOM = VkFormatFeatureFlags2.BoxFilterSampledQcom;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_RESERVED_47_BIT_ARM = VkFormatFeatureFlags2.Reserved47Arm;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_RESERVED_39_BIT_EXT = VkFormatFeatureFlags2.Reserved39EXT;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_OPTICAL_FLOW_IMAGE_BIT_NV = VkFormatFeatureFlags2.OpticalFlowImageNV;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_OPTICAL_FLOW_VECTOR_BIT_NV = VkFormatFeatureFlags2.OpticalFlowVectorNV;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_OPTICAL_FLOW_COST_BIT_NV = VkFormatFeatureFlags2.OpticalFlowCostNV;
        public const VkFormatFeatureFlags2 VK_FORMAT_FEATURE_2_RESERVED_48_BIT_EXT = VkFormatFeatureFlags2.Reserved48EXT;
    }

    [Flags]
    public enum VkRenderingFlags : int
    {
        None = 0,
        ContentsSecondaryCommandBuffers = 1,
        Suspending = 2,
        Resuming = 4,
        EnableLegacyDitheringEXT = 8,
    }
    public static partial class RawConstants
    {
        public const VkRenderingFlags VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT = VkRenderingFlags.ContentsSecondaryCommandBuffers;
        public const VkRenderingFlags VK_RENDERING_SUSPENDING_BIT = VkRenderingFlags.Suspending;
        public const VkRenderingFlags VK_RENDERING_RESUMING_BIT = VkRenderingFlags.Resuming;
        public const VkRenderingFlags VK_RENDERING_ENABLE_LEGACY_DITHERING_BIT_EXT = VkRenderingFlags.EnableLegacyDitheringEXT;
    }

    [Flags]
    public enum VkVideoEncodeH265CapabilityFlagsEXT : int
    {
        None = 0,
        HrdComplianceEXT = 1,
        PredictionWeightTableGeneratedEXT = 2,
        RowUnalignedSliceSegmentEXT = 4,
        DifferentSliceSegmentTypeEXT = 8,
        BFrameInL0ListEXT = 16,
        BFrameInL1ListEXT = 32,
        PerPictureTypeMinMaxQpEXT = 64,
        PerSliceSegmentConstantQpEXT = 128,
        MultipleTilesPerSliceSegmentEXT = 256,
        MultipleSliceSegmentsPerTileEXT = 512,
    }
    public static partial class RawConstants
    {
        public const VkVideoEncodeH265CapabilityFlagsEXT VK_VIDEO_ENCODE_H265_CAPABILITY_HRD_COMPLIANCE_BIT_EXT = VkVideoEncodeH265CapabilityFlagsEXT.HrdComplianceEXT;
        public const VkVideoEncodeH265CapabilityFlagsEXT VK_VIDEO_ENCODE_H265_CAPABILITY_PREDICTION_WEIGHT_TABLE_GENERATED_BIT_EXT = VkVideoEncodeH265CapabilityFlagsEXT.PredictionWeightTableGeneratedEXT;
        public const VkVideoEncodeH265CapabilityFlagsEXT VK_VIDEO_ENCODE_H265_CAPABILITY_ROW_UNALIGNED_SLICE_SEGMENT_BIT_EXT = VkVideoEncodeH265CapabilityFlagsEXT.RowUnalignedSliceSegmentEXT;
        public const VkVideoEncodeH265CapabilityFlagsEXT VK_VIDEO_ENCODE_H265_CAPABILITY_DIFFERENT_SLICE_SEGMENT_TYPE_BIT_EXT = VkVideoEncodeH265CapabilityFlagsEXT.DifferentSliceSegmentTypeEXT;
        public const VkVideoEncodeH265CapabilityFlagsEXT VK_VIDEO_ENCODE_H265_CAPABILITY_B_FRAME_IN_L0_LIST_BIT_EXT = VkVideoEncodeH265CapabilityFlagsEXT.BFrameInL0ListEXT;
        public const VkVideoEncodeH265CapabilityFlagsEXT VK_VIDEO_ENCODE_H265_CAPABILITY_B_FRAME_IN_L1_LIST_BIT_EXT = VkVideoEncodeH265CapabilityFlagsEXT.BFrameInL1ListEXT;
        public const VkVideoEncodeH265CapabilityFlagsEXT VK_VIDEO_ENCODE_H265_CAPABILITY_PER_PICTURE_TYPE_MIN_MAX_QP_BIT_EXT = VkVideoEncodeH265CapabilityFlagsEXT.PerPictureTypeMinMaxQpEXT;
        public const VkVideoEncodeH265CapabilityFlagsEXT VK_VIDEO_ENCODE_H265_CAPABILITY_PER_SLICE_SEGMENT_CONSTANT_QP_BIT_EXT = VkVideoEncodeH265CapabilityFlagsEXT.PerSliceSegmentConstantQpEXT;
        public const VkVideoEncodeH265CapabilityFlagsEXT VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_TILES_PER_SLICE_SEGMENT_BIT_EXT = VkVideoEncodeH265CapabilityFlagsEXT.MultipleTilesPerSliceSegmentEXT;
        public const VkVideoEncodeH265CapabilityFlagsEXT VK_VIDEO_ENCODE_H265_CAPABILITY_MULTIPLE_SLICE_SEGMENTS_PER_TILE_BIT_EXT = VkVideoEncodeH265CapabilityFlagsEXT.MultipleSliceSegmentsPerTileEXT;
    }

    [Flags]
    public enum VkVideoEncodeH265StdFlagsEXT : int
    {
        None = 0,
        SeparateColorPlaneFlagSetEXT = 1,
        SampleAdaptiveOffsetEnabledFlagSetEXT = 2,
        ScalingListDataPresentFlagSetEXT = 4,
        PcmEnabledFlagSetEXT = 8,
        SpsTemporalMvpEnabledFlagSetEXT = 16,
        InitQpMinus26EXT = 32,
        WeightedPredFlagSetEXT = 64,
        WeightedBipredFlagSetEXT = 128,
        Log2ParallelMergeLevelMinus2EXT = 256,
        SignDataHidingEnabledFlagSetEXT = 512,
        TransformSkipEnabledFlagSetEXT = 1024,
        TransformSkipEnabledFlagUnsetEXT = 2048,
        PpsSliceChromaQpOffsetsPresentFlagSetEXT = 4096,
        TransquantBypassEnabledFlagSetEXT = 8192,
        ConstrainedIntraPredFlagSetEXT = 16384,
        EntropyCodingSyncEnabledFlagSetEXT = 32768,
        DeblockingFilterOverrideEnabledFlagSetEXT = 65536,
        DependentSliceSegmentsEnabledFlagSetEXT = 131072,
        DependentSliceSegmentFlagSetEXT = 262144,
        SliceQpDeltaEXT = 524288,
        DifferentSliceQpDeltaEXT = 1048576,
    }
    public static partial class RawConstants
    {
        public const VkVideoEncodeH265StdFlagsEXT VK_VIDEO_ENCODE_H265_STD_SEPARATE_COLOR_PLANE_FLAG_SET_BIT_EXT = VkVideoEncodeH265StdFlagsEXT.SeparateColorPlaneFlagSetEXT;
        public const VkVideoEncodeH265StdFlagsEXT VK_VIDEO_ENCODE_H265_STD_SAMPLE_ADAPTIVE_OFFSET_ENABLED_FLAG_SET_BIT_EXT = VkVideoEncodeH265StdFlagsEXT.SampleAdaptiveOffsetEnabledFlagSetEXT;
        public const VkVideoEncodeH265StdFlagsEXT VK_VIDEO_ENCODE_H265_STD_SCALING_LIST_DATA_PRESENT_FLAG_SET_BIT_EXT = VkVideoEncodeH265StdFlagsEXT.ScalingListDataPresentFlagSetEXT;
        public const VkVideoEncodeH265StdFlagsEXT VK_VIDEO_ENCODE_H265_STD_PCM_ENABLED_FLAG_SET_BIT_EXT = VkVideoEncodeH265StdFlagsEXT.PcmEnabledFlagSetEXT;
        public const VkVideoEncodeH265StdFlagsEXT VK_VIDEO_ENCODE_H265_STD_SPS_TEMPORAL_MVP_ENABLED_FLAG_SET_BIT_EXT = VkVideoEncodeH265StdFlagsEXT.SpsTemporalMvpEnabledFlagSetEXT;
        public const VkVideoEncodeH265StdFlagsEXT VK_VIDEO_ENCODE_H265_STD_INIT_QP_MINUS26_BIT_EXT = VkVideoEncodeH265StdFlagsEXT.InitQpMinus26EXT;
        public const VkVideoEncodeH265StdFlagsEXT VK_VIDEO_ENCODE_H265_STD_WEIGHTED_PRED_FLAG_SET_BIT_EXT = VkVideoEncodeH265StdFlagsEXT.WeightedPredFlagSetEXT;
        public const VkVideoEncodeH265StdFlagsEXT VK_VIDEO_ENCODE_H265_STD_WEIGHTED_BIPRED_FLAG_SET_BIT_EXT = VkVideoEncodeH265StdFlagsEXT.WeightedBipredFlagSetEXT;
        public const VkVideoEncodeH265StdFlagsEXT VK_VIDEO_ENCODE_H265_STD_LOG2_PARALLEL_MERGE_LEVEL_MINUS2_BIT_EXT = VkVideoEncodeH265StdFlagsEXT.Log2ParallelMergeLevelMinus2EXT;
        public const VkVideoEncodeH265StdFlagsEXT VK_VIDEO_ENCODE_H265_STD_SIGN_DATA_HIDING_ENABLED_FLAG_SET_BIT_EXT = VkVideoEncodeH265StdFlagsEXT.SignDataHidingEnabledFlagSetEXT;
        public const VkVideoEncodeH265StdFlagsEXT VK_VIDEO_ENCODE_H265_STD_TRANSFORM_SKIP_ENABLED_FLAG_SET_BIT_EXT = VkVideoEncodeH265StdFlagsEXT.TransformSkipEnabledFlagSetEXT;
        public const VkVideoEncodeH265StdFlagsEXT VK_VIDEO_ENCODE_H265_STD_TRANSFORM_SKIP_ENABLED_FLAG_UNSET_BIT_EXT = VkVideoEncodeH265StdFlagsEXT.TransformSkipEnabledFlagUnsetEXT;
        public const VkVideoEncodeH265StdFlagsEXT VK_VIDEO_ENCODE_H265_STD_PPS_SLICE_CHROMA_QP_OFFSETS_PRESENT_FLAG_SET_BIT_EXT = VkVideoEncodeH265StdFlagsEXT.PpsSliceChromaQpOffsetsPresentFlagSetEXT;
        public const VkVideoEncodeH265StdFlagsEXT VK_VIDEO_ENCODE_H265_STD_TRANSQUANT_BYPASS_ENABLED_FLAG_SET_BIT_EXT = VkVideoEncodeH265StdFlagsEXT.TransquantBypassEnabledFlagSetEXT;
        public const VkVideoEncodeH265StdFlagsEXT VK_VIDEO_ENCODE_H265_STD_CONSTRAINED_INTRA_PRED_FLAG_SET_BIT_EXT = VkVideoEncodeH265StdFlagsEXT.ConstrainedIntraPredFlagSetEXT;
        public const VkVideoEncodeH265StdFlagsEXT VK_VIDEO_ENCODE_H265_STD_ENTROPY_CODING_SYNC_ENABLED_FLAG_SET_BIT_EXT = VkVideoEncodeH265StdFlagsEXT.EntropyCodingSyncEnabledFlagSetEXT;
        public const VkVideoEncodeH265StdFlagsEXT VK_VIDEO_ENCODE_H265_STD_DEBLOCKING_FILTER_OVERRIDE_ENABLED_FLAG_SET_BIT_EXT = VkVideoEncodeH265StdFlagsEXT.DeblockingFilterOverrideEnabledFlagSetEXT;
        public const VkVideoEncodeH265StdFlagsEXT VK_VIDEO_ENCODE_H265_STD_DEPENDENT_SLICE_SEGMENTS_ENABLED_FLAG_SET_BIT_EXT = VkVideoEncodeH265StdFlagsEXT.DependentSliceSegmentsEnabledFlagSetEXT;
        public const VkVideoEncodeH265StdFlagsEXT VK_VIDEO_ENCODE_H265_STD_DEPENDENT_SLICE_SEGMENT_FLAG_SET_BIT_EXT = VkVideoEncodeH265StdFlagsEXT.DependentSliceSegmentFlagSetEXT;
        public const VkVideoEncodeH265StdFlagsEXT VK_VIDEO_ENCODE_H265_STD_SLICE_QP_DELTA_BIT_EXT = VkVideoEncodeH265StdFlagsEXT.SliceQpDeltaEXT;
        public const VkVideoEncodeH265StdFlagsEXT VK_VIDEO_ENCODE_H265_STD_DIFFERENT_SLICE_QP_DELTA_BIT_EXT = VkVideoEncodeH265StdFlagsEXT.DifferentSliceQpDeltaEXT;
    }

    [Flags]
    public enum VkVideoEncodeH265RateControlFlagsEXT : int
    {
        None = 0,
        AttemptHrdComplianceEXT = 1,
        RegularGopEXT = 2,
        ReferencePatternFlatEXT = 4,
        ReferencePatternDyadicEXT = 8,
        TemporalSubLayerPatternDyadicEXT = 16,
    }
    public static partial class RawConstants
    {
        public const VkVideoEncodeH265RateControlFlagsEXT VK_VIDEO_ENCODE_H265_RATE_CONTROL_ATTEMPT_HRD_COMPLIANCE_BIT_EXT = VkVideoEncodeH265RateControlFlagsEXT.AttemptHrdComplianceEXT;
        public const VkVideoEncodeH265RateControlFlagsEXT VK_VIDEO_ENCODE_H265_RATE_CONTROL_REGULAR_GOP_BIT_EXT = VkVideoEncodeH265RateControlFlagsEXT.RegularGopEXT;
        public const VkVideoEncodeH265RateControlFlagsEXT VK_VIDEO_ENCODE_H265_RATE_CONTROL_REFERENCE_PATTERN_FLAT_BIT_EXT = VkVideoEncodeH265RateControlFlagsEXT.ReferencePatternFlatEXT;
        public const VkVideoEncodeH265RateControlFlagsEXT VK_VIDEO_ENCODE_H265_RATE_CONTROL_REFERENCE_PATTERN_DYADIC_BIT_EXT = VkVideoEncodeH265RateControlFlagsEXT.ReferencePatternDyadicEXT;
        public const VkVideoEncodeH265RateControlFlagsEXT VK_VIDEO_ENCODE_H265_RATE_CONTROL_TEMPORAL_SUB_LAYER_PATTERN_DYADIC_BIT_EXT = VkVideoEncodeH265RateControlFlagsEXT.TemporalSubLayerPatternDyadicEXT;
    }

    [Flags]
    public enum VkVideoEncodeH265CtbSizeFlagsEXT : int
    {
        None = 0,
        _16EXT = 1,
        _32EXT = 2,
        _64EXT = 4,
    }
    public static partial class RawConstants
    {
        public const VkVideoEncodeH265CtbSizeFlagsEXT VK_VIDEO_ENCODE_H265_CTB_SIZE_16_BIT_EXT = VkVideoEncodeH265CtbSizeFlagsEXT._16EXT;
        public const VkVideoEncodeH265CtbSizeFlagsEXT VK_VIDEO_ENCODE_H265_CTB_SIZE_32_BIT_EXT = VkVideoEncodeH265CtbSizeFlagsEXT._32EXT;
        public const VkVideoEncodeH265CtbSizeFlagsEXT VK_VIDEO_ENCODE_H265_CTB_SIZE_64_BIT_EXT = VkVideoEncodeH265CtbSizeFlagsEXT._64EXT;
    }

    [Flags]
    public enum VkVideoEncodeH265TransformBlockSizeFlagsEXT : int
    {
        None = 0,
        _4EXT = 1,
        _8EXT = 2,
        _16EXT = 4,
        _32EXT = 8,
    }
    public static partial class RawConstants
    {
        public const VkVideoEncodeH265TransformBlockSizeFlagsEXT VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_4_BIT_EXT = VkVideoEncodeH265TransformBlockSizeFlagsEXT._4EXT;
        public const VkVideoEncodeH265TransformBlockSizeFlagsEXT VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_8_BIT_EXT = VkVideoEncodeH265TransformBlockSizeFlagsEXT._8EXT;
        public const VkVideoEncodeH265TransformBlockSizeFlagsEXT VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_16_BIT_EXT = VkVideoEncodeH265TransformBlockSizeFlagsEXT._16EXT;
        public const VkVideoEncodeH265TransformBlockSizeFlagsEXT VK_VIDEO_ENCODE_H265_TRANSFORM_BLOCK_SIZE_32_BIT_EXT = VkVideoEncodeH265TransformBlockSizeFlagsEXT._32EXT;
    }

    [Flags]
    public enum VkExportMetalObjectTypeFlagsEXT : int
    {
        None = 0,
        MetalDeviceEXT = 1,
        MetalCommandQueueEXT = 2,
        MetalBufferEXT = 4,
        MetalTextureEXT = 8,
        MetalIosurfaceEXT = 16,
        MetalSharedEventEXT = 32,
    }
    public static partial class RawConstants
    {
        public const VkExportMetalObjectTypeFlagsEXT VK_EXPORT_METAL_OBJECT_TYPE_METAL_DEVICE_BIT_EXT = VkExportMetalObjectTypeFlagsEXT.MetalDeviceEXT;
        public const VkExportMetalObjectTypeFlagsEXT VK_EXPORT_METAL_OBJECT_TYPE_METAL_COMMAND_QUEUE_BIT_EXT = VkExportMetalObjectTypeFlagsEXT.MetalCommandQueueEXT;
        public const VkExportMetalObjectTypeFlagsEXT VK_EXPORT_METAL_OBJECT_TYPE_METAL_BUFFER_BIT_EXT = VkExportMetalObjectTypeFlagsEXT.MetalBufferEXT;
        public const VkExportMetalObjectTypeFlagsEXT VK_EXPORT_METAL_OBJECT_TYPE_METAL_TEXTURE_BIT_EXT = VkExportMetalObjectTypeFlagsEXT.MetalTextureEXT;
        public const VkExportMetalObjectTypeFlagsEXT VK_EXPORT_METAL_OBJECT_TYPE_METAL_IOSURFACE_BIT_EXT = VkExportMetalObjectTypeFlagsEXT.MetalIosurfaceEXT;
        public const VkExportMetalObjectTypeFlagsEXT VK_EXPORT_METAL_OBJECT_TYPE_METAL_SHARED_EVENT_BIT_EXT = VkExportMetalObjectTypeFlagsEXT.MetalSharedEventEXT;
    }

    [Flags]
    public enum VkInstanceCreateFlags : int
    {
        None = 0,
        EnumeratePortabilityKHR = 1,
    }
    public static partial class RawConstants
    {
        public const VkInstanceCreateFlags VK_INSTANCE_CREATE_ENUMERATE_PORTABILITY_BIT_KHR = VkInstanceCreateFlags.EnumeratePortabilityKHR;
    }

    [Flags]
    public enum VkImageCompressionFlagsEXT : int
    {
        None = 0,
        DefaultEXT = 0,
        FixedRateDefaultEXT = 1,
        FixedRateExplicitEXT = 2,
        DisabledEXT = 4,
    }
    public static partial class RawConstants
    {
        public const VkImageCompressionFlagsEXT VK_IMAGE_COMPRESSION_DEFAULT_EXT = VkImageCompressionFlagsEXT.DefaultEXT;
        public const VkImageCompressionFlagsEXT VK_IMAGE_COMPRESSION_FIXED_RATE_DEFAULT_EXT = VkImageCompressionFlagsEXT.FixedRateDefaultEXT;
        public const VkImageCompressionFlagsEXT VK_IMAGE_COMPRESSION_FIXED_RATE_EXPLICIT_EXT = VkImageCompressionFlagsEXT.FixedRateExplicitEXT;
        public const VkImageCompressionFlagsEXT VK_IMAGE_COMPRESSION_DISABLED_EXT = VkImageCompressionFlagsEXT.DisabledEXT;
    }

    [Flags]
    public enum VkImageCompressionFixedRateFlagsEXT : int
    {
        None = 0,
        NoneEXT = 0,
        _1bpcEXT = 1,
        _2bpcEXT = 2,
        _3bpcEXT = 4,
        _4bpcEXT = 8,
        _5bpcEXT = 16,
        _6bpcEXT = 32,
        _7bpcEXT = 64,
        _8bpcEXT = 128,
        _9bpcEXT = 256,
        _10bpcEXT = 512,
        _11bpcEXT = 1024,
        _12bpcEXT = 2048,
        _13bpcEXT = 4096,
        _14bpcEXT = 8192,
        _15bpcEXT = 16384,
        _16bpcEXT = 32768,
        _17bpcEXT = 65536,
        _18bpcEXT = 131072,
        _19bpcEXT = 262144,
        _20bpcEXT = 524288,
        _21bpcEXT = 1048576,
        _22bpcEXT = 2097152,
        _23bpcEXT = 4194304,
        _24bpcEXT = 8388608,
    }
    public static partial class RawConstants
    {
        public const VkImageCompressionFixedRateFlagsEXT VK_IMAGE_COMPRESSION_FIXED_RATE_NONE_EXT = VkImageCompressionFixedRateFlagsEXT.NoneEXT;
        public const VkImageCompressionFixedRateFlagsEXT VK_IMAGE_COMPRESSION_FIXED_RATE_1BPC_BIT_EXT = VkImageCompressionFixedRateFlagsEXT._1bpcEXT;
        public const VkImageCompressionFixedRateFlagsEXT VK_IMAGE_COMPRESSION_FIXED_RATE_2BPC_BIT_EXT = VkImageCompressionFixedRateFlagsEXT._2bpcEXT;
        public const VkImageCompressionFixedRateFlagsEXT VK_IMAGE_COMPRESSION_FIXED_RATE_3BPC_BIT_EXT = VkImageCompressionFixedRateFlagsEXT._3bpcEXT;
        public const VkImageCompressionFixedRateFlagsEXT VK_IMAGE_COMPRESSION_FIXED_RATE_4BPC_BIT_EXT = VkImageCompressionFixedRateFlagsEXT._4bpcEXT;
        public const VkImageCompressionFixedRateFlagsEXT VK_IMAGE_COMPRESSION_FIXED_RATE_5BPC_BIT_EXT = VkImageCompressionFixedRateFlagsEXT._5bpcEXT;
        public const VkImageCompressionFixedRateFlagsEXT VK_IMAGE_COMPRESSION_FIXED_RATE_6BPC_BIT_EXT = VkImageCompressionFixedRateFlagsEXT._6bpcEXT;
        public const VkImageCompressionFixedRateFlagsEXT VK_IMAGE_COMPRESSION_FIXED_RATE_7BPC_BIT_EXT = VkImageCompressionFixedRateFlagsEXT._7bpcEXT;
        public const VkImageCompressionFixedRateFlagsEXT VK_IMAGE_COMPRESSION_FIXED_RATE_8BPC_BIT_EXT = VkImageCompressionFixedRateFlagsEXT._8bpcEXT;
        public const VkImageCompressionFixedRateFlagsEXT VK_IMAGE_COMPRESSION_FIXED_RATE_9BPC_BIT_EXT = VkImageCompressionFixedRateFlagsEXT._9bpcEXT;
        public const VkImageCompressionFixedRateFlagsEXT VK_IMAGE_COMPRESSION_FIXED_RATE_10BPC_BIT_EXT = VkImageCompressionFixedRateFlagsEXT._10bpcEXT;
        public const VkImageCompressionFixedRateFlagsEXT VK_IMAGE_COMPRESSION_FIXED_RATE_11BPC_BIT_EXT = VkImageCompressionFixedRateFlagsEXT._11bpcEXT;
        public const VkImageCompressionFixedRateFlagsEXT VK_IMAGE_COMPRESSION_FIXED_RATE_12BPC_BIT_EXT = VkImageCompressionFixedRateFlagsEXT._12bpcEXT;
        public const VkImageCompressionFixedRateFlagsEXT VK_IMAGE_COMPRESSION_FIXED_RATE_13BPC_BIT_EXT = VkImageCompressionFixedRateFlagsEXT._13bpcEXT;
        public const VkImageCompressionFixedRateFlagsEXT VK_IMAGE_COMPRESSION_FIXED_RATE_14BPC_BIT_EXT = VkImageCompressionFixedRateFlagsEXT._14bpcEXT;
        public const VkImageCompressionFixedRateFlagsEXT VK_IMAGE_COMPRESSION_FIXED_RATE_15BPC_BIT_EXT = VkImageCompressionFixedRateFlagsEXT._15bpcEXT;
        public const VkImageCompressionFixedRateFlagsEXT VK_IMAGE_COMPRESSION_FIXED_RATE_16BPC_BIT_EXT = VkImageCompressionFixedRateFlagsEXT._16bpcEXT;
        public const VkImageCompressionFixedRateFlagsEXT VK_IMAGE_COMPRESSION_FIXED_RATE_17BPC_BIT_EXT = VkImageCompressionFixedRateFlagsEXT._17bpcEXT;
        public const VkImageCompressionFixedRateFlagsEXT VK_IMAGE_COMPRESSION_FIXED_RATE_18BPC_BIT_EXT = VkImageCompressionFixedRateFlagsEXT._18bpcEXT;
        public const VkImageCompressionFixedRateFlagsEXT VK_IMAGE_COMPRESSION_FIXED_RATE_19BPC_BIT_EXT = VkImageCompressionFixedRateFlagsEXT._19bpcEXT;
        public const VkImageCompressionFixedRateFlagsEXT VK_IMAGE_COMPRESSION_FIXED_RATE_20BPC_BIT_EXT = VkImageCompressionFixedRateFlagsEXT._20bpcEXT;
        public const VkImageCompressionFixedRateFlagsEXT VK_IMAGE_COMPRESSION_FIXED_RATE_21BPC_BIT_EXT = VkImageCompressionFixedRateFlagsEXT._21bpcEXT;
        public const VkImageCompressionFixedRateFlagsEXT VK_IMAGE_COMPRESSION_FIXED_RATE_22BPC_BIT_EXT = VkImageCompressionFixedRateFlagsEXT._22bpcEXT;
        public const VkImageCompressionFixedRateFlagsEXT VK_IMAGE_COMPRESSION_FIXED_RATE_23BPC_BIT_EXT = VkImageCompressionFixedRateFlagsEXT._23bpcEXT;
        public const VkImageCompressionFixedRateFlagsEXT VK_IMAGE_COMPRESSION_FIXED_RATE_24BPC_BIT_EXT = VkImageCompressionFixedRateFlagsEXT._24bpcEXT;
    }

    public enum VkPipelineRobustnessBufferBehaviorEXT : int
    {
        DeviceDefaultEXT = 0,
        DisabledEXT = 1,
        RobustBufferAccessEXT = 2,
        RobustBufferAccess2EXT = 3,
    }
    public static partial class RawConstants
    {
        public const VkPipelineRobustnessBufferBehaviorEXT VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DEVICE_DEFAULT_EXT = VkPipelineRobustnessBufferBehaviorEXT.DeviceDefaultEXT;
        public const VkPipelineRobustnessBufferBehaviorEXT VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_DISABLED_EXT = VkPipelineRobustnessBufferBehaviorEXT.DisabledEXT;
        public const VkPipelineRobustnessBufferBehaviorEXT VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS_EXT = VkPipelineRobustnessBufferBehaviorEXT.RobustBufferAccessEXT;
        public const VkPipelineRobustnessBufferBehaviorEXT VK_PIPELINE_ROBUSTNESS_BUFFER_BEHAVIOR_ROBUST_BUFFER_ACCESS_2_EXT = VkPipelineRobustnessBufferBehaviorEXT.RobustBufferAccess2EXT;
    }

    public enum VkPipelineRobustnessImageBehaviorEXT : int
    {
        DeviceDefaultEXT = 0,
        DisabledEXT = 1,
        RobustImageAccessEXT = 2,
        RobustImageAccess2EXT = 3,
    }
    public static partial class RawConstants
    {
        public const VkPipelineRobustnessImageBehaviorEXT VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DEVICE_DEFAULT_EXT = VkPipelineRobustnessImageBehaviorEXT.DeviceDefaultEXT;
        public const VkPipelineRobustnessImageBehaviorEXT VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_DISABLED_EXT = VkPipelineRobustnessImageBehaviorEXT.DisabledEXT;
        public const VkPipelineRobustnessImageBehaviorEXT VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS_EXT = VkPipelineRobustnessImageBehaviorEXT.RobustImageAccessEXT;
        public const VkPipelineRobustnessImageBehaviorEXT VK_PIPELINE_ROBUSTNESS_IMAGE_BEHAVIOR_ROBUST_IMAGE_ACCESS_2_EXT = VkPipelineRobustnessImageBehaviorEXT.RobustImageAccess2EXT;
    }

    [Flags]
    public enum VkOpticalFlowGridSizeFlagsNV : int
    {
        None = 0,
        UnknownNV = 0,
        _1x1NV = 1,
        _2x2NV = 2,
        _4x4NV = 4,
        _8x8NV = 8,
    }
    public static partial class RawConstants
    {
        public const VkOpticalFlowGridSizeFlagsNV VK_OPTICAL_FLOW_GRID_SIZE_UNKNOWN_NV = VkOpticalFlowGridSizeFlagsNV.UnknownNV;
        public const VkOpticalFlowGridSizeFlagsNV VK_OPTICAL_FLOW_GRID_SIZE_1X1_BIT_NV = VkOpticalFlowGridSizeFlagsNV._1x1NV;
        public const VkOpticalFlowGridSizeFlagsNV VK_OPTICAL_FLOW_GRID_SIZE_2X2_BIT_NV = VkOpticalFlowGridSizeFlagsNV._2x2NV;
        public const VkOpticalFlowGridSizeFlagsNV VK_OPTICAL_FLOW_GRID_SIZE_4X4_BIT_NV = VkOpticalFlowGridSizeFlagsNV._4x4NV;
        public const VkOpticalFlowGridSizeFlagsNV VK_OPTICAL_FLOW_GRID_SIZE_8X8_BIT_NV = VkOpticalFlowGridSizeFlagsNV._8x8NV;
    }

    [Flags]
    public enum VkOpticalFlowUsageFlagsNV : int
    {
        None = 0,
        UnknownNV = 0,
        InputNV = 1,
        OutputNV = 2,
        HintNV = 4,
        CostNV = 8,
        GlobalFlowNV = 16,
    }
    public static partial class RawConstants
    {
        public const VkOpticalFlowUsageFlagsNV VK_OPTICAL_FLOW_USAGE_UNKNOWN_NV = VkOpticalFlowUsageFlagsNV.UnknownNV;
        public const VkOpticalFlowUsageFlagsNV VK_OPTICAL_FLOW_USAGE_INPUT_BIT_NV = VkOpticalFlowUsageFlagsNV.InputNV;
        public const VkOpticalFlowUsageFlagsNV VK_OPTICAL_FLOW_USAGE_OUTPUT_BIT_NV = VkOpticalFlowUsageFlagsNV.OutputNV;
        public const VkOpticalFlowUsageFlagsNV VK_OPTICAL_FLOW_USAGE_HINT_BIT_NV = VkOpticalFlowUsageFlagsNV.HintNV;
        public const VkOpticalFlowUsageFlagsNV VK_OPTICAL_FLOW_USAGE_COST_BIT_NV = VkOpticalFlowUsageFlagsNV.CostNV;
        public const VkOpticalFlowUsageFlagsNV VK_OPTICAL_FLOW_USAGE_GLOBAL_FLOW_BIT_NV = VkOpticalFlowUsageFlagsNV.GlobalFlowNV;
    }

    public enum VkOpticalFlowPerformanceLevelNV : int
    {
        VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_UNKNOWN_NV = 0,
        VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_SLOW_NV = 1,
        VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_MEDIUM_NV = 2,
        VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_FAST_NV = 3,
    }
    public static partial class RawConstants
    {
        public const VkOpticalFlowPerformanceLevelNV VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_UNKNOWN_NV = VkOpticalFlowPerformanceLevelNV.VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_UNKNOWN_NV;
        public const VkOpticalFlowPerformanceLevelNV VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_SLOW_NV = VkOpticalFlowPerformanceLevelNV.VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_SLOW_NV;
        public const VkOpticalFlowPerformanceLevelNV VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_MEDIUM_NV = VkOpticalFlowPerformanceLevelNV.VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_MEDIUM_NV;
        public const VkOpticalFlowPerformanceLevelNV VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_FAST_NV = VkOpticalFlowPerformanceLevelNV.VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_FAST_NV;
    }

    public enum VkOpticalFlowSessionBindingPointNV : int
    {
        VK_OPTICAL_FLOW_SESSION_BINDING_POINT_UNKNOWN_NV = 0,
        VK_OPTICAL_FLOW_SESSION_BINDING_POINT_INPUT_NV = 1,
        VK_OPTICAL_FLOW_SESSION_BINDING_POINT_REFERENCE_NV = 2,
        VK_OPTICAL_FLOW_SESSION_BINDING_POINT_HINT_NV = 3,
        VK_OPTICAL_FLOW_SESSION_BINDING_POINT_FLOW_VECTOR_NV = 4,
        VK_OPTICAL_FLOW_SESSION_BINDING_POINT_BACKWARD_FLOW_VECTOR_NV = 5,
        VK_OPTICAL_FLOW_SESSION_BINDING_POINT_COST_NV = 6,
        VK_OPTICAL_FLOW_SESSION_BINDING_POINT_BACKWARD_COST_NV = 7,
        VK_OPTICAL_FLOW_SESSION_BINDING_POINT_GLOBAL_FLOW_NV = 8,
    }
    public static partial class RawConstants
    {
        public const VkOpticalFlowSessionBindingPointNV VK_OPTICAL_FLOW_SESSION_BINDING_POINT_UNKNOWN_NV = VkOpticalFlowSessionBindingPointNV.VK_OPTICAL_FLOW_SESSION_BINDING_POINT_UNKNOWN_NV;
        public const VkOpticalFlowSessionBindingPointNV VK_OPTICAL_FLOW_SESSION_BINDING_POINT_INPUT_NV = VkOpticalFlowSessionBindingPointNV.VK_OPTICAL_FLOW_SESSION_BINDING_POINT_INPUT_NV;
        public const VkOpticalFlowSessionBindingPointNV VK_OPTICAL_FLOW_SESSION_BINDING_POINT_REFERENCE_NV = VkOpticalFlowSessionBindingPointNV.VK_OPTICAL_FLOW_SESSION_BINDING_POINT_REFERENCE_NV;
        public const VkOpticalFlowSessionBindingPointNV VK_OPTICAL_FLOW_SESSION_BINDING_POINT_HINT_NV = VkOpticalFlowSessionBindingPointNV.VK_OPTICAL_FLOW_SESSION_BINDING_POINT_HINT_NV;
        public const VkOpticalFlowSessionBindingPointNV VK_OPTICAL_FLOW_SESSION_BINDING_POINT_FLOW_VECTOR_NV = VkOpticalFlowSessionBindingPointNV.VK_OPTICAL_FLOW_SESSION_BINDING_POINT_FLOW_VECTOR_NV;
        public const VkOpticalFlowSessionBindingPointNV VK_OPTICAL_FLOW_SESSION_BINDING_POINT_BACKWARD_FLOW_VECTOR_NV = VkOpticalFlowSessionBindingPointNV.VK_OPTICAL_FLOW_SESSION_BINDING_POINT_BACKWARD_FLOW_VECTOR_NV;
        public const VkOpticalFlowSessionBindingPointNV VK_OPTICAL_FLOW_SESSION_BINDING_POINT_COST_NV = VkOpticalFlowSessionBindingPointNV.VK_OPTICAL_FLOW_SESSION_BINDING_POINT_COST_NV;
        public const VkOpticalFlowSessionBindingPointNV VK_OPTICAL_FLOW_SESSION_BINDING_POINT_BACKWARD_COST_NV = VkOpticalFlowSessionBindingPointNV.VK_OPTICAL_FLOW_SESSION_BINDING_POINT_BACKWARD_COST_NV;
        public const VkOpticalFlowSessionBindingPointNV VK_OPTICAL_FLOW_SESSION_BINDING_POINT_GLOBAL_FLOW_NV = VkOpticalFlowSessionBindingPointNV.VK_OPTICAL_FLOW_SESSION_BINDING_POINT_GLOBAL_FLOW_NV;
    }

    [Flags]
    public enum VkOpticalFlowSessionCreateFlagsNV : int
    {
        None = 0,
        EnableHintNV = 1,
        EnableCostNV = 2,
        EnableGlobalFlowNV = 4,
        AllowRegionsNV = 8,
        BothDirectionsNV = 16,
    }
    public static partial class RawConstants
    {
        public const VkOpticalFlowSessionCreateFlagsNV VK_OPTICAL_FLOW_SESSION_CREATE_ENABLE_HINT_BIT_NV = VkOpticalFlowSessionCreateFlagsNV.EnableHintNV;
        public const VkOpticalFlowSessionCreateFlagsNV VK_OPTICAL_FLOW_SESSION_CREATE_ENABLE_COST_BIT_NV = VkOpticalFlowSessionCreateFlagsNV.EnableCostNV;
        public const VkOpticalFlowSessionCreateFlagsNV VK_OPTICAL_FLOW_SESSION_CREATE_ENABLE_GLOBAL_FLOW_BIT_NV = VkOpticalFlowSessionCreateFlagsNV.EnableGlobalFlowNV;
        public const VkOpticalFlowSessionCreateFlagsNV VK_OPTICAL_FLOW_SESSION_CREATE_ALLOW_REGIONS_BIT_NV = VkOpticalFlowSessionCreateFlagsNV.AllowRegionsNV;
        public const VkOpticalFlowSessionCreateFlagsNV VK_OPTICAL_FLOW_SESSION_CREATE_BOTH_DIRECTIONS_BIT_NV = VkOpticalFlowSessionCreateFlagsNV.BothDirectionsNV;
    }

    [Flags]
    public enum VkOpticalFlowExecuteFlagsNV : int
    {
        None = 0,
        DisableTemporalHintsNV = 1,
    }
    public static partial class RawConstants
    {
        public const VkOpticalFlowExecuteFlagsNV VK_OPTICAL_FLOW_EXECUTE_DISABLE_TEMPORAL_HINTS_BIT_NV = VkOpticalFlowExecuteFlagsNV.DisableTemporalHintsNV;
    }

    public enum VkMicromapTypeEXT : int
    {
        OpacityMicromapEXT = 0,
        DisplacementMicromapNV = 1000397000,
    }
    public static partial class RawConstants
    {
        public const VkMicromapTypeEXT VK_MICROMAP_TYPE_OPACITY_MICROMAP_EXT = VkMicromapTypeEXT.OpacityMicromapEXT;
        public const VkMicromapTypeEXT VK_MICROMAP_TYPE_DISPLACEMENT_MICROMAP_NV = VkMicromapTypeEXT.DisplacementMicromapNV;
    }

    [Flags]
    public enum VkBuildMicromapFlagsEXT : int
    {
        None = 0,
        PreferFastTraceEXT = 1,
        PreferFastBuildEXT = 2,
        AllowCompactionEXT = 4,
    }
    public static partial class RawConstants
    {
        public const VkBuildMicromapFlagsEXT VK_BUILD_MICROMAP_PREFER_FAST_TRACE_BIT_EXT = VkBuildMicromapFlagsEXT.PreferFastTraceEXT;
        public const VkBuildMicromapFlagsEXT VK_BUILD_MICROMAP_PREFER_FAST_BUILD_BIT_EXT = VkBuildMicromapFlagsEXT.PreferFastBuildEXT;
        public const VkBuildMicromapFlagsEXT VK_BUILD_MICROMAP_ALLOW_COMPACTION_BIT_EXT = VkBuildMicromapFlagsEXT.AllowCompactionEXT;
    }

    [Flags]
    public enum VkMicromapCreateFlagsEXT : int
    {
        None = 0,
        DeviceAddressCaptureReplayEXT = 1,
    }
    public static partial class RawConstants
    {
        public const VkMicromapCreateFlagsEXT VK_MICROMAP_CREATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_EXT = VkMicromapCreateFlagsEXT.DeviceAddressCaptureReplayEXT;
    }

    public enum VkCopyMicromapModeEXT : int
    {
        CloneEXT = 0,
        SerializeEXT = 1,
        DeserializeEXT = 2,
        CompactEXT = 3,
    }
    public static partial class RawConstants
    {
        public const VkCopyMicromapModeEXT VK_COPY_MICROMAP_MODE_CLONE_EXT = VkCopyMicromapModeEXT.CloneEXT;
        public const VkCopyMicromapModeEXT VK_COPY_MICROMAP_MODE_SERIALIZE_EXT = VkCopyMicromapModeEXT.SerializeEXT;
        public const VkCopyMicromapModeEXT VK_COPY_MICROMAP_MODE_DESERIALIZE_EXT = VkCopyMicromapModeEXT.DeserializeEXT;
        public const VkCopyMicromapModeEXT VK_COPY_MICROMAP_MODE_COMPACT_EXT = VkCopyMicromapModeEXT.CompactEXT;
    }

    public enum VkBuildMicromapModeEXT : int
    {
        BuildEXT = 0,
    }
    public static partial class RawConstants
    {
        public const VkBuildMicromapModeEXT VK_BUILD_MICROMAP_MODE_BUILD_EXT = VkBuildMicromapModeEXT.BuildEXT;
    }

    public enum VkOpacityMicromapFormatEXT : int
    {
        _2StateEXT = 1,
        _4StateEXT = 2,
    }
    public static partial class RawConstants
    {
        public const VkOpacityMicromapFormatEXT VK_OPACITY_MICROMAP_FORMAT_2_STATE_EXT = VkOpacityMicromapFormatEXT._2StateEXT;
        public const VkOpacityMicromapFormatEXT VK_OPACITY_MICROMAP_FORMAT_4_STATE_EXT = VkOpacityMicromapFormatEXT._4StateEXT;
    }

    public enum VkOpacityMicromapSpecialIndexEXT : int
    {
        FullyTransparentEXT = -1,
        FullyOpaqueEXT = -2,
        FullyUnknownTransparentEXT = -3,
        FullyUnknownOpaqueEXT = -4,
    }
    public static partial class RawConstants
    {
        public const VkOpacityMicromapSpecialIndexEXT VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_TRANSPARENT_EXT = VkOpacityMicromapSpecialIndexEXT.FullyTransparentEXT;
        public const VkOpacityMicromapSpecialIndexEXT VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_OPAQUE_EXT = VkOpacityMicromapSpecialIndexEXT.FullyOpaqueEXT;
        public const VkOpacityMicromapSpecialIndexEXT VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_TRANSPARENT_EXT = VkOpacityMicromapSpecialIndexEXT.FullyUnknownTransparentEXT;
        public const VkOpacityMicromapSpecialIndexEXT VK_OPACITY_MICROMAP_SPECIAL_INDEX_FULLY_UNKNOWN_OPAQUE_EXT = VkOpacityMicromapSpecialIndexEXT.FullyUnknownOpaqueEXT;
    }

    public enum VkDepthBiasRepresentationEXT : int
    {
        LeastRepresentableValueFormatEXT = 0,
        LeastRepresentableValueForceUnormEXT = 1,
        FloatEXT = 2,
    }
    public static partial class RawConstants
    {
        public const VkDepthBiasRepresentationEXT VK_DEPTH_BIAS_REPRESENTATION_LEAST_REPRESENTABLE_VALUE_FORMAT_EXT = VkDepthBiasRepresentationEXT.LeastRepresentableValueFormatEXT;
        public const VkDepthBiasRepresentationEXT VK_DEPTH_BIAS_REPRESENTATION_LEAST_REPRESENTABLE_VALUE_FORCE_UNORM_EXT = VkDepthBiasRepresentationEXT.LeastRepresentableValueForceUnormEXT;
        public const VkDepthBiasRepresentationEXT VK_DEPTH_BIAS_REPRESENTATION_FLOAT_EXT = VkDepthBiasRepresentationEXT.FloatEXT;
    }

    public enum VkDeviceFaultAddressTypeEXT : int
    {
        ///<summary>Currently unused</summary>
        NoneEXT = 0,
        ReadInvalidEXT = 1,
        WriteInvalidEXT = 2,
        ExecuteInvalidEXT = 3,
        InstructionPointerUnknownEXT = 4,
        InstructionPointerInvalidEXT = 5,
        InstructionPointerFaultEXT = 6,
    }
    public static partial class RawConstants
    {
        ///<summary>Currently unused</summary>
        public const VkDeviceFaultAddressTypeEXT VK_DEVICE_FAULT_ADDRESS_TYPE_NONE_EXT = VkDeviceFaultAddressTypeEXT.NoneEXT;
        public const VkDeviceFaultAddressTypeEXT VK_DEVICE_FAULT_ADDRESS_TYPE_READ_INVALID_EXT = VkDeviceFaultAddressTypeEXT.ReadInvalidEXT;
        public const VkDeviceFaultAddressTypeEXT VK_DEVICE_FAULT_ADDRESS_TYPE_WRITE_INVALID_EXT = VkDeviceFaultAddressTypeEXT.WriteInvalidEXT;
        public const VkDeviceFaultAddressTypeEXT VK_DEVICE_FAULT_ADDRESS_TYPE_EXECUTE_INVALID_EXT = VkDeviceFaultAddressTypeEXT.ExecuteInvalidEXT;
        public const VkDeviceFaultAddressTypeEXT VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_UNKNOWN_EXT = VkDeviceFaultAddressTypeEXT.InstructionPointerUnknownEXT;
        public const VkDeviceFaultAddressTypeEXT VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_INVALID_EXT = VkDeviceFaultAddressTypeEXT.InstructionPointerInvalidEXT;
        public const VkDeviceFaultAddressTypeEXT VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_FAULT_EXT = VkDeviceFaultAddressTypeEXT.InstructionPointerFaultEXT;
    }

    public enum VkDeviceFaultVendorBinaryHeaderVersionEXT : int
    {
        OneEXT = 1,
    }
    public static partial class RawConstants
    {
        public const VkDeviceFaultVendorBinaryHeaderVersionEXT VK_DEVICE_FAULT_VENDOR_BINARY_HEADER_VERSION_ONE_EXT = VkDeviceFaultVendorBinaryHeaderVersionEXT.OneEXT;
    }

    public enum VkDisplacementMicromapFormatNV : int
    {
        VK_DISPLACEMENT_MICROMAP_FORMAT_64_TRIANGLES_64_BYTES_NV = 1,
        VK_DISPLACEMENT_MICROMAP_FORMAT_256_TRIANGLES_128_BYTES_NV = 2,
        VK_DISPLACEMENT_MICROMAP_FORMAT_1024_TRIANGLES_128_BYTES_NV = 3,
    }
    public static partial class RawConstants
    {
        public const VkDisplacementMicromapFormatNV VK_DISPLACEMENT_MICROMAP_FORMAT_64_TRIANGLES_64_BYTES_NV = VkDisplacementMicromapFormatNV.VK_DISPLACEMENT_MICROMAP_FORMAT_64_TRIANGLES_64_BYTES_NV;
        public const VkDisplacementMicromapFormatNV VK_DISPLACEMENT_MICROMAP_FORMAT_256_TRIANGLES_128_BYTES_NV = VkDisplacementMicromapFormatNV.VK_DISPLACEMENT_MICROMAP_FORMAT_256_TRIANGLES_128_BYTES_NV;
        public const VkDisplacementMicromapFormatNV VK_DISPLACEMENT_MICROMAP_FORMAT_1024_TRIANGLES_128_BYTES_NV = VkDisplacementMicromapFormatNV.VK_DISPLACEMENT_MICROMAP_FORMAT_1024_TRIANGLES_128_BYTES_NV;
    }

    [Flags]
    public enum VkShaderCreateFlagsEXT : int
    {
        None = 0,
        LinkStageEXT = 1,
        AllowVaryingSubgroupSizeEXT = 2,
        RequireFullSubgroupsEXT = 4,
        NoTaskShaderEXT = 8,
        DispatchBaseEXT = 16,
        FragmentShadingRateAttachmentEXT = 32,
        FragmentDensityMapAttachmentEXT = 64,
    }
    public static partial class RawConstants
    {
        public const VkShaderCreateFlagsEXT VK_SHADER_CREATE_LINK_STAGE_BIT_EXT = VkShaderCreateFlagsEXT.LinkStageEXT;
        public const VkShaderCreateFlagsEXT VK_SHADER_CREATE_ALLOW_VARYING_SUBGROUP_SIZE_BIT_EXT = VkShaderCreateFlagsEXT.AllowVaryingSubgroupSizeEXT;
        public const VkShaderCreateFlagsEXT VK_SHADER_CREATE_REQUIRE_FULL_SUBGROUPS_BIT_EXT = VkShaderCreateFlagsEXT.RequireFullSubgroupsEXT;
        public const VkShaderCreateFlagsEXT VK_SHADER_CREATE_NO_TASK_SHADER_BIT_EXT = VkShaderCreateFlagsEXT.NoTaskShaderEXT;
        public const VkShaderCreateFlagsEXT VK_SHADER_CREATE_DISPATCH_BASE_BIT_EXT = VkShaderCreateFlagsEXT.DispatchBaseEXT;
        public const VkShaderCreateFlagsEXT VK_SHADER_CREATE_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_EXT = VkShaderCreateFlagsEXT.FragmentShadingRateAttachmentEXT;
        public const VkShaderCreateFlagsEXT VK_SHADER_CREATE_FRAGMENT_DENSITY_MAP_ATTACHMENT_BIT_EXT = VkShaderCreateFlagsEXT.FragmentDensityMapAttachmentEXT;
    }

    public enum VkShaderCodeTypeEXT : int
    {
        BinaryEXT = 0,
        SpirvEXT = 1,
    }
    public static partial class RawConstants
    {
        public const VkShaderCodeTypeEXT VK_SHADER_CODE_TYPE_BINARY_EXT = VkShaderCodeTypeEXT.BinaryEXT;
        public const VkShaderCodeTypeEXT VK_SHADER_CODE_TYPE_SPIRV_EXT = VkShaderCodeTypeEXT.SpirvEXT;
    }

    public enum VkScopeKHR : int
    {
        DeviceKHR = 1,
        WorkgroupKHR = 2,
        SubgroupKHR = 3,
        QueueFamilyKHR = 5,
    }
    public static partial class RawConstants
    {
        public const VkScopeKHR VK_SCOPE_DEVICE_KHR = VkScopeKHR.DeviceKHR;
        public const VkScopeKHR VK_SCOPE_WORKGROUP_KHR = VkScopeKHR.WorkgroupKHR;
        public const VkScopeKHR VK_SCOPE_SUBGROUP_KHR = VkScopeKHR.SubgroupKHR;
        public const VkScopeKHR VK_SCOPE_QUEUE_FAMILY_KHR = VkScopeKHR.QueueFamilyKHR;
    }

    public enum VkComponentTypeKHR : int
    {
        Float16KHR = 0,
        Float32KHR = 1,
        Float64KHR = 2,
        Sint8KHR = 3,
        Sint16KHR = 4,
        Sint32KHR = 5,
        Sint64KHR = 6,
        Uint8KHR = 7,
        Uint16KHR = 8,
        Uint32KHR = 9,
        Uint64KHR = 10,
    }
    public static partial class RawConstants
    {
        public const VkComponentTypeKHR VK_COMPONENT_TYPE_FLOAT16_KHR = VkComponentTypeKHR.Float16KHR;
        public const VkComponentTypeKHR VK_COMPONENT_TYPE_FLOAT32_KHR = VkComponentTypeKHR.Float32KHR;
        public const VkComponentTypeKHR VK_COMPONENT_TYPE_FLOAT64_KHR = VkComponentTypeKHR.Float64KHR;
        public const VkComponentTypeKHR VK_COMPONENT_TYPE_SINT8_KHR = VkComponentTypeKHR.Sint8KHR;
        public const VkComponentTypeKHR VK_COMPONENT_TYPE_SINT16_KHR = VkComponentTypeKHR.Sint16KHR;
        public const VkComponentTypeKHR VK_COMPONENT_TYPE_SINT32_KHR = VkComponentTypeKHR.Sint32KHR;
        public const VkComponentTypeKHR VK_COMPONENT_TYPE_SINT64_KHR = VkComponentTypeKHR.Sint64KHR;
        public const VkComponentTypeKHR VK_COMPONENT_TYPE_UINT8_KHR = VkComponentTypeKHR.Uint8KHR;
        public const VkComponentTypeKHR VK_COMPONENT_TYPE_UINT16_KHR = VkComponentTypeKHR.Uint16KHR;
        public const VkComponentTypeKHR VK_COMPONENT_TYPE_UINT32_KHR = VkComponentTypeKHR.Uint32KHR;
        public const VkComponentTypeKHR VK_COMPONENT_TYPE_UINT64_KHR = VkComponentTypeKHR.Uint64KHR;
    }

    public enum VkCubicFilterWeightsQCOM : int
    {
        VK_CUBIC_FILTER_WEIGHTS_CATMULL_ROM_QCOM = 0,
        VK_CUBIC_FILTER_WEIGHTS_ZERO_TANGENT_CARDINAL_QCOM = 1,
        VK_CUBIC_FILTER_WEIGHTS_B_SPLINE_QCOM = 2,
        VK_CUBIC_FILTER_WEIGHTS_MITCHELL_NETRAVALI_QCOM = 3,
    }
    public static partial class RawConstants
    {
        public const VkCubicFilterWeightsQCOM VK_CUBIC_FILTER_WEIGHTS_CATMULL_ROM_QCOM = VkCubicFilterWeightsQCOM.VK_CUBIC_FILTER_WEIGHTS_CATMULL_ROM_QCOM;
        public const VkCubicFilterWeightsQCOM VK_CUBIC_FILTER_WEIGHTS_ZERO_TANGENT_CARDINAL_QCOM = VkCubicFilterWeightsQCOM.VK_CUBIC_FILTER_WEIGHTS_ZERO_TANGENT_CARDINAL_QCOM;
        public const VkCubicFilterWeightsQCOM VK_CUBIC_FILTER_WEIGHTS_B_SPLINE_QCOM = VkCubicFilterWeightsQCOM.VK_CUBIC_FILTER_WEIGHTS_B_SPLINE_QCOM;
        public const VkCubicFilterWeightsQCOM VK_CUBIC_FILTER_WEIGHTS_MITCHELL_NETRAVALI_QCOM = VkCubicFilterWeightsQCOM.VK_CUBIC_FILTER_WEIGHTS_MITCHELL_NETRAVALI_QCOM;
    }

    public enum VkBlockMatchWindowCompareModeQCOM : int
    {
        VK_BLOCK_MATCH_WINDOW_COMPARE_MODE_MIN_QCOM = 0,
        VK_BLOCK_MATCH_WINDOW_COMPARE_MODE_MAX_QCOM = 1,
    }
    public static partial class RawConstants
    {
        public const VkBlockMatchWindowCompareModeQCOM VK_BLOCK_MATCH_WINDOW_COMPARE_MODE_MIN_QCOM = VkBlockMatchWindowCompareModeQCOM.VK_BLOCK_MATCH_WINDOW_COMPARE_MODE_MIN_QCOM;
        public const VkBlockMatchWindowCompareModeQCOM VK_BLOCK_MATCH_WINDOW_COMPARE_MODE_MAX_QCOM = VkBlockMatchWindowCompareModeQCOM.VK_BLOCK_MATCH_WINDOW_COMPARE_MODE_MAX_QCOM;
    }

    public enum VkLayeredDriverUnderlyingApiMSFT : int
    {
        VK_LAYERED_DRIVER_UNDERLYING_API_NONE_MSFT = 0,
        VK_LAYERED_DRIVER_UNDERLYING_API_D3D12_MSFT = 1,
    }
    public static partial class RawConstants
    {
        public const VkLayeredDriverUnderlyingApiMSFT VK_LAYERED_DRIVER_UNDERLYING_API_NONE_MSFT = VkLayeredDriverUnderlyingApiMSFT.VK_LAYERED_DRIVER_UNDERLYING_API_NONE_MSFT;
        public const VkLayeredDriverUnderlyingApiMSFT VK_LAYERED_DRIVER_UNDERLYING_API_D3D12_MSFT = VkLayeredDriverUnderlyingApiMSFT.VK_LAYERED_DRIVER_UNDERLYING_API_D3D12_MSFT;
    }

    public enum StdVideoH264ChromaFormatIdc : int
    {
        Monochrome = 0,
        _420 = 1,
        _422 = 2,
        _444 = 3,
        Invalid = 2147483647,
    }
    public static partial class RawConstants
    {
        public const StdVideoH264ChromaFormatIdc STD_VIDEO_H264_CHROMA_FORMAT_IDC_MONOCHROME = StdVideoH264ChromaFormatIdc.Monochrome;
        public const StdVideoH264ChromaFormatIdc STD_VIDEO_H264_CHROMA_FORMAT_IDC_420 = StdVideoH264ChromaFormatIdc._420;
        public const StdVideoH264ChromaFormatIdc STD_VIDEO_H264_CHROMA_FORMAT_IDC_422 = StdVideoH264ChromaFormatIdc._422;
        public const StdVideoH264ChromaFormatIdc STD_VIDEO_H264_CHROMA_FORMAT_IDC_444 = StdVideoH264ChromaFormatIdc._444;
        public const StdVideoH264ChromaFormatIdc STD_VIDEO_H264_CHROMA_FORMAT_IDC_INVALID = StdVideoH264ChromaFormatIdc.Invalid;
    }

    public enum StdVideoH264ProfileIdc : int
    {
        ///<summary>Only constrained baseline is supported</summary>
        Baseline = 66,
        Main = 77,
        High = 100,
        High444Predictive = 244,
        Invalid = 2147483647,
    }
    public static partial class RawConstants
    {
        ///<summary>Only constrained baseline is supported</summary>
        public const StdVideoH264ProfileIdc STD_VIDEO_H264_PROFILE_IDC_BASELINE = StdVideoH264ProfileIdc.Baseline;
        public const StdVideoH264ProfileIdc STD_VIDEO_H264_PROFILE_IDC_MAIN = StdVideoH264ProfileIdc.Main;
        public const StdVideoH264ProfileIdc STD_VIDEO_H264_PROFILE_IDC_HIGH = StdVideoH264ProfileIdc.High;
        public const StdVideoH264ProfileIdc STD_VIDEO_H264_PROFILE_IDC_HIGH_444_PREDICTIVE = StdVideoH264ProfileIdc.High444Predictive;
        public const StdVideoH264ProfileIdc STD_VIDEO_H264_PROFILE_IDC_INVALID = StdVideoH264ProfileIdc.Invalid;
    }

    public enum StdVideoH264LevelIdc : int
    {
        _10 = 0,
        _11 = 1,
        _12 = 2,
        _13 = 3,
        _20 = 4,
        _21 = 5,
        _22 = 6,
        _30 = 7,
        _31 = 8,
        _32 = 9,
        _40 = 10,
        _41 = 11,
        _42 = 12,
        _50 = 13,
        _51 = 14,
        _52 = 15,
        _60 = 16,
        _61 = 17,
        _62 = 18,
        Invalid = 2147483647,
    }
    public static partial class RawConstants
    {
        public const StdVideoH264LevelIdc STD_VIDEO_H264_LEVEL_IDC_1_0 = StdVideoH264LevelIdc._10;
        public const StdVideoH264LevelIdc STD_VIDEO_H264_LEVEL_IDC_1_1 = StdVideoH264LevelIdc._11;
        public const StdVideoH264LevelIdc STD_VIDEO_H264_LEVEL_IDC_1_2 = StdVideoH264LevelIdc._12;
        public const StdVideoH264LevelIdc STD_VIDEO_H264_LEVEL_IDC_1_3 = StdVideoH264LevelIdc._13;
        public const StdVideoH264LevelIdc STD_VIDEO_H264_LEVEL_IDC_2_0 = StdVideoH264LevelIdc._20;
        public const StdVideoH264LevelIdc STD_VIDEO_H264_LEVEL_IDC_2_1 = StdVideoH264LevelIdc._21;
        public const StdVideoH264LevelIdc STD_VIDEO_H264_LEVEL_IDC_2_2 = StdVideoH264LevelIdc._22;
        public const StdVideoH264LevelIdc STD_VIDEO_H264_LEVEL_IDC_3_0 = StdVideoH264LevelIdc._30;
        public const StdVideoH264LevelIdc STD_VIDEO_H264_LEVEL_IDC_3_1 = StdVideoH264LevelIdc._31;
        public const StdVideoH264LevelIdc STD_VIDEO_H264_LEVEL_IDC_3_2 = StdVideoH264LevelIdc._32;
        public const StdVideoH264LevelIdc STD_VIDEO_H264_LEVEL_IDC_4_0 = StdVideoH264LevelIdc._40;
        public const StdVideoH264LevelIdc STD_VIDEO_H264_LEVEL_IDC_4_1 = StdVideoH264LevelIdc._41;
        public const StdVideoH264LevelIdc STD_VIDEO_H264_LEVEL_IDC_4_2 = StdVideoH264LevelIdc._42;
        public const StdVideoH264LevelIdc STD_VIDEO_H264_LEVEL_IDC_5_0 = StdVideoH264LevelIdc._50;
        public const StdVideoH264LevelIdc STD_VIDEO_H264_LEVEL_IDC_5_1 = StdVideoH264LevelIdc._51;
        public const StdVideoH264LevelIdc STD_VIDEO_H264_LEVEL_IDC_5_2 = StdVideoH264LevelIdc._52;
        public const StdVideoH264LevelIdc STD_VIDEO_H264_LEVEL_IDC_6_0 = StdVideoH264LevelIdc._60;
        public const StdVideoH264LevelIdc STD_VIDEO_H264_LEVEL_IDC_6_1 = StdVideoH264LevelIdc._61;
        public const StdVideoH264LevelIdc STD_VIDEO_H264_LEVEL_IDC_6_2 = StdVideoH264LevelIdc._62;
        public const StdVideoH264LevelIdc STD_VIDEO_H264_LEVEL_IDC_INVALID = StdVideoH264LevelIdc.Invalid;
    }

    public enum StdVideoH264PocType : int
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        Invalid = 2147483647,
    }
    public static partial class RawConstants
    {
        public const StdVideoH264PocType STD_VIDEO_H264_POC_TYPE_0 = StdVideoH264PocType._0;
        public const StdVideoH264PocType STD_VIDEO_H264_POC_TYPE_1 = StdVideoH264PocType._1;
        public const StdVideoH264PocType STD_VIDEO_H264_POC_TYPE_2 = StdVideoH264PocType._2;
        public const StdVideoH264PocType STD_VIDEO_H264_POC_TYPE_INVALID = StdVideoH264PocType.Invalid;
    }

    public enum StdVideoH264AspectRatioIdc : int
    {
        Unspecified = 0,
        Square = 1,
        _1211 = 2,
        _1011 = 3,
        _1611 = 4,
        _4033 = 5,
        _2411 = 6,
        _2011 = 7,
        _3211 = 8,
        _8033 = 9,
        _1811 = 10,
        _1511 = 11,
        _6433 = 12,
        _16099 = 13,
        _43 = 14,
        _32 = 15,
        _21 = 16,
        ExtendedSar = 255,
        Invalid = 2147483647,
    }
    public static partial class RawConstants
    {
        public const StdVideoH264AspectRatioIdc STD_VIDEO_H264_ASPECT_RATIO_IDC_UNSPECIFIED = StdVideoH264AspectRatioIdc.Unspecified;
        public const StdVideoH264AspectRatioIdc STD_VIDEO_H264_ASPECT_RATIO_IDC_SQUARE = StdVideoH264AspectRatioIdc.Square;
        public const StdVideoH264AspectRatioIdc STD_VIDEO_H264_ASPECT_RATIO_IDC_12_11 = StdVideoH264AspectRatioIdc._1211;
        public const StdVideoH264AspectRatioIdc STD_VIDEO_H264_ASPECT_RATIO_IDC_10_11 = StdVideoH264AspectRatioIdc._1011;
        public const StdVideoH264AspectRatioIdc STD_VIDEO_H264_ASPECT_RATIO_IDC_16_11 = StdVideoH264AspectRatioIdc._1611;
        public const StdVideoH264AspectRatioIdc STD_VIDEO_H264_ASPECT_RATIO_IDC_40_33 = StdVideoH264AspectRatioIdc._4033;
        public const StdVideoH264AspectRatioIdc STD_VIDEO_H264_ASPECT_RATIO_IDC_24_11 = StdVideoH264AspectRatioIdc._2411;
        public const StdVideoH264AspectRatioIdc STD_VIDEO_H264_ASPECT_RATIO_IDC_20_11 = StdVideoH264AspectRatioIdc._2011;
        public const StdVideoH264AspectRatioIdc STD_VIDEO_H264_ASPECT_RATIO_IDC_32_11 = StdVideoH264AspectRatioIdc._3211;
        public const StdVideoH264AspectRatioIdc STD_VIDEO_H264_ASPECT_RATIO_IDC_80_33 = StdVideoH264AspectRatioIdc._8033;
        public const StdVideoH264AspectRatioIdc STD_VIDEO_H264_ASPECT_RATIO_IDC_18_11 = StdVideoH264AspectRatioIdc._1811;
        public const StdVideoH264AspectRatioIdc STD_VIDEO_H264_ASPECT_RATIO_IDC_15_11 = StdVideoH264AspectRatioIdc._1511;
        public const StdVideoH264AspectRatioIdc STD_VIDEO_H264_ASPECT_RATIO_IDC_64_33 = StdVideoH264AspectRatioIdc._6433;
        public const StdVideoH264AspectRatioIdc STD_VIDEO_H264_ASPECT_RATIO_IDC_160_99 = StdVideoH264AspectRatioIdc._16099;
        public const StdVideoH264AspectRatioIdc STD_VIDEO_H264_ASPECT_RATIO_IDC_4_3 = StdVideoH264AspectRatioIdc._43;
        public const StdVideoH264AspectRatioIdc STD_VIDEO_H264_ASPECT_RATIO_IDC_3_2 = StdVideoH264AspectRatioIdc._32;
        public const StdVideoH264AspectRatioIdc STD_VIDEO_H264_ASPECT_RATIO_IDC_2_1 = StdVideoH264AspectRatioIdc._21;
        public const StdVideoH264AspectRatioIdc STD_VIDEO_H264_ASPECT_RATIO_IDC_EXTENDED_SAR = StdVideoH264AspectRatioIdc.ExtendedSar;
        public const StdVideoH264AspectRatioIdc STD_VIDEO_H264_ASPECT_RATIO_IDC_INVALID = StdVideoH264AspectRatioIdc.Invalid;
    }

    public enum StdVideoH264WeightedBipredIdc : int
    {
        Default = 0,
        Explicit = 1,
        Implicit = 2,
        Invalid = 2147483647,
    }
    public static partial class RawConstants
    {
        public const StdVideoH264WeightedBipredIdc STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_DEFAULT = StdVideoH264WeightedBipredIdc.Default;
        public const StdVideoH264WeightedBipredIdc STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_EXPLICIT = StdVideoH264WeightedBipredIdc.Explicit;
        public const StdVideoH264WeightedBipredIdc STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_IMPLICIT = StdVideoH264WeightedBipredIdc.Implicit;
        public const StdVideoH264WeightedBipredIdc STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_INVALID = StdVideoH264WeightedBipredIdc.Invalid;
    }

    public enum StdVideoH264ModificationOfPicNumsIdc : int
    {
        ShortTermSubtract = 0,
        ShortTermAdd = 1,
        LongTerm = 2,
        End = 3,
        Invalid = 2147483647,
    }
    public static partial class RawConstants
    {
        public const StdVideoH264ModificationOfPicNumsIdc STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_SHORT_TERM_SUBTRACT = StdVideoH264ModificationOfPicNumsIdc.ShortTermSubtract;
        public const StdVideoH264ModificationOfPicNumsIdc STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_SHORT_TERM_ADD = StdVideoH264ModificationOfPicNumsIdc.ShortTermAdd;
        public const StdVideoH264ModificationOfPicNumsIdc STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_LONG_TERM = StdVideoH264ModificationOfPicNumsIdc.LongTerm;
        public const StdVideoH264ModificationOfPicNumsIdc STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_END = StdVideoH264ModificationOfPicNumsIdc.End;
        public const StdVideoH264ModificationOfPicNumsIdc STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_INVALID = StdVideoH264ModificationOfPicNumsIdc.Invalid;
    }

    public enum StdVideoH264MemMgmtControlOp : int
    {
        End = 0,
        UnmarkShortTerm = 1,
        UnmarkLongTerm = 2,
        MarkLongTerm = 3,
        SetMaxLongTermIndex = 4,
        UnmarkAll = 5,
        MarkCurrentAsLongTerm = 6,
        Invalid = 2147483647,
    }
    public static partial class RawConstants
    {
        public const StdVideoH264MemMgmtControlOp STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_END = StdVideoH264MemMgmtControlOp.End;
        public const StdVideoH264MemMgmtControlOp STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_UNMARK_SHORT_TERM = StdVideoH264MemMgmtControlOp.UnmarkShortTerm;
        public const StdVideoH264MemMgmtControlOp STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_UNMARK_LONG_TERM = StdVideoH264MemMgmtControlOp.UnmarkLongTerm;
        public const StdVideoH264MemMgmtControlOp STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_MARK_LONG_TERM = StdVideoH264MemMgmtControlOp.MarkLongTerm;
        public const StdVideoH264MemMgmtControlOp STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_SET_MAX_LONG_TERM_INDEX = StdVideoH264MemMgmtControlOp.SetMaxLongTermIndex;
        public const StdVideoH264MemMgmtControlOp STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_UNMARK_ALL = StdVideoH264MemMgmtControlOp.UnmarkAll;
        public const StdVideoH264MemMgmtControlOp STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_MARK_CURRENT_AS_LONG_TERM = StdVideoH264MemMgmtControlOp.MarkCurrentAsLongTerm;
        public const StdVideoH264MemMgmtControlOp STD_VIDEO_H264_MEM_MGMT_CONTROL_OP_INVALID = StdVideoH264MemMgmtControlOp.Invalid;
    }

    public enum StdVideoH264CabacInitIdc : int
    {
        _0 = 0,
        _1 = 1,
        _2 = 2,
        Invalid = 2147483647,
    }
    public static partial class RawConstants
    {
        public const StdVideoH264CabacInitIdc STD_VIDEO_H264_CABAC_INIT_IDC_0 = StdVideoH264CabacInitIdc._0;
        public const StdVideoH264CabacInitIdc STD_VIDEO_H264_CABAC_INIT_IDC_1 = StdVideoH264CabacInitIdc._1;
        public const StdVideoH264CabacInitIdc STD_VIDEO_H264_CABAC_INIT_IDC_2 = StdVideoH264CabacInitIdc._2;
        public const StdVideoH264CabacInitIdc STD_VIDEO_H264_CABAC_INIT_IDC_INVALID = StdVideoH264CabacInitIdc.Invalid;
    }

    public enum StdVideoH264DisableDeblockingFilterIdc : int
    {
        Disabled = 0,
        Enabled = 1,
        Partial = 2,
        Invalid = 2147483647,
    }
    public static partial class RawConstants
    {
        public const StdVideoH264DisableDeblockingFilterIdc STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_DISABLED = StdVideoH264DisableDeblockingFilterIdc.Disabled;
        public const StdVideoH264DisableDeblockingFilterIdc STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_ENABLED = StdVideoH264DisableDeblockingFilterIdc.Enabled;
        public const StdVideoH264DisableDeblockingFilterIdc STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_PARTIAL = StdVideoH264DisableDeblockingFilterIdc.Partial;
        public const StdVideoH264DisableDeblockingFilterIdc STD_VIDEO_H264_DISABLE_DEBLOCKING_FILTER_IDC_INVALID = StdVideoH264DisableDeblockingFilterIdc.Invalid;
    }

    public enum StdVideoH264SliceType : int
    {
        P = 0,
        B = 1,
        I = 2,
        Invalid = 2147483647,
    }
    public static partial class RawConstants
    {
        public const StdVideoH264SliceType STD_VIDEO_H264_SLICE_TYPE_P = StdVideoH264SliceType.P;
        public const StdVideoH264SliceType STD_VIDEO_H264_SLICE_TYPE_B = StdVideoH264SliceType.B;
        public const StdVideoH264SliceType STD_VIDEO_H264_SLICE_TYPE_I = StdVideoH264SliceType.I;
        public const StdVideoH264SliceType STD_VIDEO_H264_SLICE_TYPE_INVALID = StdVideoH264SliceType.Invalid;
    }

    public enum StdVideoH264PictureType : int
    {
        P = 0,
        B = 1,
        I = 2,
        Idr = 5,
        Invalid = 2147483647,
    }
    public static partial class RawConstants
    {
        public const StdVideoH264PictureType STD_VIDEO_H264_PICTURE_TYPE_P = StdVideoH264PictureType.P;
        public const StdVideoH264PictureType STD_VIDEO_H264_PICTURE_TYPE_B = StdVideoH264PictureType.B;
        public const StdVideoH264PictureType STD_VIDEO_H264_PICTURE_TYPE_I = StdVideoH264PictureType.I;
        public const StdVideoH264PictureType STD_VIDEO_H264_PICTURE_TYPE_IDR = StdVideoH264PictureType.Idr;
        public const StdVideoH264PictureType STD_VIDEO_H264_PICTURE_TYPE_INVALID = StdVideoH264PictureType.Invalid;
    }

    public enum StdVideoH264NonVclNaluType : int
    {
        Sps = 0,
        Pps = 1,
        Aud = 2,
        Prefix = 3,
        EndOfSequence = 4,
        EndOfStream = 5,
        Precoded = 6,
        Invalid = 2147483647,
    }
    public static partial class RawConstants
    {
        public const StdVideoH264NonVclNaluType STD_VIDEO_H264_NON_VCL_NALU_TYPE_SPS = StdVideoH264NonVclNaluType.Sps;
        public const StdVideoH264NonVclNaluType STD_VIDEO_H264_NON_VCL_NALU_TYPE_PPS = StdVideoH264NonVclNaluType.Pps;
        public const StdVideoH264NonVclNaluType STD_VIDEO_H264_NON_VCL_NALU_TYPE_AUD = StdVideoH264NonVclNaluType.Aud;
        public const StdVideoH264NonVclNaluType STD_VIDEO_H264_NON_VCL_NALU_TYPE_PREFIX = StdVideoH264NonVclNaluType.Prefix;
        public const StdVideoH264NonVclNaluType STD_VIDEO_H264_NON_VCL_NALU_TYPE_END_OF_SEQUENCE = StdVideoH264NonVclNaluType.EndOfSequence;
        public const StdVideoH264NonVclNaluType STD_VIDEO_H264_NON_VCL_NALU_TYPE_END_OF_STREAM = StdVideoH264NonVclNaluType.EndOfStream;
        public const StdVideoH264NonVclNaluType STD_VIDEO_H264_NON_VCL_NALU_TYPE_PRECODED = StdVideoH264NonVclNaluType.Precoded;
        public const StdVideoH264NonVclNaluType STD_VIDEO_H264_NON_VCL_NALU_TYPE_INVALID = StdVideoH264NonVclNaluType.Invalid;
    }

    public enum StdVideoDecodeH264FieldOrderCount : int
    {
        Top = 0,
        Bottom = 1,
        Invalid = 2147483647,
    }
    public static partial class RawConstants
    {
        public const StdVideoDecodeH264FieldOrderCount STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_TOP = StdVideoDecodeH264FieldOrderCount.Top;
        public const StdVideoDecodeH264FieldOrderCount STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_BOTTOM = StdVideoDecodeH264FieldOrderCount.Bottom;
        public const StdVideoDecodeH264FieldOrderCount STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_INVALID = StdVideoDecodeH264FieldOrderCount.Invalid;
    }

    public enum StdVideoH265ChromaFormatIdc : int
    {
        Monochrome = 0,
        _420 = 1,
        _422 = 2,
        _444 = 3,
        Invalid = 2147483647,
    }
    public static partial class RawConstants
    {
        public const StdVideoH265ChromaFormatIdc STD_VIDEO_H265_CHROMA_FORMAT_IDC_MONOCHROME = StdVideoH265ChromaFormatIdc.Monochrome;
        public const StdVideoH265ChromaFormatIdc STD_VIDEO_H265_CHROMA_FORMAT_IDC_420 = StdVideoH265ChromaFormatIdc._420;
        public const StdVideoH265ChromaFormatIdc STD_VIDEO_H265_CHROMA_FORMAT_IDC_422 = StdVideoH265ChromaFormatIdc._422;
        public const StdVideoH265ChromaFormatIdc STD_VIDEO_H265_CHROMA_FORMAT_IDC_444 = StdVideoH265ChromaFormatIdc._444;
        public const StdVideoH265ChromaFormatIdc STD_VIDEO_H265_CHROMA_FORMAT_IDC_INVALID = StdVideoH265ChromaFormatIdc.Invalid;
    }

    public enum StdVideoH265ProfileIdc : int
    {
        Main = 1,
        Main10 = 2,
        MainStillPicture = 3,
        FormatRangeExtensions = 4,
        SccExtensions = 9,
        Invalid = 2147483647,
    }
    public static partial class RawConstants
    {
        public const StdVideoH265ProfileIdc STD_VIDEO_H265_PROFILE_IDC_MAIN = StdVideoH265ProfileIdc.Main;
        public const StdVideoH265ProfileIdc STD_VIDEO_H265_PROFILE_IDC_MAIN_10 = StdVideoH265ProfileIdc.Main10;
        public const StdVideoH265ProfileIdc STD_VIDEO_H265_PROFILE_IDC_MAIN_STILL_PICTURE = StdVideoH265ProfileIdc.MainStillPicture;
        public const StdVideoH265ProfileIdc STD_VIDEO_H265_PROFILE_IDC_FORMAT_RANGE_EXTENSIONS = StdVideoH265ProfileIdc.FormatRangeExtensions;
        public const StdVideoH265ProfileIdc STD_VIDEO_H265_PROFILE_IDC_SCC_EXTENSIONS = StdVideoH265ProfileIdc.SccExtensions;
        public const StdVideoH265ProfileIdc STD_VIDEO_H265_PROFILE_IDC_INVALID = StdVideoH265ProfileIdc.Invalid;
    }

    public enum StdVideoH265LevelIdc : int
    {
        _10 = 0,
        _20 = 1,
        _21 = 2,
        _30 = 3,
        _31 = 4,
        _40 = 5,
        _41 = 6,
        _50 = 7,
        _51 = 8,
        _52 = 9,
        _60 = 10,
        _61 = 11,
        _62 = 12,
        Invalid = 2147483647,
    }
    public static partial class RawConstants
    {
        public const StdVideoH265LevelIdc STD_VIDEO_H265_LEVEL_IDC_1_0 = StdVideoH265LevelIdc._10;
        public const StdVideoH265LevelIdc STD_VIDEO_H265_LEVEL_IDC_2_0 = StdVideoH265LevelIdc._20;
        public const StdVideoH265LevelIdc STD_VIDEO_H265_LEVEL_IDC_2_1 = StdVideoH265LevelIdc._21;
        public const StdVideoH265LevelIdc STD_VIDEO_H265_LEVEL_IDC_3_0 = StdVideoH265LevelIdc._30;
        public const StdVideoH265LevelIdc STD_VIDEO_H265_LEVEL_IDC_3_1 = StdVideoH265LevelIdc._31;
        public const StdVideoH265LevelIdc STD_VIDEO_H265_LEVEL_IDC_4_0 = StdVideoH265LevelIdc._40;
        public const StdVideoH265LevelIdc STD_VIDEO_H265_LEVEL_IDC_4_1 = StdVideoH265LevelIdc._41;
        public const StdVideoH265LevelIdc STD_VIDEO_H265_LEVEL_IDC_5_0 = StdVideoH265LevelIdc._50;
        public const StdVideoH265LevelIdc STD_VIDEO_H265_LEVEL_IDC_5_1 = StdVideoH265LevelIdc._51;
        public const StdVideoH265LevelIdc STD_VIDEO_H265_LEVEL_IDC_5_2 = StdVideoH265LevelIdc._52;
        public const StdVideoH265LevelIdc STD_VIDEO_H265_LEVEL_IDC_6_0 = StdVideoH265LevelIdc._60;
        public const StdVideoH265LevelIdc STD_VIDEO_H265_LEVEL_IDC_6_1 = StdVideoH265LevelIdc._61;
        public const StdVideoH265LevelIdc STD_VIDEO_H265_LEVEL_IDC_6_2 = StdVideoH265LevelIdc._62;
        public const StdVideoH265LevelIdc STD_VIDEO_H265_LEVEL_IDC_INVALID = StdVideoH265LevelIdc.Invalid;
    }

    public enum StdVideoH265SliceType : int
    {
        B = 0,
        P = 1,
        I = 2,
        Invalid = 2147483647,
    }
    public static partial class RawConstants
    {
        public const StdVideoH265SliceType STD_VIDEO_H265_SLICE_TYPE_B = StdVideoH265SliceType.B;
        public const StdVideoH265SliceType STD_VIDEO_H265_SLICE_TYPE_P = StdVideoH265SliceType.P;
        public const StdVideoH265SliceType STD_VIDEO_H265_SLICE_TYPE_I = StdVideoH265SliceType.I;
        public const StdVideoH265SliceType STD_VIDEO_H265_SLICE_TYPE_INVALID = StdVideoH265SliceType.Invalid;
    }

    public enum StdVideoH265PictureType : int
    {
        P = 0,
        B = 1,
        I = 2,
        Idr = 3,
        Invalid = 2147483647,
    }
    public static partial class RawConstants
    {
        public const StdVideoH265PictureType STD_VIDEO_H265_PICTURE_TYPE_P = StdVideoH265PictureType.P;
        public const StdVideoH265PictureType STD_VIDEO_H265_PICTURE_TYPE_B = StdVideoH265PictureType.B;
        public const StdVideoH265PictureType STD_VIDEO_H265_PICTURE_TYPE_I = StdVideoH265PictureType.I;
        public const StdVideoH265PictureType STD_VIDEO_H265_PICTURE_TYPE_IDR = StdVideoH265PictureType.Idr;
        public const StdVideoH265PictureType STD_VIDEO_H265_PICTURE_TYPE_INVALID = StdVideoH265PictureType.Invalid;
    }

    public enum StdVideoH265AspectRatioIdc : int
    {
        Unspecified = 0,
        Square = 1,
        _1211 = 2,
        _1011 = 3,
        _1611 = 4,
        _4033 = 5,
        _2411 = 6,
        _2011 = 7,
        _3211 = 8,
        _8033 = 9,
        _1811 = 10,
        _1511 = 11,
        _6433 = 12,
        _16099 = 13,
        _43 = 14,
        _32 = 15,
        _21 = 16,
        ExtendedSar = 255,
        Invalid = 2147483647,
    }
    public static partial class RawConstants
    {
        public const StdVideoH265AspectRatioIdc STD_VIDEO_H265_ASPECT_RATIO_IDC_UNSPECIFIED = StdVideoH265AspectRatioIdc.Unspecified;
        public const StdVideoH265AspectRatioIdc STD_VIDEO_H265_ASPECT_RATIO_IDC_SQUARE = StdVideoH265AspectRatioIdc.Square;
        public const StdVideoH265AspectRatioIdc STD_VIDEO_H265_ASPECT_RATIO_IDC_12_11 = StdVideoH265AspectRatioIdc._1211;
        public const StdVideoH265AspectRatioIdc STD_VIDEO_H265_ASPECT_RATIO_IDC_10_11 = StdVideoH265AspectRatioIdc._1011;
        public const StdVideoH265AspectRatioIdc STD_VIDEO_H265_ASPECT_RATIO_IDC_16_11 = StdVideoH265AspectRatioIdc._1611;
        public const StdVideoH265AspectRatioIdc STD_VIDEO_H265_ASPECT_RATIO_IDC_40_33 = StdVideoH265AspectRatioIdc._4033;
        public const StdVideoH265AspectRatioIdc STD_VIDEO_H265_ASPECT_RATIO_IDC_24_11 = StdVideoH265AspectRatioIdc._2411;
        public const StdVideoH265AspectRatioIdc STD_VIDEO_H265_ASPECT_RATIO_IDC_20_11 = StdVideoH265AspectRatioIdc._2011;
        public const StdVideoH265AspectRatioIdc STD_VIDEO_H265_ASPECT_RATIO_IDC_32_11 = StdVideoH265AspectRatioIdc._3211;
        public const StdVideoH265AspectRatioIdc STD_VIDEO_H265_ASPECT_RATIO_IDC_80_33 = StdVideoH265AspectRatioIdc._8033;
        public const StdVideoH265AspectRatioIdc STD_VIDEO_H265_ASPECT_RATIO_IDC_18_11 = StdVideoH265AspectRatioIdc._1811;
        public const StdVideoH265AspectRatioIdc STD_VIDEO_H265_ASPECT_RATIO_IDC_15_11 = StdVideoH265AspectRatioIdc._1511;
        public const StdVideoH265AspectRatioIdc STD_VIDEO_H265_ASPECT_RATIO_IDC_64_33 = StdVideoH265AspectRatioIdc._6433;
        public const StdVideoH265AspectRatioIdc STD_VIDEO_H265_ASPECT_RATIO_IDC_160_99 = StdVideoH265AspectRatioIdc._16099;
        public const StdVideoH265AspectRatioIdc STD_VIDEO_H265_ASPECT_RATIO_IDC_4_3 = StdVideoH265AspectRatioIdc._43;
        public const StdVideoH265AspectRatioIdc STD_VIDEO_H265_ASPECT_RATIO_IDC_3_2 = StdVideoH265AspectRatioIdc._32;
        public const StdVideoH265AspectRatioIdc STD_VIDEO_H265_ASPECT_RATIO_IDC_2_1 = StdVideoH265AspectRatioIdc._21;
        public const StdVideoH265AspectRatioIdc STD_VIDEO_H265_ASPECT_RATIO_IDC_EXTENDED_SAR = StdVideoH265AspectRatioIdc.ExtendedSar;
        public const StdVideoH265AspectRatioIdc STD_VIDEO_H265_ASPECT_RATIO_IDC_INVALID = StdVideoH265AspectRatioIdc.Invalid;
    }
}
