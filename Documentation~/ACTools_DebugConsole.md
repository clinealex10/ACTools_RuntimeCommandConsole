# ACTools: Debug Console
<br>

## Instructions
### How to use the debug console:
<ol>
	<li>
		<p>To open the debug console, press the grave accent key (`).</p>
	</li>
	<li>
		<p>Type "help" into the input field and press the enter/return key to display all of the available commands.</p>
	</li>
	<li>
		<p>You can click on the commands in the help window or in the suggestion window to have that command writing in the input field.</p>
	</li>
	<li>
		<p>Commands with <i>< parameter ></i> take in a value for the you to enter after you type a command into the input field. 
		Be sure to leave a single space bewteen the command and the parameter.</p>
	</li>
</ol>
<hr/>

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
			</il>
			<li>
				<p>description - What the command does.</p>
			</il>
			<li>
				<p>format - How to write the command in the debub console.</p>
			</il>
			<li>
				<p>newCommand - The action that is called when the command is invoked.</p>
			</il>
		</ul>
	</li>
	<li>
		<p>Add your new command to the list at the end of the public static void InitializeCommandList(ref List<object> CommandList) method.</p>
	</li>
</ol>
<hr/>
