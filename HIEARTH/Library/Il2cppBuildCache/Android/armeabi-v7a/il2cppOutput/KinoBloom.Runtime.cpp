#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>


template <typename R>
struct VirtFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};

// System.Char[]
struct CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34;
// UnityEngine.RenderTexture[]
struct RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E;
// Kino.Bloom
struct Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C;
// UnityEngine.Material
struct Material_t8927C00353A72755313F046D0CE85178AE8218EE;
// UnityEngine.MonoBehaviour
struct MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A;
// UnityEngine.Object
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A;
// UnityEngine.RenderTexture
struct RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849;
// UnityEngine.Shader
struct Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39;
// System.String
struct String_t;
// UnityEngine.Texture
struct Texture_t9FE0218A1EEDF266E8C85879FE123265CACC95AE;
// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5;

IL2CPP_EXTERN_C RuntimeClass* Graphics_t97FAEBE964F3F622D4865E7EC62717FE94D1F56D_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Material_t8927C00353A72755313F046D0CE85178AE8218EE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral207B3D9446F2D4167D3D15FA99BDA04AA93AD0A0;
IL2CPP_EXTERN_C String_t* _stringLiteral30245BC99B9312D571EE0A8F1703B93F992F1F66;
IL2CPP_EXTERN_C String_t* _stringLiteral3CB951C5C06E2A9CE696B22F5090A82016181ECD;
IL2CPP_EXTERN_C String_t* _stringLiteral4E207A1E776F6188653FF9228A95BFD3A17B492E;
IL2CPP_EXTERN_C String_t* _stringLiteral87C43E0C533B5BE7D4EAEA9F762B4B033313B85F;
IL2CPP_EXTERN_C String_t* _stringLiteralD62D0620DCC59E7C5F2161A049F9FF6D888D2E74;
IL2CPP_EXTERN_C String_t* _stringLiteralDCDB0027A8D2E4AA1706349E5323E470B20312E4;

struct RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct U3CModuleU3E_tEC365190A83812388BF490CCC5CB99B532700C9B 
{
public:

public:
};


// System.Object

struct Il2CppArrayBounds;

// System.Array


// System.String
struct String_t  : public RuntimeObject
{
public:
	// System.Int32 System.String::m_stringLength
	int32_t ___m_stringLength_0;
	// System.Char System.String::m_firstChar
	Il2CppChar ___m_firstChar_1;

public:
	inline static int32_t get_offset_of_m_stringLength_0() { return static_cast<int32_t>(offsetof(String_t, ___m_stringLength_0)); }
	inline int32_t get_m_stringLength_0() const { return ___m_stringLength_0; }
	inline int32_t* get_address_of_m_stringLength_0() { return &___m_stringLength_0; }
	inline void set_m_stringLength_0(int32_t value)
	{
		___m_stringLength_0 = value;
	}

	inline static int32_t get_offset_of_m_firstChar_1() { return static_cast<int32_t>(offsetof(String_t, ___m_firstChar_1)); }
	inline Il2CppChar get_m_firstChar_1() const { return ___m_firstChar_1; }
	inline Il2CppChar* get_address_of_m_firstChar_1() { return &___m_firstChar_1; }
	inline void set_m_firstChar_1(Il2CppChar value)
	{
		___m_firstChar_1 = value;
	}
};

struct String_t_StaticFields
{
public:
	// System.String System.String::Empty
	String_t* ___Empty_5;

public:
	inline static int32_t get_offset_of_Empty_5() { return static_cast<int32_t>(offsetof(String_t_StaticFields, ___Empty_5)); }
	inline String_t* get_Empty_5() const { return ___Empty_5; }
	inline String_t** get_address_of_Empty_5() { return &___Empty_5; }
	inline void set_Empty_5(String_t* value)
	{
		___Empty_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Empty_5), (void*)value);
	}
};


// System.ValueType
struct ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52  : public RuntimeObject
{
public:

public:
};

// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52_marshaled_com
{
};

// System.Boolean
struct Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37 
{
public:
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37, ___m_value_0)); }
	inline bool get_m_value_0() const { return ___m_value_0; }
	inline bool* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(bool value)
	{
		___m_value_0 = value;
	}
};

struct Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_StaticFields
{
public:
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;

public:
	inline static int32_t get_offset_of_TrueString_5() { return static_cast<int32_t>(offsetof(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_StaticFields, ___TrueString_5)); }
	inline String_t* get_TrueString_5() const { return ___TrueString_5; }
	inline String_t** get_address_of_TrueString_5() { return &___TrueString_5; }
	inline void set_TrueString_5(String_t* value)
	{
		___TrueString_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___TrueString_5), (void*)value);
	}

	inline static int32_t get_offset_of_FalseString_6() { return static_cast<int32_t>(offsetof(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_StaticFields, ___FalseString_6)); }
	inline String_t* get_FalseString_6() const { return ___FalseString_6; }
	inline String_t** get_address_of_FalseString_6() { return &___FalseString_6; }
	inline void set_FalseString_6(String_t* value)
	{
		___FalseString_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___FalseString_6), (void*)value);
	}
};


// System.Enum
struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA  : public ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52
{
public:

public:
};

struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA_StaticFields
{
public:
	// System.Char[] System.Enum::enumSeperatorCharArray
	CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* ___enumSeperatorCharArray_0;

public:
	inline static int32_t get_offset_of_enumSeperatorCharArray_0() { return static_cast<int32_t>(offsetof(Enum_t23B90B40F60E677A8025267341651C94AE079CDA_StaticFields, ___enumSeperatorCharArray_0)); }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* get_enumSeperatorCharArray_0() const { return ___enumSeperatorCharArray_0; }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34** get_address_of_enumSeperatorCharArray_0() { return &___enumSeperatorCharArray_0; }
	inline void set_enumSeperatorCharArray_0(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* value)
	{
		___enumSeperatorCharArray_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumSeperatorCharArray_0), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.Enum
struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.Enum
struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA_marshaled_com
{
};

// System.Int32
struct Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046 
{
public:
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046, ___m_value_0)); }
	inline int32_t get_m_value_0() const { return ___m_value_0; }
	inline int32_t* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(int32_t value)
	{
		___m_value_0 = value;
	}
};


// System.IntPtr
struct IntPtr_t 
{
public:
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(IntPtr_t, ___m_value_0)); }
	inline void* get_m_value_0() const { return ___m_value_0; }
	inline void** get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(void* value)
	{
		___m_value_0 = value;
	}
};

struct IntPtr_t_StaticFields
{
public:
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;

public:
	inline static int32_t get_offset_of_Zero_1() { return static_cast<int32_t>(offsetof(IntPtr_t_StaticFields, ___Zero_1)); }
	inline intptr_t get_Zero_1() const { return ___Zero_1; }
	inline intptr_t* get_address_of_Zero_1() { return &___Zero_1; }
	inline void set_Zero_1(intptr_t value)
	{
		___Zero_1 = value;
	}
};


// System.Single
struct Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E 
{
public:
	// System.Single System.Single::m_value
	float ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Single_tE07797BA3C98D4CA9B5A19413C19A76688AB899E, ___m_value_0)); }
	inline float get_m_value_0() const { return ___m_value_0; }
	inline float* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(float value)
	{
		___m_value_0 = value;
	}
};


// UnityEngine.Vector3
struct Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E 
{
public:
	// System.Single UnityEngine.Vector3::x
	float ___x_2;
	// System.Single UnityEngine.Vector3::y
	float ___y_3;
	// System.Single UnityEngine.Vector3::z
	float ___z_4;

public:
	inline static int32_t get_offset_of_x_2() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E, ___x_2)); }
	inline float get_x_2() const { return ___x_2; }
	inline float* get_address_of_x_2() { return &___x_2; }
	inline void set_x_2(float value)
	{
		___x_2 = value;
	}

	inline static int32_t get_offset_of_y_3() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E, ___y_3)); }
	inline float get_y_3() const { return ___y_3; }
	inline float* get_address_of_y_3() { return &___y_3; }
	inline void set_y_3(float value)
	{
		___y_3 = value;
	}

	inline static int32_t get_offset_of_z_4() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E, ___z_4)); }
	inline float get_z_4() const { return ___z_4; }
	inline float* get_address_of_z_4() { return &___z_4; }
	inline void set_z_4(float value)
	{
		___z_4 = value;
	}
};

