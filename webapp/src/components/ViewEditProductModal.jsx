import { React, useEffect, useState } from 'react'
import { Button, Modal, Input, InputNumber, Form, Typography } from 'antd'
import { CloseOutlined, EditOutlined, SaveOutlined } from '@ant-design/icons';

import ProductForm from './ProductForm';

import { useDataFetch } from '../context/DataFetchContext';
import { useModal } from '../context/ModalContext';

import axios from '../api/axios'

const { TextArea } = Input;
const { Text } = Typography;

const ViewEditProductModal = () => {
    const { isViewEditModalVisible, setViewEditModalVisible, viewEditModalProductId, setViewEditModalProductId } = useModal();
    const { dispatch } = useDataFetch();

    const isFormReadOnly = true;

    const [isLoading, setIsLoading] = useState(false);
    const [isEditMode, setIsEditMode] = useState(false);
    const [isFormDisabled, setIsFormDisabled] = useState(false);

    const [data, setData] = useState(null);

    const [viewForm] = Form.useForm();
    const [editForm] = Form.useForm();


    useEffect(() => {
        if (viewEditModalProductId != null) {
            setIsLoading(true);
            fetchDataAsync();
        }
    }, [viewEditModalProductId]);

    const fetchDataAsync = async () => {
        try {
            const response = await axios.get(`/api/products/${viewEditModalProductId}`);
            console.debug(response);

            setData(response.data);
            viewForm.setFieldsValue(response.data);
        }
        catch (error) {
            console.error(error);
        }
        finally {
            setIsLoading(false);
        }
    }

    const submitFormAsync = async () => {
        try {
            var validateResults = await editForm.validateFields();
            setIsFormDisabled(true);

            const response = await axios.put(`/api/products/${data.Id}`, validateResults);
            console.log(response);

            setViewEditModalVisible(false);
            setViewEditModalProductId(null);
            setIsEditMode(false);

            dispatch({ type: 'TOGGLE_FETCH' });

            editForm.resetFields();
        }
        catch (error) {
            console.log(error);

            const errors = Object.keys(error.response.data.errors).map((field => ({
                name: field,
                errors: [error.response.data.errors[field]],
            })));
            editForm.setFields(errors);
        }
        finally {
            setIsFormDisabled(false);
        }
    }

    const handleClose = () => {
        setViewEditModalVisible(false);
        setIsEditMode(false);
    }

    const ProductData = () => {
        if (!isLoading) {
            if (!isEditMode) {
                return (
                    <Form form={viewForm} layout="vertical" className="modal-form">
                        <Form.Item name="Name" label="Название товара">
                            <TextArea readOnly={isFormReadOnly} size="large"></TextArea>
                        </Form.Item>
                        <Form.Item name="Description" label="Описание товара">
                            <TextArea readOnly={isFormReadOnly} size="large" ></TextArea>
                        </Form.Item>
                        <Form.Item name="Vendorcode" label="Код товара">
                            <InputNumber readOnly={isFormReadOnly} size="large" />
                        </Form.Item>
                        <Form.Item name="Quantity" label="Количество на складе">
                            <InputNumber readOnly={isFormReadOnly} id="productQuantity" size="large" />
                        </Form.Item>
                        <Form.Item name="Price" label="Цена товара">
                            <InputNumber readOnly={isFormReadOnly} size="large" />
                        </Form.Item>
                    </Form>
                );
            }
            else {
                return (
                    <ProductForm form={editForm} isFormDisabled={isFormDisabled} />
                )
            }
        }
    }

    const getModalTitle = () => {
        return isEditMode ? "Редактирование товара" : "Просмотр товара";
    }

    const changeEditMode = () => {
        setIsEditMode(!isEditMode);
        editForm.setFieldsValue(data);
    }

    const FooterButtons = () => {
        if (isEditMode) {
            return (
                <>
                    <Button icon={<CloseOutlined />} onClick={changeEditMode}>Отменить редактирование</Button>
                    <Button icon={<SaveOutlined />} type="primary" key="back" onClick={submitFormAsync}>Сохранить</Button>
                </>
            );
        }
        else {
            return (
                <>
                    <Button icon={<EditOutlined />} onClick={changeEditMode}>Редактировать товар</Button>
                    <Button icon={<CloseOutlined />} key="back" onClick={handleClose}>Закрыть</Button>
                </>
            );
        }
    }

    return (
        <Modal title={getModalTitle()}
            loading={isLoading}
            open={isViewEditModalVisible}
            onCancel={handleClose}
            footer={FooterButtons}>
            <ProductData />
        </Modal>
    )
};

export default ViewEditProductModal;