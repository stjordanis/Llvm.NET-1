#ifndef LLVM_BINDINGS_LLVM_METADATABINDINGS_H
#define LLVM_BINDINGS_LLVM_METADATABINDINGS_H

#include <stdint.h>
#include "llvm-c/Core.h"
#include "llvm-c/DebugInfo.h"

#ifdef __cplusplus
extern "C" {
#endif

    enum LibLLVMDwarfTag
    {
#define HANDLE_DW_TAG(ID, NAME, VERSION, VENDOR)                 \
  LibLLVMDwarfTag##NAME = ID,
#include "llvm/BinaryFormat/Dwarf.def"
#undef HANDLE_DW_TAG
    };

    typedef struct LLVMOpaqueMDOperand* LibLLVMMDOperandRef;

    unsigned int LibLLVMDIBasicTypeGetEncoding( LLVMMetadataRef /*DIBasicType*/ basicType );
    LLVMBool LibLLVMSubProgramDescribes( LLVMMetadataRef subProgram, LLVMValueRef /*const Function **/F );
    LLVMContextRef LibLLVMGetNodeContext( LLVMMetadataRef /*MDNode*/ node );

    LLVMMetadataRef LibLLVMDIBuilderCreateTempFunctionFwdDecl( LLVMDIBuilderRef D
                                                               , LLVMMetadataRef /*DIScope* */Scope
                                                               , char const* Name
                                                               , size_t NameLen
                                                               , char const* LinkageName
                                                               , size_t LinakgeNameLen
                                                               , LLVMMetadataRef /*DIFile* */ File
                                                               , unsigned LineNo
                                                               , LLVMMetadataRef /*DISubroutineType* */ Ty
                                                               , LLVMBool isLocalToUnit
                                                               , LLVMBool isDefinition
                                                               , unsigned ScopeLine
                                                               , LLVMDIFlags Flags /*= 0*/
                                                               , LLVMBool isOptimized /*= false*/
    );

    void LibLLVMDIBuilderFinalizeSubProgram( LLVMDIBuilderRef dref, LLVMMetadataRef /*DISubProgram*/ subProgram );
    LLVMMetadataRef LibLLVMDILocation( LLVMContextRef context, unsigned Line, unsigned Column, LLVMMetadataRef scope, LLVMMetadataRef InlinedAt );
    LibLLVMDwarfTag LibLLVMDIDescriptorGetTag( LLVMMetadataRef descriptor );
    LLVMMetadataRef /*DILocation*/ LibLLVMDILocationGetInlinedAt( LLVMMetadataRef /*DILocation*/ location );
    LLVMMetadataRef /*DILocalScope*/ LibLLVMDILocationGetInlinedAtScope( LLVMMetadataRef /*DILocation*/ location );

    // caller must call LLVMDisposeMessage() on the returned string
    char const* LibLLVMMetadataAsString( LLVMMetadataRef descriptor );

    uint32_t LibLLVMMDNodeGetNumOperands( LLVMMetadataRef /*MDNode*/ node );
    LibLLVMMDOperandRef LibLLVMMDNodeGetOperand( LLVMMetadataRef /*MDNode*/ node, uint32_t index );
    void LibLLVMMDNodeReplaceOperand( LLVMMetadataRef /* MDNode */ node, uint32_t index, LLVMMetadataRef operand );
    LLVMMetadataRef LibLLVMGetOperandNode( LibLLVMMDOperandRef operand );

    LLVMModuleRef LibLLVMNamedMetadataGetParentModule( LLVMNamedMDNodeRef namedMDNode );
    void LibLLVMNamedMetadataEraseFromParent( LLVMNamedMDNodeRef namedMDNode );
    LLVMMetadataKind LibLLVMGetMetadataID( LLVMMetadataRef /*Metadata*/ md );

    unsigned LibLLVMNamedMDNodeGetNumOperands( LLVMNamedMDNodeRef namedMDNode );
    /*MDNode*/ LLVMMetadataRef LibLLVMNamedMDNodeGetOperand( LLVMNamedMDNodeRef namedMDNode, unsigned index );
    void LibLLVMNamedMDNodeSetOperand( LLVMNamedMDNodeRef namedMDNode, unsigned index, LLVMMetadataRef /*MDNode*/ node );
    void LibLLVMNamedMDNodeAddOperand( LLVMNamedMDNodeRef namedMDNode, LLVMMetadataRef /*MDNode*/ node );
    void LibLLVMNamedMDNodeClearOperands( LLVMNamedMDNodeRef namedMDNode );

    LLVMMetadataRef LibLLVMConstantAsMetadata( LLVMValueRef Val );
    LLVMMetadataRef LibLLVMMDString2( LLVMContextRef C, const char* Str, unsigned SLen );
    LLVMMetadataRef LibLLVMMDNode2( LLVMContextRef C, LLVMMetadataRef* MDs, unsigned Count );

    char const* LibLLVMGetMDStringText( LLVMMetadataRef mdstring, unsigned* len );

    void LibLLVMAddNamedMetadataOperand2( LLVMModuleRef M, const char* name, LLVMMetadataRef Val );
    void LibLLVMSetMetadata2( LLVMValueRef Inst, unsigned KindID, LLVMMetadataRef MD );
    void LibLLVMSetCurrentDebugLocation2( LLVMBuilderRef Bref, unsigned Line, unsigned Col, LLVMMetadataRef Scope, LLVMMetadataRef InlinedAt );

    LLVMBool LibLLVMIsTemporary( LLVMMetadataRef M );
    LLVMBool LibLLVMIsResolved( LLVMMetadataRef M );
    LLVMBool LibLLVMIsUniqued( LLVMMetadataRef M );
    LLVMBool LibLLVMIsDistinct( LLVMMetadataRef M );

    LLVMMetadataRef LibLLVMDIGlobalVarExpGetVariable( LLVMMetadataRef /*DIGlobalVariableExpression*/ metadataHandle );

#ifdef __cplusplus
} // extern "C"
#endif

#endif
