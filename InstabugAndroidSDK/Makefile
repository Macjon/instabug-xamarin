NUGET_PATH=$(shell which nuget)

NAMESPACE=InstabugSdk.Android

BINDING_DIR=binding
BINDING_SOLUTION_DIR=$(BINDING_DIR)/$(NAMESPACE).sln

PROJ_DIR=$(BINDING_DIR)/$(NAMESPACE)

all: restoreNuget downloadInstabugViaGradle binding nuget

restoreNuget:
	$(NUGET_PATH) restore $(BINDING_SOLUTION_DIR)

downloadInstabugViaGradle:
	cd Gradle; gradle downloadAndCopyLibs

binding:
	cd $(BINDING_DIR)
	@echo "Delete the previous dll if it exists"
	@echo "---------------------------------------------"
	rm -rf *.dll lib
	@echo "\n"
	@echo "Create the binding..."
	@echo "---------------------"
	msbuild $(BINDING_SOLUTION_DIR) /p:Configuration=Release

nuget:
	nuget pack $(PROJ_DIR)/$(NAMESPACE).nuspec -properties Configuration=Release

clean:
	cd Gradle; gradle clean
	rm -rf *.dll *.nupkg
	rm -rf $(BINDING_DIR)/packages
	rm -rf $(PROJ_DIR)/bin $(PROJ_DIR)/obj 
	rm -rf $(BINDING_DIR)/InstabugSdk.Android.Core/bin $(BINDING_DIR)/InstabugSdk.Android.Core/obj
	rm -rf $(BINDING_DIR)/InstabugSdk.Android.Crash/bin $(BINDING_DIR)/InstabugSdk.Android.Crash/obj
	rm -rf $(BINDING_DIR)/InstabugSdk.Android.Survey/bin $(BINDING_DIR)/InstabugSdk.Android.Survey/obj
	rm -rf $(BINDING_DIR)/RxAndroid/bin $(BINDING_DIR)/RxAndroid/obj

.PHONY: downloadInstabugViaGradle clean binding nuget
