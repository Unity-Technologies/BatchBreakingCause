# Batch Breaking Cause
This project demonstrates different cases when Unity has to break a batch while rendering.  
Best used with Unity 5.6b4+ where Frame Debugger window tells you why Unity had to start a new batch.

# Causes
### Additional Vertex Streams
A mesh renderer has additional vertex streams. Dynamic batching doesn't support such mesh renderers.

### Deferred Objects on Different Lighting Layers
Objects are on dfferent lighting layers.

### Deferred Objects Split by Shadow Distance
Some objects are within the shadow distance, while others are not.

### Different Combined Meshes
The combined mesh is different between static-batched objects.

### Different Custom Properties
Objects have different MaterialProperyBlock set.

### Different Lights
Objects are affected by different forward lights.

### Different Materials
Objects have different materials.

### Different Reflection Probes
Objects are affected by different reflection probes.

### Different Shadow Caster Hash
Objects either have different shadow caster shaders, or have different shader properties / keywords that affect the output of the shadow caster pass.

### Different Shadow Receiving Settings
Objects either have different "Receive Shadows" settings, or some objects are within the shadow distance, while some other objects are not. 

### Different Static Batching Flags
Objects have different static batching settings.

### Dynamic Batching Disabled to Avoid Z-Fighting
Dynamic batching is turned off in Player Settings or is disabled temporarily in the current context to avoid z-fighting.

### Instancing Different Geometries
Rendering different meshes or sub-meshes with GPU instancing.

### Lightmapped Objects
Objects use light maps.

### Lightprobe Affected Objects
Objects are affected by different light probes.

### Mixed Sided Mode Shadow Casters
Objects have different "Cast Shadows" settings.

### Multipass
An object is using a multi-pass shader.

### Multiple Forward Lights
An object is affected by multiple forward lights. 

### Non-instanceable Property Set
Non-instanced properties set for instanced shader.

### Odd Negative Scaling
An object has odd negative scaling.

### Shader Disables Batching
The shader explixitly disables batching with the "DisableBatching" tag.

### Too Many Indices in Dynamic Batch
There are too many indices (more than 32k) in a dynamic batch.

### Too Many Indices in Static Batch
There are too many indices in the combined mesh of a static batch. The limit is 48k indices on OpenGL ES, 32k on OSX and 64k on other platforms.

### Too Many Vertex Attributes for Dynamic Batching
A submesh we are trying to dynamicly batch has more than 900 vertex attributes.

### Too Many Vertices for Dynamic Batching
A submesh we are trying to dynamicly batch has more than 300 vertices.
