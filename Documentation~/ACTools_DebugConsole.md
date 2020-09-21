# ACTools: Debug Console
<br>

## Instructions
### How to create your own debug command:
<ol>
	<li>
		<p>In the project folder, search and open "ListOfDebugCommand.cs".</p>
	</li>
	<li>
		<p>Declare a new "public static DebugCommand or public static DebugCommand<T1> at the top of the class.</p>
	</li>
	<li>
		<p>Assign your new command a value in the public static void InitializeCommandList(ref List<object> CommandList) method.</p>
		<p>Below are the parameters for the DebugConsole and the DebugConsole<T1> constructor.</p>
		<ul>
			<li>
				<p>id - ID of the command. This is what the debug console is looking for.</p>
				<p>description - What the command does.</p>
				<p>format - How to write the command in the debub console.</p>
				<p>newCommand - The action that is called when the command is invoked.</p>
			</il>
		</ul>
	</li>
	<li>
		<p>Add your new command to the command list at the end of the public static void InitializeCommandList(ref List<object> CommandList) method.</p>
	</li>
</ol>
<hr/>