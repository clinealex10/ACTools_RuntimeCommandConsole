## ACTools: Debug Console
<p>
    This debug console tool is for developers to create debug commands to can use during the game to make it easier to debug and test the game.
    <br/>
    Feel free to use it for whatever. If you wouldn't mind, please credit me. It would be appreciated!
</p>

## Installation:
<p>
    <b>For easy updates, use the following git URL through the Package Manager: https://github.com/mob-sakai/UpmGitExtension.git</b>
    <br/>
    <i>&nbsp;&nbsp;&nbsp;&nbsp;I guess you could use a submodule as well, but I can't help you with that.</i>
</p>
<p>
    <b>In the Package Manager, use the following git URL: https://github.com/Cpt-Jack04/ACTools_DebugConsole.git</b>
    <br/>
    In the Unity Editor, go to Tools>ACTools>Debug Console>Initialize Console. Click the "Generate Required Folders" button, wait for the folders to be generated, then click the "Generate Required Assets".
    <br/>
    In the Project Window, navigate to Assets/Resources/ACTools/Prefabs and open the Debug Console Prefab there. Open the "Events" dropdown and open the "Debug" dropdown.
    <br/>
    You will need to add some listeners to a few events.
    <br/>
    <ul>
        <li>In the "Toggle Console" event, add the "Debug Controller" ScriptableObject. Then select the "CreateOrToggleConsole" method as the function.</li>
        <li>In the "Submit" event, add the "Debug Controller" ScriptableObject. Then select the "OnSubmit" method as the function.</li>
        <li>In the "Select Input Field" event, add the "Debug Controller" ScriptableObject. Then select the "SelectInputField" method as the function.</li>
    </ul>
</p>

<p>
    If you need to get in touch with me, please email me or @ me on Twitter. You can find those on my profile on GitHub.
</p>

[!INCLUDE [<ACTools_DebugConsole>](</Documentation~/ACTools_DebugConsole.md>)]
