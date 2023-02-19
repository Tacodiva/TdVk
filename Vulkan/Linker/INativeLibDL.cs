using System;

public interface INativeLibDL
{
    IntPtr dlopen(string fileName, int flags);

    IntPtr dlsym(IntPtr handle, string name);

    int dlclose(IntPtr handle);

    string dlerror();
}