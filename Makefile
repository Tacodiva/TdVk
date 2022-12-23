
.PHONY: vk.generator vk.rewrite vk run

run: vk.generator vk vk.rewrite
	@echo Done!

vk.generator:
	@echo Generating sources...
	@rm -f vk/Generated/*.gen.cs
	dotnet run --project vk.generator vk/Generated

vk:
	@rm -rf build
	@echo Building sources...
	dotnet build vk -c Release -o build

vk.rewrite:
	@echo Rewriting CIL...
	@rm -f build/vk.unpatched.dll
	@mv build/vk.dll build/vk.unpatched.dll
	dotnet run --project vk.rewrite build/vk.unpatched.dll build/vk.dll
