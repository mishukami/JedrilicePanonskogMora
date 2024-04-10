#version 330 core

layout (location = 0) out vec4 FragColor;
layout (location = 1) out vec4 BrightColor;

in vec3 TexCoords;

uniform samplerCube skybox;

void main()
{
//     vec3 result = texture(skybox, TexCoords).rgb;
//     float brightness = dot(result, vec3(0.2126, 0.7152, 0.0722));
//     if(brightness > 1.0)
//         BrightColor = vec4(result, 1.0);
//     else
//         BrightColor = vec4(0.0, 0.0, 0.0, 1.0);
//
//     FragColor = vec4(result, 1.0);

          FragColor = texture(skybox, TexCoords);
          BrightColor = vec4(0.0, 0.0, 0.0, 1.0);
}
