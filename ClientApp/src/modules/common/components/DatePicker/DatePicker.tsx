import React from 'react';
import ReactDatePicker from 'react-datepicker';
import 'react-datepicker/dist/react-datepicker.css';
import {getTomorrow} from '../../helpers/getTomorrow';
import './DatePicker.css';

interface Props {
    isClearable?: boolean;
    name: string;
    onChange: (name: string, value: Date) => void;
    value: Date;
    showPopperArrow?: boolean;
    disabled?: boolean;
    isUnlimited?: boolean;
}

/**
 * Date picker component to be used with forms. Adopted from 'ReactDatePicker'
 * @param name
 * @param value
 * @param onChange
 * @param isClearable
 * @param showPopperArrow
 * @constructor
 */
export const DatePicker: React.FC<Props> = ({
    name,
    value,
    onChange,
    isClearable = false,
    showPopperArrow = false,
    disabled = false,
    isUnlimited = false,
}) => {
    return (
        // Honestly, I have no idea how to improve this part without writing a compatible datepicker myself...
        // @ts-ignore
        <ReactDatePicker
            name={name}
            selected={value && new Date(value)}
            onChange={(value: any) => onChange(name, value as Date)}
            isClearable={isClearable}
            minDate={isUnlimited ? null : getTomorrow()}
            inline
            disabled={disabled}
        />
    );
};