struct Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields
{
public:
	// UnityEngine.Vector3 UnityEngine.Vector3::zeroVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___zeroVector_5;
	// UnityEngine.Vector3 UnityEngine.Vector3::oneVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___oneVector_6;
	// UnityEngine.Vector3 UnityEngine.Vector3::upVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___upVector_7;
	// UnityEngine.Vector3 UnityEngine.Vector3::downVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___downVector_8;
	// UnityEngine.Vector3 UnityEngine.Vector3::leftVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___leftVector_9;
	// UnityEngine.Vector3 UnityEngine.Vector3::rightVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___rightVector_10;
	// UnityEngine.Vector3 UnityEngine.Vector3::forwardVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___forwardVector_11;
	// UnityEngine.Vector3 UnityEngine.Vector3::backVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___backVector_12;
	// UnityEngine.Vector3 UnityEngine.Vector3::positiveInfinityVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___positiveInfinityVector_13;
	// UnityEngine.Vector3 UnityEngine.Vector3::negativeInfinityVector
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___negativeInfinityVector_14;

public:
	inline static int32_t get_offset_of_zeroVector_5() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___zeroVector_5)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_zeroVector_5() const { return ___zeroVector_5; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_zeroVector_5() { return &___zeroVector_5; }
	inline void set_zeroVector_5(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___zeroVector_5 = value;
	}

	inline static int32_t get_offset_of_oneVector_6() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___oneVector_6)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_oneVector_6() const { return ___oneVector_6; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_oneVector_6() { return &___oneVector_6; }
	inline void set_oneVector_6(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___oneVector_6 = value;
	}

	inline static int32_t get_offset_of_upVector_7() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___upVector_7)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_upVector_7() const { return ___upVector_7; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_upVector_7() { return &___upVector_7; }
	inline void set_upVector_7(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___upVector_7 = value;
	}

	inline static int32_t get_offset_of_downVector_8() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___downVector_8)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_downVector_8() const { return ___downVector_8; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_downVector_8() { return &___downVector_8; }
	inline void set_downVector_8(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___downVector_8 = value;
	}

	inline static int32_t get_offset_of_leftVector_9() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___leftVector_9)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_leftVector_9() const { return ___leftVector_9; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_leftVector_9() { return &___leftVector_9; }
	inline void set_leftVector_9(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___leftVector_9 = value;
	}

	inline static int32_t get_offset_of_rightVector_10() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___rightVector_10)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_rightVector_10() const { return ___rightVector_10; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_rightVector_10() { return &___rightVector_10; }
	inline void set_rightVector_10(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___rightVector_10 = value;
	}

	inline static int32_t get_offset_of_forwardVector_11() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___forwardVector_11)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_forwardVector_11() const { return ___forwardVector_11; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_forwardVector_11() { return &___forwardVector_11; }
	inline void set_forwardVector_11(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___forwardVector_11 = value;
	}

	inline static int32_t get_offset_of_backVector_12() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___backVector_12)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_backVector_12() const { return ___backVector_12; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_backVector_12() { return &___backVector_12; }
	inline void set_backVector_12(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___backVector_12 = value;
	}

	inline static int32_t get_offset_of_positiveInfinityVector_13() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___positiveInfinityVector_13)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_positiveInfinityVector_13() const { return ___positiveInfinityVector_13; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_positiveInfinityVector_13() { return &___positiveInfinityVector_13; }
	inline void set_positiveInfinityVector_13(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___positiveInfinityVector_13 = value;
	}

	inline static int32_t get_offset_of_negativeInfinityVector_14() { return static_cast<int32_t>(offsetof(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E_StaticFields, ___negativeInfinityVector_14)); }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  get_negativeInfinityVector_14() const { return ___negativeInfinityVector_14; }
	inline Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * get_address_of_negativeInfinityVector_14() { return &___negativeInfinityVector_14; }
	inline void set_negativeInfinityVector_14(Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  value)
	{
		___negativeInfinityVector_14 = value;
	}
};


// UnityEngine.Vector4
struct Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 
{
public:
	// System.Single UnityEngine.Vector4::x
	float ___x_1;
	// System.Single UnityEngine.Vector4::y
	float ___y_2;
	// System.Single UnityEngine.Vector4::z
	float ___z_3;
	// System.Single UnityEngine.Vector4::w
	float ___w_4;

public:
	inline static int32_t get_offset_of_x_1() { return static_cast<int32_t>(offsetof(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7, ___x_1)); }
	inline float get_x_1() const { return ___x_1; }
	inline float* get_address_of_x_1() { return &___x_1; }
	inline void set_x_1(float value)
	{
		___x_1 = value;
	}

	inline static int32_t get_offset_of_y_2() { return static_cast<int32_t>(offsetof(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7, ___y_2)); }
	inline float get_y_2() const { return ___y_2; }
	inline float* get_address_of_y_2() { return &___y_2; }
	inline void set_y_2(float value)
	{
		___y_2 = value;
	}

	inline static int32_t get_offset_of_z_3() { return static_cast<int32_t>(offsetof(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7, ___z_3)); }
	inline float get_z_3() const { return ___z_3; }
	inline float* get_address_of_z_3() { return &___z_3; }
	inline void set_z_3(float value)
	{
		___z_3 = value;
	}

	inline static int32_t get_offset_of_w_4() { return static_cast<int32_t>(offsetof(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7, ___w_4)); }
	inline float get_w_4() const { return ___w_4; }
	inline float* get_address_of_w_4() { return &___w_4; }
	inline void set_w_4(float value)
	{
		___w_4 = value;
	}
};

struct Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_StaticFields
{
public:
	// UnityEngine.Vector4 UnityEngine.Vector4::zeroVector
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___zeroVector_5;
	// UnityEngine.Vector4 UnityEngine.Vector4::oneVector
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___oneVector_6;
	// UnityEngine.Vector4 UnityEngine.Vector4::positiveInfinityVector
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___positiveInfinityVector_7;
	// UnityEngine.Vector4 UnityEngine.Vector4::negativeInfinityVector
	Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___negativeInfinityVector_8;

public:
	inline static int32_t get_offset_of_zeroVector_5() { return static_cast<int32_t>(offsetof(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_StaticFields, ___zeroVector_5)); }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  get_zeroVector_5() const { return ___zeroVector_5; }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * get_address_of_zeroVector_5() { return &___zeroVector_5; }
	inline void set_zeroVector_5(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  value)
	{
		___zeroVector_5 = value;
	}

	inline static int32_t get_offset_of_oneVector_6() { return static_cast<int32_t>(offsetof(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_StaticFields, ___oneVector_6)); }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  get_oneVector_6() const { return ___oneVector_6; }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * get_address_of_oneVector_6() { return &___oneVector_6; }
	inline void set_oneVector_6(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  value)
	{
		___oneVector_6 = value;
	}

	inline static int32_t get_offset_of_positiveInfinityVector_7() { return static_cast<int32_t>(offsetof(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_StaticFields, ___positiveInfinityVector_7)); }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  get_positiveInfinityVector_7() const { return ___positiveInfinityVector_7; }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * get_address_of_positiveInfinityVector_7() { return &___positiveInfinityVector_7; }
	inline void set_positiveInfinityVector_7(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  value)
	{
		___positiveInfinityVector_7 = value;
	}

	inline static int32_t get_offset_of_negativeInfinityVector_8() { return static_cast<int32_t>(offsetof(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7_StaticFields, ___negativeInfinityVector_8)); }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  get_negativeInfinityVector_8() const { return ___negativeInfinityVector_8; }
	inline Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7 * get_address_of_negativeInfinityVector_8() { return &___negativeInfinityVector_8; }
	inline void set_negativeInfinityVector_8(Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  value)
	{
		___negativeInfinityVector_8 = value;
	}
};


// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5 
{
public:
	union
	{
		struct
		{
		};
		uint8_t Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5__padding[1];
	};

public:
};


// UnityEngine.HideFlags
struct HideFlags_tDC64149E37544FF83B2B4222D3E9DC8188766A12 
{
public:
	// System.Int32 UnityEngine.HideFlags::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(HideFlags_tDC64149E37544FF83B2B4222D3E9DC8188766A12, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Object
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;

public:
	inline static int32_t get_offset_of_m_CachedPtr_0() { return static_cast<int32_t>(offsetof(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A, ___m_CachedPtr_0)); }
	inline intptr_t get_m_CachedPtr_0() const { return ___m_CachedPtr_0; }
	inline intptr_t* get_address_of_m_CachedPtr_0() { return &___m_CachedPtr_0; }
	inline void set_m_CachedPtr_0(intptr_t value)
	{
		___m_CachedPtr_0 = value;
	}
};

struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_StaticFields
{
public:
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;

public:
	inline static int32_t get_offset_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return static_cast<int32_t>(offsetof(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_StaticFields, ___OffsetOfInstanceIDInCPlusPlusObject_1)); }
	inline int32_t get_OffsetOfInstanceIDInCPlusPlusObject_1() const { return ___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline int32_t* get_address_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return &___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline void set_OffsetOfInstanceIDInCPlusPlusObject_1(int32_t value)
	{
		___OffsetOfInstanceIDInCPlusPlusObject_1 = value;
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};

// UnityEngine.RenderTextureFormat
struct RenderTextureFormat_t8371287102ED67772EF78229CF4AB9D38C2CD626 
{
public:
	// System.Int32 UnityEngine.RenderTextureFormat::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(RenderTextureFormat_t8371287102ED67772EF78229CF4AB9D38C2CD626, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Component
struct Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
};


// UnityEngine.Material
struct Material_t8927C00353A72755313F046D0CE85178AE8218EE  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
};


// UnityEngine.Shader
struct Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
};


// UnityEngine.Texture
struct Texture_t9FE0218A1EEDF266E8C85879FE123265CACC95AE  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
};

struct Texture_t9FE0218A1EEDF266E8C85879FE123265CACC95AE_StaticFields
{
public:
	// System.Int32 UnityEngine.Texture::GenerateAllMips
	int32_t ___GenerateAllMips_4;

public:
	inline static int32_t get_offset_of_GenerateAllMips_4() { return static_cast<int32_t>(offsetof(Texture_t9FE0218A1EEDF266E8C85879FE123265CACC95AE_StaticFields, ___GenerateAllMips_4)); }
	inline int32_t get_GenerateAllMips_4() const { return ___GenerateAllMips_4; }
	inline int32_t* get_address_of_GenerateAllMips_4() { return &___GenerateAllMips_4; }
	inline void set_GenerateAllMips_4(int32_t value)
	{
		___GenerateAllMips_4 = value;
	}
};


// UnityEngine.Behaviour
struct Behaviour_t1A3DDDCF73B4627928FBFE02ED52B7251777DBD9  : public Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684
{
public:

public:
};


// UnityEngine.RenderTexture
struct RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849  : public Texture_t9FE0218A1EEDF266E8C85879FE123265CACC95AE
{
public:

public:
};


// UnityEngine.MonoBehaviour
struct MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A  : public Behaviour_t1A3DDDCF73B4627928FBFE02ED52B7251777DBD9
{
public:

public:
};


// Kino.Bloom
struct Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// System.Single Kino.Bloom::_threshold
	float ____threshold_4;
	// System.Single Kino.Bloom::_softKnee
	float ____softKnee_5;
	// System.Single Kino.Bloom::_radius
	float ____radius_6;
	// System.Single Kino.Bloom::_intensity
	float ____intensity_7;
	// System.Boolean Kino.Bloom::_highQuality
	bool ____highQuality_8;
	// System.Boolean Kino.Bloom::_antiFlicker
	bool ____antiFlicker_9;
	// UnityEngine.Shader Kino.Bloom::_shader
	Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * ____shader_10;
	// UnityEngine.Material Kino.Bloom::_material
	Material_t8927C00353A72755313F046D0CE85178AE8218EE * ____material_11;
	// UnityEngine.RenderTexture[] Kino.Bloom::_blurBuffer1
	RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E* ____blurBuffer1_13;
	// UnityEngine.RenderTexture[] Kino.Bloom::_blurBuffer2
	RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E* ____blurBuffer2_14;

public:
	inline static int32_t get_offset_of__threshold_4() { return static_cast<int32_t>(offsetof(Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C, ____threshold_4)); }
	inline float get__threshold_4() const { return ____threshold_4; }
	inline float* get_address_of__threshold_4() { return &____threshold_4; }
	inline void set__threshold_4(float value)
	{
		____threshold_4 = value;
	}

	inline static int32_t get_offset_of__softKnee_5() { return static_cast<int32_t>(offsetof(Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C, ____softKnee_5)); }
	inline float get__softKnee_5() const { return ____softKnee_5; }
	inline float* get_address_of__softKnee_5() { return &____softKnee_5; }
	inline void set__softKnee_5(float value)
	{
		____softKnee_5 = value;
	}

	inline static int32_t get_offset_of__radius_6() { return static_cast<int32_t>(offsetof(Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C, ____radius_6)); }
	inline float get__radius_6() const { return ____radius_6; }
	inline float* get_address_of__radius_6() { return &____radius_6; }
	inline void set__radius_6(float value)
	{
		____radius_6 = value;
	}

	inline static int32_t get_offset_of__intensity_7() { return static_cast<int32_t>(offsetof(Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C, ____intensity_7)); }
	inline float get__intensity_7() const { return ____intensity_7; }
	inline float* get_address_of__intensity_7() { return &____intensity_7; }
	inline void set__intensity_7(float value)
	{
		____intensity_7 = value;
	}

	inline static int32_t get_offset_of__highQuality_8() { return static_cast<int32_t>(offsetof(Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C, ____highQuality_8)); }
	inline bool get__highQuality_8() const { return ____highQuality_8; }
	inline bool* get_address_of__highQuality_8() { return &____highQuality_8; }
	inline void set__highQuality_8(bool value)
	{
		____highQuality_8 = value;
	}

	inline static int32_t get_offset_of__antiFlicker_9() { return static_cast<int32_t>(offsetof(Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C, ____antiFlicker_9)); }
	inline bool get__antiFlicker_9() const { return ____antiFlicker_9; }
	inline bool* get_address_of__antiFlicker_9() { return &____antiFlicker_9; }
	inline void set__antiFlicker_9(bool value)
	{
		____antiFlicker_9 = value;
	}

	inline static int32_t get_offset_of__shader_10() { return static_cast<int32_t>(offsetof(Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C, ____shader_10)); }
	inline Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * get__shader_10() const { return ____shader_10; }
	inline Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 ** get_address_of__shader_10() { return &____shader_10; }
	inline void set__shader_10(Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * value)
	{
		____shader_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____shader_10), (void*)value);
	}

	inline static int32_t get_offset_of__material_11() { return static_cast<int32_t>(offsetof(Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C, ____material_11)); }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE * get__material_11() const { return ____material_11; }
	inline Material_t8927C00353A72755313F046D0CE85178AE8218EE ** get_address_of__material_11() { return &____material_11; }
	inline void set__material_11(Material_t8927C00353A72755313F046D0CE85178AE8218EE * value)
	{
		____material_11 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____material_11), (void*)value);
	}

	inline static int32_t get_offset_of__blurBuffer1_13() { return static_cast<int32_t>(offsetof(Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C, ____blurBuffer1_13)); }
	inline RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E* get__blurBuffer1_13() const { return ____blurBuffer1_13; }
	inline RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E** get_address_of__blurBuffer1_13() { return &____blurBuffer1_13; }
	inline void set__blurBuffer1_13(RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E* value)
	{
		____blurBuffer1_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____blurBuffer1_13), (void*)value);
	}

	inline static int32_t get_offset_of__blurBuffer2_14() { return static_cast<int32_t>(offsetof(Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C, ____blurBuffer2_14)); }
	inline RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E* get__blurBuffer2_14() const { return ____blurBuffer2_14; }
	inline RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E** get_address_of__blurBuffer2_14() { return &____blurBuffer2_14; }
	inline void set__blurBuffer2_14(RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E* value)
	{
		____blurBuffer2_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____blurBuffer2_14), (void*)value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// UnityEngine.RenderTexture[]
struct RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * m_Items[1];

public:
	inline RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};



