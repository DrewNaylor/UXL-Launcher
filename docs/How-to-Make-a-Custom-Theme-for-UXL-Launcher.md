The UXL Launcher Theme Engine is currently at version 1.01 and is the version used in UXL Launcher Version 3.1.

If you just want to jump right in and figure everything out yourself and want to modify a basic, pre-existing theme, you can [use the Default theme](https://github.com/DrewNaylor/UXL-Launcher/blob/master/UXL-Launcher/VB%20Code-behind/Themes/DefaultTheme_XML.xml). If, however, you want to use a theme with flat buttons, you can [use the Maudern theme](https://github.com/DrewNaylor/UXL-Launcher/blob/master/UXL-Launcher/VB%20Code-behind/Themes/MaudernTheme_XML.xml). Otherwise, you can read on to find out how to make your own theme, or [skip ahead to the part where it's described](#making-a-custom-theme).

## Note about which Windows Forms properties are used

The UXL Launcher Theme Engine mostly just uses the standard Windows Forms properties, but some properties are custom. Here's a list of the custom ones present in the `uxlProToolstripRenderer` class at the bottom of [`UXLLauncher_ThemeEngine.vb`](https://github.com/DrewNaylor/UXL-Launcher/blob/master/UXL-Launcher/VB%20Code-behind/Themes/UXLLauncher_ThemeEngine.vb):

- MenuItem BackColor in theme files is referred to in code as `DropdownBackColor` and is separate from the MenuBar BackColor.
- `TextHighlightColor` in code is automatically set to `ControlText`; it's used when the user hovers over or clicks on a menuitem and can't yet be overridden. If this is a standard property, then I forgot.
- The MenuItem ImageMarginGradient StartColor and EndColor in theme files are both referred to as `ImageMarginGradientStartColor` and `ImageMarginGradientEndColor` in code, respectively.
- The arrow on the right side of menuitems automatically uses the same color as the theme's MenuItem ForeColor property, but changes to the `TextHighlightColor` when the mouse is moved over its menuitem or its menuitem is clicked.

## Supported file extensions

Although the primary file extension for UXL Launcher themes is XML, regular text files (TXT) are also officially supported. As such, these are the two extensions available as filters in the `Browse for a custom theme` file open dialog box window that shows up when clicking the `Browse...` button next to the custom theme path textbox. Other file extensions, such as JS (JavaScript) or VB (Visual Basic) may work, though it's not recommended.

## Configuring your custom theme to be used

Once you've created a file to use as your custom theme (preferably with [one of the supported file extensions](#supported-file-extensions)), you'll need to configure UXL Launcher to use it. Here are the steps for doing this.

1. Start UXL Launcher.
2. Open the `Options` window from `Tools>Options...`.
3. Go to the `Personalization` tab.
4. If it's not already enabled, click the checkbox next to `Enable UXL Launcher Theme Engine (requires application restart)`, save your settings, and restart UXL Launcher. Afterward, go to step 2. Otherwise, continue to step 5.
5. Choose `(Custom)` from the theme list dropdown box.
6. Either paste the exact location (including the drive letter and all folders) into the custom theme path textbox below the theme list or click the `Browse...` button next to the textbox and browse to your custom theme file. Double-click on it to choose it.
7. Click the `Save` button to save your settings.

Next, you can [preview your custom theme](#previewing-your-custom-theme).

## Previewing your custom theme

If you would like to preview your custom theme as you save it and click a button to update to the latest changes in your theme file, you can follow the steps below. This isn't required, but it does make custom theme designing easier. You can [skip this part](#making-a-custom-theme) if you want to.

1. Create a copy of `UXL-Launcher.exe.config` next to the main EXE file (`UXL-Launcher.exe`). This can be used as a backup in case anything goes wrong during this process.
2. Open the config file (`UXL-Launcher.exe.config`) in your favorite text editor, such as [Notepad++](https://notepad-plus-plus.org/).
3. Find the XML element/tag under `userSettings` for the `debugmodeShowLabels` setting. You may need to scroll down before it's visible.
4. Change the `value` property of this setting from `False` to `True`.
5. If you also want to have theme engine output show up in the Visual Studio Immediate Window as well, change the `value` property of the `debugmodeShowThemeEngineOutput` setting from `False` to `True`. This output is rather verbose (lots of detail) and includes error messages that may be helpful in debugging your custom theme if you're having trouble with it.
6. Save the config file (`UXL-Launcher.exe.config`).
7. Restart UXL Launcher.

Once the app is restarted, you can use the `Apply Chosen Theme` button in the bottom-left corner of the main window to re-apply your custom theme file after making changes and saving it. Currently, themes are not re-applied when their file is updated, so clicking the button is required.

The first set of steps also enables some debug labels in the bottom-middle that show theme details such as title, description, author, version, and the version of the theme engine the theme is compatible with. Any of these labels can be double-clicked to copy their text and you can paste them into the textbox on the bottom-right that shows the full path used for launching apps if you want to quickly read them without using Notepad. Please be aware that this does [have a few issues](#important-note-on-debug-labelstextbox-being-overwritten), as detailed below. 

### Important note on debug labels/textbox being overwritten
Please note, however, that once you do anything that updates the debug labels (such as saving settings in the Options window, reverting to default theme under `View`, enabling or disabling `Always On Top`, and clicking either of the `Apply Chosen Theme` or `Apply Default Theme` buttons) will <b>reset the text in all the debug labels and the folder location textbox</b> so it's not recommended to place anything important into the folder location textbox.

## Making a custom theme

### Minimum required elements/tags

At a minimum, all UXL Launcher themes must have at least the opening and closing root XML elements (tags) as shown below:

```xml
<UXL_Launcher_Theme>

</UXL_Launcher_Theme>
```

If you want to, you can copy the code above into your custom theme file to make things easier.

### Custom theme info

Manually adding an XML namespace is not required because one is added to each theme file as it's read automatically. The original file isn't modified, though.

`xmlns:uxl="https://drewnaylor.github.io/xml"`

The above example isn't exactly how it's presented in code, but should be close enough for anyone wondering what namespace is being used for theme files. The `/xml` in the address above is just made up for the sake of an XML namespace.

Most theme designers will want some identifying information for their custom themes, so you can use the template below to help you with this:

```xml
<UXL_Launcher_Theme>
  <Title>(theme title; will be displayed in the Options window theme info textbox)</Title>
  <Description>(theme description. you may want to say if you don't want your theme
to be distributed or modified without your permission since there's no category for
that in the theme engine yet. this would also work for a license area, too, though
it's recommended to provide a link to the license as well if it makes sense.)</Description>
  <Version>(theme version; can be a string/doesn't have to be just a number)</Version>
  <Author>(theme author; usually your name)</Author>

  <!-- "UseThemeEngineVersion" is used to specify the version of the
  UXL Launcher Theme Engine to use in case there are changes in newer
  versions of the theme engine that designers or developers don't want
  to use. Version 1.01 is the oldest version number available and anything
  smaller than that will automatically be set to 1.01 at runtime. -->
  <UseThemeEngineVersion>1.01</UseThemeEngineVersion>
</UXL_Launcher_Theme>
```

The `UseThemeEngineVersion` element/tag is used if there's a change in a newer version of the theme engine that could cause issues with custom themes that theme designers want to avoid. Some changes can't be avoided simply because they're not actually in with the code that reads the theme colors, but most changes should be able to be avoided by keeping the number for `UseThemeEngineVersion` at a number before the undesired change. Each time the theme engine is updated, it will be mentioned in the changelog. Because it might only be mentioned then, it's recommended to only design themes using the [latest stable release of UXL Launcher](https://github.com/DrewNaylor/UXL-Launcher/releases/latest) unless you're feeling adventurous. More details are available in the code example above.

If any of the theme info elements/tags are missing from the custom theme file, they'll simply be replaced with `(No [element/tag] specified)`, with the exception of the `<UseThemeEngineVersion>` element/tag. This tag is described above in the template. If the version number specified is less than `1.01`, then the theme engine will set it to `1.01`.

**Please note:** In UXL Launcher 3.1 Release Candidate 1 (and probably Version 3.1 Stable since it's not that major of a bug, all things considered) and UXL Launcher Theme Engine Version 1.01, [there is a bug/known issue where numbers such as `1.01.1` will crash UXL Launcher](https://github.com/DrewNaylor/UXL-Launcher/issues/126) with an exception of `System.InvalidCastException` because it's trying to convert the value from a string to a decimal type (decimal is the only way I could get the theme engine to have a number that I can do greater than/less than comparisons with). This bug will be fixed in UXL Launcher Version 3.2 and Theme Engine Version 1.02. Please note that this particular change won't be able to be avoided as it's not part of the code dealing with how colors are pulled from the theme file.

### Custom theme colors

Once you've [filled out your theme info section](#custom-theme-info), you can get started on the custom theme colors. You're not limited to just using basic colors like `Red`, `Blue`, or `Yellow`. Rather, you can also use HTML color codes such as `0xF1F1F1` (the `0x` needs to be added or it won't work) or even system colors like `Control` (gray-ish default Windows Forms background color) or `ControlText` (default Windows Forms text color) or even `Transparent`, if you don't want to set a color for a particular control type. Any missing or invalid colors will just use the default value, but any invalid XML will cause the Default theme to be used instead. Re-using the template from above (but without the theme info template; that'll be left above to reduce clutter), here's what the theme colors part looks like:

```xml
<UXL_Launcher_Theme>

	<theme_info_template_goes_here />
  
  <Theme_Colors>

	  
  </Theme_Colors>
  
</UXL_Launcher_Theme>
```

All the theme colors go between the `<Theme_Colors>` opening and closing tags, and the `<theme_info_template_goes_here />` tag is where the theme info would go, but I removed it from this particular code block because it would take up too much space. The [example theme code](#complete-custom-theme-example) and screenshot (screenshot may not be ready for a while) will be available at the end of this wiki page, though. Please be aware that the resulting custom theme example might not look very good, but that's only to have each control visibly identifiable (unless it's text, in which case it'll be the color that's the most easily distinguishable from the background and might be the same in different areas.).

Now we'll get started on the actual colors!

#### Buttons

The first theme color in the example theme file is for buttons. 

An example of a button with white text (ForeColor) and maroon (similar to red) background color (BackColor) is available below. You can paste this into the [custom theme colors template](#custom-theme-colors) presented above if you want to, between the `<Theme_Colors>` beginning and ending tag. These buttons are just the standard Windows Forms buttons.

```xml
      <Button>
        <BackColor>Maroon</BackColor>
        <ForeColor>White</ForeColor>
      </Button>
```

The example theme will use the code presented above for buttons, but you could also use flat buttons if you wanted to. Nowadays, it seems like most companies want their design to be flat so that they're "modern", for some reason. Here's an example of flat buttons using the button colors from the [Maudern theme](https://github.com/DrewNaylor/UXL-Launcher/blob/master/UXL-Launcher/VB%20Code-behind/Themes/MaudernTheme_XML.xml). Please note that the theme engine doesn't support changing the size of flat button borders or changing the button click color at the moment (as of July 4, 2018).

The buttons from the example below will be flat with gray background color, white text, and a light gray border.

```xml
      <Button>
        <BackColor>Gray</BackColor>
        <ForeColor>White</ForeColor>
        <!-- The FlatStyle determines the "depth" of the buttons. This can be set
        to either "Flat" or "Standard". Anything else will be set to "Standard".
        Quotation marks are not supported. -->
        <FlatStyle>Flat</FlatStyle>
        <!-- Anything within the "FlatAppearance" element will only be used if
        "FlatStyle" is set to "Flat". -->
        <FlatAppearance>
          <BorderColor>LightGray</BorderColor>
        </FlatAppearance>
      </Button>
```

#### Groupboxes

The next category in the example theme is for the groupboxes.

Below is an example of groupboxes with a light blue background and black text color. You can paste this into the [custom theme colors template](#custom-theme-colors) presented above if you want to, between the `<Theme_Colors>` beginning and ending tag and after the closing tag for `<Button>`. These groupboxes are just the standard Windows Forms groupboxes and the corners might look kinda bad when using background colors other than `Transparent` because the color extends into the area with the header.

```xml
      <GroupBox>
        <BackColor>LightBlue</BackColor>
        <ForeColor>Black</ForeColor>
      </GroupBox>
```

This time, there's no "Flat" option for the groupboxes, so that means it's time for the [Flow Layout Panel colors](#flow-layout-panel).

#### Flow Layout Panel

On the main window for UXL Launcher, there's a single flow layout panel behind the groupboxes that is responsible for making sure the groupboxes don't get messed up when running on a HiDPI device.

Below is an example of the flow layout panel with a light green background and black text color. You can paste this into the [custom theme colors template](#custom-theme-colors) presented above if you want to, between the `<Theme_Colors>` beginning and ending tag and after the closing tag for `<GroupBox>`. This flow layout panel is just the standard Windows Forms flow layout panel.

```xml
      <FlowLayoutPanel>
        <BackColor>LightGreen</BackColor>
        <ForeColor>Black</ForeColor>
      </FlowLayoutPanel>
```

#### Statusbar

For the main window's statusbar, there's only the option to set its background color. But don't worry, because you can also set the text color for statusbar <i>labels</i> (currently only one exists in the app) in the [Status label](#status-label) section below.

Here's an example of a light yellow background for the statusbar. You can paste this into the [custom theme colors template](#custom-theme-colors) presented above if you want to, between the `<Theme_Colors>` beginning and ending tag and after the closing tag for `<FlowLayoutPanel>`. This statusbar is just the standard Windows Forms statusbar.

```xml
      <StatusBar>
        <BackColor>LightYellow</BackColor>
      </StatusBar>
```

#### Label

This only applies to the debug labels for now (Theme Engine Version 1.01), but here is an example of labels with a transparent background and black text color. You can paste this into the [custom theme colors template](#custom-theme-colors) presented above if you want to, between the `<Theme_Colors>` beginning and ending tag and after the closing tag for `<StatusBar>`. This label is just the standard Windows Forms label.

```xml
      <Label>
        <BackColor>Transparent</BackColor>
        <ForeColor>Black</ForeColor>
      </Label>
```

#### Textbox

This only applies to the textbox on the bottom-right that shows the full path used for launching apps for now (Theme Engine Version 1.01), but here's an example of a textbox with a plum background and black text. You can paste this into the [custom theme colors template](#custom-theme-colors) presented above if you want to, between the `<Theme_Colors>` beginning and ending tag and after the closing tag for `<Label>`. This textbox is just the standard Windows Forms textbox.

```xml
      <TextBox>
        <BackColor>Plum</BackColor>
        <ForeColor>Black</ForeColor>
      </TextBox>
```

#### MenuItem

The MenuItem colors refer to the dropdown items in the menubar and the items in the Quickmenu. Refer to the [menubar section](#menubar) for more details on menubar background colors. When hovering the mouse or clicking on a menuitem, the text color will change to the `ControlText` color as of Theme Engine Version 1.01.

The example below has light yellow background colors, black text, and a yellow-to-light yellow left-to-right horizontal gradient in the left item image margin. This example is a bit more advanced than the others, so more detail is provided in the code below. You can paste this into the [custom theme colors template](#custom-theme-colors) presented above if you want to, between the `<Theme_Colors>` beginning and ending tag and after the closing tag for `<TextBox>`. MenuItem BackColor and the image margin gradient colors are [custom properties](#note-about-which-windows-forms-properties-are-used) not usually available in Windows Forms, though the MenuItems themselves are the standard Windows Forms ones.

```xml
      <MenuItem>
        <!-- Background color for menubar dropdown items. -->
        <BackColor>LightYellow</BackColor>
        <!-- Text color for menubar dropdown items. -->
        <ForeColor>Black</ForeColor>
        <ImageMarginGradient>
          <!-- The "ImageMarginGradient" is the small box on the
          left side of many Windows dropdown menu items. 
          Make sure to include the "0x" at the beginning
          of HTML color codes or they might not work, though
          you can also just use regular words like "Red" or "Blue".-->
          
          <!-- "StartColor" is the color on the left side of
          the image margin's gradient. -->
          <StartColor>Yellow</StartColor>
          <!-- "EndColor" is the color on the right side of
          the image margin's gradient. -->
          <EndColor>LightYellow</EndColor>
        </ImageMarginGradient>
      </MenuItem>
```

#### MenuBar

This is the background color for the menubar itself. The text color is taken from the [MenuItem ForeColor](#menuitem).

This example uses a background color of LightYellow to blend with the MenuItem BackColor. You can paste this into the [custom theme colors template](#custom-theme-colors) presented above if you want to, between the `<Theme_Colors>` beginning and ending tag and after the closing tag for `<MenuItem>`. This MenuBar is just the standard Windows Forms MenuStrip, but I called it a "menubar" because that's what most people call it.

```xml
      <MenuBar>
        <!-- Background color for the menubar itself. -->
        <BackColor>LightYellow</BackColor>
      </MenuBar>
```

#### Status label

These are the settings for all status labels in the [statusbar](#statusbar).

This example uses a background color of Transparent, a text color of black, no borders, and if there were borders, they would be flat. You can paste this into the [custom theme colors template](#custom-theme-colors) presented above if you want to, between the `<Theme_Colors>` beginning and ending tag and after the closing tag for `<MenuBar>`. This status label is just the standard Windows Forms status label.

```xml
      <StatusLabel>
        <BackColor>Transparent</BackColor>
        <ForeColor>Black</ForeColor>
        
        <!--Accepted BorderSides values are None, Top, Bottom, Left, Right, and All. Other values will be set to None.-->
        <BorderSides>None</BorderSides>

        <!--Accepted BorderStyle values are Adjust, Bump, Etched, Flat, Raised, RaisedInner, RaisedOuter, Sunken, SunkenInner,
        and SunkenOuter. Other values will be set to Flat. BorderSides must be something other than None for this to work.-->
        <BorderStyle>Flat</BorderStyle>
      </StatusLabel>
```

## Complete custom theme example

This is the final result of all the steps on this page to making a custom theme. If you want to use it yourself, you can. You can also modify it if you want to, but please state that it's modified from the original. The screenshots aren't ready yet.

```xml
<UXL_Launcher_Theme>
  <Title>Example Custom Theme</Title>
  <Description>This is an example of a custom theme for UXL Launcher. You can modify this theme if you want to, but please state that it's modified from the original.</Description>
  <Version>v1.0-example</Version>
  <Author>Drew Naylor</Author>

  <!-- "UseThemeEngineVersion" is used to specify the version of the
  UXL Launcher Theme Engine to use in case there are changes in newer
  versions of the theme engine that designers or developers don't want
  to use. Version 1.01 is the oldest version number available and anything
  smaller than that will automatically be set to 1.01 at runtime. -->
  <UseThemeEngineVersion>1.01</UseThemeEngineVersion>
      <Theme_Colors>
      <Button>
        <BackColor>Maroon</BackColor>
        <ForeColor>White</ForeColor>
      </Button>
      
      <GroupBox>
        <BackColor>LightBlue</BackColor>
        <ForeColor>Black</ForeColor>
      </GroupBox>

      <FlowLayoutPanel>
        <BackColor>LightGreen</BackColor>
        <ForeColor>Black</ForeColor>
      </FlowLayoutPanel>
      
      <StatusBar>
        <BackColor>LightYellow</BackColor>
      </StatusBar>

      <Label>
        <BackColor>Transparent</BackColor>
        <ForeColor>Black</ForeColor>
      </Label>

      <TextBox>
        <BackColor>Plum</BackColor>
        <ForeColor>Black</ForeColor>
      </TextBox>

      <MenuItem>
        <!-- Background color for menubar dropdown items. -->
        <BackColor>LightYellow</BackColor>
        <!-- Text color for menubar dropdown items. -->
        <ForeColor>Black</ForeColor>
        <ImageMarginGradient>
          <!-- The "ImageMarginGradient" is the small box on the
          left side of many Windows dropdown menu items. 
          Make sure to include the "0x" at the beginning
          of HTML color codes or they might not work, though
          you can also just use regular words like "Red" or "Blue".-->
          
          <!-- "StartColor" is the color on the left side of
          the image margin's gradient. -->
          <StartColor>Yellow</StartColor>
          <!-- "EndColor" is the color on the right side of
          the image margin's gradient. -->
          <EndColor>LightYellow</EndColor>
        </ImageMarginGradient>
      </MenuItem>

      <MenuBar>
        <!-- Background color for the menubar itself. -->
        <BackColor>LightYellow</BackColor>
      </MenuBar>
      
      <StatusLabel>
        <BackColor>Transparent</BackColor>
        <ForeColor>Black</ForeColor>
        
        <!--Accepted BorderSides values are None, Top, Bottom, Left, Right, and All. Other values will be set to None.-->
        <BorderSides>None</BorderSides>

        <!--Accepted BorderStyle values are Adjust, Bump, Etched, Flat, Raised, RaisedInner, RaisedOuter, Sunken, SunkenInner,
        and SunkenOuter. Other values will be set to Flat. BorderSides must be something other than None for this to work.-->
        <BorderStyle>Flat</BorderStyle>
      </StatusLabel>

  </Theme_Colors>
</UXL_Launcher_Theme>
```