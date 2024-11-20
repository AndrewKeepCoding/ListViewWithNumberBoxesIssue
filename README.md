# ListViewWithNumberBoxesIssue

```xaml
<Grid RowDefinitions="Auto,*">
    <Button
        Grid.Row="0"
        Command="{x:Bind ViewModel.MoveFirstToBottomCommand}"
        Content="Move First To Bottom" />
    <ListView
        Grid.Row="1"
        ItemsSource="{x:Bind ViewModel.Items, Mode=OneWay}">
        <ListView.ItemTemplate>
            <DataTemplate x:DataType="local:Item">
                <!--  Value shouldn't be set before Minimum.  -->
                <!--
                <NumberBox
                    Value="{x:Bind Value, Mode=TwoWay, UpdateSourceTrigger=PropertyChanged}"
                    Minimum="{x:Bind Min, Mode=OneWay}" />
                -->
                <NumberBox
                    Minimum="{x:Bind Min, Mode=OneWay}"
                    Value="{x:Bind Value, Mode=TwoWay, UpdateSourceTrigger=PropertyChanged}" />
            </DataTemplate>
        </ListView.ItemTemplate>
    </ListView>
</Grid>
```