// System.Single UnityEngine.Mathf::Max(System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Mathf_Max_m4CE510E1F1013B33275F01543731A51A58BA0775 (float ___a0, float ___b1, const RuntimeMethod* method);
// System.Single Kino.Bloom::get_thresholdGamma()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Bloom_get_thresholdGamma_m6BEE5227D0623EB6961BE89A8361C472DAF8B971 (Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C * __this, const RuntimeMethod* method);
// System.Single Kino.Bloom::GammaToLinear(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Bloom_GammaToLinear_m51722CF07B0BBFBFDE52B1ED57727561A53EACAE (Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C * __this, float ___x0, const RuntimeMethod* method);
// System.Single Kino.Bloom::LinearToGamma(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Bloom_LinearToGamma_mAC848DC12CAE8AD9B148919510F1BBD9E981E85C (Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C * __this, float ___x0, const RuntimeMethod* method);
// System.Single UnityEngine.Mathf::LinearToGammaSpace(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Mathf_LinearToGammaSpace_m5F74DEC2B3A7B45A75AC199284A22D92839118F3 (float ___value0, const RuntimeMethod* method);
// System.Single UnityEngine.Mathf::GammaToLinearSpace(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Mathf_GammaToLinearSpace_mD7A738810039778B4592535A1DB5767C4CAD68FB (float ___value0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Object::op_Implicit(UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Object_op_Implicit_mC8214E4F028CC2F036CC82BDB81D102A02893499 (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___exists0, const RuntimeMethod* method);
// UnityEngine.Shader UnityEngine.Shader::Find(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * Shader_Find_m596EC6EBDCA8C9D5D86E2410A319928C1E8E6B5A (String_t* ___name0, const RuntimeMethod* method);
// System.Void UnityEngine.Material::.ctor(UnityEngine.Shader)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Material__ctor_mD2A3BCD3B4F17F5C6E95F3B34DAF4B497B67127E (Material_t8927C00353A72755313F046D0CE85178AE8218EE * __this, Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * ___shader0, const RuntimeMethod* method);
// System.Void UnityEngine.Object::set_hideFlags(UnityEngine.HideFlags)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object_set_hideFlags_m7DE229AF60B92F0C68819F77FEB27D775E66F3AC (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * __this, int32_t ___value0, const RuntimeMethod* method);
// System.Void UnityEngine.Object::DestroyImmediate(UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object_DestroyImmediate_mCCED69F4D4C9A4FA3AC30A142CF3D7F085F7C422 (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___obj0, const RuntimeMethod* method);
// System.Boolean UnityEngine.Application::get_isMobilePlatform()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Application_get_isMobilePlatform_m86CE0D4224E9F3E4DC8DFF848C5E559F4B3E622E (const RuntimeMethod* method);
// System.Single UnityEngine.Mathf::Log(System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Mathf_Log_mF7F3624FA030AB57AD8C1F4CAF084B2DCC99897A (float ___f0, float ___p1, const RuntimeMethod* method);
// System.Int32 UnityEngine.Mathf::Clamp(System.Int32,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Mathf_Clamp_mAD0781EB7470594CD4482DD64A0D739E4E539C3C (int32_t ___value0, int32_t ___min1, int32_t ___max2, const RuntimeMethod* method);
// System.Single Kino.Bloom::get_thresholdLinear()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Bloom_get_thresholdLinear_m0B4B57713DA7522431A1D74D13320870AE7731A0 (Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C * __this, const RuntimeMethod* method);
// System.Void UnityEngine.Material::SetFloat(System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Material_SetFloat_mBE01E05D49E5C7045E010F49A38E96B101D82768 (Material_t8927C00353A72755313F046D0CE85178AE8218EE * __this, String_t* ___name0, float ___value1, const RuntimeMethod* method);
// System.Void UnityEngine.Vector3::.ctor(System.Single,System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector3__ctor_m57495F692C6CE1CEF278CAD9A98221165D37E636_inline (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * __this, float ___x0, float ___y1, float ___z2, const RuntimeMethod* method);
// UnityEngine.Vector4 UnityEngine.Vector4::op_Implicit(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  Vector4_op_Implicit_mDCFA56E9D34979E1E2BFE6C2D61F1768D934A8EB (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  ___v0, const RuntimeMethod* method);
// System.Void UnityEngine.Material::SetVector(System.String,UnityEngine.Vector4)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Material_SetVector_mCB22CD5FDA6D8C7C282D7998A9244E12CC293F0D (Material_t8927C00353A72755313F046D0CE85178AE8218EE * __this, String_t* ___name0, Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  ___value1, const RuntimeMethod* method);
// System.Single Kino.Bloom::get_intensity()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Bloom_get_intensity_mE9F68DA2CEAB373F2F3563591E6001501888B138 (Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C * __this, const RuntimeMethod* method);
// UnityEngine.RenderTexture UnityEngine.RenderTexture::GetTemporary(System.Int32,System.Int32,System.Int32,UnityEngine.RenderTextureFormat)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * RenderTexture_GetTemporary_mEA38E780ED9C1E065B97E85BBC63F8DE548C7B8E (int32_t ___width0, int32_t ___height1, int32_t ___depthBuffer2, int32_t ___format3, const RuntimeMethod* method);
// System.Void UnityEngine.Graphics::Blit(UnityEngine.Texture,UnityEngine.RenderTexture,UnityEngine.Material,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Graphics_Blit_mF7AA319E24D980D0E560A721966B87186392C3DD (Texture_t9FE0218A1EEDF266E8C85879FE123265CACC95AE * ___source0, RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * ___dest1, Material_t8927C00353A72755313F046D0CE85178AE8218EE * ___mat2, int32_t ___pass3, const RuntimeMethod* method);
// System.Void UnityEngine.Material::SetTexture(System.String,UnityEngine.Texture)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Material_SetTexture_m04A1CD55201841F85E475992931A210229C782CF (Material_t8927C00353A72755313F046D0CE85178AE8218EE * __this, String_t* ___name0, Texture_t9FE0218A1EEDF266E8C85879FE123265CACC95AE * ___value1, const RuntimeMethod* method);
// System.Boolean UnityEngine.Object::op_Inequality(UnityEngine.Object,UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Object_op_Inequality_mE1F187520BD83FB7D86A6D850710C4D42B864E90 (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___x0, Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___y1, const RuntimeMethod* method);
// System.Void UnityEngine.RenderTexture::ReleaseTemporary(UnityEngine.RenderTexture)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RenderTexture_ReleaseTemporary_m2BF2BDDC359A491C05C401B977878DAE1D0850D4 (RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * ___temp0, const RuntimeMethod* method);
// System.Void UnityEngine.MonoBehaviour::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED (MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A * __this, const RuntimeMethod* method);
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Single Kino.Bloom::get_thresholdGamma()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Bloom_get_thresholdGamma_m6BEE5227D0623EB6961BE89A8361C472DAF8B971 (Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C * __this, const RuntimeMethod* method)
{
	{
		// get { return Mathf.Max(_threshold, 0); }
		float L_0 = __this->get__threshold_4();
		float L_1;
		L_1 = Mathf_Max_m4CE510E1F1013B33275F01543731A51A58BA0775(L_0, (0.0f), /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void Kino.Bloom::set_thresholdGamma(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Bloom_set_thresholdGamma_mC5B7704A40F117EBFACCD42507EE23A8EC76500F (Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C * __this, float ___value0, const RuntimeMethod* method)
{
	{
		// set { _threshold = value; }
		float L_0 = ___value0;
		__this->set__threshold_4(L_0);
		// set { _threshold = value; }
		return;
	}
}
// System.Single Kino.Bloom::get_thresholdLinear()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Bloom_get_thresholdLinear_m0B4B57713DA7522431A1D74D13320870AE7731A0 (Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C * __this, const RuntimeMethod* method)
{
	{
		// get { return GammaToLinear(thresholdGamma); }
		float L_0;
		L_0 = Bloom_get_thresholdGamma_m6BEE5227D0623EB6961BE89A8361C472DAF8B971(__this, /*hidden argument*/NULL);
		float L_1;
		L_1 = Bloom_GammaToLinear_m51722CF07B0BBFBFDE52B1ED57727561A53EACAE(__this, L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void Kino.Bloom::set_thresholdLinear(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Bloom_set_thresholdLinear_mFDB5BC929E71882457C8C27B12F005BE954D5818 (Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C * __this, float ___value0, const RuntimeMethod* method)
{
	{
		// set { _threshold = LinearToGamma(value); }
		float L_0 = ___value0;
		float L_1;
		L_1 = Bloom_LinearToGamma_mAC848DC12CAE8AD9B148919510F1BBD9E981E85C(__this, L_0, /*hidden argument*/NULL);
		__this->set__threshold_4(L_1);
		// set { _threshold = LinearToGamma(value); }
		return;
	}
}
// System.Single Kino.Bloom::get_softKnee()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Bloom_get_softKnee_m7CEB3B4598042E7F5E80ACBD2BA26BDDB5F36937 (Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C * __this, const RuntimeMethod* method)
{
	{
		// get { return _softKnee; }
		float L_0 = __this->get__softKnee_5();
		return L_0;
	}
}
// System.Void Kino.Bloom::set_softKnee(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Bloom_set_softKnee_m2F2877D901BD787AF45E98EAFEADACF6284CE4A5 (Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C * __this, float ___value0, const RuntimeMethod* method)
{
	{
		// set { _softKnee = value; }
		float L_0 = ___value0;
		__this->set__softKnee_5(L_0);
		// set { _softKnee = value; }
		return;
	}
}
// System.Single Kino.Bloom::get_radius()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Bloom_get_radius_m3D71E2F9F72A57A278D008ECE05290255B6E914E (Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C * __this, const RuntimeMethod* method)
{
	{
		// get { return _radius; }
		float L_0 = __this->get__radius_6();
		return L_0;
	}
}
// System.Void Kino.Bloom::set_radius(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Bloom_set_radius_m4A4FECF767147F09ACEA31390B23CF79527520BD (Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C * __this, float ___value0, const RuntimeMethod* method)
{
	{
		// set { _radius = value; }
		float L_0 = ___value0;
		__this->set__radius_6(L_0);
		// set { _radius = value; }
		return;
	}
}
// System.Single Kino.Bloom::get_intensity()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Bloom_get_intensity_mE9F68DA2CEAB373F2F3563591E6001501888B138 (Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C * __this, const RuntimeMethod* method)
{
	{
		// get { return Mathf.Max(_intensity, 0); }
		float L_0 = __this->get__intensity_7();
		float L_1;
		L_1 = Mathf_Max_m4CE510E1F1013B33275F01543731A51A58BA0775(L_0, (0.0f), /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void Kino.Bloom::set_intensity(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Bloom_set_intensity_m26FDECACD003C79E9A653F0E198DC32209C21F33 (Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C * __this, float ___value0, const RuntimeMethod* method)
{
	{
		// set { _intensity = value; }
		float L_0 = ___value0;
		__this->set__intensity_7(L_0);
		// set { _intensity = value; }
		return;
	}
}
// System.Boolean Kino.Bloom::get_highQuality()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Bloom_get_highQuality_m3D20BF6921D6AA542418BCCE347020EAFF7C2C93 (Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C * __this, const RuntimeMethod* method)
{
	{
		// get { return _highQuality; }
		bool L_0 = __this->get__highQuality_8();
		return L_0;
	}
}
// System.Void Kino.Bloom::set_highQuality(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Bloom_set_highQuality_mCFD94A4A1AD392351B0CDD1B88F0894A246AEA76 (Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C * __this, bool ___value0, const RuntimeMethod* method)
{
	{
		// set { _highQuality = value; }
		bool L_0 = ___value0;
		__this->set__highQuality_8(L_0);
		// set { _highQuality = value; }
		return;
	}
}
// System.Boolean Kino.Bloom::get_antiFlicker()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Bloom_get_antiFlicker_m52DAB3162A47BEE7AC5812A51A6203DDDCF84A99 (Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C * __this, const RuntimeMethod* method)
{
	{
		// get { return _antiFlicker; }
		bool L_0 = __this->get__antiFlicker_9();
		return L_0;
	}
}
// System.Void Kino.Bloom::set_antiFlicker(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Bloom_set_antiFlicker_mE475D7FD1C0D0F5B15355202833E61D1B26A186B (Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C * __this, bool ___value0, const RuntimeMethod* method)
{
	{
		// set { _antiFlicker = value; }
		bool L_0 = ___value0;
		__this->set__antiFlicker_9(L_0);
		// set { _antiFlicker = value; }
		return;
	}
}
// System.Single Kino.Bloom::LinearToGamma(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Bloom_LinearToGamma_mAC848DC12CAE8AD9B148919510F1BBD9E981E85C (Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C * __this, float ___x0, const RuntimeMethod* method)
{
	{
		// return Mathf.LinearToGammaSpace(x);
		float L_0 = ___x0;
		float L_1;
		L_1 = Mathf_LinearToGammaSpace_m5F74DEC2B3A7B45A75AC199284A22D92839118F3(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Single Kino.Bloom::GammaToLinear(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Bloom_GammaToLinear_m51722CF07B0BBFBFDE52B1ED57727561A53EACAE (Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C * __this, float ___x0, const RuntimeMethod* method)
{
	{
		// return Mathf.GammaToLinearSpace(x);
		float L_0 = ___x0;
		float L_1;
		L_1 = Mathf_GammaToLinearSpace_mD7A738810039778B4592535A1DB5767C4CAD68FB(L_0, /*hidden argument*/NULL);
		return L_1;
	}
}
// System.Void Kino.Bloom::OnEnable()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Bloom_OnEnable_m266500328250E28A250719918C2C5042C7B802BB (Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Material_t8927C00353A72755313F046D0CE85178AE8218EE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral30245BC99B9312D571EE0A8F1703B93F992F1F66);
		s_Il2CppMethodInitialized = true;
	}
	Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * V_0 = NULL;
	Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * G_B3_0 = NULL;
	{
		// var shader = _shader ? _shader : Shader.Find("Hidden/Kino/Bloom");
		Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * L_0 = __this->get__shader_10();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = Object_op_Implicit_mC8214E4F028CC2F036CC82BDB81D102A02893499(L_0, /*hidden argument*/NULL);
		if (L_1)
		{
			goto IL_0019;
		}
	}
	{
		Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * L_2;
		L_2 = Shader_Find_m596EC6EBDCA8C9D5D86E2410A319928C1E8E6B5A(_stringLiteral30245BC99B9312D571EE0A8F1703B93F992F1F66, /*hidden argument*/NULL);
		G_B3_0 = L_2;
		goto IL_001f;
	}

IL_0019:
	{
		Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * L_3 = __this->get__shader_10();
		G_B3_0 = L_3;
	}

IL_001f:
	{
		V_0 = G_B3_0;
		// _material = new Material(shader);
		Shader_tB2355DC4F3CAF20B2F1AB5AABBF37C3555FFBC39 * L_4 = V_0;
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_5 = (Material_t8927C00353A72755313F046D0CE85178AE8218EE *)il2cpp_codegen_object_new(Material_t8927C00353A72755313F046D0CE85178AE8218EE_il2cpp_TypeInfo_var);
		Material__ctor_mD2A3BCD3B4F17F5C6E95F3B34DAF4B497B67127E(L_5, L_4, /*hidden argument*/NULL);
		__this->set__material_11(L_5);
		// _material.hideFlags = HideFlags.DontSave;
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_6 = __this->get__material_11();
		NullCheck(L_6);
		Object_set_hideFlags_m7DE229AF60B92F0C68819F77FEB27D775E66F3AC(L_6, ((int32_t)52), /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void Kino.Bloom::OnDisable()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Bloom_OnDisable_m24237610511F133A5772E3DEAEA8C4F484515516 (Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// DestroyImmediate(_material);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_0 = __this->get__material_11();
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		Object_DestroyImmediate_mCCED69F4D4C9A4FA3AC30A142CF3D7F085F7C422(L_0, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void Kino.Bloom::OnRenderImage(UnityEngine.RenderTexture,UnityEngine.RenderTexture)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Bloom_OnRenderImage_m073FCD8423DB513F3C856C4E030BE793F5603BF4 (Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C * __this, RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * ___source0, RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * ___destination1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Graphics_t97FAEBE964F3F622D4865E7EC62717FE94D1F56D_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral207B3D9446F2D4167D3D15FA99BDA04AA93AD0A0);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral3CB951C5C06E2A9CE696B22F5090A82016181ECD);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4E207A1E776F6188653FF9228A95BFD3A17B492E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral87C43E0C533B5BE7D4EAEA9F762B4B033313B85F);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralD62D0620DCC59E7C5F2161A049F9FF6D888D2E74);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDCDB0027A8D2E4AA1706349E5323E470B20312E4);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	float V_3 = 0.0f;
	int32_t V_4 = 0;
	int32_t V_5 = 0;
	float V_6 = 0.0f;
	float V_7 = 0.0f;
	Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  V_8;
	memset((&V_8), 0, sizeof(V_8));
	bool V_9 = false;
	RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * V_10 = NULL;
	int32_t V_11 = 0;
	RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * V_12 = NULL;
	int32_t V_13 = 0;
	int32_t V_14 = 0;
	RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * V_15 = NULL;
	int32_t V_16 = 0;
	bool G_B2_0 = false;
	bool G_B1_0 = false;
	int32_t G_B5_0 = 0;
	int32_t G_B8_0 = 0;
	String_t* G_B10_0 = NULL;
	Material_t8927C00353A72755313F046D0CE85178AE8218EE * G_B10_1 = NULL;
	String_t* G_B9_0 = NULL;
	Material_t8927C00353A72755313F046D0CE85178AE8218EE * G_B9_1 = NULL;
	float G_B11_0 = 0.0f;
	String_t* G_B11_1 = NULL;
	Material_t8927C00353A72755313F046D0CE85178AE8218EE * G_B11_2 = NULL;
	int32_t G_B14_0 = 0;
	int32_t G_B20_0 = 0;
	int32_t G_B26_0 = 0;
	int32_t G_B31_0 = 0;
	{
		// var useRGBM = Application.isMobilePlatform;
		bool L_0;
		L_0 = Application_get_isMobilePlatform_m86CE0D4224E9F3E4DC8DFF848C5E559F4B3E622E(/*hidden argument*/NULL);
		// var tw = source.width;
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_1 = ___source0;
		NullCheck(L_1);
		int32_t L_2;
		L_2 = VirtFuncInvoker0< int32_t >::Invoke(4 /* System.Int32 UnityEngine.Texture::get_width() */, L_1);
		V_0 = L_2;
		// var th = source.height;
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_3 = ___source0;
		NullCheck(L_3);
		int32_t L_4;
		L_4 = VirtFuncInvoker0< int32_t >::Invoke(6 /* System.Int32 UnityEngine.Texture::get_height() */, L_3);
		V_1 = L_4;
		// if (!_highQuality)
		bool L_5 = __this->get__highQuality_8();
		G_B1_0 = L_0;
		if (L_5)
		{
			G_B2_0 = L_0;
			goto IL_0023;
		}
	}
	{
		// tw /= 2;
		int32_t L_6 = V_0;
		V_0 = ((int32_t)((int32_t)L_6/(int32_t)2));
		// th /= 2;
		int32_t L_7 = V_1;
		V_1 = ((int32_t)((int32_t)L_7/(int32_t)2));
		G_B2_0 = G_B1_0;
	}

IL_0023:
	{
		// var rtFormat = useRGBM ?
		//     RenderTextureFormat.Default : RenderTextureFormat.DefaultHDR;
		if (G_B2_0)
		{
			goto IL_0029;
		}
	}
	{
		G_B5_0 = ((int32_t)9);
		goto IL_002a;
	}

IL_0029:
	{
		G_B5_0 = 7;
	}

IL_002a:
	{
		V_2 = G_B5_0;
		// var logh = Mathf.Log(th, 2) + _radius - 8;
		int32_t L_8 = V_1;
		float L_9;
		L_9 = Mathf_Log_mF7F3624FA030AB57AD8C1F4CAF084B2DCC99897A(((float)((float)L_8)), (2.0f), /*hidden argument*/NULL);
		float L_10 = __this->get__radius_6();
		V_3 = ((float)il2cpp_codegen_subtract((float)((float)il2cpp_codegen_add((float)L_9, (float)L_10)), (float)(8.0f)));
		// var logh_i = (int)logh;
		float L_11 = V_3;
		V_4 = il2cpp_codegen_cast_double_to_int<int32_t>(L_11);
		// var iterations = Mathf.Clamp(logh_i, 1, kMaxIterations);
		int32_t L_12 = V_4;
		int32_t L_13;
		L_13 = Mathf_Clamp_mAD0781EB7470594CD4482DD64A0D739E4E539C3C(L_12, 1, ((int32_t)16), /*hidden argument*/NULL);
		V_5 = L_13;
		// var lthresh = thresholdLinear;
		float L_14;
		L_14 = Bloom_get_thresholdLinear_m0B4B57713DA7522431A1D74D13320870AE7731A0(__this, /*hidden argument*/NULL);
		V_6 = L_14;
		// _material.SetFloat("_Threshold", lthresh);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_15 = __this->get__material_11();
		float L_16 = V_6;
		NullCheck(L_15);
		Material_SetFloat_mBE01E05D49E5C7045E010F49A38E96B101D82768(L_15, _stringLiteral207B3D9446F2D4167D3D15FA99BDA04AA93AD0A0, L_16, /*hidden argument*/NULL);
		// var knee = lthresh * _softKnee + 1e-5f;
		float L_17 = V_6;
		float L_18 = __this->get__softKnee_5();
		V_7 = ((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_multiply((float)L_17, (float)L_18)), (float)(9.99999975E-06f)));
		// var curve = new Vector3(lthresh - knee, knee * 2, 0.25f / knee);
		float L_19 = V_6;
		float L_20 = V_7;
		float L_21 = V_7;
		float L_22 = V_7;
		Vector3__ctor_m57495F692C6CE1CEF278CAD9A98221165D37E636_inline((Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E *)(&V_8), ((float)il2cpp_codegen_subtract((float)L_19, (float)L_20)), ((float)il2cpp_codegen_multiply((float)L_21, (float)(2.0f))), ((float)((float)(0.25f)/(float)L_22)), /*hidden argument*/NULL);
		// _material.SetVector("_Curve", curve);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_23 = __this->get__material_11();
		Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E  L_24 = V_8;
		Vector4_tA56A37FC5661BCC89C3DDC24BE12BA5BCB6A02C7  L_25;
		L_25 = Vector4_op_Implicit_mDCFA56E9D34979E1E2BFE6C2D61F1768D934A8EB(L_24, /*hidden argument*/NULL);
		NullCheck(L_23);
		Material_SetVector_mCB22CD5FDA6D8C7C282D7998A9244E12CC293F0D(L_23, _stringLiteral87C43E0C533B5BE7D4EAEA9F762B4B033313B85F, L_25, /*hidden argument*/NULL);
		// var pfo = !_highQuality && _antiFlicker;
		bool L_26 = __this->get__highQuality_8();
		if (L_26)
		{
			goto IL_00c3;
		}
	}
	{
		bool L_27 = __this->get__antiFlicker_9();
		G_B8_0 = ((int32_t)(L_27));
		goto IL_00c4;
	}

IL_00c3:
	{
		G_B8_0 = 0;
	}

IL_00c4:
	{
		V_9 = (bool)G_B8_0;
		// _material.SetFloat("_PrefilterOffs", pfo ? -0.5f : 0.0f);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_28 = __this->get__material_11();
		bool L_29 = V_9;
		G_B9_0 = _stringLiteralDCDB0027A8D2E4AA1706349E5323E470B20312E4;
		G_B9_1 = L_28;
		if (L_29)
		{
			G_B10_0 = _stringLiteralDCDB0027A8D2E4AA1706349E5323E470B20312E4;
			G_B10_1 = L_28;
			goto IL_00dc;
		}
	}
	{
		G_B11_0 = (0.0f);
		G_B11_1 = G_B9_0;
		G_B11_2 = G_B9_1;
		goto IL_00e1;
	}

IL_00dc:
	{
		G_B11_0 = (-0.5f);
		G_B11_1 = G_B10_0;
		G_B11_2 = G_B10_1;
	}

IL_00e1:
	{
		NullCheck(G_B11_2);
		Material_SetFloat_mBE01E05D49E5C7045E010F49A38E96B101D82768(G_B11_2, G_B11_1, G_B11_0, /*hidden argument*/NULL);
		// _material.SetFloat("_SampleScale", 0.5f + logh - logh_i);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_30 = __this->get__material_11();
		float L_31 = V_3;
		int32_t L_32 = V_4;
		NullCheck(L_30);
		Material_SetFloat_mBE01E05D49E5C7045E010F49A38E96B101D82768(L_30, _stringLiteral3CB951C5C06E2A9CE696B22F5090A82016181ECD, ((float)il2cpp_codegen_subtract((float)((float)il2cpp_codegen_add((float)(0.5f), (float)L_31)), (float)((float)((float)L_32)))), /*hidden argument*/NULL);
		// _material.SetFloat("_Intensity", intensity);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_33 = __this->get__material_11();
		float L_34;
		L_34 = Bloom_get_intensity_mE9F68DA2CEAB373F2F3563591E6001501888B138(__this, /*hidden argument*/NULL);
		NullCheck(L_33);
		Material_SetFloat_mBE01E05D49E5C7045E010F49A38E96B101D82768(L_33, _stringLiteral4E207A1E776F6188653FF9228A95BFD3A17B492E, L_34, /*hidden argument*/NULL);
		// var prefiltered = RenderTexture.GetTemporary(tw, th, 0, rtFormat);
		int32_t L_35 = V_0;
		int32_t L_36 = V_1;
		int32_t L_37 = V_2;
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_38;
		L_38 = RenderTexture_GetTemporary_mEA38E780ED9C1E065B97E85BBC63F8DE548C7B8E(L_35, L_36, 0, L_37, /*hidden argument*/NULL);
		V_10 = L_38;
		// var pass = _antiFlicker ? 1 : 0;
		bool L_39 = __this->get__antiFlicker_9();
		if (L_39)
		{
			goto IL_012d;
		}
	}
	{
		G_B14_0 = 0;
		goto IL_012e;
	}

IL_012d:
	{
		G_B14_0 = 1;
	}

IL_012e:
	{
		V_11 = G_B14_0;
		// Graphics.Blit(source, prefiltered, _material, pass);
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_40 = ___source0;
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_41 = V_10;
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_42 = __this->get__material_11();
		int32_t L_43 = V_11;
		IL2CPP_RUNTIME_CLASS_INIT(Graphics_t97FAEBE964F3F622D4865E7EC62717FE94D1F56D_il2cpp_TypeInfo_var);
		Graphics_Blit_mF7AA319E24D980D0E560A721966B87186392C3DD(L_40, L_41, L_42, L_43, /*hidden argument*/NULL);
		// var last = prefiltered;
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_44 = V_10;
		V_12 = L_44;
		// for (var level = 0; level < iterations; level++)
		V_13 = 0;
		goto IL_01a9;
	}

IL_0149:
	{
		// _blurBuffer1[level] = RenderTexture.GetTemporary(
		//     last.width / 2, last.height / 2, 0, rtFormat
		// );
		RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E* L_45 = __this->get__blurBuffer1_13();
		int32_t L_46 = V_13;
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_47 = V_12;
		NullCheck(L_47);
		int32_t L_48;
		L_48 = VirtFuncInvoker0< int32_t >::Invoke(4 /* System.Int32 UnityEngine.Texture::get_width() */, L_47);
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_49 = V_12;
		NullCheck(L_49);
		int32_t L_50;
		L_50 = VirtFuncInvoker0< int32_t >::Invoke(6 /* System.Int32 UnityEngine.Texture::get_height() */, L_49);
		int32_t L_51 = V_2;
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_52;
		L_52 = RenderTexture_GetTemporary_mEA38E780ED9C1E065B97E85BBC63F8DE548C7B8E(((int32_t)((int32_t)L_48/(int32_t)2)), ((int32_t)((int32_t)L_50/(int32_t)2)), 0, L_51, /*hidden argument*/NULL);
		NullCheck(L_45);
		ArrayElementTypeCheck (L_45, L_52);
		(L_45)->SetAt(static_cast<il2cpp_array_size_t>(L_46), (RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 *)L_52);
		// pass = (level == 0) ? (_antiFlicker ? 3 : 2) : 4;
		int32_t L_53 = V_13;
		if (!L_53)
		{
			goto IL_0172;
		}
	}
	{
		G_B20_0 = 4;
		goto IL_017e;
	}

IL_0172:
	{
		bool L_54 = __this->get__antiFlicker_9();
		if (L_54)
		{
			goto IL_017d;
		}
	}
	{
		G_B20_0 = 2;
		goto IL_017e;
	}

IL_017d:
	{
		G_B20_0 = 3;
	}

IL_017e:
	{
		V_11 = G_B20_0;
		// Graphics.Blit(last, _blurBuffer1[level], _material, pass);
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_55 = V_12;
		RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E* L_56 = __this->get__blurBuffer1_13();
		int32_t L_57 = V_13;
		NullCheck(L_56);
		int32_t L_58 = L_57;
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_59 = (L_56)->GetAt(static_cast<il2cpp_array_size_t>(L_58));
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_60 = __this->get__material_11();
		int32_t L_61 = V_11;
		IL2CPP_RUNTIME_CLASS_INIT(Graphics_t97FAEBE964F3F622D4865E7EC62717FE94D1F56D_il2cpp_TypeInfo_var);
		Graphics_Blit_mF7AA319E24D980D0E560A721966B87186392C3DD(L_55, L_59, L_60, L_61, /*hidden argument*/NULL);
		// last = _blurBuffer1[level];
		RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E* L_62 = __this->get__blurBuffer1_13();
		int32_t L_63 = V_13;
		NullCheck(L_62);
		int32_t L_64 = L_63;
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_65 = (L_62)->GetAt(static_cast<il2cpp_array_size_t>(L_64));
		V_12 = L_65;
		// for (var level = 0; level < iterations; level++)
		int32_t L_66 = V_13;
		V_13 = ((int32_t)il2cpp_codegen_add((int32_t)L_66, (int32_t)1));
	}

IL_01a9:
	{
		// for (var level = 0; level < iterations; level++)
		int32_t L_67 = V_13;
		int32_t L_68 = V_5;
		if ((((int32_t)L_67) < ((int32_t)L_68)))
		{
			goto IL_0149;
		}
	}
	{
		// for (var level = iterations - 2; level >= 0; level--)
		int32_t L_69 = V_5;
		V_14 = ((int32_t)il2cpp_codegen_subtract((int32_t)L_69, (int32_t)2));
		goto IL_0229;
	}

IL_01b7:
	{
		// var basetex = _blurBuffer1[level];
		RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E* L_70 = __this->get__blurBuffer1_13();
		int32_t L_71 = V_14;
		NullCheck(L_70);
		int32_t L_72 = L_71;
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_73 = (L_70)->GetAt(static_cast<il2cpp_array_size_t>(L_72));
		V_15 = L_73;
		// _material.SetTexture("_BaseTex", basetex);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_74 = __this->get__material_11();
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_75 = V_15;
		NullCheck(L_74);
		Material_SetTexture_m04A1CD55201841F85E475992931A210229C782CF(L_74, _stringLiteralD62D0620DCC59E7C5F2161A049F9FF6D888D2E74, L_75, /*hidden argument*/NULL);
		// _blurBuffer2[level] = RenderTexture.GetTemporary(
		//     basetex.width, basetex.height, 0, rtFormat
		// );
		RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E* L_76 = __this->get__blurBuffer2_14();
		int32_t L_77 = V_14;
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_78 = V_15;
		NullCheck(L_78);
		int32_t L_79;
		L_79 = VirtFuncInvoker0< int32_t >::Invoke(4 /* System.Int32 UnityEngine.Texture::get_width() */, L_78);
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_80 = V_15;
		NullCheck(L_80);
		int32_t L_81;
		L_81 = VirtFuncInvoker0< int32_t >::Invoke(6 /* System.Int32 UnityEngine.Texture::get_height() */, L_80);
		int32_t L_82 = V_2;
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_83;
		L_83 = RenderTexture_GetTemporary_mEA38E780ED9C1E065B97E85BBC63F8DE548C7B8E(L_79, L_81, 0, L_82, /*hidden argument*/NULL);
		NullCheck(L_76);
		ArrayElementTypeCheck (L_76, L_83);
		(L_76)->SetAt(static_cast<il2cpp_array_size_t>(L_77), (RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 *)L_83);
		// pass = _highQuality ? 6 : 5;
		bool L_84 = __this->get__highQuality_8();
		if (L_84)
		{
			goto IL_01fd;
		}
	}
	{
		G_B26_0 = 5;
		goto IL_01fe;
	}

IL_01fd:
	{
		G_B26_0 = 6;
	}

IL_01fe:
	{
		V_11 = G_B26_0;
		// Graphics.Blit(last, _blurBuffer2[level], _material, pass);
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_85 = V_12;
		RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E* L_86 = __this->get__blurBuffer2_14();
		int32_t L_87 = V_14;
		NullCheck(L_86);
		int32_t L_88 = L_87;
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_89 = (L_86)->GetAt(static_cast<il2cpp_array_size_t>(L_88));
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_90 = __this->get__material_11();
		int32_t L_91 = V_11;
		IL2CPP_RUNTIME_CLASS_INIT(Graphics_t97FAEBE964F3F622D4865E7EC62717FE94D1F56D_il2cpp_TypeInfo_var);
		Graphics_Blit_mF7AA319E24D980D0E560A721966B87186392C3DD(L_85, L_89, L_90, L_91, /*hidden argument*/NULL);
		// last = _blurBuffer2[level];
		RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E* L_92 = __this->get__blurBuffer2_14();
		int32_t L_93 = V_14;
		NullCheck(L_92);
		int32_t L_94 = L_93;
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_95 = (L_92)->GetAt(static_cast<il2cpp_array_size_t>(L_94));
		V_12 = L_95;
		// for (var level = iterations - 2; level >= 0; level--)
		int32_t L_96 = V_14;
		V_14 = ((int32_t)il2cpp_codegen_subtract((int32_t)L_96, (int32_t)1));
	}

IL_0229:
	{
		// for (var level = iterations - 2; level >= 0; level--)
		int32_t L_97 = V_14;
		if ((((int32_t)L_97) >= ((int32_t)0)))
		{
			goto IL_01b7;
		}
	}
	{
		// _material.SetTexture("_BaseTex", source);
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_98 = __this->get__material_11();
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_99 = ___source0;
		NullCheck(L_98);
		Material_SetTexture_m04A1CD55201841F85E475992931A210229C782CF(L_98, _stringLiteralD62D0620DCC59E7C5F2161A049F9FF6D888D2E74, L_99, /*hidden argument*/NULL);
		// pass = _highQuality ? 8 : 7;
		bool L_100 = __this->get__highQuality_8();
		if (L_100)
		{
			goto IL_024a;
		}
	}
	{
		G_B31_0 = 7;
		goto IL_024b;
	}

IL_024a:
	{
		G_B31_0 = 8;
	}

IL_024b:
	{
		V_11 = G_B31_0;
		// Graphics.Blit(last, destination, _material, pass);
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_101 = V_12;
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_102 = ___destination1;
		Material_t8927C00353A72755313F046D0CE85178AE8218EE * L_103 = __this->get__material_11();
		int32_t L_104 = V_11;
		IL2CPP_RUNTIME_CLASS_INIT(Graphics_t97FAEBE964F3F622D4865E7EC62717FE94D1F56D_il2cpp_TypeInfo_var);
		Graphics_Blit_mF7AA319E24D980D0E560A721966B87186392C3DD(L_101, L_102, L_103, L_104, /*hidden argument*/NULL);
		// for (var i = 0; i < kMaxIterations; i++)
		V_16 = 0;
		goto IL_02ba;
	}

IL_0262:
	{
		// if (_blurBuffer1[i] != null)
		RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E* L_105 = __this->get__blurBuffer1_13();
		int32_t L_106 = V_16;
		NullCheck(L_105);
		int32_t L_107 = L_106;
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_108 = (L_105)->GetAt(static_cast<il2cpp_array_size_t>(L_107));
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_109;
		L_109 = Object_op_Inequality_mE1F187520BD83FB7D86A6D850710C4D42B864E90(L_108, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_109)
		{
			goto IL_0281;
		}
	}
	{
		// RenderTexture.ReleaseTemporary(_blurBuffer1[i]);
		RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E* L_110 = __this->get__blurBuffer1_13();
		int32_t L_111 = V_16;
		NullCheck(L_110);
		int32_t L_112 = L_111;
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_113 = (L_110)->GetAt(static_cast<il2cpp_array_size_t>(L_112));
		RenderTexture_ReleaseTemporary_m2BF2BDDC359A491C05C401B977878DAE1D0850D4(L_113, /*hidden argument*/NULL);
	}

IL_0281:
	{
		// if (_blurBuffer2[i] != null)
		RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E* L_114 = __this->get__blurBuffer2_14();
		int32_t L_115 = V_16;
		NullCheck(L_114);
		int32_t L_116 = L_115;
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_117 = (L_114)->GetAt(static_cast<il2cpp_array_size_t>(L_116));
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_118;
		L_118 = Object_op_Inequality_mE1F187520BD83FB7D86A6D850710C4D42B864E90(L_117, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		if (!L_118)
		{
			goto IL_02a0;
		}
	}
	{
		// RenderTexture.ReleaseTemporary(_blurBuffer2[i]);
		RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E* L_119 = __this->get__blurBuffer2_14();
		int32_t L_120 = V_16;
		NullCheck(L_119);
		int32_t L_121 = L_120;
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_122 = (L_119)->GetAt(static_cast<il2cpp_array_size_t>(L_121));
		RenderTexture_ReleaseTemporary_m2BF2BDDC359A491C05C401B977878DAE1D0850D4(L_122, /*hidden argument*/NULL);
	}

IL_02a0:
	{
		// _blurBuffer1[i] = null;
		RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E* L_123 = __this->get__blurBuffer1_13();
		int32_t L_124 = V_16;
		NullCheck(L_123);
		ArrayElementTypeCheck (L_123, NULL);
		(L_123)->SetAt(static_cast<il2cpp_array_size_t>(L_124), (RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 *)NULL);
		// _blurBuffer2[i] = null;
		RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E* L_125 = __this->get__blurBuffer2_14();
		int32_t L_126 = V_16;
		NullCheck(L_125);
		ArrayElementTypeCheck (L_125, NULL);
		(L_125)->SetAt(static_cast<il2cpp_array_size_t>(L_126), (RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 *)NULL);
		// for (var i = 0; i < kMaxIterations; i++)
		int32_t L_127 = V_16;
		V_16 = ((int32_t)il2cpp_codegen_add((int32_t)L_127, (int32_t)1));
	}

IL_02ba:
	{
		// for (var i = 0; i < kMaxIterations; i++)
		int32_t L_128 = V_16;
		if ((((int32_t)L_128) < ((int32_t)((int32_t)16))))
		{
			goto IL_0262;
		}
	}
	{
		// RenderTexture.ReleaseTemporary(prefiltered);
		RenderTexture_t5FE7A5B47EF962A0E8D7BEBA05E9FC87D49A1849 * L_129 = V_10;
		RenderTexture_ReleaseTemporary_m2BF2BDDC359A491C05C401B977878DAE1D0850D4(L_129, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void Kino.Bloom::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Bloom__ctor_m1F935808BF723F72546991175C66A499194F4733 (Bloom_t26A89084F1DE8B6A96DDD69D8166A8E844EE673C * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// float _threshold = 0.8f;
		__this->set__threshold_4((0.800000012f));
		// float _softKnee = 0.5f;
		__this->set__softKnee_5((0.5f));
		// float _radius = 2.5f;
		__this->set__radius_6((2.5f));
		// float _intensity = 0.8f;
		__this->set__intensity_7((0.800000012f));
		// bool _highQuality = true;
		__this->set__highQuality_8((bool)1);
		// bool _antiFlicker = true;
		__this->set__antiFlicker_9((bool)1);
		// RenderTexture[] _blurBuffer1 = new RenderTexture[kMaxIterations];
		RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E* L_0 = (RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E*)(RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E*)SZArrayNew(RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E_il2cpp_TypeInfo_var, (uint32_t)((int32_t)16));
		__this->set__blurBuffer1_13(L_0);
		// RenderTexture[] _blurBuffer2 = new RenderTexture[kMaxIterations];
		RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E* L_1 = (RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E*)(RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E*)SZArrayNew(RenderTextureU5BU5D_tDC947BF3616454E270458293C61A06867ED4B02E_il2cpp_TypeInfo_var, (uint32_t)((int32_t)16));
		__this->set__blurBuffer2_14(L_1);
		MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector3__ctor_m57495F692C6CE1CEF278CAD9A98221165D37E636_inline (Vector3_t65B972D6A585A0A5B63153CF1177A90D3C90D65E * __this, float ___x0, float ___y1, float ___z2, const RuntimeMethod* method)
{
	{
		float L_0 = ___x0;
		__this->set_x_2(L_0);
		float L_1 = ___y1;
		__this->set_y_3(L_1);
		float L_2 = ___z2;
		__this->set_z_4(L_2);
		return;
	}
}
