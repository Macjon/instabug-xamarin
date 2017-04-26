//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action))]
		internal delegate void DAction (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDAction {
			static internal readonly DAction Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DAction))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDAction */
		
		internal class NIDAction {
			IntPtr blockPtr;
			DAction invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDAction (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DAction> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDAction ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDAction ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke ()
			{
				invoker (blockPtr);
			}
		} /* class NIDAction */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::iOSBindingDynamicLib.PostInvocationHandler))]
		internal delegate void DPostInvocationHandler (IntPtr block, nint dismissType, nint reportType);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPostInvocationHandler {
			static internal readonly DPostInvocationHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPostInvocationHandler))]
			static unsafe void Invoke (IntPtr block, nint dismissType, nint reportType) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::iOSBindingDynamicLib.PostInvocationHandler) (descriptor->Target);
				if (del != null)
					del ((global::iOSBindingDynamicLib.IBGDismissType) (global::System.Int64) dismissType, (global::iOSBindingDynamicLib.IBGReportType) (global::System.Int64) reportType);
			}
		} /* class SDPostInvocationHandler */
		
		internal class NIDPostInvocationHandler {
			IntPtr blockPtr;
			DPostInvocationHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPostInvocationHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPostInvocationHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPostInvocationHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::iOSBindingDynamicLib.PostInvocationHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::iOSBindingDynamicLib.PostInvocationHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPostInvocationHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::iOSBindingDynamicLib.IBGDismissType dismissType, global::iOSBindingDynamicLib.IBGReportType reportType)
			{
				invoker (blockPtr, (nint) (Int64) dismissType, (nint) (Int64) reportType);
			}
		} /* class NIDPostInvocationHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::iOSBindingDynamicLib.PromptOptionHandler))]
		internal delegate void DPromptOptionHandler (IntPtr block, nint promptOption);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDPromptOptionHandler {
			static internal readonly DPromptOptionHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DPromptOptionHandler))]
			static unsafe void Invoke (IntPtr block, nint promptOption) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::iOSBindingDynamicLib.PromptOptionHandler) (descriptor->Target);
				if (del != null)
					del ((global::iOSBindingDynamicLib.IBGPromptOption) (global::System.Int64) promptOption);
			}
		} /* class SDPromptOptionHandler */
		
		internal class NIDPromptOptionHandler {
			IntPtr blockPtr;
			DPromptOptionHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDPromptOptionHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DPromptOptionHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDPromptOptionHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::iOSBindingDynamicLib.PromptOptionHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::iOSBindingDynamicLib.PromptOptionHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDPromptOptionHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::iOSBindingDynamicLib.IBGPromptOption promptOption)
			{
				invoker (blockPtr, (nint) (Int64) promptOption);
			}
		} /* class NIDPromptOptionHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::iOSBindingDynamicLib.ScreenshotCapturingHandler))]
		internal delegate IntPtr DScreenshotCapturingHandler (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDScreenshotCapturingHandler {
			static internal readonly DScreenshotCapturingHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DScreenshotCapturingHandler))]
			static unsafe IntPtr Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::iOSBindingDynamicLib.ScreenshotCapturingHandler) (descriptor->Target);
				UIKit.UIImage retval = del ();
				return retval != null ? retval.Handle : IntPtr.Zero;
			}
		} /* class SDScreenshotCapturingHandler */
		
		internal class NIDScreenshotCapturingHandler {
			IntPtr blockPtr;
			DScreenshotCapturingHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDScreenshotCapturingHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DScreenshotCapturingHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDScreenshotCapturingHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::iOSBindingDynamicLib.ScreenshotCapturingHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::iOSBindingDynamicLib.ScreenshotCapturingHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDScreenshotCapturingHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe global::UIKit.UIImage Invoke ()
			{
				var ret =  Runtime.GetNSObject<global::UIKit.UIImage> (invoker (blockPtr));
				return ret;
			}
		} /* class NIDScreenshotCapturingHandler */
	}
}
