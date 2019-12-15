#if ENABLE_VSTU
 
 using SyntaxTree.VisualStudio.Unity.Bridge;
 using UnityEditor;
 
 // Adapted from https://stackoverflow.com/questions/45578298/how-to-enable-c-sharp-7-features-on-unity3d-projects
 [InitializeOnLoad]
 public class ProjectFilesGeneration
 {
     static ProjectFilesGeneration ()
     {
         ProjectFilesGenerator.ProjectFileGeneration += ( string name, string content ) =>
         {
             return content.Replace
             (    "<LangVersion>latest</LangVersion>",
                 "<LangVersion>6</LangVersion>" );
         };
     }
 }
 
#endif