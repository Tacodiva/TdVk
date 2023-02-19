# TdVk Vulkan Bindings for .NET

This repository contains cross-platform low-level bindings for the [Vulkan](https://www.khronos.org/vulkan/) graphics and compute API and its extensions. It is a fork of the [`vk` nuget package](https://github.com/mellinoe/vk) which has compatibility problems, only supports Vulkan 1.0, doesn't provide support for any Vulkan extensions, is only built for .NET 5.0 and .NET Standard 1.4 and hasn't been updated for 2 years.

These bindings differ from many other .NET bindings in that they are low-level and unsafe. There is no attempt made to provide a higher-level abstraction on top of Vulkan. This means you must be very careful with usages of the API. On the other hand, it means that you can simply and easily translate from the many C++ examples available on the web.

# Repository Structure
### Vulkan

Contains the raw bindings for the Vulkan API. 

### Vulkan.Build

The a cake frosting project which contains the code generation logic for creating the C# bindings for Vulkan, as well as a patcher which uses Mono.Cecil to modify `Vulkan.dll` to call the native functions directly for performance.