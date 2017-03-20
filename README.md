# Batch Breaking Cause
This project demonstrates different cases when Unity has to break a batch while rendering.  
Best used with Unity 5.6b4+ where the Frame Debugger window shows why Unity had to start a new batch.

# Causes

- **Additional Vertex Streams** — the object has additional vertex streams set using MeshRenderer.additionalVertexStreams.
- **Deferred Objects on Different Lighting Layers** — the object is on a different light layer.
- **Deferred Objects Split by Shadow Distance** — one of the objects is within shadow distance, the other one is not.
- **Different Combined Meshes** — the object belongs to another combined static mesh.
- **Different Custom Properties** — the object has a different MaterialProperyBlock set.
- **Different Lights** — the object is affected by a different forward light.
- **Different Materials** — the object has a different material.
- **Different Reflection Probes** — the object is affected by a different reflection probe.
- **Different Shadow Caster Hash** — the objects either have different shadow caster shaders, or have different shader properties / keywords that affect the output of the shadow caster pass.
- **Different Shadow Receiving Settings** — the objects either have different "Receive Shadows" settings, or some objects are within the shadow distance, while some other objects are not. 
- **Different Static Batching Flags** — the object has different static batching settings.
- **Dynamic Batching Disabled to Avoid Z-Fighting** — dynamic batching is turned off in Player Settings or disabled temporarily in the current context to avoid z-fighting.
- **Instancing Different Geometries** — rendering different meshes or sub-meshes with GPU instancing.
- **Lightmapped Objects** — the object uses a different light map or has different light map uv transformations within the same light map.
- **Lightprobe Affected Objects** — the object is affected by different light probes.
- **Mixed Sided Mode Shadow Casters** — objects have different "Cast Shadows" settings.
- **Multipass** — the object is using a multi-pass shader.
- **Multiple Forward Lights** — the object is affected by multiple forward lights.
- **Non-instanceable Property Set** — non-instanced properties are set for an instanced shader.
- **Odd Negative Scaling** — the object has odd negative scaling (e.g. (1, -1, 1)).
- **Shader Disables Batching** — the shader explicitly disables batching with the "DisableBatching" tag.
- **Too Many Indices in Dynamic Batch** — there are too many indices (more than 32k) in a dynamic batch.
- **Too Many Indices in Static Batch** — there are too many indices in the combined mesh of a static batch. The limit is 48k indices on OpenGL ES, 32k on OSX and 64k on other platforms.
- **Too Many Vertex Attributes for Dynamic Batching** — a submesh we are trying to dynamically batch has more than 900 vertex attributes.
- **Too Many Vertices for Dynamic Batching** — a submesh we are trying to dynamically batch has more than 300 vertices.
