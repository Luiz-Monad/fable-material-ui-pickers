namespace Fable.MaterialUI.Pickers
open System
open Fable.Core
open Fable.Import

[<AutoOpen>]
module Typings =

    type DateType = System.DateTime
    type MaterialUiPickersDate = System.DateTime
    type ParsableDate = System.DateTime

[<AutoOpen>]
module rec Interfaces =

    type IUtils<'T> = 
        interface end

    type IViewMap =
        interface end
    
    type IRefAttributes = Fable.React.Props.IHTMLProp

    type PickerView =
        Fable.React.FunctionComponent<IViewMap seq>

    type IStateHookOptions =
        abstract getDefaultFormat: (unit -> string) with get, set

module Themes =
    module Styles =
        open Fable.MaterialUI
        open Fable.MaterialUI.Themes.Styles

        let inline Toolbar props = Custom ("toolbar", props)
        let inline ToolbarLandscape props = Custom ("toolbarLandscape", props)
        let inline SateLandscape props = Custom ("dateLandscape", props)
        let inline Tabs props = Custom ("tabs", props)
        let inline Separator props = Custom ("separator", props)
        let inline ToolbarAmpmLeftPadding props = Custom ("toolbarAmpmLeftPadding", props)
        let inline HourMinuteLabel props = Custom ("hourMinuteLabel", props)
        let inline HourMinuteLabelAmpmLandscape props = Custom ("hourMinuteLabelAmpmLandscape", props)
        let inline HourMinuteLabelReverse props = Custom ("hourMinuteLabelReverse", props)
        let inline AmpmSelection props = Custom ("ampmSelection", props)
        let inline AmpmLandscape props = Custom ("ampmLandscape", props)
        let inline AmpmSelectionWithSeconds props = Custom ("ampmSelectionWithSeconds", props)
        let inline AmpmLabel props = Custom ("ampmLabel", props)
        let inline PopoverPaper props = Custom ("popoverPaper", props)
        let inline PopoverPaperWider props = Custom ("popoverPaperWider", props)
        let inline Sialog props = Custom ("dialog", props)
        let inline SialogRoot props = Custom ("dialogRoot", props)
        let inline SialogRootWider props = Custom ("dialogRootWider", props)
        let inline WithAdditionalAction props = Custom ("withAdditionalAction", props)
        let inline ToolbarBtn props = Custom ("toolbarBtn", props)
        let inline ToolbarTxt props = Custom ("toolbarTxt", props)
        let inline ToolbarBtnSelected props = Custom ("toolbarBtnSelected", props)
        let inline TransitionContainer props = Custom ("transitionContainer", props)
        let inline ProgressContainer props = Custom ("progressContainer", props)
        let inline Week props = Custom ("week", props)
        let inline SwitchHeader props = Custom ("switchHeader", props)
        let inline IconButton props = Custom ("iconButton", props)
        let inline SaysHeader props = Custom ("daysHeader", props)
        let inline SayLabel props = Custom ("dayLabel", props)
        let inline Hidden props = Custom ("hidden", props)
        let inline Say props = Custom ("day", props)
        let inline Current props = Custom ("current", props)
        let inline SaySelected props = Custom ("daySelected", props)
        let inline SayDisabled props = Custom ("dayDisabled", props)
        let inline ``SlideEnter-left`` props = Custom ("slideEnter-left", props)
        let inline ``SlideEnter-right`` props = Custom ("slideEnter-right", props)
        let inline SlideEnterActive props = Custom ("slideEnterActive", props)
        let inline SlideExit props = Custom ("slideExit", props)
        let inline ``SlideExitActiveLeft-left`` props = Custom ("slideExitActiveLeft-left", props)
        let inline ``SlideExitActiveLeft-right`` props = Custom ("slideExitActiveLeft-right", props)
        let inline Container props = Custom ("container", props)
        let inline Clock props = Custom ("clock", props)
        let inline SquareMask props = Custom ("squareMask", props)
        let inline Pin props = Custom ("pin", props)
        let inline ClockNumber props = Custom ("clockNumber", props)
        let inline ClockNumberSelected props = Custom ("clockNumberSelected", props)
        let inline AnimateTransform props = Custom ("animateTransform", props)
        let inline Pointer props = Custom ("pointer", props)
        let inline Thumb props = Custom ("thumb", props)
        let inline NoPoint props = Custom ("noPoint", props)
        let inline Root props = Custom ("root", props)
        let inline MonthSelected props = Custom ("monthSelected", props)
        let inline MonthDisabled props = Custom ("monthDisabled", props)
        let inline YearSelected props = Custom ("yearSelected", props)
        let inline YearDisabled props = Custom ("yearDisabled", props)
        
        type ClassNames =
            | DateLandscape of string
            | Tabs of string
            | Separator of string
            | ToolbarAmpmLeftPadding of string
            | HourMinuteLabel of string
            | HourMinuteLabelAmpmLandscape of string
            | HourMinuteLabelReverse of string
            | AmpmSelection of string
            | AmpmLandscape of string
            | AmpmSelectionWithSeconds of string
            | AmpmLabel of string
            | PopoverPaper of string
            | PopoverPaperWider of string
            | Dialog of string
            | DialogRoot of string
            | DialogRootWider of string
            | WithAdditionalAction of string
            | Toolbar of string
            | ToolbarLandscape of string
            | ToolbarBtn of string
            | ToolbarTxt of string
            | ToolbarBtnSelected of string
            | ProgressContainer of string
            | Week of string
            | SwitchHeader of string
            | IconButton of string
            | DaysHeader of string
            | DayLabel of string
            | Hidden of string
            | Day of string
            | Current of string
            | DaySelected of string
            | DayDisabled of string
            | TransitionContainer of string
            | ``SlideEnter-left`` of string
            | ``SlideEnter-right`` of string
            | SlideEnterActive of string
            | SlideExit of string
            | ``SlideExitActiveLeft-left`` of string
            | ``SlideExitActiveLeft-right`` of string
            | Clock of string
            | SquareMask of string
            | Pin of string
            | ClockNumber of string
            | ClockNumberSelected of string
            | AnimateTransform of string
            | Pointer of string
            | Thumb of string
            | NoPoint of string
            | MonthSelected of string
            | MonthDisabled of string
            | Root of string
            | YearSelected of string
            | YearDisabled of string
            | Container of string
            | [<Erase>] Custom of string * string
            interface IClassNames
            interface IStyles

