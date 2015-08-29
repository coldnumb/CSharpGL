﻿using CSharpGL.Maths;
using CSharpGL.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBook.Winforms.Demo
{
    class TeapotExampleHelper
    {
        public const int NumTeapotVertices = 306;
        public const int NumTeapotPatches = 32;
        public const int NumTeapotVerticesPerPatch = 16;  // 4x4 Bezier patches
        public const int NumTeapotIndices = NumTeapotVerticesPerPatch * NumTeapotPatches;

        #region TeapotVertices

        public static readonly vec3[] TeapotVertices = new vec3[NumTeapotVertices]
        {
            new vec3(1.4f, 2.4f, 0.0f),
            new vec3(1.4f, 2.4f, 0.784f),
            new vec3(0.784f, 2.4f, 1.4f),
            new vec3(0.0f, 2.4f, 1.4f),
            new vec3(1.3375f, 2.53125f, 0.0f),
            new vec3(1.3375f, 2.53125f, 0.749f),
            new vec3(0.749f, 2.53125f, 1.3375f),
            new vec3(0.0f, 2.53125f, 1.3375f),
            new vec3(1.4375f, 2.53125f, 0.0f),
            new vec3(1.4375f, 2.53125f, 0.805f),
            new vec3(0.805f, 2.53125f, 1.4375f),
            new vec3(0.0f, 2.53125f, 1.4375f),
            new vec3(1.5f, 2.4f, 0.0f),
            new vec3(1.5f, 2.4f, 0.84f),
            new vec3(0.84f, 2.4f, 1.5f),
            new vec3(0.0f, 2.4f, 1.5f),
            new vec3(-0.784f, 2.4f, 1.4f),
            new vec3(-1.4f, 2.4f, 0.784f),
            new vec3(-1.4f, 2.4f, 0.0f),
            new vec3(-0.749f, 2.53125f, 1.3375f),
            new vec3(-1.3375f, 2.53125f, 0.749f),
            new vec3(-1.3375f, 2.53125f, 0.0f),
            new vec3(-0.805f, 2.53125f, 1.4375f),
            new vec3(-1.4375f, 2.53125f, 0.805f),
            new vec3(-1.4375f, 2.53125f, 0.0f),
            new vec3(-0.84f, 2.4f, 1.5f),
            new vec3(-1.5f, 2.4f, 0.84f),
            new vec3(-1.5f, 2.4f, 0.0f),
            new vec3(-1.4f, 2.4f, 0.784f),
            new vec3(-0.784f, 2.4f, 1.4f),
            new vec3(0.0f, 2.4f, 1.4f),
            new vec3(-1.3375f, 2.53125f, 0.749f),
            new vec3(-0.749f, 2.53125f, 1.3375f),
            new vec3(0.0f, 2.53125f, 1.3375f),
            new vec3(-1.4375f, 2.53125f, 0.805f),
            new vec3(-0.805f, 2.53125f, 1.4375f),
            new vec3(0.0f, 2.53125f, 1.4375f),
            new vec3(-1.5f, 2.4f, 0.84f),
            new vec3(-0.84f, 2.4f, 1.5f),
            new vec3(0.0f, 2.4f, 1.5f),
            new vec3(0.784f, 2.4f, 1.4f),
            new vec3(1.4f, 2.4f, 0.784f),
            new vec3(0.749f, 2.53125f, 1.3375f),
            new vec3(1.3375f, 2.53125f, 0.749f),
            new vec3(0.805f, 2.53125f, 1.4375f),
            new vec3(1.4375f, 2.53125f, 0.805f),
            new vec3(0.84f, 2.4f, 1.5f),
            new vec3(1.5f, 2.4f, 0.84f),
            new vec3(1.75f, 1.875f, 0.0f),
            new vec3(1.75f, 1.875f, 0.98f),
            new vec3(0.98f, 1.875f, 1.75f),
            new vec3(0.0f, 1.875f, 1.75f),
            new vec3(2.0f, 1.35f, 0.0f),
            new vec3(2.0f, 1.35f, 1.12f),
            new vec3(1.12f, 1.35f, 2.0f),
            new vec3(0.0f, 1.35f, 2.0f),
            new vec3(2.0f, 0.9f, 0.0f),
            new vec3(2.0f, 0.9f, 1.12f),
            new vec3(1.12f, 0.9f, 2.0f),
            new vec3(0.0f, 0.9f, 2.0f),
            new vec3(-0.98f, 1.875f, 1.75f),
            new vec3(-1.75f, 1.875f, 0.98f),
            new vec3(-1.75f, 1.875f, 0.0f),
            new vec3(-1.12f, 1.35f, 2.0f),
            new vec3(-2.0f, 1.35f, 1.12f),
            new vec3(-2.0f, 1.35f, 0.0f),
            new vec3(-1.12f, 0.9f, 2.0f),
            new vec3(-2.0f, 0.9f, 1.12f),
            new vec3(-2.0f, 0.9f, 0.0f),
            new vec3(-1.75f, 1.875f, 0.98f),
            new vec3(-0.98f, 1.875f, 1.75f),
            new vec3(0.0f, 1.875f, 1.75f),
            new vec3(-2.0f, 1.35f, 1.12f),
            new vec3(-1.12f, 1.35f, 2.0f),
            new vec3(0.0f, 1.35f, 2.0f),
            new vec3(-2.0f, 0.9f, 1.12f),
            new vec3(-1.12f, 0.9f, 2.0f),
            new vec3(0.0f, 0.9f, 2.0f),
            new vec3(0.98f, 1.875f, 1.75f),
            new vec3(1.75f, 1.875f, 0.98f),
            new vec3(1.12f, 1.35f, 2.0f),
            new vec3(2.0f, 1.35f, 1.12f),
            new vec3(1.12f, 0.9f, 2.0f),
            new vec3(2.0f, 0.9f, 1.12f),
            new vec3(2.0f, 0.45f, 0.0f),
            new vec3(2.0f, 0.45f, 1.12f),
            new vec3(1.12f, 0.45f, 2.0f),
            new vec3(0.0f, 0.45f, 2.0f),
            new vec3(1.5f, 0.225f, 0.0f),
            new vec3(1.5f, 0.225f, 0.84f),
            new vec3(0.84f, 0.225f, 1.5f),
            new vec3(0.0f, 0.225f, 1.5f),
            new vec3(1.5f, 0.15f, 0.0f),
            new vec3(1.5f, 0.15f, 0.84f),
            new vec3(0.84f, 0.15f, 1.5f),
            new vec3(0.0f, 0.15f, 1.5f),
            new vec3(-1.12f, 0.45f, 2.0f),
            new vec3(-2.0f, 0.45f, 1.12f),
            new vec3(-2.0f, 0.45f, 0.0f),
            new vec3(-0.84f, 0.225f, 1.5f),
            new vec3(-1.5f, 0.225f, 0.84f),
            new vec3(-1.5f, 0.225f, 0.0f),
            new vec3(-0.84f, 0.15f, 1.5f),
            new vec3(-1.5f, 0.15f, 0.84f),
            new vec3(-1.5f, 0.15f, 0.0f),
            new vec3(-2.0f, 0.45f, 1.12f),
            new vec3(-1.12f, 0.45f, 2.0f),
            new vec3(0.0f, 0.45f, 2.0f),
            new vec3(-1.5f, 0.225f, 0.84f),
            new vec3(-0.84f, 0.225f, 1.5f),
            new vec3(0.0f, 0.225f, 1.5f),
            new vec3(-1.5f, 0.15f, 0.84f),
            new vec3(-0.84f, 0.15f, 1.5f),
            new vec3(0.0f, 0.15f, 1.5f),
            new vec3(1.12f, 0.45f, 2.0f),
            new vec3(2.0f, 0.45f, 1.12f),
            new vec3(0.84f, 0.225f, 1.5f),
            new vec3(1.5f, 0.225f, 0.84f),
            new vec3(0.84f, 0.15f, 1.5f),
            new vec3(1.5f, 0.15f, 0.84f),
            new vec3(-1.6f, 2.025f, 0.0f),
            new vec3(-1.6f, 2.025f, 0.3f),
            new vec3(-1.5f, 2.25f, 0.3f),
            new vec3(-1.5f, 2.25f, 0.0f),
            new vec3(-2.3f, 2.025f, 0.0f),
            new vec3(-2.3f, 2.025f, 0.3f),
            new vec3(-2.5f, 2.25f, 0.3f),
            new vec3(-2.5f, 2.25f, 0.0f),
            new vec3(-2.7f, 2.025f, 0.0f),
            new vec3(-2.7f, 2.025f, 0.3f),
            new vec3(-3.0f, 2.25f, 0.3f),
            new vec3(-3.0f, 2.25f, 0.0f),
            new vec3(-2.7f, 1.8f, 0.0f),
            new vec3(-2.7f, 1.8f, 0.3f),
            new vec3(-3.0f, 1.8f, 0.3f),
            new vec3(-3.0f, 1.8f, 0.0f),
            new vec3(-1.5f, 2.25f, 0.3f),
            new vec3(-1.6f, 2.025f, 0.3f),
            new vec3(-2.5f, 2.25f, 0.3f),
            new vec3(-2.3f, 2.025f, 0.3f),
            new vec3(-3.0f, 2.25f, 0.3f),
            new vec3(-2.7f, 2.025f, 0.3f),
            new vec3(-3.0f, 1.8f, 0.3f),
            new vec3(-2.7f, 1.8f, 0.3f),
            new vec3(-2.7f, 1.575f, 0.0f),
            new vec3(-2.7f, 1.575f, 0.3f),
            new vec3(-3.0f, 1.35f, 0.3f),
            new vec3(-3.0f, 1.35f, 0.0f),
            new vec3(-2.5f, 1.125f, 0.0f),
            new vec3(-2.5f, 1.125f, 0.3f),
            new vec3(-2.65f, 0.9375f, 0.3f),
            new vec3(-2.65f, 0.9375f, 0.0f),
            new vec3(-2.0f, 0.9f, 0.3f),
            new vec3(-1.9f, 0.6f, 0.3f),
            new vec3(-1.9f, 0.6f, 0.0f),
            new vec3(-3.0f, 1.35f, 0.3f),
            new vec3(-2.7f, 1.575f, 0.3f),
            new vec3(-2.65f, 0.9375f, 0.3f),
            new vec3(-2.5f, 1.125f, 0.3f),
            new vec3(-1.9f, 0.6f, 0.3f),
            new vec3(-2.0f, 0.9f, 0.3f),
            new vec3(1.7f, 1.425f, 0.0f),
            new vec3(1.7f, 1.425f, 0.66f),
            new vec3(1.7f, 0.6f, 0.66f),
            new vec3(1.7f, 0.6f, 0.0f),
            new vec3(2.6f, 1.425f, 0.0f),
            new vec3(2.6f, 1.425f, 0.66f),
            new vec3(3.1f, 0.825f, 0.66f),
            new vec3(3.1f, 0.825f, 0.0f),
            new vec3(2.3f, 2.1f, 0.0f),
            new vec3(2.3f, 2.1f, 0.25f),
            new vec3(2.4f, 2.025f, 0.25f),
            new vec3(2.4f, 2.025f, 0.0f),
            new vec3(2.7f, 2.4f, 0.0f),
            new vec3(2.7f, 2.4f, 0.25f),
            new vec3(3.3f, 2.4f, 0.25f),
            new vec3(3.3f, 2.4f, 0.0f),
            new vec3(1.7f, 0.6f, 0.66f),
            new vec3(1.7f, 1.425f, 0.66f),
            new vec3(3.1f, 0.825f, 0.66f),
            new vec3(2.6f, 1.425f, 0.66f),
            new vec3(2.4f, 2.025f, 0.25f),
            new vec3(2.3f, 2.1f, 0.25f),
            new vec3(3.3f, 2.4f, 0.25f),
            new vec3(2.7f, 2.4f, 0.25f),
            new vec3(2.8f, 2.475f, 0.0f),
            new vec3(2.8f, 2.475f, 0.25f),
            new vec3(3.525f, 2.49375f, 0.25f),
            new vec3(3.525f, 2.49375f, 0.0f),
            new vec3(2.9f, 2.475f, 0.0f),
            new vec3(2.9f, 2.475f, 0.15f),
            new vec3(3.45f, 2.5125f, 0.15f),
            new vec3(3.45f, 2.5125f, 0.0f),
            new vec3(2.8f, 2.4f, 0.0f),
            new vec3(2.8f, 2.4f, 0.15f),
            new vec3(3.2f, 2.4f, 0.15f),
            new vec3(3.2f, 2.4f, 0.0f),
            new vec3(3.525f, 2.49375f, 0.25f),
            new vec3(2.8f, 2.475f, 0.25f),
            new vec3(3.45f, 2.5125f, 0.15f),
            new vec3(2.9f, 2.475f, 0.15f),
            new vec3(3.2f, 2.4f, 0.15f),
            new vec3(2.8f, 2.4f, 0.15f),
            new vec3(0.0f, 3.15f, 0.0f),
            new vec3(0.0f, 3.15f, 0.002f),
            new vec3(0.002f, 3.15f, 0.0f),
            new vec3(0.8f, 3.15f, 0.0f),
            new vec3(0.8f, 3.15f, 0.45f),
            new vec3(0.45f, 3.15f, 0.8f),
            new vec3(0.0f, 3.15f, 0.8f),
            new vec3(0.0f, 2.85f, 0.0f),
            new vec3(0.2f, 2.7f, 0.0f),
            new vec3(0.2f, 2.7f, 0.112f),
            new vec3(0.112f, 2.7f, 0.2f),
            new vec3(0.0f, 2.7f, 0.2f),
            new vec3(-0.002f, 3.15f, 0.0f),
            new vec3(-0.45f, 3.15f, 0.8f),
            new vec3(-0.8f, 3.15f, 0.45f),
            new vec3(-0.8f, 3.15f, 0.0f),
            new vec3(-0.112f, 2.7f, 0.2f),
            new vec3(-0.2f, 2.7f, 0.112f),
            new vec3(-0.2f, 2.7f, 0.0f),
            new vec3(0.0f, 3.15f, 0.002f),
            new vec3(-0.8f, 3.15f, 0.45f),
            new vec3(-0.45f, 3.15f, 0.8f),
            new vec3(0.0f, 3.15f, 0.8f),
            new vec3(-0.2f, 2.7f, 0.112f),
            new vec3(-0.112f, 2.7f, 0.2f),
            new vec3(0.0f, 2.7f, 0.2f),
            new vec3(0.45f, 3.15f, 0.8f),
            new vec3(0.8f, 3.15f, 0.45f),
            new vec3(0.112f, 2.7f, 0.2f),
            new vec3(0.2f, 2.7f, 0.112f),
            new vec3(0.4f, 2.55f, 0.0f),
            new vec3(0.4f, 2.55f, 0.224f),
            new vec3(0.224f, 2.55f, 0.4f),
            new vec3(0.0f, 2.55f, 0.4f),
            new vec3(1.3f, 2.55f, 0.0f),
            new vec3(1.3f, 2.55f, 0.728f),
            new vec3(0.728f, 2.55f, 1.3f),
            new vec3(0.0f, 2.55f, 1.3f),
            new vec3(1.3f, 2.4f, 0.0f),
            new vec3(1.3f, 2.4f, 0.728f),
            new vec3(0.728f, 2.4f, 1.3f),
            new vec3(0.0f, 2.4f, 1.3f),
            new vec3(-0.224f, 2.55f, 0.4f),
            new vec3(-0.4f, 2.55f, 0.224f),
            new vec3(-0.4f, 2.55f, 0.0f),
            new vec3(-0.728f, 2.55f, 1.3f),
            new vec3(-1.3f, 2.55f, 0.728f),
            new vec3(-1.3f, 2.55f, 0.0f),
            new vec3(-0.728f, 2.4f, 1.3f),
            new vec3(-1.3f, 2.4f, 0.728f),
            new vec3(-1.3f, 2.4f, 0.0f),
            new vec3(-0.4f, 2.55f, 0.224f),
            new vec3(-0.224f, 2.55f, 0.4f),
            new vec3(0.0f, 2.55f, 0.4f),
            new vec3(-1.3f, 2.55f, 0.728f),
            new vec3(-0.728f, 2.55f, 1.3f),
            new vec3(0.0f, 2.55f, 1.3f),
            new vec3(-1.3f, 2.4f, 0.728f),
            new vec3(-0.728f, 2.4f, 1.3f),
            new vec3(0.0f, 2.4f, 1.3f),
            new vec3(0.224f, 2.55f, 0.4f),
            new vec3(0.4f, 2.55f, 0.224f),
            new vec3(0.728f, 2.55f, 1.3f),
            new vec3(1.3f, 2.55f, 0.728f),
            new vec3(0.728f, 2.4f, 1.3f),
            new vec3(1.3f, 2.4f, 0.728f),
            new vec3(0.0f, 0.0f, 0.0f),
            new vec3(1.5f, 0.15f, 0.0f),
            new vec3(1.5f, 0.15f, 0.84f),
            new vec3(0.84f, 0.15f, 1.5f),
            new vec3(0.0f, 0.15f, 1.5f),
            new vec3(1.5f, 0.075f, 0.0f),
            new vec3(1.5f, 0.075f, 0.84f),
            new vec3(0.84f, 0.075f, 1.5f),
            new vec3(0.0f, 0.075f, 1.5f),
            new vec3(1.425f, 0.0f, 0.0f),
            new vec3(1.425f, 0.0f, 0.798f),
            new vec3(0.798f, 0.0f, 1.425f),
            new vec3(0.0f, 0.0f, 1.425f),
            new vec3(-0.84f, 0.15f, 1.5f),
            new vec3(-1.5f, 0.15f, 0.84f),
            new vec3(-1.5f, 0.15f, 0.0f),
            new vec3(-0.84f, 0.075f, 1.5f),
            new vec3(-1.5f, 0.075f, 0.84f),
            new vec3(-1.5f, 0.075f, 0.0f),
            new vec3(-0.798f, 0.0f, 1.425f),
            new vec3(-1.425f, 0.0f, 0.798f),
            new vec3(-1.425f, 0.0f, 0.0f),
            new vec3(-1.5f, 0.15f, 0.84f),
            new vec3(-0.84f, 0.15f, 1.5f),
            new vec3(0.0f, 0.15f, 1.5f),
            new vec3(-1.5f, 0.075f, 0.84f),
            new vec3(-0.84f, 0.075f, 1.5f),
            new vec3(0.0f, 0.075f, 1.5f),
            new vec3(-1.425f, 0.0f, 0.798f),
            new vec3(-0.798f, 0.0f, 1.425f),
            new vec3(0.0f, 0.0f, 1.425f),
            new vec3(0.84f, 0.15f, 1.5f),
            new vec3(1.5f, 0.15f, 0.84f),
            new vec3(0.84f, 0.075f, 1.5f),
            new vec3(1.5f, 0.075f, 0.84f),
            new vec3(0.798f, 0.0f, 1.425f),
            new vec3(1.425f, 0.0f, 0.798f),
        };

        #endregion TeapotVertices


        #region TeapotIndices

        public static readonly uint[] TeapotIndices = new uint[NumTeapotPatches * 4 * 4]
        {
	        0, 1, 2, 3,
	        4, 5, 6, 7,
	        8, 9, 10, 11,
	        12, 13, 14, 15
            ,
            
	        3, 16, 17, 18,
	        7, 19, 20, 21,
	        11, 22, 23, 24,
	        15, 25, 26, 27
            ,
            
	        18, 28, 29, 30,
	        21, 31, 32, 33,
	        24, 34, 35, 36,
	        27, 37, 38, 39
            ,
            
	        30, 40, 41, 0,
	        33, 42, 43, 4,
	        36, 44, 45, 8,
	        39, 46, 47, 12
            ,
            
	        12, 13, 14, 15,
	        48, 49, 50, 51,
	        52, 53, 54, 55,
	        56, 57, 58, 59
            ,
            
	        15, 25, 26, 27,
	        51, 60, 61, 62,
	        55, 63, 64, 65,
	        59, 66, 67, 68
            ,
            
	        27, 37, 38, 39,
	        62, 69, 70, 71,
	        65, 72, 73, 74,
	        68, 75, 76, 77
            ,
            
	        39, 46, 47, 12,
	        71, 78, 79, 48,
	        74, 80, 81, 52,
	        77, 82, 83, 56
            ,
            
	        56, 57, 58, 59,
	        84, 85, 86, 87,
	        88, 89, 90, 91,
	        92, 93, 94, 95
            ,
            
	        59, 66, 67, 68,
	        87, 96, 97, 98,
	        91, 99, 100, 101,
	        95, 102, 103, 104
            ,
            
	        68, 75, 76, 77,
	        98, 105, 106, 107,
	        101, 108, 109, 110,
	        104, 111, 112, 113
            ,
            
	        77, 82, 83, 56,
	        107, 114, 115, 84,
	        110, 116, 117, 88,
	        113, 118, 119, 92
            ,
            
	        120, 121, 122, 123,
	        124, 125, 126, 127,
	        128, 129, 130, 131,
	        132, 133, 134, 135
            ,
            
	        123, 136, 137, 120,
	        127, 138, 139, 124,
	        131, 140, 141, 128,
	        135, 142, 143, 132
            ,
            
	        132, 133, 134, 135,
	        144, 145, 146, 147,
	        148, 149, 150, 151,
	        68, 152, 153, 154
            ,
            
	        135, 142, 143, 132,
	        147, 155, 156, 144,
	        151, 157, 158, 148,
	        154, 159, 160, 68
            ,
            
	        161, 162, 163, 164,
	        165, 166, 167, 168,
	        169, 170, 171, 172,
	        173, 174, 175, 176
            ,
            
	        164, 177, 178, 161,
	        168, 179, 180, 165,
	        172, 181, 182, 169,
	        176, 183, 184, 173
            ,
            
	        173, 174, 175, 176,
	        185, 186, 187, 188,
	        189, 190, 191, 192,
	        193, 194, 195, 196
            ,
            
	        176, 183, 184, 173,
	        188, 197, 198, 185,
	        192, 199, 200, 189,
	        196, 201, 202, 193
            ,
            
	        203, 203, 203, 203,
	        206, 207, 208, 209,
	        210, 210, 210, 210,
	        211, 212, 213, 214
            ,
            
	        203, 203, 203, 203,
	        209, 216, 217, 218,
	        210, 210, 210, 210,
	        214, 219, 220, 221
            ,
            
	        203, 203, 203, 203,
	        218, 223, 224, 225,
	        210, 210, 210, 210,
	        221, 226, 227, 228
            ,
            
	        203, 203, 203, 203,
	        225, 229, 230, 206,
	        210, 210, 210, 210,
	        228, 231, 232, 211
            ,
            
	        211, 212, 213, 214,
	        233, 234, 235, 236,
	        237, 238, 239, 240,
	        241, 242, 243, 244
            ,
            
	        214, 219, 220, 221,
	        236, 245, 246, 247,
	        240, 248, 249, 250,
	        244, 251, 252, 253
            ,
            
	        221, 226, 227, 228,
	        247, 254, 255, 256,
	        250, 257, 258, 259,
	        253, 260, 261, 262
            ,
            
	        228, 231, 232, 211,
	        256, 263, 264, 233,
	        259, 265, 266, 237,
	        262, 267, 268, 241
            ,
            
	        269, 269, 269, 269,
	        278, 279, 280, 281,
	        274, 275, 276, 277,
	        270, 271, 272, 273
            ,
            
	        269, 269, 269, 269,
	        281, 288, 289, 290,
	        277, 285, 286, 287,
	        273, 282, 283, 284
            ,
            
	        269, 269, 269, 269,
	        290, 297, 298, 299,
	        287, 294, 295, 296,
	        284, 291, 292, 293
            ,
            
	        269, 269, 269, 269,
	        299, 304, 305, 278,
	        296, 302, 303, 274,
	        293, 300, 301, 270
        };

        #endregion TeapotIndices

    }
}