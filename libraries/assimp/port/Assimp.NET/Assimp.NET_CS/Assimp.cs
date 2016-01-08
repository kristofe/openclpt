/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.8
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class Assimp {
  public static uint MAXLEN {
    get {
      uint ret = AssimpPINVOKE.MAXLEN_get();
      return ret;
    } 
  }

  public static string aiGetLegalString() {
    string ret = AssimpPINVOKE.aiGetLegalString();
    return ret;
  }

  public static uint aiGetVersionMinor() {
    uint ret = AssimpPINVOKE.aiGetVersionMinor();
    return ret;
  }

  public static uint aiGetVersionMajor() {
    uint ret = AssimpPINVOKE.aiGetVersionMajor();
    return ret;
  }

  public static uint aiGetVersionRevision() {
    uint ret = AssimpPINVOKE.aiGetVersionRevision();
    return ret;
  }

  public static uint aiGetCompileFlags() {
    uint ret = AssimpPINVOKE.aiGetCompileFlags();
    return ret;
  }

  public static readonly double AI_MATH_PI = AssimpPINVOKE.AI_MATH_PI_get();
  public static readonly double AI_MATH_TWO_PI = AssimpPINVOKE.AI_MATH_TWO_PI_get();
  public static readonly double AI_MATH_HALF_PI = AssimpPINVOKE.AI_MATH_HALF_PI_get();
  public static readonly double AI_MATH_PI_F = AssimpPINVOKE.AI_MATH_PI_F_get();
  public static readonly double AI_MATH_TWO_PI_F = AssimpPINVOKE.AI_MATH_TWO_PI_F_get();
  public static readonly double AI_MATH_HALF_PI_F = AssimpPINVOKE.AI_MATH_HALF_PI_F_get();
  public static readonly string AI_CONFIG_GLOB_MEASURE_TIME = AssimpPINVOKE.AI_CONFIG_GLOB_MEASURE_TIME_get();
  public static readonly string AI_CONFIG_PP_SBBC_MAX_BONES = AssimpPINVOKE.AI_CONFIG_PP_SBBC_MAX_BONES_get();
  public static readonly int AI_SBBC_DEFAULT_MAX_BONES = AssimpPINVOKE.AI_SBBC_DEFAULT_MAX_BONES_get();
  public static readonly string AI_CONFIG_PP_CT_MAX_SMOOTHING_ANGLE = AssimpPINVOKE.AI_CONFIG_PP_CT_MAX_SMOOTHING_ANGLE_get();
  public static readonly string AI_CONFIG_PP_CT_TEXTURE_CHANNEL_INDEX = AssimpPINVOKE.AI_CONFIG_PP_CT_TEXTURE_CHANNEL_INDEX_get();
  public static readonly string AI_CONFIG_PP_GSN_MAX_SMOOTHING_ANGLE = AssimpPINVOKE.AI_CONFIG_PP_GSN_MAX_SMOOTHING_ANGLE_get();
  public static readonly string AI_CONFIG_IMPORT_MDL_COLORMAP = AssimpPINVOKE.AI_CONFIG_IMPORT_MDL_COLORMAP_get();
  public static readonly string AI_CONFIG_PP_RRM_EXCLUDE_LIST = AssimpPINVOKE.AI_CONFIG_PP_RRM_EXCLUDE_LIST_get();
  public static readonly string AI_CONFIG_PP_PTV_KEEP_HIERARCHY = AssimpPINVOKE.AI_CONFIG_PP_PTV_KEEP_HIERARCHY_get();
  public static readonly string AI_CONFIG_PP_PTV_NORMALIZE = AssimpPINVOKE.AI_CONFIG_PP_PTV_NORMALIZE_get();
  public static readonly string AI_CONFIG_PP_FD_REMOVE = AssimpPINVOKE.AI_CONFIG_PP_FD_REMOVE_get();
  public static readonly string AI_CONFIG_PP_OG_EXCLUDE_LIST = AssimpPINVOKE.AI_CONFIG_PP_OG_EXCLUDE_LIST_get();
  public static readonly string AI_CONFIG_PP_SLM_TRIANGLE_LIMIT = AssimpPINVOKE.AI_CONFIG_PP_SLM_TRIANGLE_LIMIT_get();
  public static readonly int AI_SLM_DEFAULT_MAX_TRIANGLES = AssimpPINVOKE.AI_SLM_DEFAULT_MAX_TRIANGLES_get();
  public static readonly string AI_CONFIG_PP_SLM_VERTEX_LIMIT = AssimpPINVOKE.AI_CONFIG_PP_SLM_VERTEX_LIMIT_get();
  public static readonly int AI_SLM_DEFAULT_MAX_VERTICES = AssimpPINVOKE.AI_SLM_DEFAULT_MAX_VERTICES_get();
  public static readonly string AI_CONFIG_PP_LBW_MAX_WEIGHTS = AssimpPINVOKE.AI_CONFIG_PP_LBW_MAX_WEIGHTS_get();
  public static readonly int AI_LMW_MAX_WEIGHTS = AssimpPINVOKE.AI_LMW_MAX_WEIGHTS_get();
  public static readonly string AI_CONFIG_PP_DB_THRESHOLD = AssimpPINVOKE.AI_CONFIG_PP_DB_THRESHOLD_get();
  public static readonly double AI_DEBONE_THRESHOLD = AssimpPINVOKE.AI_DEBONE_THRESHOLD_get();
  public static readonly string AI_CONFIG_PP_DB_ALL_OR_NONE = AssimpPINVOKE.AI_CONFIG_PP_DB_ALL_OR_NONE_get();
  public static readonly int PP_ICL_PTCACHE_SIZE = AssimpPINVOKE.PP_ICL_PTCACHE_SIZE_get();
  public static readonly string AI_CONFIG_PP_ICL_PTCACHE_SIZE = AssimpPINVOKE.AI_CONFIG_PP_ICL_PTCACHE_SIZE_get();
  public static readonly string AI_CONFIG_PP_RVC_FLAGS = AssimpPINVOKE.AI_CONFIG_PP_RVC_FLAGS_get();
  public static readonly string AI_CONFIG_PP_SBP_REMOVE = AssimpPINVOKE.AI_CONFIG_PP_SBP_REMOVE_get();
  public static readonly string AI_CONFIG_PP_FID_ANIM_ACCURACY = AssimpPINVOKE.AI_CONFIG_PP_FID_ANIM_ACCURACY_get();
  public static readonly int AI_UVTRAFO_SCALING = AssimpPINVOKE.AI_UVTRAFO_SCALING_get();
  public static readonly int AI_UVTRAFO_ROTATION = AssimpPINVOKE.AI_UVTRAFO_ROTATION_get();
  public static readonly int AI_UVTRAFO_TRANSLATION = AssimpPINVOKE.AI_UVTRAFO_TRANSLATION_get();
  public static readonly int AI_UVTRAFO_ALL = AssimpPINVOKE.AI_UVTRAFO_ALL_get();
  public static readonly string AI_CONFIG_PP_TUV_EVALUATE = AssimpPINVOKE.AI_CONFIG_PP_TUV_EVALUATE_get();
  public static readonly string AI_CONFIG_FAVOUR_SPEED = AssimpPINVOKE.AI_CONFIG_FAVOUR_SPEED_get();
  public static readonly string AI_CONFIG_IMPORT_GLOBAL_KEYFRAME = AssimpPINVOKE.AI_CONFIG_IMPORT_GLOBAL_KEYFRAME_get();
  public static readonly string AI_CONFIG_IMPORT_MD3_KEYFRAME = AssimpPINVOKE.AI_CONFIG_IMPORT_MD3_KEYFRAME_get();
  public static readonly string AI_CONFIG_IMPORT_MD2_KEYFRAME = AssimpPINVOKE.AI_CONFIG_IMPORT_MD2_KEYFRAME_get();
  public static readonly string AI_CONFIG_IMPORT_MDL_KEYFRAME = AssimpPINVOKE.AI_CONFIG_IMPORT_MDL_KEYFRAME_get();
  public static readonly string AI_CONFIG_IMPORT_MDC_KEYFRAME = AssimpPINVOKE.AI_CONFIG_IMPORT_MDC_KEYFRAME_get();
  public static readonly string AI_CONFIG_IMPORT_SMD_KEYFRAME = AssimpPINVOKE.AI_CONFIG_IMPORT_SMD_KEYFRAME_get();
  public static readonly string AI_CONFIG_IMPORT_UNREAL_KEYFRAME = AssimpPINVOKE.AI_CONFIG_IMPORT_UNREAL_KEYFRAME_get();
  public static readonly string AI_CONFIG_IMPORT_AC_SEPARATE_BFCULL = AssimpPINVOKE.AI_CONFIG_IMPORT_AC_SEPARATE_BFCULL_get();
  public static readonly string AI_CONFIG_IMPORT_AC_EVAL_SUBDIVISION = AssimpPINVOKE.AI_CONFIG_IMPORT_AC_EVAL_SUBDIVISION_get();
  public static readonly string AI_CONFIG_IMPORT_UNREAL_HANDLE_FLAGS = AssimpPINVOKE.AI_CONFIG_IMPORT_UNREAL_HANDLE_FLAGS_get();
  public static readonly string AI_CONFIG_IMPORT_TER_MAKE_UVS = AssimpPINVOKE.AI_CONFIG_IMPORT_TER_MAKE_UVS_get();
  public static readonly string AI_CONFIG_IMPORT_ASE_RECONSTRUCT_NORMALS = AssimpPINVOKE.AI_CONFIG_IMPORT_ASE_RECONSTRUCT_NORMALS_get();
  public static readonly string AI_CONFIG_IMPORT_MD3_HANDLE_MULTIPART = AssimpPINVOKE.AI_CONFIG_IMPORT_MD3_HANDLE_MULTIPART_get();
  public static readonly string AI_CONFIG_IMPORT_MD3_SKIN_NAME = AssimpPINVOKE.AI_CONFIG_IMPORT_MD3_SKIN_NAME_get();
  public static readonly string AI_CONFIG_IMPORT_MD3_SHADER_SRC = AssimpPINVOKE.AI_CONFIG_IMPORT_MD3_SHADER_SRC_get();
  public static readonly string AI_CONFIG_IMPORT_LWO_ONE_LAYER_ONLY = AssimpPINVOKE.AI_CONFIG_IMPORT_LWO_ONE_LAYER_ONLY_get();
  public static readonly string AI_CONFIG_IMPORT_MD5_NO_ANIM_AUTOLOAD = AssimpPINVOKE.AI_CONFIG_IMPORT_MD5_NO_ANIM_AUTOLOAD_get();
  public static readonly string AI_CONFIG_IMPORT_LWS_ANIM_START = AssimpPINVOKE.AI_CONFIG_IMPORT_LWS_ANIM_START_get();
  public static readonly string AI_CONFIG_IMPORT_LWS_ANIM_END = AssimpPINVOKE.AI_CONFIG_IMPORT_LWS_ANIM_END_get();
  public static readonly string AI_CONFIG_IMPORT_IRR_ANIM_FPS = AssimpPINVOKE.AI_CONFIG_IMPORT_IRR_ANIM_FPS_get();
  public static readonly string AI_CONFIG_IMPORT_OGRE_MATERIAL_FILE = AssimpPINVOKE.AI_CONFIG_IMPORT_OGRE_MATERIAL_FILE_get();
  public static readonly string AI_CONFIG_IMPORT_OGRE_TEXTURETYPE_FROM_FILENAME = AssimpPINVOKE.AI_CONFIG_IMPORT_OGRE_TEXTURETYPE_FROM_FILENAME_get();
  public static readonly string AI_CONFIG_IMPORT_IFC_SKIP_SPACE_REPRESENTATIONS = AssimpPINVOKE.AI_CONFIG_IMPORT_IFC_SKIP_SPACE_REPRESENTATIONS_get();
  public static readonly string AI_CONFIG_IMPORT_IFC_SKIP_CURVE_REPRESENTATIONS = AssimpPINVOKE.AI_CONFIG_IMPORT_IFC_SKIP_CURVE_REPRESENTATIONS_get();
  public static readonly string AI_CONFIG_IMPORT_IFC_CUSTOM_TRIANGULATION = AssimpPINVOKE.AI_CONFIG_IMPORT_IFC_CUSTOM_TRIANGULATION_get();
  public static readonly int ASSIMP_CFLAGS_SHARED = AssimpPINVOKE.ASSIMP_CFLAGS_SHARED_get();
  public static readonly int ASSIMP_CFLAGS_STLPORT = AssimpPINVOKE.ASSIMP_CFLAGS_STLPORT_get();
  public static readonly int ASSIMP_CFLAGS_DEBUG = AssimpPINVOKE.ASSIMP_CFLAGS_DEBUG_get();
  public static readonly int ASSIMP_CFLAGS_NOBOOST = AssimpPINVOKE.ASSIMP_CFLAGS_NOBOOST_get();
  public static readonly int ASSIMP_CFLAGS_SINGLETHREADED = AssimpPINVOKE.ASSIMP_CFLAGS_SINGLETHREADED_get();
  public static readonly int AI_MAX_FACE_INDICES = AssimpPINVOKE.AI_MAX_FACE_INDICES_get();
  public static readonly int AI_MAX_BONE_WEIGHTS = AssimpPINVOKE.AI_MAX_BONE_WEIGHTS_get();
  public static readonly int AI_MAX_VERTICES = AssimpPINVOKE.AI_MAX_VERTICES_get();
  public static readonly int AI_MAX_FACES = AssimpPINVOKE.AI_MAX_FACES_get();
  public static readonly int AI_MAX_NUMBER_OF_COLOR_SETS = AssimpPINVOKE.AI_MAX_NUMBER_OF_COLOR_SETS_get();
  public static readonly int AI_MAX_NUMBER_OF_TEXTURECOORDS = AssimpPINVOKE.AI_MAX_NUMBER_OF_TEXTURECOORDS_get();
  public static readonly string AI_DEFAULT_MATERIAL_NAME = AssimpPINVOKE.AI_DEFAULT_MATERIAL_NAME_get();
  public static readonly string _AI_MATKEY_TEXTURE_BASE = AssimpPINVOKE._AI_MATKEY_TEXTURE_BASE_get();
  public static readonly string _AI_MATKEY_UVWSRC_BASE = AssimpPINVOKE._AI_MATKEY_UVWSRC_BASE_get();
  public static readonly string _AI_MATKEY_TEXOP_BASE = AssimpPINVOKE._AI_MATKEY_TEXOP_BASE_get();
  public static readonly string _AI_MATKEY_MAPPING_BASE = AssimpPINVOKE._AI_MATKEY_MAPPING_BASE_get();
  public static readonly string _AI_MATKEY_TEXBLEND_BASE = AssimpPINVOKE._AI_MATKEY_TEXBLEND_BASE_get();
  public static readonly string _AI_MATKEY_MAPPINGMODE_U_BASE = AssimpPINVOKE._AI_MATKEY_MAPPINGMODE_U_BASE_get();
  public static readonly string _AI_MATKEY_MAPPINGMODE_V_BASE = AssimpPINVOKE._AI_MATKEY_MAPPINGMODE_V_BASE_get();
  public static readonly string _AI_MATKEY_TEXMAP_AXIS_BASE = AssimpPINVOKE._AI_MATKEY_TEXMAP_AXIS_BASE_get();
  public static readonly string _AI_MATKEY_UVTRANSFORM_BASE = AssimpPINVOKE._AI_MATKEY_UVTRANSFORM_BASE_get();
  public static readonly string _AI_MATKEY_TEXFLAGS_BASE = AssimpPINVOKE._AI_MATKEY_TEXFLAGS_BASE_get();
  public static readonly int AI_SCENE_FLAGS_INCOMPLETE = AssimpPINVOKE.AI_SCENE_FLAGS_INCOMPLETE_get();
  public static readonly int AI_SCENE_FLAGS_VALIDATED = AssimpPINVOKE.AI_SCENE_FLAGS_VALIDATED_get();
  public static readonly int AI_SCENE_FLAGS_VALIDATION_WARNING = AssimpPINVOKE.AI_SCENE_FLAGS_VALIDATION_WARNING_get();
  public static readonly int AI_SCENE_FLAGS_NON_VERBOSE_FORMAT = AssimpPINVOKE.AI_SCENE_FLAGS_NON_VERBOSE_FORMAT_get();
  public static readonly int AI_SCENE_FLAGS_TERRAIN = AssimpPINVOKE.AI_SCENE_FLAGS_TERRAIN_get();
  public static readonly int AI_PROPERTY_WAS_NOT_EXISTING = AssimpPINVOKE.AI_PROPERTY_WAS_NOT_EXISTING_get();
}