[<AutoOpen>]
module Constants =
    open Fable.Core.JsInterop
    let dialogWidth = import<int> "DIALOG_WIDTH" "material-ui-pickers/constants/dimensions"
    let dialogWidthWider = import<int> "DIALOG_WIDTH_WIDER" "material-ui-pickers/constants/dimensions"
    let viewHeight = import<int> "VIEW_HEIGHT" "material-ui-pickers/constants/dimensions"

[<AutoOpen>]
module Options =
    open Fable.React
    open Fable.React.Props

    type MakePickerOption<'T> = 
        | UseOptions of (obj option -> IStateHookOptions)
        | GetCustomProps of ('T -> 'T) (*option*)
        | [<CompiledName "DefaultToolbarComponent">]
          DefaultToolbarComponent of ReactElementType
        interface IHTMLProp

    type StateHookOption =
        | GetDefaultFormat of (unit -> string)
        interface IHTMLProp

[<AutoOpen>]
module rec Props =
    open Browser.Types
    open Fable.Core
    open Fable.Core.JS
    open Fable.Core.JsInterop
    open Fable.React
    open Fable.React.Props
    open Fable.MaterialUI

    let inline private customHtmlAttr key props =
        HTMLAttr.Custom(key, props |> keyValueList CaseRules.LowerFirst)

    type [<StringEnum; RequireQualifiedAccess>] ClockType =
        | Hours
        | Minutes
        | Seconds

    type [<StringEnum; RequireQualifiedAccess>] ClockViewType =
        | [<CompiledName "Hours">] Hours
        | [<CompiledName "Minutes">] Minutes
        | [<CompiledName "Seconds">] Seconds

    type [<StringEnum; RequireQualifiedAccess>] DatePickerView =
        | Year
        | Date
        | Month

    type [<StringEnum; RequireQualifiedAccess>] DateTimePickerView =
        | Year
        | Date
        | Month
        | Hours
        | Minutes

    type [<StringEnum; RequireQualifiedAccess>] WrapperVariant =
        | Dialog
        | Inline
        | Static

    type [<StringEnum; RequireQualifiedAccess>] SlideDirection =
        | Right
        | Left

    type MuiPickersUtilsProviderProp = 
        | Utils of obj (*option*)
        | Children of ReactElement
        | Locale of obj (*option*)
        | LibInstance of obj (*option*)
        interface IHTMLProp

    type BaseDatePickerProp = 
        /// Min selectable date
        | MinDate of ParsableDate (*option*)
        /// Max selectable date
        | MaxDate of ParsableDate (*option*)
        /// Compare dates by the exact timestamp, instead of start/end of date
        | StrictCompareDates of bool (*option*)
        /// Disable past dates
        | DisablePast of bool (*option*)
        /// Disable future dates
        | DisableFuture of bool (*option*)
        /// To animate scrolling to current year (using scrollIntoView)
        | AnimateYearScrolling of bool (*option*)
        /// Callback firing on year change @DateIOType
        | OnYearChange of (MaterialUiPickersDate -> unit) (*option*)
        interface IHTMLProp

    type DatePickerViewsProp = 
        /// Array of views to show
        | Views of DatePickerView [] (*option*)
        /// Open to DatePicker
        | OpenTo of DatePickerView (*option*)
        interface IHTMLProp

    type DateTimePickerViewsProp = 
        /// Array of views to show
        | Views of DateTimePickerView [] (*option*)
        /// Open to DatePicker
        | OpenTo of DateTimePickerView (*option*)
        /// To show tabs
        | HideTabs of bool (*option*)
        /// Date tab icon
        | DateRangeIcon of ReactElement (*option*)
        /// Time tab icon
        | TimeIcon of ReactElement (*option*)
        interface IHTMLProp

    type DateTimePickerTabsProp = 
        | View of DateTimePickerView
        | OnChange of (DateTimePickerView -> unit)
        | DateRangeIcon of ReactElement (*option*)
        | TimeIcon of ReactElement (*option*)
        interface IHTMLProp

    type ToolbarComponentProp = 
        | Views of PickerView []
        | OpenView of PickerView
        | Date of MaterialUiPickersDate
        | SetOpenView of (PickerView -> unit)
        | OnChange of (MaterialUiPickersDate -> bool -> unit)
        | HideTabs of bool (*option*)
        | DateRangeIcon of ReactElement (*option*)
        | TimeIcon of ReactElement (*option*)
        | IsLandscape of bool
        interface IHTMLProp

    type PickerViewProp = 
        | Views of PickerView []
        | OpenTo of PickerView
        | DisableToolbar of bool (*option*)
        | [<CompiledName "ToolbarComponent">]
          ToolbarComponent of ReactElementType
        | HideTabs of bool (*option*)
        | DateRangeIcon of ReactElement (*option*)
        | TimeIcon of ReactElement (*option*)
        interface IHTMLProp

    type PickerProp = 
        | Date of MaterialUiPickersDate
        | Orientation of BasePickerProp (*option*)
        | OnChange of (MaterialUiPickersDate -> bool -> unit)
        interface IHTMLProp

    type BaseTimePickerProp = 
        /// 12h/24h view for hour selection clock
        | Ampm of bool (*option*)
        /// Step over minutes
        | MinutesStep of float (*option*)
        interface IHTMLProp

    type TimePickerViewsProp = 
        /// Array of views to show
        | Views of ClockType [] (*option*)
        /// Open to timepicker
        | OpenTo of ClockType (*option*)
        interface IHTMLProp

    type BasePickerProp = 
        /// Picker value
        | Value of ParsableDate
        /// onChange callback @DateIOType
        | OnChange of (MaterialUiPickersDate -> unit)
        /// Auto accept date on selection
        | AutoOk of bool (*option*)
        /// Format string
        | Format of string (*option*)
        /// Disable datepicker and text field
        | Disabled of bool (*option*)
        /// Dynamic formatter of text field value @DateIOType
        | LabelFunc of (MaterialUiPickersDate -> string -> string) (*option*)
        /// Date that will be initially highlighted if null was passed
        | InitialFocusedDate of ParsableDate (*option*)
        /// Message displaying in text field if date is invalid (doesn't work in keyboard mode)
        | InvalidLabel of string (*option*)
        /// Message displaying in text field, if null passed (doesn't work in keyboard mode)
        | EmptyLabel of string (*option*)
        /// Callback fired when date is accepted @DateIOType
        | OnAccept of (MaterialUiPickersDate -> unit) (*option*)
        /// Callback fired when new error should be displayed @DateIOType
        | OnError of (ReactElement -> MaterialUiPickersDate -> unit) (*option*)
        /// On open callback
        | OnOpen of (unit -> unit) (*option*)
        /// On close callback
        | OnClose of (unit -> unit) (*option*)
        /// Controlled picker open state
        | Open of bool (*option*)
        /// Hide toolbar and show only date/time views
        | DisableToolbar of bool (*option*)
        /// Force rendering in particular orientation
        | Orientation of U2<string, string> (*option*)
        /// Component that will replace default toolbar renderer
        | [<CompiledName "ToolbarComponent">]
          ToolbarComponent of ReactElementType (*option*)
        | Variant of WrapperVariant (*option*)
        interface IHTMLProp

    module InlineWrapperProp = 
        /// Popover props passed to material-ui Popover (with variant="inline")
        let inline PopoverProps (props : IHTMLProp seq) (*option*) =
            customHtmlAttr "popoverProps" props

    type ModalWrapperProp = 
        /// "OK" label message
        | OkLabel of ReactElement (*option*)
        /// "CANCEL" label message
        | CancelLabel of ReactElement (*option*)
        /// "CLEAR" label message
        | ClearLabel of ReactElement (*option*)
        /// "TODAY" label message
        | TodayLabel of ReactElement (*option*)
        /// If true today button will be displayed <b>Note*</b> that clear button has higher priority
        | ShowTodayButton of bool (*option*)
        /// Show clear action in picker dialog
        | Clearable of bool (*option*)
        interface IHTMLProp

    module ModalWrapperProp = 
        /// Props to be passed directly to material-ui Dialog
        let inline DialogProps (props : IHTMLProp seq) =
            customHtmlAttr "dialogProps" props

    type WrappersProp = 
        | Variant of WrapperVariant (*option*)
        | Children of ReactElement (*option*)
        interface IHTMLProp

    type WrapperProp = 
        | Open of bool
        | OnAccept of (unit -> unit)
        | OnDismiss of (unit -> unit)
        | OnClear of (unit -> unit)
        | OnSetToday of (unit -> unit)
        | [<CompiledName "InputComponent">] 
          InputComponent of ReactElementType        
        | Wider of bool (*option*)
        | ShowTabs of bool (*option*)
        interface IHTMLProp

    module WrapperProp = 
        let inline DateInputProps (props : IHTMLProp seq) =
            customHtmlAttr "DateInputProps" props

    type BaseValidationProp = 
        /// Message, appearing when date cannot be parsed
        | InvalidDateMessage of ReactElement (*option*)
        interface IHTMLProp

    type DateValidationProp = 
        /// Error message, shown if date is less then minimal date
        | MinDateMessage of ReactElement (*option*)
        /// Error message, shown if date is more then maximal date
        | MaxDateMessage of ReactElement (*option*)
        interface IHTMLProp

    type KeyboardDateInputProp = 
        | Format of string
        | OnChange of (string option -> unit)
        | OnClick of (unit -> unit) (*option*)
        | ValidationError of ReactElement (*option*)
        | InputValue of string
        /// Override input component
        | [<CompiledName "TextFieldComponent">] 
          TextFieldComponent of ReactElementType (*option*)
        /// Icon displaying for open picker button
        | KeyboardIcon of ReactElement (*option*)
        /// Pass material-ui text field variant down, bypass internal variant prop
        | InputVariant of TextFieldVariant (*option*)
        /// Custom mask. Can be used to override generate from format. (e.g. __/__/____ __:__)
        | Mask of string (*option*)
        /// Char string that will be replaced with number (for "_" mask will be "__/__/____")
        | MaskChar of string (*option*)
        /// Refuse values regexp
        | Refuse of RegExpConstructor (*option*)
        /// Custom formatter to be passed into Rifm component
        | RifmFormatter of (string -> string) (*option*)
        interface IHTMLProp

    module KeyboardDateInputProp = 
        let inline InputProps (props : IHTMLProp seq) (*option*) = 
            customHtmlAttr "inputProps" props
        /// Props to pass to embedded input component, same as `ChildrenProp.InputProps`
        let inline ChildrenInputProps (props : IHTMLProp seq) (*option*) =
            customHtmlAttr "InputProps" props
        /// Props to pass to keyboard input adornment
        let inline InputAdornmentProps (props : IHTMLProp seq) (*option*) =
            customHtmlAttr "inputAdornmentProps" props
        /// Props to pass to keyboard adornment button
        let inline KeyboardButtonProps (props : IHTMLProp seq) (*option*) =
            customHtmlAttr "keyboardButtonProps" props

    type ModalDialogProp = 
        | OnAccept of (unit -> unit)
        | OnDismiss of (unit -> unit)
        | OnClear of (unit -> unit)
        | OnSetToday of (unit -> unit)
        | OkLabel of ReactElement (*option*)
        | CancelLabel of ReactElement (*option*)
        | ClearLabel of ReactElement (*option*)
        | TodayLabel of ReactElement (*option*)
        | Clearable of bool (*option*)
        | ShowTodayButton of bool (*option*)
        | ShowTabs of bool (*option*)
        | Wider of bool (*option*)
        interface IHTMLProp

    type PickerToolbarProp = 
        | IsLandscape of bool
        interface IHTMLProp

    type PureDateInputProp = 
        /// Pass material-ui text field variant down, bypass internal variant prop
        | InputVariant of TextFieldVariant (*option*)
        /// Override input component
        | TextFieldComponent of ReactElementType (*option*)
        | InputValue of string
        | ValidationError of ReactElement (*option*)
        interface IHTMLProp

    module PureDateInputProp = 
        let inline InputProps (props : IHTMLProp seq) (*option*) = 
            customHtmlAttr "inputProps" props
        /// Props to pass to embedded input component, same as `ChildrenProp.InputProps`
        let inline ChildrenInputProps (props : IHTMLProp seq) (*option*) =
            customHtmlAttr "InputProps" props

    type ToolbarButtonProp = 
        | Variant of TypographyVariant
        | Selected of bool
        | Label of string
        | Align of TextAlignOptions (*option*)
        | TypographyClassName of string (*option*)
        interface IHTMLProp

    type ToolbarTextProp = 
        | Selected of bool (*option*)
        | Label of string
        interface IHTMLProp

    type WithUtilsProp = 
        | Utils of IUtils<MaterialUiPickersDate>
        interface IHTMLProp

    type OutterCalendarProp = 
        /// Left arrow icon
        | LeftArrowIcon of ReactElement (*option*)
        /// Right arrow icon
        | RightArrowIcon of ReactElement (*option*)
        /// Custom renderer for day @DateIOType
        | RenderDay of (MaterialUiPickersDate -> MaterialUiPickersDate -> bool -> ReactElement -> ReactElement) (*option*)
        /// Enables keyboard listener for moving between days in calendar
        | AllowKeyboardControl of bool (*option*)
        /// Disable specific date @DateIOType
        | ShouldDisableDate of (MaterialUiPickersDate -> bool) (*option*)
        /// Callback firing on month change. Return promise to render spinner till it will not be resolved @DateIOType
        | OnMonthChange of (MaterialUiPickersDate -> U2<unit, Promise<unit>>) (*option*)
        /// Custom loading indicator
        | LoadingIndicator of ReactElement (*option*)
        interface IHTMLProp

    module OutterCalendarProp = 
        /// Props to pass to left arrow button
        let inline LeftArrowButtonProps (props : IHTMLProp seq) (*option*) = 
            customHtmlAttr "leftArrowButtonProps" props
        /// Props to pass to right arrow button
        let inline RightArrowButtonProps (props : IHTMLProp seq) (*option*) =
            customHtmlAttr "rightArrowButtonProps" props

    type CalendarProp = 
        /// Calendar Date @DateIOType
        | Date of MaterialUiPickersDate
        /// Calendar onChange
        | OnChange of (MaterialUiPickersDate -> bool -> unit)
        /// Min date @DateIOType
        | MinDate of MaterialUiPickersDate (*option*)
        /// Max date @DateIOType
        | MaxDate of MaterialUiPickersDate (*option*)
        /// Disable past dates
        | DisablePast of bool (*option*)
        /// Disable future dates
        | DisableFuture of bool (*option*)
        interface IHTMLProp

    type CalendarHeaderProp = 
        | CurrentMonth of DateType
        | LeftArrowIcon of ReactElement (*option*)
        | RightArrowIcon of ReactElement (*option*)
        | DisablePrevMonth of bool (*option*)
        | DisableNextMonth of bool (*option*)
        | SlideDirection of SlideDirection
        | OnMonthChange of (MaterialUiPickersDate -> SlideDirection -> U2<unit, Promise<unit>>)
        interface IHTMLProp

    module CalendarHeaderProp = 
        let inline LeftArrowButtonProps (props : IHTMLProp seq) (*option*) = 
            customHtmlAttr "leftArrowButtonProps" props
        let inline RightArrowButtonProps (props : IHTMLProp seq) (*option*) =
            customHtmlAttr "rightArrowButtonProps" props

    type DayProp = 
        /// Day text
        | Children of ReactElement
        /// Is today
        | Current of bool (*option*)
        /// Disabled?
        | Disabled of bool (*option*)
        /// Hidden?
        | Hidden of bool (*option*)
        /// Selected?
        | Selected of bool (*option*)
        interface IHTMLProp

    type DayWrapperProp = 
        | Value of obj (*option*)
        | Children of ReactElement
        | DayInCurrentMonth of bool (*option*)
        | Disabled of bool (*option*)
        | OnSelect of (obj option -> unit)
        interface IHTMLProp

    type SlideTransitionProp = 
        | TransKey of string
        | ClassName of string (*option*)
        | SlideDirection of SlideDirection
        | Children of ReactElement
        interface IHTMLProp

    type ClockProp = 
        | Type of ClockViewType
        | Value of float
        | OnChange of (float -> bool -> unit)
        | Ampm of bool (*option*)
        | MinutesStep of float (*option*)
        | Children of ReactElement
        interface IHTMLProp

    type ClockNumberProp = 
        | Index of float
        | Label of string
        | Selected of bool
        | IsInner of bool (*option*)
        interface IHTMLProp

    type ClockPointerProp = 
        | Value of float
        | HasSelected of bool
        | IsInner of bool
        | Type of ClockViewType
        interface IHTMLProp

    type TimePickerViewProp = 
        /// TimePicker value
        | Date of MaterialUiPickersDate
        /// Clock type
        | Type of U3<string, string, string>
        /// 12h/24h clock mode
        | Ampm of bool (*option*)
        /// Minutes step
        | MinutesStep of float (*option*)
        /// On hour change
        | OnHourChange of (MaterialUiPickersDate -> bool -> unit)
        /// On minutes change
        | OnMinutesChange of (MaterialUiPickersDate -> bool -> unit)
        /// On seconds change
        | OnSecondsChange of (MaterialUiPickersDate -> bool -> unit)
        interface IHTMLProp

    type MonthProp = 
        | Children of ReactElement
        | Disabled of bool (*option*)
        | OnSelect of (obj option -> unit)
        | Selected of bool (*option*)
        | Value of obj (*option*)
        interface IHTMLProp

    type MonthSelectionProp = 
        | Date of MaterialUiPickersDate
        | MinDate of ParsableDate (*option*)
        | MaxDate of ParsableDate (*option*)
        | OnChange of (MaterialUiPickersDate -> bool -> unit)
        | DisablePast of bool (*option*)
        | DisableFuture of bool (*option*)
        | OnMonthChange of (MaterialUiPickersDate -> U2<unit, Promise<unit>>) (*option*)
        interface IHTMLProp

    type YearProp = 
        | Children of ReactElement
        | Disabled of bool (*option*)
        | OnSelect of (obj option -> unit)
        | Selected of bool (*option*)
        | Value of obj (*option*)
        | ForwardedRef of Ref<HTMLElement option> (*option*)
        interface IHTMLProp

    type YearSelectionProp = 
        | Date of MaterialUiPickersDate
        | MinDate of DateType
        | MaxDate of DateType
        | OnChange of (MaterialUiPickersDate -> bool -> unit)
        | DisablePast of bool (*option*)
        | DisableFuture of bool (*option*)
        | AnimateYearScrolling of bool (*option*)
        | OnYearChange of (MaterialUiPickersDate -> unit) (*option*)
        interface IHTMLProp

    type BaseKeyboardPickerProp = 
        /// String value for controlling value with pure input string. Overrides value prop
        | InputValue of string (*option*)
        /// Keyboard onChange callback @DateIOType
        | OnChange of (MaterialUiPickersDate option -> string -> unit)
        interface IHTMLProp

    [<AutoOpen>]
    module OverridesProp =
        let inline private pascalCaseProp (name : string) (props : Themes.IStyles seq) =
            OverridesProp.Custom (name, props |> keyValueList CaseRules.LowerFirst)

        let inline MuiPickersDay styles = pascalCaseProp "MuiPickersDay" styles
        let inline MuiPickersDTHeader styles = pascalCaseProp "MuiPickerDTHeader" styles
        let inline MuiPickersDTTabs styles = pascalCaseProp "MuiPickerDTTabs" styles
        let inline MuiPickersCalendar styles = pascalCaseProp "MuiPickersCalendar" styles
        let inline MuiPickersCalendarHeader styles = pascalCaseProp "MuiPickersCalendarHeader" styles
        let inline MuiPickersSlideTransition styles = pascalCaseProp "MuiPickersSlideTransition" styles
        let inline MuiPickersYearSelectionStyles styles = pascalCaseProp "MuiPickersYearSelectionStyles" styles
        let inline MuiPickersYear styles = pascalCaseProp "MuiPickersYear" styles
        let inline MuiPickersMonthSelection styles = pascalCaseProp "MuiPickersMonthSelection" styles
        let inline MuiPickersMonth styles = pascalCaseProp "MuiPickersMonth" styles
        let inline MuiPickersTimePickerToolbar styles = pascalCaseProp "MuiPickersTimePickerToolbar" styles
        let inline MuiPickersClock styles = pascalCaseProp "MuiPickersClock" styles
        let inline MuiPickersClockNumber styles = pascalCaseProp "MuiPickersClockNumber" styles
        let inline MuiPickersClockPointer styles = pascalCaseProp "MuiPickersClockPointer" styles
        let inline MuiPickersModal styles = pascalCaseProp "MuiPickersModal" styles
        let inline MuiPickersToolbar styles = pascalCaseProp "MuiPickersToolbar" styles
        let inline MuiPickersToolbarButton styles = pascalCaseProp "MuiPickersToolbarButton" styles
        let inline MuiPickersDatePickerRoot styles = pascalCaseProp "MuiPickersDatePickerRoot" styles
        let inline MuiPickersDTToolbar styles = pascalCaseProp "MuiPickerDTToolbar" styles

    [<AutoOpen>]
    module ThemePropsProp =
        let inline private pascalCaseProp (name : string) (props : Themes.IStyles seq) =
            ThemePropsProp.Custom (name, props |> keyValueList CaseRules.LowerFirst)

        let inline MuiPickersDay props = pascalCaseProp "MuiPickersDay" props
        let inline MuiPickersDTHeader props = pascalCaseProp "MuiPickerDTHeader" props
        let inline MuiPickersDTTabs props = pascalCaseProp "MuiPickerDTTabs" props
        let inline MuiPickersCalendar props = pascalCaseProp "MuiPickersCalendar" props
        let inline MuiPickersCalendarHeader props = pascalCaseProp "MuiPickersCalendarHeader" props
        let inline MuiPickersSlideTransition props = pascalCaseProp "MuiPickersSlideTransition" props
        let inline MuiPickersYearSelectionprops props = pascalCaseProp "MuiPickersYearSelectionprops" props
        let inline MuiPickersYear props = pascalCaseProp "MuiPickersYear" props
        let inline MuiPickersMonthSelection props = pascalCaseProp "MuiPickersMonthSelection" props
        let inline MuiPickersMonth props = pascalCaseProp "MuiPickersMonth" props
        let inline MuiPickersTimePickerToolbar props = pascalCaseProp "MuiPickersTimePickerToolbar" props
        let inline MuiPickersClock props = pascalCaseProp "MuiPickersClock" props
        let inline MuiPickersClockNumber props = pascalCaseProp "MuiPickersClockNumber" props
        let inline MuiPickersClockPointer props = pascalCaseProp "MuiPickersClockPointer" props
        let inline MuiPickersModal props = pascalCaseProp "MuiPickersModal" props
        let inline MuiPickersToolbar props = pascalCaseProp "MuiPickersToolbar" props
        let inline MuiPickersToolbarButton props = pascalCaseProp "MuiPickersToolbarButton" props
        let inline MuiPickersDatePickerRoot props = pascalCaseProp "MuiPickersDatePickerRoot" props
        let inline MuiPickersDTToolbar props = pascalCaseProp "MuiPickerDTToolbar" props
